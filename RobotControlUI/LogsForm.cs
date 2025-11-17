using RobotControlLibrary;
using RobotControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotControlUI
{
    public partial class LogsForm : Form
    {
        private List<LogEntryModel> currentLogs;
        private List<DeviceModel> devices;

        public LogsForm()
        {
            InitializeComponent();
            currentLogs = new List<LogEntryModel>();
        }

        private void LogsForm_Load(object sender, EventArgs e)
        {
            // Load devices for filter
            LoadDevicesFilter();

            // Populate level filter
            PopulateLevelFilter();

            // Set default date range (last 7 days)
            dtpDateTo.Value = DateTime.Now;
            dtpDateFrom.Value = DateTime.Now.AddDays(-7);

            // Load initial logs
            LoadLogs();
        }

        private void LoadDevicesFilter()
        {
            try
            {
                devices = GlobalConfig.Connection.GetAllDevices();

                cbFilterDevice.Items.Clear();
                cbFilterDevice.Items.Add("All Devices");

                if (devices != null && devices.Count > 0)
                {
                    foreach (var device in devices)
                    {
                        cbFilterDevice.Items.Add(device.DisplayName);
                    }
                }

                cbFilterDevice.SelectedIndex = 0; // Select "All Devices"
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading devices: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateLevelFilter()
        {
            cbFilterLevel.Items.Clear();
            cbFilterLevel.Items.Add("All Levels");
            cbFilterLevel.Items.Add("Info");
            cbFilterLevel.Items.Add("Warn");
            cbFilterLevel.Items.Add("Error");

            cbFilterLevel.SelectedIndex = 0; // Select "All Levels"
        }

        private void LoadLogs()
        {
            try
            {
                // Get filter values
                string deviceFilter = null;
                if (cbFilterDevice.SelectedIndex > 0) // Not "All Devices"
                {
                    // Get the actual DeviceId from the selected display name
                    string selectedDisplayName = cbFilterDevice.SelectedItem.ToString();
                    var selectedDevice = devices?.FirstOrDefault(d => d.DisplayName == selectedDisplayName);
                    deviceFilter = selectedDevice?.DeviceId;
                }

                string levelFilter = null;
                if (cbFilterLevel.SelectedIndex > 0) // Not "All Levels"
                {
                    levelFilter = cbFilterLevel.SelectedItem.ToString();
                }

                DateTime? fromDate = dtpDateFrom.Value.Date;
                DateTime? toDate = dtpDateTo.Value.Date.AddDays(1).AddSeconds(-1); // End of selected day

                // Get filtered logs
                currentLogs = GlobalConfig.Connection.GetFilteredLogs(
                    deviceFilter,
                    levelFilter,
                    fromDate,
                    toDate
                );

                // Clear grid
                dgvLogs.Rows.Clear();

                if (currentLogs != null && currentLogs.Count > 0)
                {
                    foreach (var log in currentLogs)
                    {
                        int rowIndex = dgvLogs.Rows.Add(
                            log.LogId,
                            GetLevelIcon(log.Level),
                            log.DeviceId ?? "System",
                            log.Message,
                            log.CreatedAt.ToLocalTime().ToString("MM/dd/yyyy HH:mm:ss")
                        );

                        // Color code by level
                        Color levelColor = GetLevelColor(log.Level);
                        dgvLogs.Rows[rowIndex].Cells[1].Style.ForeColor = levelColor;
                        dgvLogs.Rows[rowIndex].Cells[1].Style.Font = new Font(dgvLogs.Font, FontStyle.Bold);

                        // Highlight error rows
                        if (log.Level == "Error")
                        {
                            dgvLogs.Rows[rowIndex].DefaultCellStyle.BackColor = Color.FromArgb(255, 240, 240);
                        }
                    }
                }

                // Update status label
                lblStatus.Text = $"Showing {currentLogs?.Count ?? 0} log entries";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading logs: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetLevelIcon(string level)
        {
            switch (level?.Trim())
            {
                case "Info":
                    return "ℹ️ Info";
                case "Warn":
                    return "⚠️ Warn";
                case "Error":
                    return "❌ Error";
                default:
                    return level;
            }
        }

        private Color GetLevelColor(string level)
        {
            switch (level?.Trim())
            {
                case "Info":
                    return Color.FromArgb(23, 162, 184); // Blue
                case "Warn":
                    return Color.FromArgb(255, 193, 7); // Yellow/Orange
                case "Error":
                    return Color.FromArgb(220, 53, 69); // Red
                default:
                    return Color.Black;
            }
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnExportCSV_Click(object sender, EventArgs e)
        {
            if (currentLogs == null || currentLogs.Count == 0)
            {
                MessageBox.Show("No logs to export.", "No Data",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                // Show save file dialog
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                    FileName = $"Logs_{DateTime.Now:yyyyMMdd_HHmmss}.csv",
                    Title = "Export Logs to CSV"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    // Build CSV content
                    StringBuilder csv = new StringBuilder();

                    // Header
                    csv.AppendLine("LogId,Level,Device,Message,Timestamp");

                    // Data rows
                    foreach (var log in currentLogs)
                    {
                        string message = log.Message?.Replace("\"", "\"\"") ?? ""; // Escape quotes
                        string device = log.DeviceId ?? "System";

                        csv.AppendLine($"{log.LogId}," +
                                     $"{log.Level}," +
                                     $"\"{device}\"," +
                                     $"\"{message}\"," +
                                     $"{log.CreatedAt.ToLocalTime():yyyy-MM-dd HH:mm:ss}");
                    }

                    // Write to file
                    File.WriteAllText(saveDialog.FileName, csv.ToString());

                    MessageBox.Show($"Successfully exported {currentLogs.Count} logs to:\n{saveDialog.FileName}",
                        "Export Successful",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    // Log the export
                    GlobalConfig.Connection.CreateLog(
                        null,
                        "Info",
                        $"Logs exported by {SessionManager.CurrentUsername} - {currentLogs.Count} entries"
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error exporting logs: {ex.Message}", "Export Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvLogs_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < currentLogs.Count)
            {
                // Show detailed log information
                LogEntryModel log = currentLogs[e.RowIndex];

                string details = $"Log ID: {log.LogId}\n" +
                               $"Level: {log.Level}\n" +
                               $"Device: {log.DeviceId ?? "System"}\n" +
                               $"Timestamp: {log.CreatedAt.ToLocalTime():MM/dd/yyyy HH:mm:ss}\n" +
                               $"Message: {log.Message}\n";

                if (!string.IsNullOrEmpty(log.ContextJson))
                {
                    details += $"\nContext JSON:\n{log.ContextJson}";
                }

                MessageBox.Show(details, "Log Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
    }
}
