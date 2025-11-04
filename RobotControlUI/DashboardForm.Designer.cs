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
            refreshButton = new Button();
            pnlDeviceStatus = new Panel();
            lblDeviceStatusHeader = new Label();
            lblDeviceStatusBadge = new Label();
            lblDeviceName = new Label();
            pnlLastHeartbeat = new Panel();
            lblHeartbeatLocal = new Label();
            lblHeartbeatUTC = new Label();
            lblHeartbeatHeader = new Label();
            lblHeartbeatAgo = new Label();
            pnlPendingCommands = new Panel();
            llViewAllCommands = new Label();
            lblPendingCount = new Label();
            lblPendingCommandsHeader = new Label();
            pnlRunningRoutine = new Panel();
            lblGroupId = new Label();
            lblRoutineName = new Label();
            lblRunningRoutineHeader = new Label();
            btnStopRoutine = new Button();
            pnlDeviceStatus.SuspendLayout();
            pnlLastHeartbeat.SuspendLayout();
            pnlPendingCommands.SuspendLayout();
            pnlRunningRoutine.SuspendLayout();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(102, 77, 171);
            lblPageTitle.Location = new Point(20, 20);
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
            lblLastUpdated.Location = new Point(31, 70);
            lblLastUpdated.Name = "lblLastUpdated";
            lblLastUpdated.Size = new Size(92, 15);
            lblLastUpdated.TabIndex = 1;
            lblLastUpdated.Text = "Last Updated: --";
            // 
            // refreshButton
            // 
            refreshButton.FlatAppearance.BorderSize = 0;
            refreshButton.FlatStyle = FlatStyle.Flat;
            refreshButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refreshButton.ForeColor = Color.FromArgb(102, 77, 171);
            refreshButton.Location = new Point(898, 30);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(80, 29);
            refreshButton.TabIndex = 2;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            // 
            // pnlDeviceStatus
            // 
            pnlDeviceStatus.BorderStyle = BorderStyle.FixedSingle;
            pnlDeviceStatus.Controls.Add(lblDeviceName);
            pnlDeviceStatus.Controls.Add(lblDeviceStatusBadge);
            pnlDeviceStatus.Controls.Add(lblDeviceStatusHeader);
            pnlDeviceStatus.Location = new Point(55, 178);
            pnlDeviceStatus.Name = "pnlDeviceStatus";
            pnlDeviceStatus.Size = new Size(200, 180);
            pnlDeviceStatus.TabIndex = 3;
            // 
            // lblDeviceStatusHeader
            // 
            lblDeviceStatusHeader.AutoSize = true;
            lblDeviceStatusHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceStatusHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblDeviceStatusHeader.Location = new Point(43, 11);
            lblDeviceStatusHeader.Name = "lblDeviceStatusHeader";
            lblDeviceStatusHeader.Size = new Size(113, 21);
            lblDeviceStatusHeader.TabIndex = 0;
            lblDeviceStatusHeader.Text = "Device Status";
            // 
            // lblDeviceStatusBadge
            // 
            lblDeviceStatusBadge.AutoSize = true;
            lblDeviceStatusBadge.BackColor = Color.FromArgb(40, 167, 69);
            lblDeviceStatusBadge.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceStatusBadge.ForeColor = Color.White;
            lblDeviceStatusBadge.Location = new Point(68, 65);
            lblDeviceStatusBadge.Name = "lblDeviceStatusBadge";
            lblDeviceStatusBadge.Size = new Size(66, 37);
            lblDeviceStatusBadge.TabIndex = 1;
            lblDeviceStatusBadge.Text = "Idle";
            lblDeviceStatusBadge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDeviceName
            // 
            lblDeviceName.AutoSize = true;
            lblDeviceName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeviceName.ForeColor = Color.FromArgb(108, 117, 125);
            lblDeviceName.Location = new Point(55, 130);
            lblDeviceName.Name = "lblDeviceName";
            lblDeviceName.Size = new Size(91, 17);
            lblDeviceName.TabIndex = 2;
            lblDeviceName.Text = "Robot Arm #1";
            lblDeviceName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlLastHeartbeat
            // 
            pnlLastHeartbeat.BorderStyle = BorderStyle.FixedSingle;
            pnlLastHeartbeat.Controls.Add(lblHeartbeatAgo);
            pnlLastHeartbeat.Controls.Add(lblHeartbeatLocal);
            pnlLastHeartbeat.Controls.Add(lblHeartbeatUTC);
            pnlLastHeartbeat.Controls.Add(lblHeartbeatHeader);
            pnlLastHeartbeat.Location = new Point(305, 178);
            pnlLastHeartbeat.Name = "pnlLastHeartbeat";
            pnlLastHeartbeat.Size = new Size(200, 180);
            pnlLastHeartbeat.TabIndex = 4;
            // 
            // lblHeartbeatLocal
            // 
            lblHeartbeatLocal.AutoSize = true;
            lblHeartbeatLocal.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHeartbeatLocal.ForeColor = Color.FromArgb(108, 117, 125);
            lblHeartbeatLocal.Location = new Point(71, 106);
            lblHeartbeatLocal.Name = "lblHeartbeatLocal";
            lblHeartbeatLocal.Size = new Size(52, 17);
            lblHeartbeatLocal.TabIndex = 2;
            lblHeartbeatLocal.Text = "-- Local";
            lblHeartbeatLocal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHeartbeatUTC
            // 
            lblHeartbeatUTC.AutoSize = true;
            lblHeartbeatUTC.BackColor = Color.WhiteSmoke;
            lblHeartbeatUTC.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeartbeatUTC.ForeColor = Color.FromArgb(102, 77, 171);
            lblHeartbeatUTC.Location = new Point(64, 62);
            lblHeartbeatUTC.Name = "lblHeartbeatUTC";
            lblHeartbeatUTC.Size = new Size(69, 25);
            lblHeartbeatUTC.TabIndex = 1;
            lblHeartbeatUTC.Text = "-- UTC";
            lblHeartbeatUTC.TextAlign = ContentAlignment.MiddleCenter;
            lblHeartbeatUTC.Click += this.lblHeartbeatUTC_Click;
            // 
            // lblHeartbeatHeader
            // 
            lblHeartbeatHeader.AutoSize = true;
            lblHeartbeatHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeartbeatHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblHeartbeatHeader.Location = new Point(40, 11);
            lblHeartbeatHeader.Name = "lblHeartbeatHeader";
            lblHeartbeatHeader.Size = new Size(120, 21);
            lblHeartbeatHeader.TabIndex = 0;
            lblHeartbeatHeader.Text = "Last Heartbeat";
            // 
            // lblHeartbeatAgo
            // 
            lblHeartbeatAgo.AutoSize = true;
            lblHeartbeatAgo.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblHeartbeatAgo.ForeColor = Color.FromArgb(40, 167, 69);
            lblHeartbeatAgo.Location = new Point(91, 136);
            lblHeartbeatAgo.Name = "lblHeartbeatAgo";
            lblHeartbeatAgo.Size = new Size(17, 15);
            lblHeartbeatAgo.TabIndex = 3;
            lblHeartbeatAgo.Text = "--";
            lblHeartbeatAgo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlPendingCommands
            // 
            pnlPendingCommands.BorderStyle = BorderStyle.FixedSingle;
            pnlPendingCommands.Controls.Add(llViewAllCommands);
            pnlPendingCommands.Controls.Add(lblPendingCount);
            pnlPendingCommands.Controls.Add(lblPendingCommandsHeader);
            pnlPendingCommands.Location = new Point(554, 178);
            pnlPendingCommands.Name = "pnlPendingCommands";
            pnlPendingCommands.Size = new Size(200, 180);
            pnlPendingCommands.TabIndex = 5;
            // 
            // llViewAllCommands
            // 
            llViewAllCommands.AutoSize = true;
            llViewAllCommands.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llViewAllCommands.ForeColor = Color.FromArgb(102, 77, 171);
            llViewAllCommands.Location = new Point(67, 137);
            llViewAllCommands.Name = "llViewAllCommands";
            llViewAllCommands.Size = new Size(62, 15);
            llViewAllCommands.TabIndex = 2;
            llViewAllCommands.Text = "View All →";
            llViewAllCommands.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingCount
            // 
            lblPendingCount.AutoSize = true;
            lblPendingCount.BackColor = Color.WhiteSmoke;
            lblPendingCount.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCount.ForeColor = Color.FromArgb(253, 185, 19);
            lblPendingCount.Location = new Point(62, 38);
            lblPendingCount.Name = "lblPendingCount";
            lblPendingCount.Size = new Size(74, 86);
            lblPendingCount.TabIndex = 1;
            lblPendingCount.Text = "0";
            lblPendingCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPendingCommandsHeader
            // 
            lblPendingCommandsHeader.AutoSize = true;
            lblPendingCommandsHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPendingCommandsHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblPendingCommandsHeader.Location = new Point(18, 11);
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
            pnlRunningRoutine.Location = new Point(806, 178);
            pnlRunningRoutine.Name = "pnlRunningRoutine";
            pnlRunningRoutine.Size = new Size(200, 180);
            pnlRunningRoutine.TabIndex = 5;
            // 
            // lblGroupId
            // 
            lblGroupId.AutoSize = true;
            lblGroupId.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGroupId.ForeColor = Color.FromArgb(108, 117, 125);
            lblGroupId.Location = new Point(58, 106);
            lblGroupId.Name = "lblGroupId";
            lblGroupId.Size = new Size(82, 15);
            lblGroupId.TabIndex = 2;
            lblGroupId.Text = "Group ID: N/A";
            lblGroupId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoutineName
            // 
            lblRoutineName.AutoSize = true;
            lblRoutineName.BackColor = Color.WhiteSmoke;
            lblRoutineName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoutineName.ForeColor = Color.FromArgb(102, 77, 171);
            lblRoutineName.Location = new Point(64, 62);
            lblRoutineName.Name = "lblRoutineName";
            lblRoutineName.Size = new Size(61, 25);
            lblRoutineName.TabIndex = 1;
            lblRoutineName.Text = "None";
            lblRoutineName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRunningRoutineHeader
            // 
            lblRunningRoutineHeader.AutoSize = true;
            lblRunningRoutineHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRunningRoutineHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblRunningRoutineHeader.Location = new Point(30, 11);
            lblRunningRoutineHeader.Name = "lblRunningRoutineHeader";
            lblRunningRoutineHeader.Size = new Size(139, 21);
            lblRunningRoutineHeader.TabIndex = 0;
            lblRunningRoutineHeader.Text = "Running Routine";
            // 
            // btnStopRoutine
            // 
            btnStopRoutine.BackColor = Color.WhiteSmoke;
            btnStopRoutine.Enabled = false;
            btnStopRoutine.FlatStyle = FlatStyle.Flat;
            btnStopRoutine.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStopRoutine.ForeColor = Color.FromArgb(220, 53, 69);
            btnStopRoutine.Location = new Point(57, 136);
            btnStopRoutine.Name = "btnStopRoutine";
            btnStopRoutine.Size = new Size(89, 29);
            btnStopRoutine.TabIndex = 3;
            btnStopRoutine.Text = "⏹ Stop";
            btnStopRoutine.UseVisualStyleBackColor = false;
            // 
            // DashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1063, 661);
            Controls.Add(pnlRunningRoutine);
            Controls.Add(pnlPendingCommands);
            Controls.Add(pnlLastHeartbeat);
            Controls.Add(pnlDeviceStatus);
            Controls.Add(refreshButton);
            Controls.Add(lblLastUpdated);
            Controls.Add(lblPageTitle);
            Font = new Font("Segoe UI", 10F);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Label lblLastUpdated;
        private Button refreshButton;
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
        private Label llViewAllCommands;
        private Label lblPendingCount;
        private Label lblPendingCommandsHeader;
        private Panel pnlRunningRoutine;
        private Label lblGroupId;
        private Label lblRoutineName;
        private Label lblRunningRoutineHeader;
        private Button btnStopRoutine;
    }
}
