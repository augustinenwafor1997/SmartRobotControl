namespace RobotControlUI
{
    partial class LogsForm
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            lblPageTitle = new Label();
            gbFilters = new GroupBox();
            btnExportCSV = new Button();
            dgvLogs = new DataGridView();
            colLogId = new DataGridViewTextBoxColumn();
            colLevel = new DataGridViewTextBoxColumn();
            colDevice = new DataGridViewTextBoxColumn();
            colMessage = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            dtpDateTo = new DateTimePicker();
            lblFilterDateTo = new Label();
            dtpDateFrom = new DateTimePicker();
            lblFilterDateFrom = new Label();
            cbFilterDevice = new ComboBox();
            cbFilterLevel = new ComboBox();
            lblFilterLevel = new Label();
            btnApplyFilter = new Button();
            lblFilterDevice = new Label();
            lblStatus = new Label();
            gbFilters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(102, 77, 171);
            lblPageTitle.Location = new Point(30, 30);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(237, 50);
            lblPageTitle.TabIndex = 2;
            lblPageTitle.Text = "System Logs";
            // 
            // gbFilters
            // 
            gbFilters.BackColor = Color.White;
            gbFilters.Controls.Add(lblStatus);
            gbFilters.Controls.Add(btnExportCSV);
            gbFilters.Controls.Add(dgvLogs);
            gbFilters.Controls.Add(dtpDateTo);
            gbFilters.Controls.Add(lblFilterDateTo);
            gbFilters.Controls.Add(dtpDateFrom);
            gbFilters.Controls.Add(lblFilterDateFrom);
            gbFilters.Controls.Add(cbFilterDevice);
            gbFilters.Controls.Add(cbFilterLevel);
            gbFilters.Controls.Add(lblFilterLevel);
            gbFilters.Controls.Add(btnApplyFilter);
            gbFilters.Controls.Add(lblFilterDevice);
            gbFilters.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbFilters.ForeColor = Color.FromArgb(73, 46, 135);
            gbFilters.Location = new Point(30, 160);
            gbFilters.Name = "gbFilters";
            gbFilters.Size = new Size(1140, 513);
            gbFilters.TabIndex = 4;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filters";
            // 
            // btnExportCSV
            // 
            btnExportCSV.BackColor = Color.FromArgb(253, 185, 19);
            btnExportCSV.FlatStyle = FlatStyle.Flat;
            btnExportCSV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportCSV.ForeColor = Color.FromArgb(73, 46, 135);
            btnExportCSV.Location = new Point(597, 449);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(203, 38);
            btnExportCSV.TabIndex = 31;
            btnExportCSV.Text = "📥 Export to CSV";
            btnExportCSV.UseVisualStyleBackColor = false;
            btnExportCSV.Click += btnExportCSV_Click;
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = Color.White;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Columns.AddRange(new DataGridViewColumn[] { colLogId, colLevel, colDevice, colMessage, colCreatedAt });
            dgvLogs.Location = new Point(330, 47);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(787, 372);
            dgvLogs.TabIndex = 30;
            dgvLogs.CellDoubleClick += dgvLogs_CellDoubleClick;
            // 
            // colLogId
            // 
            colLogId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colLogId.DataPropertyName = "LogId";
            colLogId.FillWeight = 5.6188693F;
            colLogId.HeaderText = "Log ID";
            colLogId.MinimumWidth = 80;
            colLogId.Name = "colLogId";
            colLogId.ReadOnly = true;
            colLogId.Width = 80;
            // 
            // colLevel
            // 
            colLevel.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colLevel.DataPropertyName = "Level";
            colLevel.FillWeight = 418.3225F;
            colLevel.HeaderText = "Level";
            colLevel.MinimumWidth = 80;
            colLevel.Name = "colLevel";
            colLevel.ReadOnly = true;
            // 
            // colDevice
            // 
            colDevice.DataPropertyName = "DeviceId";
            colDevice.FillWeight = 0.428940147F;
            colDevice.HeaderText = "Device";
            colDevice.MinimumWidth = 120;
            colDevice.Name = "colDevice";
            colDevice.ReadOnly = true;
            // 
            // colMessage
            // 
            colMessage.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colMessage.DataPropertyName = "Message";
            colMessage.FillWeight = 67.49013F;
            colMessage.HeaderText = "Message";
            colMessage.MinimumWidth = 300;
            colMessage.Name = "colMessage";
            colMessage.ReadOnly = true;
            // 
            // colCreatedAt
            // 
            colCreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colCreatedAt.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle3.Format = "G";
            dataGridViewCellStyle3.NullValue = null;
            colCreatedAt.DefaultCellStyle = dataGridViewCellStyle3;
            colCreatedAt.FillWeight = 8.139586F;
            colCreatedAt.HeaderText = "Timestamp";
            colCreatedAt.MinimumWidth = 150;
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.ReadOnly = true;
            colCreatedAt.Width = 180;
            // 
            // dtpDateTo
            // 
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(103, 169);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(144, 27);
            dtpDateTo.TabIndex = 29;
            // 
            // lblFilterDateTo
            // 
            lblFilterDateTo.AutoSize = true;
            lblFilterDateTo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterDateTo.ForeColor = Color.FromArgb(102, 77, 171);
            lblFilterDateTo.Location = new Point(15, 174);
            lblFilterDateTo.Name = "lblFilterDateTo";
            lblFilterDateTo.Size = new Size(29, 19);
            lblFilterDateTo.TabIndex = 28;
            lblFilterDateTo.Text = "To:";
            lblFilterDateTo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Format = DateTimePickerFormat.Short;
            dtpDateFrom.Location = new Point(102, 132);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(144, 27);
            dtpDateFrom.TabIndex = 27;
            // 
            // lblFilterDateFrom
            // 
            lblFilterDateFrom.AutoSize = true;
            lblFilterDateFrom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterDateFrom.ForeColor = Color.FromArgb(102, 77, 171);
            lblFilterDateFrom.Location = new Point(14, 137);
            lblFilterDateFrom.Name = "lblFilterDateFrom";
            lblFilterDateFrom.Size = new Size(48, 19);
            lblFilterDateFrom.TabIndex = 26;
            lblFilterDateFrom.Text = "From:";
            lblFilterDateFrom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbFilterDevice
            // 
            cbFilterDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterDevice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterDevice.FormattingEnabled = true;
            cbFilterDevice.Items.AddRange(new object[] { "Pick", "Place", "MoveForward", "Reverse", "TurnLeft", "TurnRight", "AboutTurn", "Home", "Stop" });
            cbFilterDevice.Location = new Point(103, 47);
            cbFilterDevice.Name = "cbFilterDevice";
            cbFilterDevice.Size = new Size(206, 27);
            cbFilterDevice.TabIndex = 25;
            // 
            // cbFilterLevel
            // 
            cbFilterLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterLevel.FormattingEnabled = true;
            cbFilterLevel.Items.AddRange(new object[] { "All Levels", "Info", "Warn", "Error" });
            cbFilterLevel.Location = new Point(103, 93);
            cbFilterLevel.Name = "cbFilterLevel";
            cbFilterLevel.Size = new Size(206, 27);
            cbFilterLevel.TabIndex = 14;
            // 
            // lblFilterLevel
            // 
            lblFilterLevel.AutoSize = true;
            lblFilterLevel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterLevel.ForeColor = Color.FromArgb(102, 77, 171);
            lblFilterLevel.Location = new Point(13, 98);
            lblFilterLevel.Name = "lblFilterLevel";
            lblFilterLevel.Size = new Size(48, 19);
            lblFilterLevel.TabIndex = 12;
            lblFilterLevel.Text = "Level:";
            lblFilterLevel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.BackColor = Color.FromArgb(102, 77, 171);
            btnApplyFilter.FlatStyle = FlatStyle.Flat;
            btnApplyFilter.ForeColor = Color.White;
            btnApplyFilter.Location = new Point(102, 231);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(128, 38);
            btnApplyFilter.TabIndex = 10;
            btnApplyFilter.Text = "🔍 Apply";
            btnApplyFilter.UseVisualStyleBackColor = false;
            btnApplyFilter.Click += btnApplyFilter_Click;
            // 
            // lblFilterDevice
            // 
            lblFilterDevice.AutoSize = true;
            lblFilterDevice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterDevice.ForeColor = Color.FromArgb(102, 77, 171);
            lblFilterDevice.Location = new Point(13, 52);
            lblFilterDevice.Name = "lblFilterDevice";
            lblFilterDevice.Size = new Size(58, 19);
            lblFilterDevice.TabIndex = 3;
            lblFilterDevice.Text = "Device:";
            lblFilterDevice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStatus
            // 
            lblStatus.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.FromArgb(108, 117, 125);
            lblStatus.Location = new Point(326, 422);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(203, 19);
            lblStatus.TabIndex = 5;
            lblStatus.Text = "Showing 0 log entries";
            lblStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // LogsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 760);
            Controls.Add(gbFilters);
            Controls.Add(lblPageTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LogsForm";
            Text = "Logs - Smart Automation Control System";
            Load += LogsForm_Load;
            gbFilters.ResumeLayout(false);
            gbFilters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private GroupBox gbFilters;
        private NumericUpDown nudStepDwell;
        private Label lblStepDwell;
        private NumericUpDown nudStepSpeed;
        private Label lblStepSpeed;
        private NumericUpDown nudStepDistance;
        private Label lblStepDistance;
        private ComboBox cbFilterLevel;
        private Label lblFilterLevel;
        private Button btnApplyFilter;
        private Label lblStepCommand;
        private Label lblFilterDevice;
        private ComboBox cbFilterDevice;
        private DateTimePicker dtpDateTo;
        private Label lblFilterDateTo;
        private DateTimePicker dtpDateFrom;
        private Label lblFilterDateFrom;
        private DataGridView dgvLogs;
        private Button btnExportCSV;
        private DataGridViewTextBoxColumn colLogId;
        private DataGridViewTextBoxColumn colLevel;
        private DataGridViewTextBoxColumn colDevice;
        private DataGridViewTextBoxColumn colMessage;
        private DataGridViewTextBoxColumn colCreatedAt;
        private Label lblStatus;
    }
}