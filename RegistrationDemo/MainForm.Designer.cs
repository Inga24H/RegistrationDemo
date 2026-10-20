namespace RegistrationDemo
{
    partial class MainForm
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
            btnLogout = new Button();
            dgvContacts = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvContacts).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(523, 492);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(94, 63);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // dgvContacts
            // 
            dgvContacts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvContacts.Location = new Point(12, 12);
            dgvContacts.Name = "dgvContacts";
            dgvContacts.RowHeadersWidth = 51;
            dgvContacts.Size = new Size(435, 234);
            dgvContacts.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 299);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 2;
            label1.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 332);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 3;
            label2.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 365);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(147, 296);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(251, 27);
            txtFullName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(147, 329);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(251, 27);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(147, 362);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(251, 27);
            txtEmail.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(33, 425);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(142, 29);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add Contact";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(206, 425);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(130, 29);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete Contact";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(725, 683);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvContacts);
            Controls.Add(btnLogout);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)dgvContacts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private DataGridView dgvContacts;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Button btnAdd;
        private Button btnDelete;
    }
}