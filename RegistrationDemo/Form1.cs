using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Drawing;
using System.Windows.Forms;

namespace RegistrationDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var fullName = txtFullName.Text.Trim();
            var email = txtEmail.Text.Trim();
            var password = txtPassword.Text;

            // Validate
            if (string.IsNullOrEmpty(fullName))
            {
                MessageBox.Show("Please enter your full name.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFullName.Focus();
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }

            var confirmPassword = txtConfirmPassword.Text;

            if (string.IsNullOrEmpty(password) || password.Length < 6)
            {
                MessageBox.Show("Password must be at least 6 characters long.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
            {
                MessageBox.Show("Passwords do not match.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtConfirmPassword.Focus();
                return;
            }

            try
            {
                // Read connection string from App.config for database Phonebook_225045052.
                var connString = System.Configuration.ConfigurationManager.ConnectionStrings["RegistrationDemoDB"].ConnectionString;
                var hashed = ComputeSha256Hash(password);

                using (var conn = new Microsoft.Data.SqlClient.SqlConnection(connString))
                {
                    conn.Open();

                    var query = @"INSERT INTO dbo.Users (FullName, Email, PasswordHash, CreatedAt)
                                  VALUES (@FullName, @Email, @PasswordHash, GETDATE())";

                    using (var cmd = new Microsoft.Data.SqlClient.SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", fullName);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@PasswordHash", hashed);

                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Registration saved to database.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Clear inputs
                txtFullName.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtPassword.Text = string.Empty;
                txtFullName.Focus();
            }
            catch (Microsoft.Data.SqlClient.SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                // Unique constraint violation (duplicate key)
                MessageBox.Show("This email is already registered.", "Duplicate Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save registration: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Simple regex for basic validation
                var pattern = @"^[^\s@]+@[^\s@]+\.[^\s@]+$";
                return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
            }
            catch
            {
                return false;
            }
        }

        public static string ComputeSha256Hash(string rawData)
        {
            using var sha256 = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(rawData);
            var hash = sha256.ComputeHash(bytes);
            var sb = new StringBuilder();
            foreach (var b in hash)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        private static string EscapeCsv(string value)
        {
            if (value == null)
                return string.Empty;
            if (value.Contains(',') || value.Contains('"') || value.Contains('\n') || value.Contains('\r'))
            {
                return '"' + value.Replace("\"", "\"\"") + '"';
            }
            return value;
        }

        private void txtConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            // Provide immediate visual feedback when user types confirm password
            try
            {
                var confirm = txtConfirmPassword.Text;
                var original = txtPassword.Text;

                if (string.IsNullOrEmpty(confirm))
                {
                    txtConfirmPassword.BackColor = SystemColors.Window;
                    return;
                }

                if (string.Equals(confirm, original, StringComparison.Ordinal))
                    txtConfirmPassword.BackColor = Color.LightGreen;
                else
                    txtConfirmPassword.BackColor = Color.LightPink;
            }
            catch
            {
                // ignore UI errors
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
