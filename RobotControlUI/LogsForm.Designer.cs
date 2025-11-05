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
            lblPageTitle = new Label();
            gbFilters = new GroupBox();
            cbFilterLevel = new ComboBox();
            lblFilterLevel = new Label();
            btnApplyFilter = new Button();
            lblFilterDevice = new Label();
            cbFilterDevice = new ComboBox();
            lblFilterDateFrom = new Label();
            dtpDateFrom = new DateTimePicker();
            dtpDateTo = new DateTimePicker();
            lblFilterDateTo = new Label();
            dgvLogs = new DataGridView();
            LogId = new DataGridViewTextBoxColumn();
            Level = new DataGridViewTextBoxColumn();
            Device = new DataGridViewTextBoxColumn();
            Message = new DataGridViewTextBoxColumn();
            CreatedAt = new DataGridViewTextBoxColumn();
            btnExportCSV = new Button();
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
            lblPageTitle.Size = new Size(300, 62);
            lblPageTitle.TabIndex = 2;
            lblPageTitle.Text = "System Logs";
            // 
            // gbFilters
            // 
            gbFilters.BackColor = Color.White;
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
            gbFilters.Size = new Size(638, 371);
            gbFilters.TabIndex = 4;
            gbFilters.TabStop = false;
            gbFilters.Text = "Filters";
            // 
            // cbFilterLevel
            // 
            cbFilterLevel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterLevel.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterLevel.FormattingEnabled = true;
            cbFilterLevel.Items.AddRange(new object[] { "All Levels", "Info", "Warn", "Error" });
            cbFilterLevel.Location = new Point(103, 93);
            cbFilterLevel.Name = "cbFilterLevel";
            cbFilterLevel.Size = new Size(206, 33);
            cbFilterLevel.TabIndex = 14;
            // 
            // lblFilterLevel
            // 
            lblFilterLevel.AutoSize = true;
            lblFilterLevel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterLevel.ForeColor = Color.FromArgb(102, 77, 171);
            lblFilterLevel.Location = new Point(13, 98);
            lblFilterLevel.Name = "lblFilterLevel";
            lblFilterLevel.Size = new Size(56, 23);
            lblFilterLevel.TabIndex = 12;
            lblFilterLevel.Text = "Level:";
            lblFilterLevel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnApplyFilter
            // 
            btnApplyFilter.BackColor = Color.FromArgb(102, 77, 171);
            btnApplyFilter.FlatStyle = FlatStyle.Flat;
            btnApplyFilter.ForeColor = Color.White;
            btnApplyFilter.Location = new Point(81, 232);
            btnApplyFilter.Name = "btnApplyFilter";
            btnApplyFilter.Size = new Size(128, 38);
            btnApplyFilter.TabIndex = 10;
            btnApplyFilter.Text = "🔍 Apply";
            btnApplyFilter.UseVisualStyleBackColor = false;
            // 
            // lblFilterDevice
            // 
            lblFilterDevice.AutoSize = true;
            lblFilterDevice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterDevice.ForeColor = Color.FromArgb(102, 77, 171);
            lblFilterDevice.Location = new Point(13, 52);
            lblFilterDevice.Name = "lblFilterDevice";
            lblFilterDevice.Size = new Size(68, 23);
            lblFilterDevice.TabIndex = 3;
            lblFilterDevice.Text = "Device:";
            lblFilterDevice.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // cbFilterDevice
            // 
            cbFilterDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFilterDevice.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbFilterDevice.FormattingEnabled = true;
            cbFilterDevice.Items.AddRange(new object[] { "Pick", "Place", "MoveForward", "Reverse", "TurnLeft", "TurnRight", "AboutTurn", "Home", "Stop" });
            cbFilterDevice.Location = new Point(103, 47);
            cbFilterDevice.Name = "cbFilterDevice";
            cbFilterDevice.Size = new Size(206, 33);
            cbFilterDevice.TabIndex = 25;
            // 
            // lblFilterDateFrom
            // 
            lblFilterDateFrom.AutoSize = true;
            lblFilterDateFrom.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterDateFrom.ForeColor = Color.FromArgb(102, 77, 171);
            lblFilterDateFrom.Location = new Point(14, 137);
            lblFilterDateFrom.Name = "lblFilterDateFrom";
            lblFilterDateFrom.Size = new Size(57, 23);
            lblFilterDateFrom.TabIndex = 26;
            lblFilterDateFrom.Text = "From:";
            lblFilterDateFrom.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpDateFrom
            // 
            dtpDateFrom.Format = DateTimePickerFormat.Short;
            dtpDateFrom.Location = new Point(102, 132);
            dtpDateFrom.Name = "dtpDateFrom";
            dtpDateFrom.Size = new Size(144, 31);
            dtpDateFrom.TabIndex = 27;
            // 
            // dtpDateTo
            // 
            dtpDateTo.Format = DateTimePickerFormat.Short;
            dtpDateTo.Location = new Point(103, 169);
            dtpDateTo.Name = "dtpDateTo";
            dtpDateTo.Size = new Size(144, 31);
            dtpDateTo.TabIndex = 29;
            // 
            // lblFilterDateTo
            // 
            lblFilterDateTo.AutoSize = true;
            lblFilterDateTo.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFilterDateTo.ForeColor = Color.FromArgb(102, 77, 171);
            lblFilterDateTo.Location = new Point(15, 174);
            lblFilterDateTo.Name = "lblFilterDateTo";
            lblFilterDateTo.Size = new Size(33, 23);
            lblFilterDateTo.TabIndex = 28;
            lblFilterDateTo.Text = "To:";
            lblFilterDateTo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvLogs
            // 
            dgvLogs.AllowUserToAddRows = false;
            dgvLogs.AllowUserToDeleteRows = false;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLogs.BackgroundColor = Color.White;
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Columns.AddRange(new DataGridViewColumn[] { LogId, Level, Device, Message, CreatedAt });
            dgvLogs.Location = new Point(330, 47);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.ReadOnly = true;
            dgvLogs.RowHeadersWidth = 51;
            dgvLogs.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLogs.Size = new Size(273, 233);
            dgvLogs.TabIndex = 30;
            // 
            // LogId
            // 
            LogId.FillWeight = 5.6188693F;
            LogId.HeaderText = "LogId";
            LogId.MinimumWidth = 6;
            LogId.Name = "LogId";
            LogId.ReadOnly = true;
            // 
            // Level
            // 
            Level.FillWeight = 3.21952367F;
            Level.HeaderText = "Level";
            Level.MinimumWidth = 6;
            Level.Name = "Level";
            Level.ReadOnly = true;
            // 
            // Device
            // 
            Device.FillWeight = 2.76995373F;
            Device.HeaderText = "Device";
            Device.MinimumWidth = 6;
            Device.Name = "Device";
            Device.ReadOnly = true;
            // 
            // Message
            // 
            Message.FillWeight = 435.828918F;
            Message.HeaderText = "Message";
            Message.MinimumWidth = 6;
            Message.Name = "Message";
            Message.ReadOnly = true;
            // 
            // CreatedAt
            // 
            CreatedAt.FillWeight = 52.56276F;
            CreatedAt.HeaderText = "CreatedAt";
            CreatedAt.MinimumWidth = 6;
            CreatedAt.Name = "CreatedAt";
            CreatedAt.ReadOnly = true;
            // 
            // btnExportCSV
            // 
            btnExportCSV.BackColor = Color.FromArgb(253, 185, 19);
            btnExportCSV.FlatStyle = FlatStyle.Flat;
            btnExportCSV.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportCSV.ForeColor = Color.FromArgb(73, 46, 135);
            btnExportCSV.Location = new Point(379, 310);
            btnExportCSV.Name = "btnExportCSV";
            btnExportCSV.Size = new Size(203, 38);
            btnExportCSV.TabIndex = 31;
            btnExportCSV.Text = "📥 Export to CSV";
            btnExportCSV.UseVisualStyleBackColor = false;
            // 
            // LogsForm
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 760);
            Controls.Add(gbFilters);
            Controls.Add(lblPageTitle);
            Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "LogsForm";
            Text = "Logs - Smart Automation Control System";
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
        private DataGridViewTextBoxColumn LogId;
        private DataGridViewTextBoxColumn Level;
        private DataGridViewTextBoxColumn Device;
        private DataGridViewTextBoxColumn Message;
        private DataGridViewTextBoxColumn CreatedAt;
        private Button btnExportCSV;
    }
}