namespace RobotControlUI
{
    partial class SchedulerForm
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
            schedulerHeaderLabel = new Label();
            gbBuildRoutine = new GroupBox();
            btnSaveRoutine = new Button();
            btnRemoveStep = new Button();
            lbRoutineSteps = new ListBox();
            lblStepsHeader = new Label();
            nudStepDwell = new NumericUpDown();
            lblStepDwell = new Label();
            nudStepSpeed = new NumericUpDown();
            lblStepSpeed = new Label();
            nudStepDistance = new NumericUpDown();
            lblStepDistance = new Label();
            cbStepCommand = new ComboBox();
            txtRoutineDescription = new TextBox();
            lblRoutineDescription = new Label();
            txtRoutineName = new TextBox();
            btnAddStep = new Button();
            lblStepCommand = new Label();
            lblAddStepHeader = new Label();
            lblRoutineName = new Label();
            gbExecuteRoutine = new GroupBox();
            lblExecutionStatus = new Label();
            cbTargetDevice = new ComboBox();
            lblTargetDevice = new Label();
            lblRoutineInfo = new Label();
            cbSavedRoutines = new ComboBox();
            lbRoutinePreview = new ListBox();
            lblRoutinePreviewHeader = new Label();
            lblRoutineInfoHeader = new Label();
            btnExecuteRoutine = new Button();
            lblExecutionStatusHeader = new Label();
            lblSelectRoutine = new Label();
            gbBuildRoutine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudStepDwell).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStepSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudStepDistance).BeginInit();
            gbExecuteRoutine.SuspendLayout();
            SuspendLayout();
            // 
            // schedulerHeaderLabel
            // 
            schedulerHeaderLabel.AutoSize = true;
            schedulerHeaderLabel.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            schedulerHeaderLabel.ForeColor = Color.FromArgb(102, 77, 171);
            schedulerHeaderLabel.Location = new Point(29, 34);
            schedulerHeaderLabel.Name = "schedulerHeaderLabel";
            schedulerHeaderLabel.Size = new Size(293, 50);
            schedulerHeaderLabel.TabIndex = 1;
            schedulerHeaderLabel.Text = "Routine Builder";
            // 
            // gbBuildRoutine
            // 
            gbBuildRoutine.Controls.Add(btnSaveRoutine);
            gbBuildRoutine.Controls.Add(btnRemoveStep);
            gbBuildRoutine.Controls.Add(lbRoutineSteps);
            gbBuildRoutine.Controls.Add(lblStepsHeader);
            gbBuildRoutine.Controls.Add(nudStepDwell);
            gbBuildRoutine.Controls.Add(lblStepDwell);
            gbBuildRoutine.Controls.Add(nudStepSpeed);
            gbBuildRoutine.Controls.Add(lblStepSpeed);
            gbBuildRoutine.Controls.Add(nudStepDistance);
            gbBuildRoutine.Controls.Add(lblStepDistance);
            gbBuildRoutine.Controls.Add(cbStepCommand);
            gbBuildRoutine.Controls.Add(txtRoutineDescription);
            gbBuildRoutine.Controls.Add(lblRoutineDescription);
            gbBuildRoutine.Controls.Add(txtRoutineName);
            gbBuildRoutine.Controls.Add(btnAddStep);
            gbBuildRoutine.Controls.Add(lblStepCommand);
            gbBuildRoutine.Controls.Add(lblAddStepHeader);
            gbBuildRoutine.Controls.Add(lblRoutineName);
            gbBuildRoutine.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbBuildRoutine.ForeColor = Color.FromArgb(73, 46, 135);
            gbBuildRoutine.Location = new Point(35, 176);
            gbBuildRoutine.Name = "gbBuildRoutine";
            gbBuildRoutine.Size = new Size(548, 425);
            gbBuildRoutine.TabIndex = 3;
            gbBuildRoutine.TabStop = false;
            gbBuildRoutine.Text = "Build New Routine";
            // 
            // btnSaveRoutine
            // 
            btnSaveRoutine.ForeColor = Color.FromArgb(40, 167, 69);
            btnSaveRoutine.Location = new Point(342, 372);
            btnSaveRoutine.Name = "btnSaveRoutine";
            btnSaveRoutine.Size = new Size(181, 38);
            btnSaveRoutine.TabIndex = 24;
            btnSaveRoutine.Text = "💾 Save Routine";
            btnSaveRoutine.UseVisualStyleBackColor = true;
            btnSaveRoutine.Click += btnSaveRoutine_Click;
            // 
            // btnRemoveStep
            // 
            btnRemoveStep.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveStep.ForeColor = Color.FromArgb(220, 53, 69);
            btnRemoveStep.Location = new Point(361, 316);
            btnRemoveStep.Name = "btnRemoveStep";
            btnRemoveStep.Size = new Size(146, 38);
            btnRemoveStep.TabIndex = 23;
            btnRemoveStep.Text = "❌ Remove";
            btnRemoveStep.UseVisualStyleBackColor = true;
            btnRemoveStep.Click += btnRemoveStep_Click;
            // 
            // lbRoutineSteps
            // 
            lbRoutineSteps.BorderStyle = BorderStyle.FixedSingle;
            lbRoutineSteps.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRoutineSteps.FormattingEnabled = true;
            lbRoutineSteps.ItemHeight = 15;
            lbRoutineSteps.Location = new Point(337, 65);
            lbRoutineSteps.Name = "lbRoutineSteps";
            lbRoutineSteps.Size = new Size(196, 242);
            lbRoutineSteps.TabIndex = 22;
            // 
            // lblStepsHeader
            // 
            lblStepsHeader.AutoSize = true;
            lblStepsHeader.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStepsHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblStepsHeader.Location = new Point(340, 30);
            lblStepsHeader.Name = "lblStepsHeader";
            lblStepsHeader.Size = new Size(110, 20);
            lblStepsHeader.TabIndex = 21;
            lblStepsHeader.Text = "Routine Steps:";
            lblStepsHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nudStepDwell
            // 
            nudStepDwell.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nudStepDwell.Location = new Point(148, 320);
            nudStepDwell.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudStepDwell.Name = "nudStepDwell";
            nudStepDwell.Size = new Size(150, 29);
            nudStepDwell.TabIndex = 20;
            nudStepDwell.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblStepDwell
            // 
            lblStepDwell.AutoSize = true;
            lblStepDwell.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStepDwell.Location = new Point(24, 327);
            lblStepDwell.Name = "lblStepDwell";
            lblStepDwell.Size = new Size(75, 19);
            lblStepDwell.TabIndex = 19;
            lblStepDwell.Text = "Dwell (ms):";
            // 
            // nudStepSpeed
            // 
            nudStepSpeed.Location = new Point(148, 273);
            nudStepSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStepSpeed.Name = "nudStepSpeed";
            nudStepSpeed.Size = new Size(150, 29);
            nudStepSpeed.TabIndex = 18;
            nudStepSpeed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblStepSpeed
            // 
            lblStepSpeed.AutoSize = true;
            lblStepSpeed.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStepSpeed.Location = new Point(24, 280);
            lblStepSpeed.Name = "lblStepSpeed";
            lblStepSpeed.Size = new Size(72, 19);
            lblStepSpeed.TabIndex = 17;
            lblStepSpeed.Text = "Speed (%):";
            // 
            // nudStepDistance
            // 
            nudStepDistance.Enabled = false;
            nudStepDistance.Location = new Point(148, 228);
            nudStepDistance.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudStepDistance.Name = "nudStepDistance";
            nudStepDistance.Size = new Size(150, 29);
            nudStepDistance.TabIndex = 16;
            nudStepDistance.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblStepDistance
            // 
            lblStepDistance.AutoSize = true;
            lblStepDistance.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStepDistance.Location = new Point(25, 235);
            lblStepDistance.Name = "lblStepDistance";
            lblStepDistance.Size = new Size(94, 19);
            lblStepDistance.TabIndex = 15;
            lblStepDistance.Text = "Distance (cm):";
            // 
            // cbStepCommand
            // 
            cbStepCommand.DropDownStyle = ComboBoxStyle.DropDownList;
            cbStepCommand.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbStepCommand.FormattingEnabled = true;
            cbStepCommand.Items.AddRange(new object[] { "Pick", "Place", "MoveForward", "Reverse", "TurnLeft", "TurnRight", "AboutTurn", "Home", "Stop" });
            cbStepCommand.Location = new Point(118, 189);
            cbStepCommand.Name = "cbStepCommand";
            cbStepCommand.Size = new Size(206, 27);
            cbStepCommand.TabIndex = 14;
            cbStepCommand.SelectedIndexChanged += cbStepCommand_SelectedIndexChanged;
            // 
            // txtRoutineDescription
            // 
            txtRoutineDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoutineDescription.Location = new Point(148, 95);
            txtRoutineDescription.MaxLength = 200;
            txtRoutineDescription.Multiline = true;
            txtRoutineDescription.Name = "txtRoutineDescription";
            txtRoutineDescription.ScrollBars = ScrollBars.Vertical;
            txtRoutineDescription.Size = new Size(170, 27);
            txtRoutineDescription.TabIndex = 13;
            // 
            // lblRoutineDescription
            // 
            lblRoutineDescription.AutoSize = true;
            lblRoutineDescription.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoutineDescription.ForeColor = Color.FromArgb(102, 77, 171);
            lblRoutineDescription.Location = new Point(13, 98);
            lblRoutineDescription.Name = "lblRoutineDescription";
            lblRoutineDescription.Size = new Size(89, 19);
            lblRoutineDescription.TabIndex = 12;
            lblRoutineDescription.Text = "Description:";
            lblRoutineDescription.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRoutineName
            // 
            txtRoutineName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtRoutineName.Location = new Point(148, 49);
            txtRoutineName.MaxLength = 100;
            txtRoutineName.Name = "txtRoutineName";
            txtRoutineName.Size = new Size(170, 27);
            txtRoutineName.TabIndex = 11;
            // 
            // btnAddStep
            // 
            btnAddStep.Location = new Point(118, 372);
            btnAddStep.Name = "btnAddStep";
            btnAddStep.Size = new Size(128, 38);
            btnAddStep.TabIndex = 10;
            btnAddStep.Text = "➕ Add Step";
            btnAddStep.UseVisualStyleBackColor = true;
            btnAddStep.Click += btnAddStep_Click;
            // 
            // lblStepCommand
            // 
            lblStepCommand.AutoSize = true;
            lblStepCommand.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStepCommand.ForeColor = Color.FromArgb(102, 77, 171);
            lblStepCommand.Location = new Point(14, 194);
            lblStepCommand.Name = "lblStepCommand";
            lblStepCommand.Size = new Size(82, 19);
            lblStepCommand.TabIndex = 6;
            lblStepCommand.Text = "Command:";
            // 
            // lblAddStepHeader
            // 
            lblAddStepHeader.AutoSize = true;
            lblAddStepHeader.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAddStepHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblAddStepHeader.Location = new Point(13, 150);
            lblAddStepHeader.Name = "lblAddStepHeader";
            lblAddStepHeader.Size = new Size(155, 20);
            lblAddStepHeader.TabIndex = 5;
            lblAddStepHeader.Text = "Add Step to Routine:";
            lblAddStepHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoutineName
            // 
            lblRoutineName.AutoSize = true;
            lblRoutineName.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoutineName.ForeColor = Color.FromArgb(102, 77, 171);
            lblRoutineName.Location = new Point(13, 52);
            lblRoutineName.Name = "lblRoutineName";
            lblRoutineName.Size = new Size(108, 19);
            lblRoutineName.TabIndex = 3;
            lblRoutineName.Text = "Routine Name:";
            lblRoutineName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gbExecuteRoutine
            // 
            gbExecuteRoutine.Controls.Add(lblExecutionStatus);
            gbExecuteRoutine.Controls.Add(cbTargetDevice);
            gbExecuteRoutine.Controls.Add(lblTargetDevice);
            gbExecuteRoutine.Controls.Add(lblRoutineInfo);
            gbExecuteRoutine.Controls.Add(cbSavedRoutines);
            gbExecuteRoutine.Controls.Add(lbRoutinePreview);
            gbExecuteRoutine.Controls.Add(lblRoutinePreviewHeader);
            gbExecuteRoutine.Controls.Add(lblRoutineInfoHeader);
            gbExecuteRoutine.Controls.Add(btnExecuteRoutine);
            gbExecuteRoutine.Controls.Add(lblExecutionStatusHeader);
            gbExecuteRoutine.Controls.Add(lblSelectRoutine);
            gbExecuteRoutine.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbExecuteRoutine.ForeColor = Color.FromArgb(73, 46, 135);
            gbExecuteRoutine.Location = new Point(615, 176);
            gbExecuteRoutine.Name = "gbExecuteRoutine";
            gbExecuteRoutine.Size = new Size(548, 425);
            gbExecuteRoutine.TabIndex = 25;
            gbExecuteRoutine.TabStop = false;
            gbExecuteRoutine.Text = "Execute Saved Routine";
            // 
            // lblExecutionStatus
            // 
            lblExecutionStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExecutionStatus.ForeColor = Color.FromArgb(40, 167, 69);
            lblExecutionStatus.Location = new Point(178, 368);
            lblExecutionStatus.Name = "lblExecutionStatus";
            lblExecutionStatus.Size = new Size(111, 32);
            lblExecutionStatus.TabIndex = 29;
            lblExecutionStatus.Text = "Ready";
            // 
            // cbTargetDevice
            // 
            cbTargetDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTargetDevice.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cbTargetDevice.FormattingEnabled = true;
            cbTargetDevice.Location = new Point(144, 226);
            cbTargetDevice.Name = "cbTargetDevice";
            cbTargetDevice.Size = new Size(162, 27);
            cbTargetDevice.TabIndex = 28;
            // 
            // lblTargetDevice
            // 
            lblTargetDevice.AutoSize = true;
            lblTargetDevice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTargetDevice.ForeColor = Color.FromArgb(102, 77, 171);
            lblTargetDevice.Location = new Point(13, 234);
            lblTargetDevice.Name = "lblTargetDevice";
            lblTargetDevice.Size = new Size(105, 19);
            lblTargetDevice.TabIndex = 27;
            lblTargetDevice.Text = "Target Device:";
            lblTargetDevice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoutineInfo
            // 
            lblRoutineInfo.AutoSize = true;
            lblRoutineInfo.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRoutineInfo.ForeColor = Color.FromArgb(108, 117, 125);
            lblRoutineInfo.Location = new Point(148, 101);
            lblRoutineInfo.Name = "lblRoutineInfo";
            lblRoutineInfo.Size = new Size(110, 15);
            lblRoutineInfo.TabIndex = 26;
            lblRoutineInfo.Text = "No routine selected";
            // 
            // cbSavedRoutines
            // 
            cbSavedRoutines.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSavedRoutines.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbSavedRoutines.FormattingEnabled = true;
            cbSavedRoutines.Items.AddRange(new object[] { "Pick", "Place", "MoveForward", "Reverse", "TurnLeft", "TurnRight", "AboutTurn", "Home", "Stop" });
            cbSavedRoutines.Location = new Point(148, 47);
            cbSavedRoutines.Name = "cbSavedRoutines";
            cbSavedRoutines.Size = new Size(176, 27);
            cbSavedRoutines.TabIndex = 25;
            cbSavedRoutines.SelectedIndexChanged += cbSavedRoutines_SelectedIndexChanged;
            // 
            // lbRoutinePreview
            // 
            lbRoutinePreview.BackColor = Color.WhiteSmoke;
            lbRoutinePreview.BorderStyle = BorderStyle.FixedSingle;
            lbRoutinePreview.Enabled = false;
            lbRoutinePreview.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbRoutinePreview.FormattingEnabled = true;
            lbRoutinePreview.ItemHeight = 15;
            lbRoutinePreview.Location = new Point(337, 65);
            lbRoutinePreview.Name = "lbRoutinePreview";
            lbRoutinePreview.Size = new Size(196, 242);
            lbRoutinePreview.TabIndex = 22;
            // 
            // lblRoutinePreviewHeader
            // 
            lblRoutinePreviewHeader.AutoSize = true;
            lblRoutinePreviewHeader.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoutinePreviewHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblRoutinePreviewHeader.Location = new Point(333, 30);
            lblRoutinePreviewHeader.Name = "lblRoutinePreviewHeader";
            lblRoutinePreviewHeader.Size = new Size(169, 20);
            lblRoutinePreviewHeader.TabIndex = 21;
            lblRoutinePreviewHeader.Text = "Routine Steps Preview:";
            lblRoutinePreviewHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoutineInfoHeader
            // 
            lblRoutineInfoHeader.AutoSize = true;
            lblRoutineInfoHeader.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRoutineInfoHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblRoutineInfoHeader.Location = new Point(13, 98);
            lblRoutineInfoHeader.Name = "lblRoutineInfoHeader";
            lblRoutineInfoHeader.Size = new Size(94, 19);
            lblRoutineInfoHeader.TabIndex = 12;
            lblRoutineInfoHeader.Text = "Routine Info:";
            lblRoutineInfoHeader.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnExecuteRoutine
            // 
            btnExecuteRoutine.BackColor = Color.FromArgb(253, 185, 19);
            btnExecuteRoutine.Location = new Point(52, 287);
            btnExecuteRoutine.Name = "btnExecuteRoutine";
            btnExecuteRoutine.Size = new Size(218, 38);
            btnExecuteRoutine.TabIndex = 10;
            btnExecuteRoutine.Text = "▶️ Execute Routine";
            btnExecuteRoutine.UseVisualStyleBackColor = false;
            btnExecuteRoutine.Click += btnExecuteRoutine_Click;
            // 
            // lblExecutionStatusHeader
            // 
            lblExecutionStatusHeader.AutoSize = true;
            lblExecutionStatusHeader.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblExecutionStatusHeader.ForeColor = Color.FromArgb(73, 46, 135);
            lblExecutionStatusHeader.Location = new Point(25, 368);
            lblExecutionStatusHeader.Name = "lblExecutionStatusHeader";
            lblExecutionStatusHeader.Size = new Size(121, 19);
            lblExecutionStatusHeader.TabIndex = 6;
            lblExecutionStatusHeader.Text = "Execution Status:";
            // 
            // lblSelectRoutine
            // 
            lblSelectRoutine.AutoSize = true;
            lblSelectRoutine.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectRoutine.ForeColor = Color.FromArgb(102, 77, 171);
            lblSelectRoutine.Location = new Point(13, 52);
            lblSelectRoutine.Name = "lblSelectRoutine";
            lblSelectRoutine.Size = new Size(108, 19);
            lblSelectRoutine.TabIndex = 3;
            lblSelectRoutine.Text = "Select Routine:";
            lblSelectRoutine.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // SchedulerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 760);
            Controls.Add(gbExecuteRoutine);
            Controls.Add(gbBuildRoutine);
            Controls.Add(schedulerHeaderLabel);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "SchedulerForm";
            Text = "Scheduler - Smart Automation Control System";
            Load += SchedulerForm_Load;
            gbBuildRoutine.ResumeLayout(false);
            gbBuildRoutine.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudStepDwell).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStepSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudStepDistance).EndInit();
            gbExecuteRoutine.ResumeLayout(false);
            gbExecuteRoutine.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label schedulerHeaderLabel;
        private GroupBox gbBuildRoutine;
        private Button btnAddStep;
        private Label lblStepCommand;
        private Label lblAddStepHeader;
        private Label lblRoutineName;
        private TextBox txtRoutineName;
        private TextBox txtRoutineDescription;
        private Label lblRoutineDescription;
        private ComboBox cbStepCommand;
        private NumericUpDown nudStepSpeed;
        private Label lblStepSpeed;
        private NumericUpDown nudStepDistance;
        private Label lblStepDistance;
        private NumericUpDown nudStepDwell;
        private Label lblStepDwell;
        private Label lblStepsHeader;
        private Button btnRemoveStep;
        private ListBox lbRoutineSteps;
        private Button btnSaveRoutine;
        private GroupBox gbExecuteRoutine;
        private ListBox lbRoutinePreview;
        private Label lblRoutinePreviewHeader;
        private Label lblRoutineInfoHeader;
        private Button btnExecuteRoutine;
        private Label lblExecutionStatusHeader;
        private Label lblSelectRoutine;
        private ComboBox cbSavedRoutines;
        private Label lblRoutineInfo;
        private Label lblTargetDevice;
        private ComboBox cbTargetDevice;
        private Label lblExecutionStatus;
    }
}