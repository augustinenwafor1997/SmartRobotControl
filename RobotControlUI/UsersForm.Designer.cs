namespace RobotControlUI
{
    partial class UsersForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblPageTitle = new Label();
            gbUserList = new GroupBox();
            btnRefreshUsers = new Button();
            dgvUsers = new DataGridView();
            colUserId = new DataGridViewTextBoxColumn();
            colUsername = new DataGridViewTextBoxColumn();
            colRole = new DataGridViewTextBoxColumn();
            colCreatedAt = new DataGridViewTextBoxColumn();
            gbAddUser = new GroupBox();
            btnCreateUser = new Button();
            cbNewRole = new ComboBox();
            lblNewRole = new Label();
            txtNewPassword = new TextBox();
            lblNewPassword = new Label();
            txtNewUsername = new TextBox();
            lblNewUsername = new Label();
            gbUserActions = new GroupBox();
            btnDeleteUser = new Button();
            btnUpdateRole = new Button();
            cbChangeRole = new ComboBox();
            lblSelectedUserValue = new Label();
            btnResetPassword = new Button();
            lblChangeRole = new Label();
            lblSelectedUserLabel = new Label();
            gbUserList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            gbAddUser.SuspendLayout();
            gbUserActions.SuspendLayout();
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
            lblPageTitle.TabIndex = 4;
            lblPageTitle.Text = "Device Management";
            // 
            // gbUserList
            // 
            gbUserList.Controls.Add(btnRefreshUsers);
            gbUserList.Controls.Add(dgvUsers);
            gbUserList.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbUserList.ForeColor = Color.FromArgb(73, 46, 135);
            gbUserList.Location = new Point(12, 100);
            gbUserList.Name = "gbUserList";
            gbUserList.Size = new Size(1060, 350);
            gbUserList.TabIndex = 5;
            gbUserList.TabStop = false;
            gbUserList.Text = "System Users";
            // 
            // btnRefreshUsers
            // 
            btnRefreshUsers.BackColor = Color.FromArgb(102, 77, 171);
            btnRefreshUsers.FlatStyle = FlatStyle.Flat;
            btnRefreshUsers.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefreshUsers.ForeColor = Color.White;
            btnRefreshUsers.Location = new Point(404, 304);
            btnRefreshUsers.Name = "btnRefreshUsers";
            btnRefreshUsers.Size = new Size(120, 35);
            btnRefreshUsers.TabIndex = 12;
            btnRefreshUsers.Text = "🔄 Refresh";
            btnRefreshUsers.UseVisualStyleBackColor = false;
            btnRefreshUsers.Click += btnRefreshUsers_Click;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Columns.AddRange(new DataGridViewColumn[] { colUserId, colUsername, colRole, colCreatedAt });
            dgvUsers.Location = new Point(18, 28);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(1020, 270);
            dgvUsers.TabIndex = 0;
            dgvUsers.SelectionChanged += dgvUsers_SelectionChanged;
            // 
            // colUserId
            // 
            colUserId.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colUserId.DataPropertyName = "UserId";
            colUserId.HeaderText = "User ID";
            colUserId.MinimumWidth = 80;
            colUserId.Name = "colUserId";
            colUserId.ReadOnly = true;
            // 
            // colUsername
            // 
            colUsername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUsername.DataPropertyName = "Username";
            colUsername.HeaderText = "Username";
            colUsername.MinimumWidth = 200;
            colUsername.Name = "colUsername";
            colUsername.ReadOnly = true;
            // 
            // colRole
            // 
            colRole.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colRole.DataPropertyName = "Role";
            colRole.HeaderText = "Role";
            colRole.MinimumWidth = 120;
            colRole.Name = "colRole";
            colRole.ReadOnly = true;
            colRole.Width = 293;
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
            colCreatedAt.Width = 292;
            // 
            // gbAddUser
            // 
            gbAddUser.BackColor = Color.White;
            gbAddUser.Controls.Add(btnCreateUser);
            gbAddUser.Controls.Add(cbNewRole);
            gbAddUser.Controls.Add(lblNewRole);
            gbAddUser.Controls.Add(txtNewPassword);
            gbAddUser.Controls.Add(lblNewPassword);
            gbAddUser.Controls.Add(txtNewUsername);
            gbAddUser.Controls.Add(lblNewUsername);
            gbAddUser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbAddUser.ForeColor = Color.FromArgb(73, 46, 135);
            gbAddUser.Location = new Point(30, 478);
            gbAddUser.Name = "gbAddUser";
            gbAddUser.Size = new Size(470, 171);
            gbAddUser.TabIndex = 6;
            gbAddUser.TabStop = false;
            gbAddUser.Text = "Add New User";
            // 
            // btnCreateUser
            // 
            btnCreateUser.BackColor = Color.FromArgb(40, 167, 69);
            btnCreateUser.FlatStyle = FlatStyle.Flat;
            btnCreateUser.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateUser.ForeColor = Color.White;
            btnCreateUser.Location = new Point(270, 72);
            btnCreateUser.Name = "btnCreateUser";
            btnCreateUser.Size = new Size(149, 35);
            btnCreateUser.TabIndex = 13;
            btnCreateUser.Text = "➕ Create User";
            btnCreateUser.UseVisualStyleBackColor = false;
            btnCreateUser.Click += btnCreateUser_Click;
            // 
            // cbNewRole
            // 
            cbNewRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbNewRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbNewRole.FormattingEnabled = true;
            cbNewRole.Items.AddRange(new object[] { "Admin", "Operator", "Viewer" });
            cbNewRole.Location = new Point(76, 122);
            cbNewRole.Name = "cbNewRole";
            cbNewRole.Size = new Size(121, 28);
            cbNewRole.TabIndex = 11;
            // 
            // lblNewRole
            // 
            lblNewRole.AutoSize = true;
            lblNewRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewRole.ForeColor = Color.FromArgb(108, 117, 125);
            lblNewRole.Location = new Point(6, 127);
            lblNewRole.Name = "lblNewRole";
            lblNewRole.Size = new Size(39, 17);
            lblNewRole.TabIndex = 10;
            lblNewRole.Text = "Role:";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewPassword.Location = new Point(85, 80);
            txtNewPassword.MaxLength = 100;
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.PasswordChar = '●';
            txtNewPassword.Size = new Size(100, 27);
            txtNewPassword.TabIndex = 9;
            txtNewPassword.UseSystemPasswordChar = true;
            // 
            // lblNewPassword
            // 
            lblNewPassword.AutoSize = true;
            lblNewPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewPassword.ForeColor = Color.FromArgb(108, 117, 125);
            lblNewPassword.Location = new Point(6, 86);
            lblNewPassword.Name = "lblNewPassword";
            lblNewPassword.Size = new Size(70, 17);
            lblNewPassword.TabIndex = 8;
            lblNewPassword.Text = "Password:";
            // 
            // txtNewUsername
            // 
            txtNewUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNewUsername.Location = new Point(85, 38);
            txtNewUsername.MaxLength = 50;
            txtNewUsername.Name = "txtNewUsername";
            txtNewUsername.Size = new Size(100, 27);
            txtNewUsername.TabIndex = 7;
            // 
            // lblNewUsername
            // 
            lblNewUsername.AutoSize = true;
            lblNewUsername.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNewUsername.ForeColor = Color.FromArgb(108, 117, 125);
            lblNewUsername.Location = new Point(6, 44);
            lblNewUsername.Name = "lblNewUsername";
            lblNewUsername.Size = new Size(73, 17);
            lblNewUsername.TabIndex = 6;
            lblNewUsername.Text = "Username:";
            // 
            // gbUserActions
            // 
            gbUserActions.BackColor = Color.White;
            gbUserActions.Controls.Add(btnDeleteUser);
            gbUserActions.Controls.Add(btnUpdateRole);
            gbUserActions.Controls.Add(cbChangeRole);
            gbUserActions.Controls.Add(lblSelectedUserValue);
            gbUserActions.Controls.Add(btnResetPassword);
            gbUserActions.Controls.Add(lblChangeRole);
            gbUserActions.Controls.Add(lblSelectedUserLabel);
            gbUserActions.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gbUserActions.ForeColor = Color.FromArgb(73, 46, 135);
            gbUserActions.Location = new Point(555, 478);
            gbUserActions.Name = "gbUserActions";
            gbUserActions.Size = new Size(470, 171);
            gbUserActions.TabIndex = 14;
            gbUserActions.TabStop = false;
            gbUserActions.Text = "User Actions";
            // 
            // btnDeleteUser
            // 
            btnDeleteUser.BackColor = Color.FromArgb(220, 53, 69);
            btnDeleteUser.Enabled = false;
            btnDeleteUser.FlatStyle = FlatStyle.Flat;
            btnDeleteUser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteUser.ForeColor = Color.White;
            btnDeleteUser.Location = new Point(271, 109);
            btnDeleteUser.Name = "btnDeleteUser";
            btnDeleteUser.Size = new Size(149, 35);
            btnDeleteUser.TabIndex = 17;
            btnDeleteUser.Text = "❌ Delete User";
            btnDeleteUser.UseVisualStyleBackColor = false;
            btnDeleteUser.Click += btnDeleteUser_Click;
            // 
            // btnUpdateRole
            // 
            btnUpdateRole.BackColor = Color.FromArgb(253, 185, 19);
            btnUpdateRole.Enabled = false;
            btnUpdateRole.FlatStyle = FlatStyle.Flat;
            btnUpdateRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUpdateRole.ForeColor = Color.FromArgb(73, 46, 135);
            btnUpdateRole.Location = new Point(28, 122);
            btnUpdateRole.Name = "btnUpdateRole";
            btnUpdateRole.Size = new Size(149, 35);
            btnUpdateRole.TabIndex = 16;
            btnUpdateRole.Text = "✏️ Update Role";
            btnUpdateRole.UseVisualStyleBackColor = false;
            btnUpdateRole.Click += btnUpdateRole_Click;
            // 
            // cbChangeRole
            // 
            cbChangeRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbChangeRole.Enabled = false;
            cbChangeRole.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbChangeRole.FormattingEnabled = true;
            cbChangeRole.Items.AddRange(new object[] { "Admin", "Operator", "Viewer" });
            cbChangeRole.Location = new Point(107, 79);
            cbChangeRole.Name = "cbChangeRole";
            cbChangeRole.Size = new Size(121, 28);
            cbChangeRole.TabIndex = 15;
            // 
            // lblSelectedUserValue
            // 
            lblSelectedUserValue.AutoSize = true;
            lblSelectedUserValue.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSelectedUserValue.ForeColor = Color.FromArgb(108, 117, 125);
            lblSelectedUserValue.Location = new Point(107, 44);
            lblSelectedUserValue.Name = "lblSelectedUserValue";
            lblSelectedUserValue.Size = new Size(92, 17);
            lblSelectedUserValue.TabIndex = 14;
            lblSelectedUserValue.Text = "None selected";
            // 
            // btnResetPassword
            // 
            btnResetPassword.BackColor = Color.FromArgb(102, 77, 171);
            btnResetPassword.Enabled = false;
            btnResetPassword.FlatStyle = FlatStyle.Flat;
            btnResetPassword.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnResetPassword.ForeColor = Color.White;
            btnResetPassword.Location = new Point(271, 44);
            btnResetPassword.Name = "btnResetPassword";
            btnResetPassword.Size = new Size(149, 35);
            btnResetPassword.TabIndex = 13;
            btnResetPassword.Text = "🔑 Reset Password";
            btnResetPassword.UseVisualStyleBackColor = false;
            btnResetPassword.Click += btnResetPassword_Click;
            // 
            // lblChangeRole
            // 
            lblChangeRole.AutoSize = true;
            lblChangeRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblChangeRole.ForeColor = Color.FromArgb(108, 117, 125);
            lblChangeRole.Location = new Point(6, 86);
            lblChangeRole.Name = "lblChangeRole";
            lblChangeRole.Size = new Size(89, 17);
            lblChangeRole.TabIndex = 8;
            lblChangeRole.Text = "Change Role:";
            // 
            // lblSelectedUserLabel
            // 
            lblSelectedUserLabel.AutoSize = true;
            lblSelectedUserLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSelectedUserLabel.ForeColor = Color.FromArgb(108, 117, 125);
            lblSelectedUserLabel.Location = new Point(6, 44);
            lblSelectedUserLabel.Name = "lblSelectedUserLabel";
            lblSelectedUserLabel.Size = new Size(95, 17);
            lblSelectedUserLabel.TabIndex = 6;
            lblSelectedUserLabel.Text = "Selected User:";
            // 
            // UsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 661);
            Controls.Add(gbUserActions);
            Controls.Add(gbAddUser);
            Controls.Add(gbUserList);
            Controls.Add(lblPageTitle);
            Name = "UsersForm";
            Text = "User Management - Smart Automation Control System";
            Load += UsersForm_Load;
            gbUserList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            gbAddUser.ResumeLayout(false);
            gbAddUser.PerformLayout();
            gbUserActions.ResumeLayout(false);
            gbUserActions.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPageTitle;
        private GroupBox gbUserList;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn colUserId;
        private DataGridViewTextBoxColumn colUsername;
        private DataGridViewTextBoxColumn colRole;
        private DataGridViewTextBoxColumn colCreatedAt;
        private Button btnRefreshUsers;
        private GroupBox gbAddUser;
        private Label lblNewUsername;
        private ComboBox cbNewRole;
        private Label lblNewRole;
        private TextBox txtNewPassword;
        private Label lblNewPassword;
        private TextBox txtNewUsername;
        private Button btnCreateUser;
        private GroupBox gbUserActions;
        private Button btnResetPassword;
        private Label lblChangeRole;
        private Label lblSelectedUserLabel;
        private Label lblSelectedUserValue;
        private Button btnUpdateRole;
        private ComboBox cbChangeRole;
        private Button btnDeleteUser;
    }
}