namespace RobotControlUI
{
    partial class MotionControlForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            motionControlHeaderLabel = new Label();
            gbCommandSetup = new GroupBox();
            nudDistance = new NumericUpDown();
            lblDistance = new Label();
            lblParametersHeader = new Label();
            cbCommandType = new ComboBox();
            lblCommandType = new Label();
            lblSpeed = new Label();
            nudSpeed = new NumericUpDown();
            btnExecute = new Button();
            gbStatus = new GroupBox();
            lblStatusHeader = new Label();
            lblStatus = new Label();
            gbRecentCommands = new GroupBox();
            lbRecentCommands = new ListBox();
            lblDevice = new Label();
            cbDevice = new ComboBox();
            btnEmergencyStop = new Button();
            btnQuickHome = new Button();
            gbCommandSetup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDistance).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSpeed).BeginInit();
            gbStatus.SuspendLayout();
            gbRecentCommands.SuspendLayout();
            SuspendLayout();
            // 
            // motionControlHeaderLabel
            // 
            motionControlHeaderLabel.AutoSize = true;
            motionControlHeaderLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            motionControlHeaderLabel.ForeColor = Color.FromArgb(102, 77, 171);
            motionControlHeaderLabel.Location = new Point(23, 19);
            motionControlHeaderLabel.Name = "motionControlHeaderLabel";
            motionControlHeaderLabel.Size = new Size(274, 62);
            motionControlHeaderLabel.TabIndex = 1;
            motionControlHeaderLabel.Text = "Commands";
            // 
            // gbCommandSetup
            // 
            gbCommandSetup.Controls.Add(btnExecute);
            gbCommandSetup.Controls.Add(nudSpeed);
            gbCommandSetup.Controls.Add(lblSpeed);
            gbCommandSetup.Controls.Add(nudDistance);
            gbCommandSetup.Controls.Add(lblDistance);
            gbCommandSetup.Controls.Add(lblParametersHeader);
            gbCommandSetup.Controls.Add(cbCommandType);
            gbCommandSetup.Controls.Add(lblCommandType);
            gbCommandSetup.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbCommandSetup.ForeColor = Color.FromArgb(73, 46, 135);
            gbCommandSetup.Location = new Point(47, 155);
            gbCommandSetup.Name = "gbCommandSetup";
            gbCommandSetup.Size = new Size(413, 365);
            gbCommandSetup.TabIndex = 2;
            gbCommandSetup.TabStop = false;
            gbCommandSetup.Text = "Command Setup";
            // 
            // nudDistance
            // 
            nudDistance.Enabled = false;
            nudDistance.Location = new Point(137, 165);
            nudDistance.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudDistance.Name = "nudDistance";
            nudDistance.Size = new Size(150, 34);
            nudDistance.TabIndex = 7;
            nudDistance.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblDistance
            // 
            lblDistance.AutoSize = true;
            lblDistance.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDistance.Location = new Point(14, 172);
            lblDistance.Name = "lblDistance";
            lblDistance.Size = new Size(117, 23);
            lblDistance.TabIndex = 6;
            lblDistance.Text = "Distance (cm):";
            // 
            // lblParametersHeader
            // 
            lblParametersHeader.AutoSize = true;
            lblParametersHeader.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParametersHeader.ForeColor = Color.FromArgb(102, 77, 171);
            lblParametersHeader.Location = new Point(13, 128);
            lblParametersHeader.Name = "lblParametersHeader";
            lblParametersHeader.Size = new Size(113, 25);
            lblParametersHeader.TabIndex = 5;
            lblParametersHeader.Text = "Parameters:";
            lblParametersHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbCommandType
            // 
            cbCommandType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCommandType.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbCommandType.FormattingEnabled = true;
            cbCommandType.Items.AddRange(new object[] { "Pick", "Place", "MoveForward", "Reverse", "TurnLeft", "TurnRight", "AboutTurn", "Home", "Stop" });
            cbCommandType.Location = new Point(178, 49);
            cbCommandType.Name = "cbCommandType";
            cbCommandType.Size = new Size(206, 33);
            cbCommandType.TabIndex = 4;
            // 
            // lblCommandType
            // 
            lblCommandType.AutoSize = true;
            lblCommandType.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCommandType.ForeColor = Color.FromArgb(102, 77, 171);
            lblCommandType.Location = new Point(13, 52);
            lblCommandType.Name = "lblCommandType";
            lblCommandType.Size = new Size(159, 25);
            lblCommandType.TabIndex = 3;
            lblCommandType.Text = "Select Command:";
            lblCommandType.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSpeed
            // 
            lblSpeed.AutoSize = true;
            lblSpeed.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSpeed.Location = new Point(13, 217);
            lblSpeed.Name = "lblSpeed";
            lblSpeed.Size = new Size(90, 23);
            lblSpeed.TabIndex = 8;
            lblSpeed.Text = "Speed (%):";
            lblSpeed.Click += label1_Click;
            // 
            // nudSpeed
            // 
            nudSpeed.Enabled = false;
            nudSpeed.Location = new Point(137, 210);
            nudSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudSpeed.Name = "nudSpeed";
            nudSpeed.Size = new Size(150, 34);
            nudSpeed.TabIndex = 9;
            nudSpeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // btnExecute
            // 
            btnExecute.Location = new Point(137, 274);
            btnExecute.Name = "btnExecute";
            btnExecute.Size = new Size(128, 38);
            btnExecute.TabIndex = 10;
            btnExecute.Text = "▶️ Run";
            btnExecute.UseVisualStyleBackColor = true;
            // 
            // gbStatus
            // 
            gbStatus.BackColor = Color.Ivory;
            gbStatus.Controls.Add(lblStatus);
            gbStatus.Controls.Add(lblStatusHeader);
            gbStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbStatus.ForeColor = Color.FromArgb(73, 46, 135);
            gbStatus.Location = new Point(524, 258);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(250, 125);
            gbStatus.TabIndex = 3;
            gbStatus.TabStop = false;
            gbStatus.Text = "Status";
            // 
            // lblStatusHeader
            // 
            lblStatusHeader.AutoSize = true;
            lblStatusHeader.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusHeader.ForeColor = Color.FromArgb(102, 77, 171);
            lblStatusHeader.Location = new Point(6, 47);
            lblStatusHeader.Name = "lblStatusHeader";
            lblStatusHeader.Size = new Size(131, 23);
            lblStatusHeader.TabIndex = 4;
            lblStatusHeader.Text = "Current Status:";
            lblStatusHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(40, 167, 69);
            lblStatus.Location = new Point(138, 45);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(60, 25);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Ready";
            lblStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbRecentCommands
            // 
            gbRecentCommands.Controls.Add(lbRecentCommands);
            gbRecentCommands.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbRecentCommands.ForeColor = Color.FromArgb(73, 46, 135);
            gbRecentCommands.Location = new Point(846, 155);
            gbRecentCommands.Name = "gbRecentCommands";
            gbRecentCommands.Size = new Size(301, 365);
            gbRecentCommands.TabIndex = 4;
            gbRecentCommands.TabStop = false;
            gbRecentCommands.Text = "Recent Commands (Last 10)";
            // 
            // lbRecentCommands
            // 
            lbRecentCommands.BorderStyle = BorderStyle.FixedSingle;
            lbRecentCommands.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRecentCommands.FormattingEnabled = true;
            lbRecentCommands.Location = new Point(23, 39);
            lbRecentCommands.Name = "lbRecentCommands";
            lbRecentCommands.Size = new Size(239, 302);
            lbRecentCommands.TabIndex = 0;
            // 
            // lblDevice
            // 
            lblDevice.AutoSize = true;
            lblDevice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDevice.ForeColor = Color.FromArgb(102, 77, 171);
            lblDevice.Location = new Point(492, 196);
            lblDevice.Name = "lblDevice";
            lblDevice.Size = new Size(133, 25);
            lblDevice.TabIndex = 5;
            lblDevice.Text = "Target Device:";
            lblDevice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbDevice
            // 
            cbDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDevice.FormattingEnabled = true;
            cbDevice.Location = new Point(632, 193);
            cbDevice.Name = "cbDevice";
            cbDevice.Size = new Size(162, 31);
            cbDevice.TabIndex = 6;
            // 
            // btnEmergencyStop
            // 
            btnEmergencyStop.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmergencyStop.ForeColor = Color.FromArgb(220, 53, 69);
            btnEmergencyStop.Location = new Point(530, 414);
            btnEmergencyStop.Name = "btnEmergencyStop";
            btnEmergencyStop.Size = new Size(237, 38);
            btnEmergencyStop.TabIndex = 11;
            btnEmergencyStop.Text = "⏹️ EMERGENCY STOP";
            btnEmergencyStop.UseVisualStyleBackColor = true;
            // 
            // btnQuickHome
            // 
            btnQuickHome.BackColor = Color.FromArgb(73, 46, 135);
            btnQuickHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuickHome.ForeColor = Color.FromArgb(253, 185, 19);
            btnQuickHome.Location = new Point(530, 482);
            btnQuickHome.Name = "btnQuickHome";
            btnQuickHome.Size = new Size(237, 38);
            btnQuickHome.TabIndex = 12;
            btnQuickHome.Text = "🏠 Quick Home";
            btnQuickHome.UseVisualStyleBackColor = false;
            // 
            // MotionControlForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1196, 760);
            Controls.Add(btnQuickHome);
            Controls.Add(btnEmergencyStop);
            Controls.Add(cbDevice);
            Controls.Add(lblDevice);
            Controls.Add(gbRecentCommands);
            Controls.Add(gbStatus);
            Controls.Add(gbCommandSetup);
            Controls.Add(motionControlHeaderLabel);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "MotionControlForm";
            Text = "Motion Control - Smart Automation Control System\n";
            gbCommandSetup.ResumeLayout(false);
            gbCommandSetup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDistance).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSpeed).EndInit();
            gbStatus.ResumeLayout(false);
            gbStatus.PerformLayout();
            gbRecentCommands.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label motionControlHeaderLabel;
        private GroupBox gbCommandSetup;
        private ComboBox cbCommandType;
        private Label lblCommandType;
        private Label lblDistance;
        private Label lblParametersHeader;
        private NumericUpDown nudDistance;
        private Label lblSpeed;
        private NumericUpDown nudSpeed;
        private Button btnExecute;
        private GroupBox gbStatus;
        private Label lblStatus;
        private Label lblStatusHeader;
        private GroupBox gbRecentCommands;
        private ListBox lbRecentCommands;
        private Label lblDevice;
        private ComboBox cbDevice;
        private Button btnEmergencyStop;
        private Button btnQuickHome;
    }
}