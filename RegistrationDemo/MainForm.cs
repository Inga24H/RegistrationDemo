using System;
using System.Data;
using System.Windows.Forms;

namespace RegistrationDemo
{
    public partial class MainForm : Form
    {
        // 1. Declare the DataTable for the contacts grid
        private DataTable contactTable = new DataTable();

        public MainForm()
        {
            InitializeComponent();
            this.Text = "Secure Phonebook - 225045052";

            dgvContacts.AllowUserToAddRows = false;

            btnDelete.Click += btnDelete_Click;

            // 2. Initialize table columns and bind to grid right away
            contactTable.Columns.Add("Full Name");
            contactTable.Columns.Add("Phone Number");
            contactTable.Columns.Add("Email");
            dgvContacts.DataSource = contactTable;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (Session.UserId == 0)
            {
                MessageBox.Show("Unauthorized access. Please log in first.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                RedirectToLogin();
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text) || string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Please enter a name and phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 3. Add row to the DataTable
            contactTable.Rows.Add(txtFullName.Text.Trim(), txtPhone.Text.Trim(), txtEmail.Text.Trim());

            // Clear inputs for the next entry
            txtFullName.Clear();
            txtPhone.Clear();
            txtEmail.Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvContacts.CurrentRow != null && !dgvContacts.CurrentRow.IsNewRow)
            {
                int rowIndex = dgvContacts.CurrentRow.Index;
                if (rowIndex >= 0 && rowIndex < contactTable.Rows.Count)
                {
                    // Remove the row directly from the DataTable
                    contactTable.Rows.RemoveAt(rowIndex);
                    MessageBox.Show("Contact deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a row in the grid to delete.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Session.UserId = 0;
                Session.FullName = null;
                RedirectToLogin();
            }
        }

        private void RedirectToLogin()
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Close();
        }
    }
}