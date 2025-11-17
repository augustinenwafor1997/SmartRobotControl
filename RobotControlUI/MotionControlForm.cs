using RobotControlLibrary;
using RobotControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace RobotControlUI
{
    public partial class MotionControlForm : Form
    {
        private List<DeviceModel> devices;

        public MotionControlForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MotionControlForm_Load(object sender, EventArgs e)
        {
            // Load devices and populate dropdown
            LoadDevices();

            // Populate command types dropdown
            LoadCommandTypes();

            // Set initial status
            txtStatus.Text = "Ready to send commands...";
            txtStatus.ForeColor = Color.FromArgb(40, 167, 69);

            // Load recent commands
            LoadRecentCommands();
        }

        private void LoadDevices()
        {
            try
            {
                devices = GlobalConfig.Connection.GetAllDevices();

                cbDevice.Items.Clear();

                if (devices != null && devices.Count > 0)
                {
                    foreach (var device in devices)
                    {
                        cbDevice.Items.Add(device.DisplayName);
                    }

                    // Select first device by default
                    cbDevice.SelectedIndex = 0;
                }
                else
                {
                    ShowError("No devices found. Please add a device first.");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error loading devices: {ex.Message}");
            }
        }

        private void LoadCommandTypes()
        {
            // Populate the command dropdown with available commands
            cbCommandType.Items.Clear();
            cbCommandType.Items.Add("Pick");
            cbCommandType.Items.Add("Place");
            cbCommandType.Items.Add("MoveForward");
            cbCommandType.Items.Add("Reverse");
            cbCommandType.Items.Add("TurnLeft");
            cbCommandType.Items.Add("TurnRight");
            cbCommandType.Items.Add("AboutTurn");
            cbCommandType.Items.Add("Home");
            cbCommandType.Items.Add("Stop");

            // Select first command by default
            if (cbCommandType.Items.Count > 0)
                cbCommandType.SelectedIndex = 0;
        }

        private void cbCommandType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Enable/disable distance based on command type
            string selectedCommand = cbCommandType.SelectedItem?.ToString();

            if (selectedCommand == "MoveForward" || selectedCommand == "Reverse")
            {
                nudDistance.Enabled = true;
                lblDistance.Enabled = true;
            }
            else
            {
                nudDistance.Enabled = false;
                lblDistance.Enabled = false;
            }
        }

        private void btnRun_Click(object sender, EventArgs e)
        {

        }

        private string BuildPayloadJson(string commandType)
        {
            // Build JSON payload based on command type and parameters
            var payload = new System.Text.StringBuilder();
            payload.Append("{");

            // Always include speed
            payload.Append($"\"speed\": {nudSpeed.Value}");

            // Add distance if applicable
            if (commandType == "MoveForward" || commandType == "Reverse")
            {
                payload.Append($", \"distance\": {nudDistance.Value}");
            }

            payload.Append("}");
            return payload.ToString();
        }

        private void LoadRecentCommands()
        {
            try
            {
                // Get recent commands for display
                List<CommandModel> recentCommands = GlobalConfig.Connection.GetRecentCommands(10);

                lbRecentCommands.Items.Clear();

                foreach (var cmd in recentCommands)
                {
                    string display = $"[{cmd.RequestedAt.ToLocalTime():HH:mm:ss}] {cmd.CommandType} - {cmd.Status}";
                    lbRecentCommands.Items.Add(display);
                }
            }
            catch (Exception ex)
            {
                // Silently fail - not critical
                System.Diagnostics.Debug.WriteLine($"Error loading recent commands: {ex.Message}");
            }
        }

        private void ShowSuccess(string message)
        {
            txtStatus.Text = message;
            txtStatus.ForeColor = Color.FromArgb(40, 167, 69); // Green
        }

        private void ShowError(string message)
        {
            txtStatus.Text = message;
            txtStatus.ForeColor = Color.FromArgb(220, 53, 69); // Red
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            // Validate selections
            if (cbDevice.SelectedIndex < 0)
            {
                ShowError("Please select a device.");
                return;
            }

            if (cbCommandType.SelectedIndex < 0)
            {
                ShowError("Please select a command.");
                return;
            }

            // Get selected device
            DeviceModel selectedDevice = devices[cbDevice.SelectedIndex];
            string commandType = cbCommandType.SelectedItem.ToString();

            // Build payload JSON
            string payloadJson = BuildPayloadJson(commandType);

            // Send command to database
            try
            {
                CommandModel command = GlobalConfig.Connection.CreateCommand(
                    selectedDevice.DeviceId,
                    commandType,
                    payloadJson,
                    SessionManager.CurrentUserId
                );

                if (command != null)
                {
                    ShowSuccess($"Command '{commandType}' sent successfully!");

                    // Reload recent commands
                    LoadRecentCommands();

                    // Log the command
                    GlobalConfig.Connection.CreateLog(
                        selectedDevice.DeviceId,
                        "Info",
                        $"Command '{commandType}' queued by {SessionManager.CurrentUsername}"
                    );
                }
                else
                {
                    ShowError("Failed to create command.");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error sending command: {ex.Message}");
            }
        }

        private void txtStatus_TextChanged(object sender, EventArgs e)
        {

        }

        

        
        private void btnEmergencyStop_Click(object sender, EventArgs e)
        {
            // Validate that a device is selected
            if (cbDevice.SelectedIndex < 0)
            {
                ShowError("Please select a device first.");
                return;
            }

            // Confirm with user
            DialogResult result = MessageBox.Show(
                "Send EMERGENCY STOP command to the robot?",
                "Confirm Emergency Stop",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    // Get selected device
                    DeviceModel selectedDevice = devices[cbDevice.SelectedIndex];

                    // Create stop command with highest priority
                    CommandModel command = GlobalConfig.Connection.CreateCommand(
                        selectedDevice.DeviceId,
                        "Stop",
                        "{\"priority\": \"emergency\"}",
                        SessionManager.CurrentUserId
                    );

                    if (command != null)
                    {
                        ShowSuccess($"EMERGENCY STOP command sent!");

                        // Log the emergency stop
                        GlobalConfig.Connection.CreateLog(
                            selectedDevice.DeviceId,
                            "Warn",
                            $"EMERGENCY STOP triggered by {SessionManager.CurrentUsername}"
                        );

                        // Reload recent commands
                        LoadRecentCommands();
                    }
                    else
                    {
                        ShowError("Failed to send emergency stop command.");
                    }
                }
                catch (Exception ex)
                {
                    ShowError($"Error sending emergency stop: {ex.Message}");
                }
            }
        }

        private void btnQuickHome_Click(object sender, EventArgs e)
        {
            // Validate that a device is selected
            if (cbDevice.SelectedIndex < 0)
            {
                ShowError("Please select a device first.");
                return;
            }

            try
            {
                // Get selected device
                DeviceModel selectedDevice = devices[cbDevice.SelectedIndex];

                // Create home command with default speed
                string payloadJson = "{\"speed\": 50}";

                CommandModel command = GlobalConfig.Connection.CreateCommand(
                    selectedDevice.DeviceId,
                    "Home",
                    payloadJson,
                    SessionManager.CurrentUserId
                );

                if (command != null)
                {
                    ShowSuccess($"Home position command sent!");

                    // Log the command
                    GlobalConfig.Connection.CreateLog(
                        selectedDevice.DeviceId,
                        "Info",
                        $"Quick Home command sent by {SessionManager.CurrentUsername}"
                    );

                    // Reload recent commands
                    LoadRecentCommands();
                }
                else
                {
                    ShowError("Failed to send home command.");
                }
            }
            catch (Exception ex)
            {
                ShowError($"Error sending home command: {ex.Message}");
            }
        }
    }
}



