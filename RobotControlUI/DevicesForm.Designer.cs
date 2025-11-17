namespace RobotControlUI
{
    partial class DevicesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblPageTitle = new Label();
            lblDescription = new Label();
            gbDeviceList = new GroupBox();
            btnRefreshDevices = new Button();
            dgvDevices = new DataGridView();
            colDeviceId = new DataGridViewTextBoxColumn();
            colDisplayName = new DataGridViewTextBoxColumn();
            colStatus = new DataGridViewTextBoxColumn();
            colLastHeartbeat = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            gbDeviceDetails = new GroupBox();
            lblStatusValue = new Label();
            lblStatusLabel = new Label();
            lblDisplayNameValue = new Label();
            lblDisplayNameLabel = new Label();
            lblDeviceIdValue = new Label();
            lblDeviceIdLabel = new Label();
            gbActions = new GroupBox();
            btnRemoveDevice = new Button();
            btnAddDevice = new Button();
            btnViewDeviceLogs = new Button();
            btnTestConnection = new Button();
            gbDeviceList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDevices).BeginInit();
            gbDeviceDetails.SuspendLayout();
            gbActions.SuspendLayout();
            SuspendLayout();
            // 
            // lblPageTitle
            // 
            lblPageTitle.AutoSize = true;
            lblPageTitle.Font = new Font("Segoe UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageTitle.ForeColor = Color.FromArgb(102, 77, 171);
            lblPageTitle.Location = new Point(30, 30);
            lblPageTitle.Name = "lblPageTitle";
            lblPageTitle.Size = new Size(378, 50);
            lblPageTitle.TabIndex = 3;
            lblPageTitle.Text = "Device Management";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(108, 117, 125);
            lblDescription.Location = new Point(39, 89);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(243, 17);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "Manage and monitor connected devices";
            // 
            // gbDeviceList
            // 
            gbDeviceList.Controls.Add(btnRefreshDevices);
            gbDeviceList.Controls.Add(dgvDevices);
            gbDeviceList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDeviceList.ForeColor = Color.FromArgb(73, 46, 135);
            gbDeviceList.Location = new Point(67, 132);
            gbDeviceList.Name = "gbDeviceList";
            gbDeviceList.Size = new Size(1060, 375);
            gbDeviceList.TabIndex = 5;
            gbDeviceList.TabStop = false;
            gbDeviceList.Text = "Connected Devices";
            // 
            // btnRefreshDevices
            // 
            btnRefreshDevices.BackColor = Color.FromArgb(102, 77, 171);
            btnRefreshDevices.FlatStyle = FlatStyle.Flat;
            btnRefreshDevices.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshDevices.ForeColor = Color.White;
            btnRefreshDevices.Location = new Point(456, 327);
            btnRefreshDevices.Name = "btnRefreshDevices";
            btnRefreshDevices.Size = new Size(120, 35);
            btnRefreshDevices.TabIndex = 11;
            btnRefreshDevices.Text = "🔄 Refresh";
            btnRefreshDevices.UseVisualStyleBackColor = false;
            btnRefreshDevices.Click += btnRefreshDevices_Click;
            // 
            // dgvDevices
            // 
            dgvDevices.AllowUserToAddRows = false;
            dgvDevices.AllowUserToDeleteRows = false;
            dgvDevices.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDevices.BackgroundColor = Color.White;
            dgvDevices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDevices.Columns.AddRange(new DataGridViewColumn[] { colDeviceId, colDisplayName, colStatus, colLastHeartbeat, colCreatedAt });
            dgvDevices.Location = new Point(17, 37);
            dgvDevices.Name = "dgvDevices";
            dgvDevices.ReadOnly = true;
            dgvDevices.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvDevices.Size = new Size(1020, 273);
            dgvDevices.TabIndex = 0;
            dgvDevices.SelectionChanged += dgvDevices_SelectionChanged;
            // 
            // colDeviceId
            // 
            colDeviceId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDeviceId.DataPropertyName = "DeviceId";
            colDeviceId.HeaderText = "Device ID";
            colDeviceId.MinimumWidth = 200;
            colDeviceId.Name = "colDeviceId";
            colDeviceId.ReadOnly = true;
            colDeviceId.Width = 200;
            // 
            // colDisplayName
            // 
            colDisplayName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colDisplayName.DataPropertyName = "DisplayName";
            colDisplayName.HeaderText = "Display Name";
            colDisplayName.MinimumWidth = 250;
            colDisplayName.Name = "colDisplayName";
            colDisplayName.ReadOnly = true;
            // 
            // colStatus
            // 
            colStatus.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colStatus.DataPropertyName = "Status";
            colStatus.HeaderText = "Status";
            colStatus.MinimumWidth = 100;
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            // 
            // colLastHeartbeat
            // 
            colLastHeartbeat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colLastHeartbeat.DataPropertyName = "LastHeartbeat";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            colLastHeartbeat.DefaultCellStyle = dataGridViewCellStyle1;
            colLastHeartbeat.HeaderText = "Last Heartbeat";
            colLastHeartbeat.MinimumWidth = 180;
            colLastHeartbeat.Name = "colLastHeartbeat";
            colLastHeartbeat.ReadOnly = true;
            colLastHeartbeat.Width = 180;
            // 
            // colCreatedAt
            // 
            colCreatedAt.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colCreatedAt.DataPropertyName = "CreatedAt";
            dataGridViewCellStyle2.Format = "G";
            dataGridViewCellStyle2.NullValue = null;
            colCreatedAt.DefaultCellStyle = dataGridViewCellStyle2;
            colCreatedAt.HeaderText = "Created";
            colCreatedAt.MinimumWidth = 180;
            colCreatedAt.Name = "colCreatedAt";
            colCreatedAt.ReadOnly = true;
            colCreatedAt.Width = 180;
            // 
            // gbDeviceDetails
            // 
            gbDeviceDetails.BackColor = Color.White;
            gbDeviceDetails.Controls.Add(lblStatusValue);
            gbDeviceDetails.Controls.Add(lblStatusLabel);
            gbDeviceDetails.Controls.Add(lblDisplayNameValue);
            gbDeviceDetails.Controls.Add(lblDisplayNameLabel);
            gbDeviceDetails.Controls.Add(lblDeviceIdValue);
            gbDeviceDetails.Controls.Add(lblDeviceIdLabel);
            gbDeviceDetails.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbDeviceDetails.ForeColor = Color.FromArgb(73, 46, 135);
            gbDeviceDetails.Location = new Point(58, 567);
            gbDeviceDetails.Name = "gbDeviceDetails";
            gbDeviceDetails.Size = new Size(520, 140);
            gbDeviceDetails.TabIndex = 6;
            gbDeviceDetails.TabStop = false;
            gbDeviceDetails.Text = "Device Details";
            // 
            // lblStatusValue
            // 
            lblStatusValue.AutoSize = true;
            lblStatusValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusValue.ForeColor = Color.FromArgb(40, 167, 69);
            lblStatusValue.Location = new Point(65, 98);
            lblStatusValue.Name = "lblStatusValue";
            lblStatusValue.Size = new Size(18, 17);
            lblStatusValue.TabIndex = 10;
            lblStatusValue.Text = "--";
            // 
            // lblStatusLabel
            // 
            lblStatusLabel.AutoSize = true;
            lblStatusLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatusLabel.ForeColor = Color.FromArgb(108, 117, 125);
            lblStatusLabel.Location = new Point(9, 98);
            lblStatusLabel.Name = "lblStatusLabel";
            lblStatusLabel.Size = new Size(50, 17);
            lblStatusLabel.TabIndex = 9;
            lblStatusLabel.Text = "Status:";
            // 
            // lblDisplayNameValue
            // 
            lblDisplayNameValue.AutoSize = true;
            lblDisplayNameValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDisplayNameValue.ForeColor = Color.FromArgb(108, 117, 125);
            lblDisplayNameValue.Location = new Point(63, 65);
            lblDisplayNameValue.Name = "lblDisplayNameValue";
            lblDisplayNameValue.Size = new Size(18, 17);
            lblDisplayNameValue.TabIndex = 8;
            lblDisplayNameValue.Text = "--";
            // 
            // lblDisplayNameLabel
            // 
            lblDisplayNameLabel.AutoSize = true;
            lblDisplayNameLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDisplayNameLabel.ForeColor = Color.FromArgb(108, 117, 125);
            lblDisplayNameLabel.Location = new Point(9, 65);
            lblDisplayNameLabel.Name = "lblDisplayNameLabel";
            lblDisplayNameLabel.Size = new Size(48, 17);
            lblDisplayNameLabel.TabIndex = 7;
            lblDisplayNameLabel.Text = "Name:";
            // 
            // lblDeviceIdValue
            // 
            lblDeviceIdValue.AutoSize = true;
            lblDeviceIdValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDeviceIdValue.ForeColor = Color.FromArgb(108, 117, 125);
            lblDeviceIdValue.Location = new Point(86, 34);
            lblDeviceIdValue.Name = "lblDeviceIdValue";
            lblDeviceIdValue.Size = new Size(18, 17);
            lblDeviceIdValue.TabIndex = 6;
            lblDeviceIdValue.Text = "--";
            // 
            // lblDeviceIdLabel
            // 
            lblDeviceIdLabel.AutoSize = true;
            lblDeviceIdLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDeviceIdLabel.ForeColor = Color.FromArgb(108, 117, 125);
            lblDeviceIdLabel.Location = new Point(9, 34);
            lblDeviceIdLabel.Name = "lblDeviceIdLabel";
            lblDeviceIdLabel.Size = new Size(71, 17);
            lblDeviceIdLabel.TabIndex = 5;
            lblDeviceIdLabel.Text = "Device ID:";
            lblDeviceIdLabel.Click += lblDeviceIdLabel_Click;
            // 
            // gbActions
            // 
            gbActions.BackColor = Color.White;
            gbActions.Controls.Add(btnRemoveDevice);
            gbActions.Controls.Add(btnAddDevice);
            gbActions.Controls.Add(btnViewDeviceLogs);
            gbActions.Controls.Add(btnTestConnection);
            gbActions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbActions.ForeColor = Color.FromArgb(73, 46, 135);
            gbActions.Location = new Point(607, 567);
            gbActions.Name = "gbActions";
            gbActions.Size = new Size(520, 140);
            gbActions.TabIndex = 7;
            gbActions.TabStop = false;
            gbActions.Text = "Actions";
            // 
            // btnRemoveDevice
            // 
            btnRemoveDevice.BackColor = Color.FromArgb(220, 53, 69);
            btnRemoveDevice.Enabled = false;
            btnRemoveDevice.FlatStyle = FlatStyle.Flat;
            btnRemoveDevice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRemoveDevice.ForeColor = Color.White;
            btnRemoveDevice.Location = new Point(269, 89);
            btnRemoveDevice.Name = "btnRemoveDevice";
            btnRemoveDevice.Size = new Size(193, 35);
            btnRemoveDevice.TabIndex = 15;
            btnRemoveDevice.Text = "❌ Remove Device";
            btnRemoveDevice.UseVisualStyleBackColor = false;
            btnRemoveDevice.Click += btnRemoveDevice_Click;
            // 
            // btnAddDevice
            // 
            btnAddDevice.BackColor = Color.FromArgb(40, 167, 69);
            btnAddDevice.FlatStyle = FlatStyle.Flat;
            btnAddDevice.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDevice.ForeColor = Color.White;
            btnAddDevice.Location = new Point(30, 89);
            btnAddDevice.Name = "btnAddDevice";
            btnAddDevice.Size = new Size(193, 35);
            btnAddDevice.TabIndex = 14;
            btnAddDevice.Text = "➕ Add New Device";
            btnAddDevice.UseVisualStyleBackColor = false;
            btnAddDevice.Click += btnAddDevice_Click;
            // 
            // btnViewDeviceLogs
            // 
            btnViewDeviceLogs.BackColor = Color.FromArgb(253, 185, 19);
            btnViewDeviceLogs.Enabled = false;
            btnViewDeviceLogs.FlatStyle = FlatStyle.Flat;
            btnViewDeviceLogs.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewDeviceLogs.ForeColor = Color.FromArgb(73, 46, 135);
            btnViewDeviceLogs.Location = new Point(269, 34);
            btnViewDeviceLogs.Name = "btnViewDeviceLogs";
            btnViewDeviceLogs.Size = new Size(193, 35);
            btnViewDeviceLogs.TabIndex = 13;
            btnViewDeviceLogs.Text = "📝 View Logs";
            btnViewDeviceLogs.UseVisualStyleBackColor = false;
            btnViewDeviceLogs.Click += btnViewDeviceLogs_Click;
            // 
            // btnTestConnection
            // 
            btnTestConnection.BackColor = Color.FromArgb(102, 77, 171);
            btnTestConnection.Enabled = false;
            btnTestConnection.FlatStyle = FlatStyle.Flat;
            btnTestConnection.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTestConnection.ForeColor = Color.White;
            btnTestConnection.Location = new Point(30, 34);
            btnTestConnection.Name = "btnTestConnection";
            btnTestConnection.Size = new Size(193, 35);
            btnTestConnection.TabIndex = 12;
            btnTestConnection.Text = "🔌 Test Connection";
            btnTestConnection.UseVisualStyleBackColor = false;
            btnTestConnection.Click += btnTestConnection_Click;
            // 
            // DevicesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1196, 760);
            Controls.Add(gbActions);
            Controls.Add(gbDeviceDetails);
            Controls.Add(gbDeviceList);
            Controls.Add(lblDescription);
            Controls.Add(lblPageTitle);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "DevicesForm";
            Text = "Devices - Smart Automation Control System";
            Load += DevicesForm_Load;
            gbDeviceList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDevices).EndInit();
            gbDeviceDetails.ResumeLayout(false);
            gbDeviceDetails.PerformLayout();
            gbActions.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private Label lblDescription;
        private GroupBox gbDeviceList;
        private DataGridView dgvDevices;
        private DataGridViewTextBoxColumn colDeviceId;
        private DataGridViewTextBoxColumn colDisplayName;
        private DataGridViewTextBoxColumn colStatus;
        private DataGridViewTextBoxColumn colLastHeartbeat;
        private DataGridViewTextBoxColumn colCreatedAt;
        private Button btnRefreshDevices;
        private GroupBox gbDeviceDetails;
        private Label lblDisplayNameLabel;
        private Label lblDeviceIdValue;
        private Label lblDeviceIdLabel;
        private Label lblStatusValue;
        private Label lblStatusLabel;
        private Label lblDisplayNameValue;
        private GroupBox gbActions;
        private Button btnViewDeviceLogs;
        private Button btnTestConnection;
        private Button btnRemoveDevice;
        private Button btnAddDevice;
    }
}