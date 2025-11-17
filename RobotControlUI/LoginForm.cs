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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                ShowError("Please enter a username.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                ShowError("Please enter a password.");
                return;
            }

            // Try to authenticate
            try
            {
                UserAccountModel user = GlobalConfig.Connection.AuthenticateUser(
                    txtUsername.Text.Trim(),
                    txtPassword.Text
                );

                if (user != null)
                {
                    // Login successful
                    SessionManager.SetCurrentUser(user);

                    // Open Dashboard
                    DashboardForm dashboard = new DashboardForm();
                    dashboard.Show();

                    // Hide login form
                    this.Hide();
                }
                else
                {
                    // Login failed
                    ShowError("Invalid username or password.");
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                ShowError($"Login error: {ex.Message}");
            }
        }

        private void ShowError(string message)
        {
            lblStatus.Text = message;
            lblStatus.ForeColor = System.Drawing.Color.FromArgb(220, 53, 69); // Red
            lblStatus.Visible = true;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // If login form closes, exit the application
            Application.Exit();
        }
    }
}
