namespace RobotControlUI
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblPageTitle = new Label();
            lblLastUpdated = new Label();
            pnlDeviceStatus = new Panel();
            lblDeviceName = new Label();
            lblDeviceStatusBadge = new Label();
            lblDeviceStatusHeader = new Label();
            pnlLastHeartbeat = new Panel();
            lblHeartbeatAgo = new Label();
            lblHeartbeatLocal = new Label();
            lblHeartbeatUTC = new Label();
            lblHeartbeatHeader = new Label();
            pnlPendingCommands = new Panel();
            lblViewAllCommands = new Label();
            lblPendingCount = new Label();
            lblPendingCommandsHeader = new Label();
            pnlRunningRoutine = new Panel();
            btnStopRoutine = new Button();
            lblGroupId = new Label();
            lblRoutineName = new Label();
            lblRunningRoutineHeader = new Label();
            menuStrip1 = new MenuStrip();
            menuDevices = new ToolStripMenuItem();
            menuLogs = new ToolStripMenuItem();
            menuUsers = new ToolStripMenuItem();
            menuLogout = new ToolStripMenuItem();
            menuAbout = new ToolStripMenuItem();
            btnGoToMotionControl = new Button();
            btnGoToScheduler = new Button();
            lblQuickActions = new Label();
            btnRefresh = new Button();
            pnlDeviceStatus.SuspendLayout();
            pnlLastHeartbeat.SuspendLayout();
            pnlPendingCommands.SuspendLayout();
            pnlRunningRoutine.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(102, 77, 171);
            lblPageTitle.Location = new Point(20, 48);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(211, 50);
            lblPageTitle.TabIndex = 0;
            lblPageTitle.Text = "Dashboard";
            // 
            // lblLastUpdated
            // 
            lblLastUpdated.AutoSize = true;
            lblLastUpdated.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLastUpdated.ForeColor = Color.FromArgb(108, 117, 125);
            lblLastUpdated.Location = new Point(31, 104);
            lblLastUpdated.Name = "lblLastUpdated";
            lblLastUpdated.Size = new Size(92, 15);
            lblLastUpdated.TabIndex = 1;
            lblLastUpdated.Text = "Last Updated: --";
            // 
            // pnlDeviceStatus
            // 
            pnlDeviceStatus.BorderStyle = BorderStyle.FixedSingle;
            pnlDeviceStatus.Controls.Add(lblDeviceName);
            pnlDeviceStatus.Controls.Add(lblDeviceStatusBadge);
            pnlDeviceStatus.Controls.Add(lblDeviceStatusHeader);
            pnlDeviceStatus.Location = new Point(73, 178);
            pnlDeviceStatus.Name = "pnlDeviceStatus";
            pnlDeviceStatus.Size = new Size(220, 197);
            pnlDeviceStatus.TabIndex = 3;
            // 
            // lblDeviceName
            // 
            lblDeviceName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeviceName.ForeColor = Color.FromArgb(108, 117, 125);
            lblDeviceName.Location = new Point(7, 137);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(203, 19);
            lblDeviceName.TabIndex = 2;
            lblDeviceName.Text = "Robot Arm #1";
            lblDeviceName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDeviceStatusBadge
            // 
            lblDeviceStatusBadge.AutoSize = true;
            lblDeviceStatusBadge.BackColor = Color.FromArgb(40, 167, 69);
            lblDeviceStatusBadge.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceStatusBadge.ForeColor = Color.White;
            lblDeviceStatusBadge.Location = new Point(69, 71);
            lblDeviceStatusBadge.Name = "lblDeviceStatusBadge";
            lblDeviceStatusBadge.Size = new Size(66, 37);
            lblDeviceStatusBadge.TabIndex = 1;
            lblDeviceStatusBadge.Text = "Idle";
            lblDeviceStatusBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDeviceStatusHeader
            // 
            lblDeviceStatusHeader.AutoSize = true;
            lblDeviceStatusHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceStatusHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblDeviceStatusHeader.Location = new Point(38, 11);
            lblDeviceStatusHeader.Name = "lblDeviceStatusHeader";
            lblDeviceStatusHeader.Size = new Size(113, 21);
            lblDeviceStatusHeader.TabIndex = 0;
            lblDeviceStatusHeader.Text = "Device Status";
            // 
            // pnlLastHeartbeat
            // 
            pnlLastHeartbeat.BorderStyle = BorderStyle.FixedSingle;
            pnlLastHeartbeat.Controls.Add(lblHeartbeatAgo);
            pnlLastHeartbeat.Controls.Add(lblHeartbeatLocal);
            pnlLastHeartbeat.Controls.Add(lblHeartbeatUTC);
            pnlLastHeartbeat.Controls.Add(lblHeartbeatHeader);
            pnlLastHeartbeat.Location = new Point(343, 178);
            pnlLastHeartbeat.Name = "pnlLastHeartbeat";
            pnlLastHeartbeat.Size = new Size(220, 197);
            pnlLastHeartbeat.TabIndex = 4;
            // 
            // lblHeartbeatAgo
            // 
            lblHeartbeatAgo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeartbeatAgo.ForeColor = Color.FromArgb(40, 167, 69);
            lblHeartbeatAgo.Location = new Point(14, 153);
            lblHeartbeatAgo.Name = "lblHeartbeatAgo";
            lblHeartbeatAgo.Size = new Size(189, 19);
            lblHeartbeatAgo.TabIndex = 3;
            lblHeartbeatAgo.Text = "--";
            lblHeartbeatAgo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeartbeatLocal
            // 
            lblHeartbeatLocal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeartbeatLocal.ForeColor = Color.FromArgb(108, 117, 125);
            lblHeartbeatLocal.Location = new Point(13, 117);
            lblHeartbeatLocal.Name = "lblHeartbeatLocal";
            lblHeartbeatLocal.Size = new Size(189, 30);
            lblHeartbeatLocal.TabIndex = 2;
            lblHeartbeatLocal.Text = "-- Local";
            lblHeartbeatLocal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeartbeatUTC
            // 
            lblHeartbeatUTC.BackColor = Color.WhiteSmoke;
            lblHeartbeatUTC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeartbeatUTC.ForeColor = Color.FromArgb(102, 77, 171);
            lblHeartbeatUTC.Location = new Point(4, 62);
            lblHeartbeatUTC.Name = "lblHeartbeatUTC";
            lblHeartbeatUTC.Size = new Size(210, 25);
            lblHeartbeatUTC.TabIndex = 1;
            lblHeartbeatUTC.Text = "-- UTC";
            lblHeartbeatUTC.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeartbeatHeader
            // 
            lblHeartbeatHeader.AutoSize = true;
            lblHeartbeatHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeartbeatHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblHeartbeatHeader.Location = new Point(32, 11);
            lblHeartbeatHeader.Name = "lblHeartbeatHeader";
            lblHeartbeatHeader.Size = new Size(120, 21);
            lblHeartbeatHeader.TabIndex = 0;
            lblHeartbeatHeader.Text = "Last Heartbeat";
            // 
            // pnlPendingCommands
            // 
            pnlPendingCommands.BorderStyle = BorderStyle.FixedSingle;
            pnlPendingCommands.Controls.Add(lblViewAllCommands);
            pnlPendingCommands.Controls.Add(lblPendingCount);
            pnlPendingCommands.Controls.Add(lblPendingCommandsHeader);
            pnlPendingCommands.Location = new Point(612, 178);
            pnlPendingCommands.Name = "pnlPendingCommands";
            pnlPendingCommands.Size = new Size(220, 197);
            pnlPendingCommands.TabIndex = 5;
            // 
            // lblViewAllCommands
            // 
            lblViewAllCommands.AutoSize = true;
            lblViewAllCommands.Cursor = Cursors.Hand;
            lblViewAllCommands.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblViewAllCommands.ForeColor = Color.FromArgb(102, 77, 171);
            lblViewAllCommands.Location = new Point(75, 150);
            lblViewAllCommands.Name = "lblViewAllCommands";
            lblViewAllCommands.Size = new Size(62, 15);
            lblViewAllCommands.TabIndex = 2;
            lblViewAllCommands.Text = "View All →";
            lblViewAllCommands.TextAlign = ContentAlignment.MiddleCenter;
            lblViewAllCommands.Click += lblViewAllCommands_Click;
            // 
            // lblPendingCount
            // 
            lblPendingCount.BackColor = Color.WhiteSmoke;
            lblPendingCount.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.ForeColor = Color.FromArgb(253, 185, 19);
            lblPendingCount.Location = new Point(27, 42);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(164, 86);
            lblPendingCount.TabIndex = 1;
            lblPendingCount.Text = "0";
            lblPendingCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingCommandsHeader
            // 
            lblPendingCommandsHeader.AutoSize = true;
            lblPendingCommandsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCommandsHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblPendingCommandsHeader.Location = new Point(10, 11);
            lblPendingCommandsHeader.Name = "lblPendingCommandsHeader";
            lblPendingCommandsHeader.Size = new Size(164, 21);
            lblPendingCommandsHeader.TabIndex = 0;
            lblPendingCommandsHeader.Text = "Pending Commands";
            lblPendingCommandsHeader.TextAlign = ContentAlignment.TopCenter;
            // 
            // pnlRunningRoutine
            // 
            pnlRunningRoutine.BorderStyle = BorderStyle.FixedSingle;
            pnlRunningRoutine.Controls.Add(btnStopRoutine);
            pnlRunningRoutine.Controls.Add(lblGroupId);
            pnlRunningRoutine.Controls.Add(lblRoutineName);
            pnlRunningRoutine.Controls.Add(lblRunningRoutineHeader);
            pnlRunningRoutine.Location = new Point(884, 178);
            pnlRunningRoutine.Name = "pnlRunningRoutine";
            pnlRunningRoutine.Size = new Size(220, 197);
            pnlRunningRoutine.TabIndex = 5;
            // 
            // btnStopRoutine
            // 
            btnStopRoutine.BackColor = Color.WhiteSmoke;
            btnStopRoutine.Enabled = false;
            btnStopRoutine.FlatStyle = FlatStyle.Flat;
            btnStopRoutine.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStopRoutine.ForeColor = Color.FromArgb(220, 53, 69);
            btnStopRoutine.Location = new Point(54, 139);
            btnStopRoutine.Name = "btnStopRoutine";
            btnStopRoutine.Size = new Size(104, 36);
            btnStopRoutine.TabIndex = 3;
            btnStopRoutine.Text = "⏹ Stop";
            btnStopRoutine.UseVisualStyleBackColor = false;
            // 
            // lblGroupId
            // 
            lblGroupId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGroupId.ForeColor = Color.FromArgb(108, 117, 125);
            lblGroupId.Location = new Point(13, 98);
            lblGroupId.Name = "lblGroupId";
            lblGroupId.Size = new Size(193, 31);
            lblGroupId.TabIndex = 2;
            lblGroupId.Text = "Group ID: N/A";
            lblGroupId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoutineName
            // 
            lblRoutineName.BackColor = Color.WhiteSmoke;
            lblRoutineName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoutineName.ForeColor = Color.FromArgb(102, 77, 171);
            lblRoutineName.Location = new Point(22, 55);
            lblRoutineName.Name = "lblRoutineName";
            lblRoutineName.Size = new Size(174, 39);
            lblRoutineName.TabIndex = 1;
            lblRoutineName.Text = "None";
            lblRoutineName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRunningRoutineHeader
            // 
            lblRunningRoutineHeader.AutoSize = true;
            lblRunningRoutineHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRunningRoutineHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblRunningRoutineHeader.Location = new Point(23, 11);
            lblRunningRoutineHeader.Name = "lblRunningRoutineHeader";
            lblRunningRoutineHeader.Size = new Size(139, 21);
            lblRunningRoutineHeader.TabIndex = 0;
            lblRunningRoutineHeader.Text = "Running Routine";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(73, 46, 135);
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuDevices, menuLogs, menuUsers, menuLogout, menuAbout });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1196, 27);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuDevices
            // 
            menuDevices.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuDevices.ForeColor = Color.FromArgb(253, 185, 19);
            menuDevices.Name = "menuDevices";
            menuDevices.Size = new Size(90, 23);
            menuDevices.Text = "🤖 Devices";
            menuDevices.Click += menuDevices_Click;
            // 
            // menuLogs
            // 
            menuLogs.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuLogs.ForeColor = Color.FromArgb(253, 185, 19);
            menuLogs.Name = "menuLogs";
            menuLogs.Size = new Size(73, 23);
            menuLogs.Text = "📝 Logs";
            menuLogs.Click += menuLogs_Click;
            // 
            // menuUsers
            // 
            menuUsers.ForeColor = Color.FromArgb(253, 185, 19);
            menuUsers.Name = "menuUsers";
            menuUsers.Size = new Size(78, 23);
            menuUsers.Text = "👥 Users";
            menuUsers.Click += menuUsers_Click;
            // 
            // menuLogout
            // 
            menuLogout.ForeColor = Color.FromArgb(253, 185, 19);
            menuLogout.Name = "menuLogout";
            menuLogout.Size = new Size(88, 23);
            menuLogout.Text = "🚪 Logout";
            menuLogout.Click += menuLogout_Click;
            // 
            // menuAbout
            // 
            menuAbout.ForeColor = Color.FromArgb(253, 185, 19);
            menuAbout.Name = "menuAbout";
            menuAbout.Size = new Size(82, 23);
            menuAbout.Text = "ℹ️ About";
            menuAbout.Click += menuAbout_Click;
            // 
            // btnGoToMotionControl
            // 
            btnGoToMotionControl.BackColor = Color.FromArgb(102, 77, 171);
            btnGoToMotionControl.FlatAppearance.BorderSize = 0;
            btnGoToMotionControl.FlatStyle = FlatStyle.Flat;
            btnGoToMotionControl.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToMotionControl.ForeColor = Color.White;
            btnGoToMotionControl.Location = new Point(327, 536);
            btnGoToMotionControl.Name = "btnGoToMotionControl";
            btnGoToMotionControl.Size = new Size(230, 48);
            btnGoToMotionControl.TabIndex = 4;
            btnGoToMotionControl.Text = "🎮 Motion Control";
            btnGoToMotionControl.UseVisualStyleBackColor = false;
            btnGoToMotionControl.Click += btnGoToMotionControl_Click;
            // 
            // btnGoToScheduler
            // 
            btnGoToScheduler.BackColor = Color.FromArgb(253, 185, 19);
            btnGoToScheduler.FlatAppearance.BorderSize = 0;
            btnGoToScheduler.FlatStyle = FlatStyle.Flat;
            btnGoToScheduler.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGoToScheduler.ForeColor = Color.FromArgb(73, 46, 135);
            btnGoToScheduler.Location = new Point(635, 536);
            btnGoToScheduler.Name = "btnGoToScheduler";
            btnGoToScheduler.Size = new Size(230, 48);
            btnGoToScheduler.TabIndex = 7;
            btnGoToScheduler.Text = "📅 Routines";
            btnGoToScheduler.UseVisualStyleBackColor = false;
            btnGoToScheduler.Click += btnGoToScheduler_Click;
            // 
            // lblQuickActions
            // 
            lblQuickActions.AutoSize = true;
            lblQuickActions.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuickActions.ForeColor = Color.FromArgb(102, 77, 171);
            lblQuickActions.Location = new Point(515, 464);
            lblQuickActions.Name = "lblQuickActions";
            lblQuickActions.Size = new Size(155, 30);
            lblQuickActions.TabIndex = 3;
            lblQuickActions.Text = "Quick Actions";
            lblQuickActions.Click += lblQuickActions_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefresh.ForeColor = Color.FromArgb(102, 77, 171);
            btnRefresh.Location = new Point(996, 48);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(108, 36);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1196, 760);
            Controls.Add(btnRefresh);
            Controls.Add(lblQuickActions);
            Controls.Add(btnGoToScheduler);
            Controls.Add(btnGoToMotionControl);
            Controls.Add(pnlRunningRoutine);
            Controls.Add(pnlPendingCommands);
            Controls.Add(pnlLastHeartbeat);
            Controls.Add(pnlDeviceStatus);
            Controls.Add(lblLastUpdated);
            Controls.Add(lblPageTitle);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 10F);
            MainMenuStrip = menuStrip1;
            Name = "DashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard - Smart Automation Control System";
            pnlDeviceStatus.ResumeLayout(false);
            pnlDeviceStatus.PerformLayout();
            pnlLastHeartbeat.ResumeLayout(false);
            pnlLastHeartbeat.PerformLayout();
            pnlPendingCommands.ResumeLayout(false);
            pnlPendingCommands.PerformLayout();
            pnlRunningRoutine.ResumeLayout(false);
            pnlRunningRoutine.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Label lblLastUpdated;
        private Panel pnlDeviceStatus;
        private Label lblDeviceStatusBadge;
        private Label lblDeviceStatusHeader;
        private Label lblDeviceName;
        private Panel pnlLastHeartbeat;
        private Label lblHeartbeatLocal;
        private Label lblHeartbeatUTC;
        private Label lblHeartbeatHeader;
        private Label lblHeartbeatAgo;
        private Panel pnlPendingCommands;
        private Label lblViewAllCommands;
        private Label lblPendingCount;
        private Label lblPendingCommandsHeader;
        private Panel pnlRunningRoutine;
        private Label lblGroupId;
        private Label lblRoutineName;
        private Label lblRunningRoutineHeader;
        private Button btnStopRoutine;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuDevices;
        private Button btnRefresh;
        private ToolStripMenuItem menuLogs;
        private ToolStripMenuItem menuUsers;
        private ToolStripMenuItem menuLogout;
        private Button btnGoToMotionControl;
        private Button btnGoToScheduler;
        private Label lblQuickActions;
        private ToolStripMenuItem menuAbout;
        //private ToolStripMenuItem menuDevices;
    }
}
