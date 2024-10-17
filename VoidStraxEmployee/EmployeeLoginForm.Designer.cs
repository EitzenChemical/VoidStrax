namespace VoidStraxEmployee
{
    partial class EmployeeLoginForm
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedTextBox txtEmail;
        private RoundedTextBox txtPassword;
        private RoundedButton btnLogin;

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
            txtEmail = new RoundedTextBox();
            txtPassword = new RoundedTextBox();
            btnLogin = new RoundedButton();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.MediumTurquoise;
            txtEmail.BorderColor = Color.Gray;
            txtEmail.BorderThickness = 2;
            txtEmail.CornerRadius = 15;
            txtEmail.Location = new Point(172, 12);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(2);
            txtEmail.Placeholder = null;
            txtEmail.Size = new Size(412, 50);
            txtEmail.TabIndex = 0;
            txtEmail.TextColor = Color.Black;
            txtEmail.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.MediumTurquoise;
            txtPassword.BorderColor = Color.Gray;
            txtPassword.BorderThickness = 2;
            txtPassword.CornerRadius = 15;
            txtPassword.Location = new Point(172, 87);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(2);
            txtPassword.Placeholder = null;
            txtPassword.Size = new Size(412, 49);
            txtPassword.TabIndex = 1;
            txtPassword.TextColor = Color.Black;
            txtPassword.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.PaleTurquoise;
            btnLogin.CornerRadius = 30;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnLogin.Location = new Point(125, 181);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(412, 62);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Вход";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(71, 23);
            label1.Name = "label1";
            label1.Size = new Size(60, 25);
            label1.TabIndex = 3;
            label1.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(71, 99);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 4;
            label2.Text = "Пароль";
            // 
            // EmployeeLoginForm
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(653, 279);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Name = "EmployeeLoginForm";
            Text = "VoidStrax: Login";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
    }
}