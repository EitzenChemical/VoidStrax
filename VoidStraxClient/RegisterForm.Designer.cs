namespace VoidStrax
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedTextBox txtFullName;
        private RoundedTextBox txtEmail;
        private RoundedTextBox txtPassword;
        private RoundedButton btnRegister;

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
            txtFullName = new RoundedTextBox();
            txtEmail = new RoundedTextBox();
            txtPassword = new RoundedTextBox();
            btnRegister = new RoundedButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.BackColor = Color.MediumTurquoise;
            txtFullName.BorderColor = Color.Gray;
            txtFullName.BorderThickness = 2;
            txtFullName.CornerRadius = 15;
            txtFullName.Location = new Point(173, 12);
            txtFullName.Name = "txtFullName";
            txtFullName.Padding = new Padding(2);
            txtFullName.Placeholder = "Имя";
            txtFullName.Size = new Size(327, 48);
            txtFullName.TabIndex = 0;
            txtFullName.TextColor = Color.Black;
            txtFullName.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.MediumTurquoise;
            txtEmail.BorderColor = Color.Gray;
            txtEmail.BorderThickness = 2;
            txtEmail.CornerRadius = 15;
            txtEmail.Location = new Point(173, 79);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(2);
            txtEmail.Placeholder = "Email";
            txtEmail.Size = new Size(327, 47);
            txtEmail.TabIndex = 1;
            txtEmail.TextColor = Color.Black;
            txtEmail.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.MediumTurquoise;
            txtPassword.BorderColor = Color.Gray;
            txtPassword.BorderThickness = 2;
            txtPassword.CornerRadius = 15;
            txtPassword.Location = new Point(173, 144);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(2);
            txtPassword.Placeholder = "Пароль";
            txtPassword.Size = new Size(327, 50);
            txtPassword.TabIndex = 2;
            txtPassword.TextColor = Color.Black;
            txtPassword.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.PaleTurquoise;
            btnRegister.CornerRadius = 30;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnRegister.Location = new Point(98, 210);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(336, 46);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "VoidStrax: Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(25, 21);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 4;
            label1.Text = "Полное имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(62, 88);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(52, 144);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 6;
            label3.Text = "Пароль";
            // 
            // RegisterForm
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(512, 268);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnRegister);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Name = "RegisterForm";
            Text = "Регистрация";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
    }
}