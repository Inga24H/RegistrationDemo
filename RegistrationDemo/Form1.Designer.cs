namespace RegistrationDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtFullName = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label3 = new Label();
            txtPassword = new TextBox();
            btnRegister = new Button();
            label4 = new Label();
            txtConfirmPassword = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(88, 103);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 0;
            label1.Text = "Full Name:";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(173, 96);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(319, 27);
            txtFullName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 166);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(173, 159);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(319, 27);
            txtEmail.TabIndex = 3;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 234);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(173, 227);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(319, 27);
            txtPassword.TabIndex = 5;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(173, 333);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(161, 63);
            btnRegister.TabIndex = 6;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 297);
            label4.Name = "label4";
            label4.Size = new Size(130, 20);
            label4.TabIndex = 7;
            label4.Text = "Confirm Password:";
            // 
            // txtConfirmPassword
            // 
            txtConfirmPassword.Location = new Point(173, 290);
            txtConfirmPassword.Name = "txtConfirmPassword";
            txtConfirmPassword.PasswordChar = '*';
            txtConfirmPassword.Size = new Size(319, 27);
            txtConfirmPassword.TabIndex = 8;
            txtConfirmPassword.TextChanged += txtConfirmPassword_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(155, 9);
            label5.Name = "label5";
            label5.Size = new Size(244, 59);
            label5.TabIndex = 9;
            label5.Text = "Register";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(537, 408);
            Controls.Add(label5);
            Controls.Add(txtConfirmPassword);
            Controls.Add(label4);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFullName;
        private Label label2;
        private TextBox txtEmail;
        private Label label3;
        private TextBox txtPassword;
        private Button btnRegister;
        private Label label4;
        private TextBox txtConfirmPassword;
        private Label label5;
    }
}
