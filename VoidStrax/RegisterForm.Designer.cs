namespace VoidStrax
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegister;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(12, 12);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(260, 20);
            this.txtFullName.TabIndex = 0;

            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(12, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 20);
            this.txtEmail.TabIndex = 1;

            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(12, 64);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(260, 20);
            this.txtPassword.TabIndex = 2;

            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(12, 90);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(260, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Регистрация";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);

            // 
            // RegisterForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 131);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFullName);
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}