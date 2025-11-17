using RobotControlLibrary;
using RobotControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotControlUI
{
    public partial class DevicesForm : Form
    {
        private List<DeviceModel> devices;
        private DeviceModel selectedDevice;

        public DevicesForm()
        {
            InitializeComponent();
        }

        private void DevicesForm_Load(object sender, EventArgs e)
        {
            LoadDevices();
        }

        private void LoadDevices()
        {
            try
            {
                devices = GlobalConfig.Connection.GetAllDevices();

                // Clear the grid
                dgvDevices.Rows.Clear();

                if (devices != null && devices.Count > 0)
                {
                    foreach (var device in devices)
                    {
                        string heartbeat = device.LastHeartbeat.HasValue
                            ? device.LastHeartbeat.Value.ToLocalTime().ToString("MM/dd/yyyy HH:mm:ss")
                            : "Never";

                        string created = device.CreatedAt.HasValue
                            ? device.CreatedAt.Value.ToLocalTime().ToString("MM/dd/yyyy HH:mm:ss")
                            : "N/A";

                        int rowIndex = dgvDevices.Rows.Add(
                            device.DeviceId,
                            device.DisplayName,
                            device.Status,
                            heartbeat,
                            created
                        );

                        // Color code based on status
                        Color statusColor = GetStatusColor(device.Status);
                        dgvDevices.Rows[rowIndex].Cells[2].Style.ForeColor = statusColor;
                        dgvDevices.Rows[rowIndex].Cells[2].Style.Font = new Font(dgvDevices.Font, FontStyle.Bold);
                    }
                }

                ClearDeviceSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading devices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Color GetStatusColor(string status)
        {
            switch (status?.Trim())
            {
                case "Idle":
                    return Color.FromArgb(40, 167, 69); // Green
                case "Active":
                    return Color.FromArgb(73, 46, 135); // Purple
                case "Error":
                    return Color.FromArgb(220, 53, 69); // Red
                case "Offline":
                    return Color.FromArgb(108, 117, 125); // Gray
                default:
                    return Color.Black;
            }
        }

        private void dgvDevices_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDevices.SelectedRows.Count > 0)
            {
                // Get the selected device ID from the first cell
                string deviceId = dgvDevices.SelectedRows[0].Cells[0].Value.ToString();
                selectedDevice = devices.FirstOrDefault(d => d.DeviceId == deviceId);

                if (selectedDevice != null)
                {
                    // Display device details
                    lblDeviceIdValue.Text = selectedDevice.DeviceId;
                    lblDisplayNameValue.Text = selectedDevice.DisplayName;
                    lblStatusValue.Text = selectedDevice.Status ?? "Unknown";
                    lblStatusValue.ForeColor = GetStatusColor(selectedDevice.Status);

                    // Enable action buttons
                    btnTestConnection.Enabled = true;
                    btnViewDeviceLogs.Enabled = true;
                    btnRemoveDevice.Enabled = true;
                }
            }
            else
            {
                ClearDeviceSelection();
            }
        }

        private void ClearDeviceSelection()
        {
            selectedDevice = null;
            lblDeviceIdValue.Text = "--";
            lblDisplayNameValue.Text = "--";
            lblStatusValue.Text = "--";
            lblStatusValue.ForeColor = Color.Black;

            btnTestConnection.Enabled = false;
            btnViewDeviceLogs.Enabled = false;
            btnRemoveDevice.Enabled = false;
        }

        private void btnRefreshDevices_Click(object sender, EventArgs e)
        {
            LoadDevices();
            MessageBox.Show("Device list refreshed.", "Refresh",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            if (selectedDevice == null)
            {
                MessageBox.Show("Please select a device first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check when last heartbeat was
                if (selectedDevice.LastHeartbeat.HasValue)
                {
                    TimeSpan timeSinceHeartbeat = DateTime.UtcNow - selectedDevice.LastHeartbeat.Value;

                    string message = $"Device: {selectedDevice.DisplayName}\n" +
                                   $"Status: {selectedDevice.Status}\n" +
                                   $"Last Heartbeat: {selectedDevice.LastHeartbeat.Value.ToLocalTime():MM/dd/yyyy HH:mm:ss}\n" +
                                   $"Time Since Heartbeat: {FormatTimeSpan(timeSinceHeartbeat)}\n\n";

                    if (timeSinceHeartbeat.TotalMinutes < 5)
                    {
                        message += "✅ Connection appears GOOD (recent heartbeat)";
                        MessageBox.Show(message, "Connection Test",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (timeSinceHeartbeat.TotalMinutes < 30)
                    {
                        message += "⚠️ Connection may be DEGRADED (heartbeat is old)";
                        MessageBox.Show(message, "Connection Test",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        message += "❌ Connection appears OFFLINE (no recent heartbeat)";
                        MessageBox.Show(message, "Connection Test",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(
                        $"Device: {selectedDevice.DisplayName}\n" +
                        $"Status: {selectedDevice.Status}\n\n" +
                        "❌ No heartbeat recorded. Device may have never connected.",
                        "Connection Test",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                // Log the test
                GlobalConfig.Connection.CreateLog(
                    selectedDevice.DeviceId,
                    "Info",
                    $"Connection test performed by {SessionManager.CurrentUsername}"
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error testing connection: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string FormatTimeSpan(TimeSpan timeSpan)
        {
            if (timeSpan.TotalSeconds < 60)
                return $"{(int)timeSpan.TotalSeconds} seconds";
            else if (timeSpan.TotalMinutes < 60)
                return $"{(int)timeSpan.TotalMinutes} minutes";
            else if (timeSpan.TotalHours < 24)
                return $"{(int)timeSpan.TotalHours} hours";
            else
                return $"{(int)timeSpan.TotalDays} days";
        }

        private void btnViewDeviceLogs_Click(object sender, EventArgs e)
        {
            if (selectedDevice == null)
            {
                MessageBox.Show("Please select a device first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open logs form (filtered to this device if possible)
            LogsForm logsForm = new LogsForm();
            logsForm.Show();

            MessageBox.Show(
                $"Logs form opened.\n\nTo view logs for '{selectedDevice.DisplayName}', " +
                "select the device in the filter dropdown.",
                "View Logs",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            // Prompt for device details
            string deviceId = PromptForInput("Enter Device ID:", "Add New Device");

            if (string.IsNullOrWhiteSpace(deviceId))
                return;

            string displayName = PromptForInput("Enter Display Name:", "Add New Device");

            if (string.IsNullOrWhiteSpace(displayName))
                return;

            try
            {
                // Check if device ID already exists
                if (devices.Any(d => d.DeviceId.Equals(deviceId, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("A device with this ID already exists.", "Duplicate Device",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert device into database
                using (System.Data.IDbConnection connection =
                    new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
                {
                    connection.Open();
                    string query = @"INSERT INTO Devices (id, DisplayName, Status, CreatedAt) 
                                   VALUES (@DeviceId, @DisplayName, 'Offline', SYSUTCDATETIME())";

                    using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query, (System.Data.SqlClient.SqlConnection)connection))
                    {
                        cmd.Parameters.AddWithValue("@DeviceId", deviceId);
                        cmd.Parameters.AddWithValue("@DisplayName", displayName);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Device '{displayName}' added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Log the action
                GlobalConfig.Connection.CreateLog(
                    deviceId,
                    "Info",
                    $"Device '{displayName}' added by {SessionManager.CurrentUsername}"
                );

                // Reload devices
                LoadDevices();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding device: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            if (selectedDevice == null)
            {
                MessageBox.Show("Please select a device first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Are you sure you want to remove device '{selectedDevice.DisplayName}'?\n\n" +
                "This will also remove all associated commands, logs, and data.\n\n" +
                "This action cannot be undone.",
                "Confirm Remove Device",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Delete device and all related records
                    using (System.Data.IDbConnection connection =
                        new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString("RobotControlDB")))
                    {
                        connection.Open();

                        using (var transaction = ((System.Data.SqlClient.SqlConnection)connection).BeginTransaction())
                        {
                            try
                            {
                                // Delete related records first (in order of dependencies)

                                // 1. Delete CommandEvents for commands of this device
                                string deleteCommandEvents = @"
                            DELETE FROM CommandEvents 
                            WHERE CommandId IN (SELECT id FROM Commands WHERE DeviceId = @DeviceId)";
                                ExecuteDelete(connection, transaction, deleteCommandEvents, selectedDevice.DeviceId);

                                // 2. Delete Commands
                                string deleteCommands = "DELETE FROM Commands WHERE DeviceId = @DeviceId";
                                ExecuteDelete(connection, transaction, deleteCommands, selectedDevice.DeviceId);

                                // 3. Delete Logs
                                string deleteLogs = "DELETE FROM Logs WHERE DeviceId = @DeviceId";
                                ExecuteDelete(connection, transaction, deleteLogs, selectedDevice.DeviceId);

                                // 4. Delete Telemetry
                                string deleteTelemetry = "DELETE FROM Telemetry WHERE DeviceId = @DeviceId";
                                ExecuteDelete(connection, transaction, deleteTelemetry, selectedDevice.DeviceId);

                                // 5. Delete Heartbeats
                                string deleteHeartbeats = "DELETE FROM Heartbeats WHERE DeviceId = @DeviceId";
                                ExecuteDelete(connection, transaction, deleteHeartbeats, selectedDevice.DeviceId);

                                // 6. Finally delete the Device
                                string deleteDevice = "DELETE FROM Devices WHERE id = @DeviceId";
                                int rowsAffected = ExecuteDelete(connection, transaction, deleteDevice, selectedDevice.DeviceId);

                                if (rowsAffected > 0)
                                {
                                    transaction.Commit();

                                    MessageBox.Show($"Device '{selectedDevice.DisplayName}' and all related data removed successfully.",
                                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    // Log the action (to null device since this one is deleted)
                                    GlobalConfig.Connection.CreateLog(
                                        null,
                                        "Warn",
                                        $"Device '{selectedDevice.DisplayName}' (ID: {selectedDevice.DeviceId}) removed by {SessionManager.CurrentUsername}"
                                    );

                                    // Reload devices
                                    LoadDevices();
                                }
                                else
                                {
                                    transaction.Rollback();
                                    MessageBox.Show("Failed to remove device.", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            catch
                            {
                                transaction.Rollback();
                                throw;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error removing device: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int ExecuteDelete(System.Data.IDbConnection connection, System.Data.SqlClient.SqlTransaction transaction,
            string query, string deviceId)
        {
            using (System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand(query,
                (System.Data.SqlClient.SqlConnection)connection, transaction))
            {
                cmd.Parameters.AddWithValue("@DeviceId", deviceId);
                return cmd.ExecuteNonQuery();
            }
        }

        private string PromptForInput(string prompt, string title)
        {
            Form inputForm = new Form()
            {
                Width = 400,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label label = new Label() { Left = 20, Top = 20, Text = prompt, AutoSize = true };
            TextBox textBox = new TextBox() { Left = 20, Top = 50, Width = 340 };
            Button confirmButton = new Button()
            {
                Text = "OK",
                Left = 220,
                Width = 70,
                Top = 90,
                DialogResult = DialogResult.OK,
                BackColor = Color.FromArgb(73, 46, 135),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            Button cancelButton = new Button()
            {
                Text = "Cancel",
                Left = 300,
                Width = 70,
                Top = 90,
                DialogResult = DialogResult.Cancel,
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            confirmButton.Click += (sender, e) => { inputForm.Close(); };
            cancelButton.Click += (sender, e) => { inputForm.Close(); };

            inputForm.Controls.Add(label);
            inputForm.Controls.Add(textBox);
            inputForm.Controls.Add(confirmButton);
            inputForm.Controls.Add(cancelButton);
            inputForm.AcceptButton = confirmButton;
            inputForm.CancelButton = cancelButton;

            return inputForm.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
        }

        private void lblDeviceIdLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
