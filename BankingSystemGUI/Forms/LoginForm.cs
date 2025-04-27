// Forms/LoginForm.cs
using System;
using System.Windows.Forms;
using BankingSystemGUI.Services;

namespace BankingSystemGUI.Forms
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;

        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bankAccount = _authService.Login(username, password);

            if (bankAccount != null)
            {
                // Login successful
                this.Hide();
                AccountDetailsForm accountDetailsForm = new AccountDetailsForm(bankAccount);
                accountDetailsForm.ShowDialog();
                this.Close();
            }
            else
            {
                // Login failed
                MessageBox.Show("Invalid username or password. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }
    }
}