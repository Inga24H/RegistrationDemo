namespace RegistrationDemo
{
    partial class LoginForm
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
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            btnGoToRegister = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GrayText;
            label1.Location = new Point(43, 55);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 0;
            label1.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.InactiveCaption;
            txtEmail.Location = new Point(95, 52);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(365, 27);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.WindowFrame;
            label2.Location = new Point(43, 105);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.InactiveCaption;
            txtPassword.Location = new Point(119, 105);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(341, 27);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.AppWorkspace;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = SystemColors.MenuText;
            btnLogin.Location = new Point(57, 239);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(178, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnGoToRegister
            // 
            btnGoToRegister.BackColor = SystemColors.Highlight;
            btnGoToRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnGoToRegister.Location = new Point(378, 239);
            btnGoToRegister.Name = "btnGoToRegister";
            btnGoToRegister.Size = new Size(135, 50);
            btnGoToRegister.TabIndex = 5;
            btnGoToRegister.Text = "Register";
            btnGoToRegister.UseVisualStyleBackColor = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ScrollBar;
            ClientSize = new Size(661, 450);
            Controls.Add(btnGoToRegister);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(label2);
            Controls.Add(txtEmail);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginForm";
            Load += LoginForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPassword;
        private Button btnLogin;
        private Button btnGoToRegister;
    }
}