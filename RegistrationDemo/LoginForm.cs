using System;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace RegistrationDemo
{
    public partial class LoginForm : Form
    {
        private readonly UserRepository _userRepository = new UserRepository();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both email and password.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 1. Look up the user from the database first
            var user = _userRepository.GetByEmail(email);

            // 2. Verify user exists and password matches
            if (user == null || !Form1.ComputeSha256Hash(password).Equals(user.PasswordHash, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Invalid email or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 3. Save session info
            Session.UserId = user.UserId;
            Session.FullName = user.FullName;

            // 4. Show success and open MainForm
            MessageBox.Show($"Welcome, {user.FullName}!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private bool VerifyPassword(string inputPassword, string storedHash)
        {
            // Simple check matching your registration hash function
            return Form1.ComputeSha256Hash(inputPassword) == storedHash;
        }

        private void btnGoToRegister_Click(object sender, EventArgs e)
        {
            var registerForm = new Form1();
            registerForm.Show();
            this.Hide();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}