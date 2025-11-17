using RobotControlLibrary;
using RobotControlLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RobotControlUI
{
    public partial class UsersForm : Form
    {
        private List<UserAccountModel> users;
        private UserAccountModel selectedUser;

        public UsersForm()
        {
            InitializeComponent();
        }
        private void UsersForm_Load(object sender, EventArgs e)
        {
            // Check if current user is admin
            if (!SessionManager.IsAdmin)
            {
                MessageBox.Show("Access Denied. Admin privileges required.", "Access Denied",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            // Populate role dropdowns
            PopulateRoleDropdowns();

            // Load all users
            LoadUsers();
        }

        private void PopulateRoleDropdowns()
        {
            // Populate new user role dropdown
            cbNewRole.Items.Clear();
            cbNewRole.Items.Add("Admin");
            cbNewRole.Items.Add("Operator");
            cbNewRole.Items.Add("Viewer");
            cbNewRole.SelectedIndex = 1; // Default to Operator

            // Populate change role dropdown
            cbChangeRole.Items.Clear();
            cbChangeRole.Items.Add("Admin");
            cbChangeRole.Items.Add("Operator");
            cbChangeRole.Items.Add("Viewer");
        }

        private void LoadUsers()
        {
            try
            {
                users = GlobalConfig.Connection.GetAllUsers();

                // Clear the grid
                dgvUsers.Rows.Clear();

                if (users != null && users.Count > 0)
                {
                    foreach (var user in users)
                    {
                        int rowIndex = dgvUsers.Rows.Add(
                            user.UserId,
                            user.Username,
                            user.Role,
                            user.CreatedAt.ToLocalTime().ToString("MM/dd/yyyy")
                        );

                        // Color code admin rows
                        if (user.Role == "Admin")
                        {
                            dgvUsers.Rows[rowIndex].DefaultCellStyle.BackColor =
                                Color.FromArgb(255, 240, 245); // Light purple
                        }
                    }
                }

                lblSelectedUserValue.Text = "None selected";
                ClearUserSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                // Get the selected user ID from the first cell
                int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells[0].Value);
                selectedUser = users.FirstOrDefault(u => u.UserId == userId);

                if (selectedUser != null)
                {
                    lblSelectedUserValue.Text = $"{selectedUser.Username} ({selectedUser.Role})";

                    // Set the change role dropdown to current role
                    cbChangeRole.SelectedItem = selectedUser.Role;

                    // Enable action buttons
                    cbChangeRole.Enabled = true;
                    btnUpdateRole.Enabled = true;
                    btnResetPassword.Enabled = true;
                    btnDeleteUser.Enabled = true;

                    // Prevent deleting yourself
                    if (selectedUser.UserId == SessionManager.CurrentUserId)
                    {
                        btnDeleteUser.Enabled = false;
                    }
                }
            }
            else
            {
                ClearUserSelection();
            }
        }

        private void ClearUserSelection()
        {
            selectedUser = null;
            lblSelectedUserValue.Text = "None selected";
            cbChangeRole.SelectedIndex = -1;
            cbChangeRole.Enabled = false;
            btnUpdateRole.Enabled = false;
            btnResetPassword.Enabled = false;
            btnDeleteUser.Enabled = false;
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtNewUsername.Text))
            {
                MessageBox.Show("Please enter a username.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewUsername.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNewPassword.Text))
            {
                MessageBox.Show("Please enter a password.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (txtNewPassword.Text.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNewPassword.Focus();
                return;
            }

            if (cbNewRole.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a role.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Check if username already exists
                if (users.Any(u => u.Username.Equals(txtNewUsername.Text.Trim(),
                    StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Username already exists. Please choose a different username.",
                        "Duplicate Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create the user
                UserAccountModel newUser = GlobalConfig.Connection.CreateUser(
                    txtNewUsername.Text.Trim(),
                    txtNewPassword.Text,
                    cbNewRole.SelectedItem.ToString()
                );

                if (newUser != null)
                {
                    MessageBox.Show($"User '{newUser.Username}' created successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear form
                    txtNewUsername.Clear();
                    txtNewPassword.Clear();
                    cbNewRole.SelectedIndex = 1; // Reset to Operator

                    // Reload users
                    LoadUsers();

                    // Log the action
                    GlobalConfig.Connection.CreateLog(
                        null,
                        "Info",
                        $"User '{newUser.Username}' created by {SessionManager.CurrentUsername}"
                    );
                }
                else
                {
                    MessageBox.Show("Failed to create user.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateRole_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbChangeRole.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a role.", "No Role Selected",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newRole = cbChangeRole.SelectedItem.ToString();

            // Check if role is actually changing
            if (newRole == selectedUser.Role)
            {
                MessageBox.Show("User already has this role.", "No Change",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm the change
            DialogResult result = MessageBox.Show(
                $"Change role for '{selectedUser.Username}' from '{selectedUser.Role}' to '{newRole}'?",
                "Confirm Role Change",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = GlobalConfig.Connection.UpdateUserRole(selectedUser.UserId, newRole);

                    if (success)
                    {
                        MessageBox.Show($"Role updated successfully to '{newRole}'.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Log the action
                        GlobalConfig.Connection.CreateLog(
                            null,
                            "Info",
                            $"User '{selectedUser.Username}' role changed from '{selectedUser.Role}' to '{newRole}' by {SessionManager.CurrentUsername}"
                        );

                        // Reload users
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update role.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating role: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prompt for new password
            string newPassword = PromptForPassword($"Reset password for '{selectedUser.Username}'");

            if (!string.IsNullOrEmpty(newPassword))
            {
                if (newPassword.Length < 6)
                {
                    MessageBox.Show("Password must be at least 6 characters.", "Invalid Password",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    bool success = GlobalConfig.Connection.ResetUserPassword(
                        selectedUser.UserId,
                        newPassword
                    );

                    if (success)
                    {
                        MessageBox.Show(
                            $"Password reset successfully for '{selectedUser.Username}'.\n\nNew password: {newPassword}",
                            "Success",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);

                        // Log the action
                        GlobalConfig.Connection.CreateLog(
                            null,
                            "Warn",
                            $"Password reset for user '{selectedUser.Username}' by {SessionManager.CurrentUsername}"
                        );
                    }
                    else
                    {
                        MessageBox.Show("Failed to reset password.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error resetting password: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("Please select a user first.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prevent deleting yourself
            if (selectedUser.UserId == SessionManager.CurrentUserId)
            {
                MessageBox.Show("You cannot delete your own account.", "Cannot Delete Self",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion
            DialogResult result = MessageBox.Show(
                $"Are you sure you want to delete user '{selectedUser.Username}'?\n\nThis action cannot be undone.",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = GlobalConfig.Connection.DeleteUser(selectedUser.UserId);

                    if (success)
                    {
                        MessageBox.Show($"User '{selectedUser.Username}' deleted successfully.", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Log the action
                        GlobalConfig.Connection.CreateLog(
                            null,
                            "Warn",
                            $"User '{selectedUser.Username}' deleted by {SessionManager.CurrentUsername}"
                        );

                        // Reload users
                        LoadUsers();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete user.", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefreshUsers_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private string PromptForPassword(string title)
        {
            // Create a simple input dialog for password
            Form prompt = new Form()
            {
                Width = 400,
                Height = 180,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = title,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label textLabel = new Label()
            {
                Left = 20,
                Top = 20,
                Text = "Enter new password:",
                AutoSize = true
            };

            TextBox textBox = new TextBox()
            {
                Left = 20,
                Top = 50,
                Width = 340,
                UseSystemPasswordChar = true
            };

            Button confirmation = new Button()
            {
                Text = "OK",
                Left = 220,
                Width = 70,
                Top = 90,
                DialogResult = DialogResult.OK,
                BackColor = Color.FromArgb(73, 46, 135),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            Button cancel = new Button()
            {
                Text = "Cancel",
                Left = 300,
                Width = 70,
                Top = 90,
                DialogResult = DialogResult.Cancel,
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            confirmation.Click += (sender, e) => { prompt.Close(); };
            cancel.Click += (sender, e) => { prompt.Close(); };

            prompt.Controls.Add(textLabel);
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(cancel);
            prompt.AcceptButton = confirmation;
            prompt.CancelButton = cancel;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : string.Empty;
        }
    }
}
