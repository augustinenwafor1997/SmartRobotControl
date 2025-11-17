using RobotControlLibrary;
using RobotControlLibrary.Models;

namespace RobotControlUI
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lblQuickActions_Click(object sender, EventArgs e)
        {

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            // Load data when form opens
            LoadDashboardData();

            // Show/hide admin menu based on user role
            if (SessionManager.IsAdmin)
            {
                menuUsers.Visible = true;
            }
            else
            {
                menuUsers.Visible = false;
            }

            // Enable navigation buttons
            btnGoToMotionControl.Enabled = true;
            btnGoToScheduler.Enabled = true;
        }

        private void LoadDashboardData()
        {
            try
            {
                LoadDeviceStatus();
                LoadPendingCommandsCount();
                LoadRecentCommands();
                LoadRecentLogs();
                UpdateLastUpdatedTime();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadDeviceStatus()
        {
            // Get all devices
            List<DeviceModel> devices = GlobalConfig.Connection.GetAllDevices();

            if (devices != null && devices.Count > 0)
            {
                // For now, show the first device
                DeviceModel device = devices.First();

                lblDeviceName.Text = device.DisplayName;
                lblDeviceStatusBadge.Text = device.Status ?? "Unknown";

                // Set badge color based on status
                switch (device.Status)
                {
                    case "Idle":
                        lblDeviceStatusBadge.BackColor = Color.FromArgb(40, 167, 69); // Green
                        break;
                    case "Active":
                        lblDeviceStatusBadge.BackColor = Color.FromArgb(73, 46, 135); // Purple
                        break;
                    case "Error":
                        lblDeviceStatusBadge.BackColor = Color.FromArgb(220, 53, 69); // Red
                        break;
                    case "Offline":
                        lblDeviceStatusBadge.BackColor = Color.FromArgb(108, 117, 125); // Gray
                        break;
                    default:
                        lblDeviceStatusBadge.BackColor = Color.FromArgb(108, 117, 125); // Gray
                        break;
                }

                // Update heartbeat
                if (device.LastHeartbeat.HasValue)
                {
                    lblHeartbeatUTC.Text = device.LastHeartbeat.Value.ToString("yyyy-MM-dd HH:mm:ss") + " UTC";
                    lblHeartbeatLocal.Text = device.LastHeartbeat.Value.ToLocalTime().ToString("MM/dd/yyyy hh:mm:ss tt");

                    // Calculate time ago
                    TimeSpan timeAgo = DateTime.UtcNow - device.LastHeartbeat.Value;
                    lblHeartbeatAgo.Text = GetTimeAgoText(timeAgo);

                    // Color based on recency
                    if (timeAgo.TotalMinutes < 5)
                    {
                        lblHeartbeatAgo.ForeColor = Color.FromArgb(40, 167, 69); // Green
                    }
                    else if (timeAgo.TotalMinutes < 15)
                    {
                        lblHeartbeatAgo.ForeColor = Color.FromArgb(255, 193, 7); // Yellow
                    }
                    else
                    {
                        lblHeartbeatAgo.ForeColor = Color.FromArgb(220, 53, 69); // Red
                    }
                }
                else
                {
                    lblHeartbeatUTC.Text = "-- UTC";
                    lblHeartbeatLocal.Text = "-- Local";
                    lblHeartbeatAgo.Text = "No heartbeat";
                    lblHeartbeatAgo.ForeColor = Color.FromArgb(220, 53, 69); // Red
                }
            }
            else
            {
                lblDeviceName.Text = "No devices found";
                lblDeviceStatusBadge.Text = "N/A";
                lblDeviceStatusBadge.BackColor = Color.FromArgb(108, 117, 125); // Gray
            }
        }


        private void LoadPendingCommandsCount()
        {
            List<CommandModel> commands = GlobalConfig.Connection.GetRecentCommands(100);

            // No need for .Trim() anymore!
            int pendingCount = commands.Count(c =>
                c.Status == "Pending" ||
                c.Status == "InProgress");

            lblPendingCount.Text = pendingCount.ToString();
        }


        private void LoadRecentCommands()
        {
            // Get recent commands
            List<CommandModel> commands = GlobalConfig.Connection.GetRecentCommands(20);

            // Clear existing rows (if any)
            // Note: We'll populate this properly once we add the DataGridView
            // For now, just store the count
            // TODO: Populate DataGridView when we add it
        }

        private void LoadRecentLogs()
        {
            // Get recent logs
            List<LogEntryModel> logs = GlobalConfig.Connection.GetRecentLogs(30);

            // TODO: Populate DataGridView when we add it
        }

        private void UpdateLastUpdatedTime()
        {
            lblLastUpdated.Text = $"Last Updated: {DateTime.Now.ToString("MM/dd/yyyy hh:mm:ss tt")}";
        }

        private string GetTimeAgoText(TimeSpan timeAgo)
        {
            if (timeAgo.TotalSeconds < 60)
                return $"{(int)timeAgo.TotalSeconds} seconds ago";
            else if (timeAgo.TotalMinutes < 60)
                return $"{(int)timeAgo.TotalMinutes} minutes ago";
            else if (timeAgo.TotalHours < 24)
                return $"{(int)timeAgo.TotalHours} hours ago";
            else
                return $"{(int)timeAgo.TotalDays} days ago";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadDashboardData();
        }

        #region Navigation Buttons

        private void btnGoToMotionControl_Click(object sender, EventArgs e)
        {
            MotionControlForm motionForm = new MotionControlForm();
            motionForm.Show();
        }

        private void btnGoToScheduler_Click(object sender, EventArgs e)
        {
            SchedulerForm schedulerForm = new SchedulerForm();
            schedulerForm.Show();
        }

        #endregion

        #region Menu Items

        private void menuLogs_Click(object sender, EventArgs e)
        {
            LogsForm logsForm = new LogsForm();
            logsForm.Show();
        }

        private void menuDevices_Click(object sender, EventArgs e)
        {
            DevicesForm devicesForm = new DevicesForm();
            devicesForm.Show();
        }

        private void menuUsers_Click(object sender, EventArgs e)
        {
            UsersForm usersForm = new UsersForm();
            usersForm.Show();
        }

        private void menuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Smart Automation Control System\n\n" +
                "Version 1.0\n" +
                "Created by: Augustine Nwafor\n\n" +
                "A robot control and monitoring system.",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void menuLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Are you sure you want to logout?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Clear session
                SessionManager.ClearSession();

                // Close all open forms except this one
                foreach (Form form in Application.OpenForms.Cast<Form>().ToList())
                {
                    if (form != this)
                        form.Close();
                }

                // Show login form
                LoginForm loginForm = new LoginForm();
                loginForm.Show();

                // Close dashboard
                this.Close();
            }
        }

        #endregion

        private void lblViewAllCommands_Click(object sender, EventArgs e)
        {
            LogsForm logsForm = new LogsForm();
            logsForm.Show();
        }
    }
}

