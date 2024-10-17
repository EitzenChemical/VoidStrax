using MetroFramework.Controls;
using System.Drawing.Drawing2D;

namespace VoidStraxAdmin
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedTextBox txtEmployeeName;
        private RoundedTextBox txtEmail;
        private RoundedTextBox txtPassword;
        private RoundedButton btnAddEmployee;
        private RoundedComboBox cmbEmployees;
        private RoundedButton btnDeleteEmployee;

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
            txtEmployeeName = new RoundedTextBox();
            txtEmail = new RoundedTextBox();
            txtPassword = new RoundedTextBox();
            btnAddEmployee = new RoundedButton();
            cmbEmployees = new RoundedComboBox();
            btnDeleteEmployee = new RoundedButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.BackColor = Color.MediumTurquoise;
            txtEmployeeName.BorderColor = Color.Gray;
            txtEmployeeName.BorderThickness = 2;
            txtEmployeeName.CornerRadius = 15;
            txtEmployeeName.Location = new Point(193, 30);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Padding = new Padding(2);
            txtEmployeeName.Placeholder = "Полное имя";
            txtEmployeeName.Size = new Size(297, 51);
            txtEmployeeName.TabIndex = 0;
            txtEmployeeName.TextColor = Color.Black;
            txtEmployeeName.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.MediumTurquoise;
            txtEmail.BorderColor = Color.Gray;
            txtEmail.BorderThickness = 2;
            txtEmail.CornerRadius = 15;
            txtEmail.Location = new Point(193, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.Padding = new Padding(2);
            txtEmail.Placeholder = "Email";
            txtEmail.Size = new Size(297, 53);
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
            txtPassword.ForeColor = SystemColors.Info;
            txtPassword.Location = new Point(193, 180);
            txtPassword.Name = "txtPassword";
            txtPassword.Padding = new Padding(2);
            txtPassword.Placeholder = "Пароль";
            txtPassword.Size = new Size(297, 53);
            txtPassword.TabIndex = 2;
            txtPassword.TextColor = Color.Black;
            txtPassword.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.BackColor = Color.PaleTurquoise;
            btnAddEmployee.CornerRadius = 30;
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnAddEmployee.Location = new Point(111, 266);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(260, 58);
            btnAddEmployee.TabIndex = 3;
            btnAddEmployee.Text = "Добавить сотрудника";
            btnAddEmployee.UseVisualStyleBackColor = false;
            btnAddEmployee.Click += btnAddEmployee_Click;
            // 
            // cmbEmployees
            // 
            cmbEmployees.BackColor = Color.DarkTurquoise;
            cmbEmployees.BackColorCustom = Color.White;
            cmbEmployees.BorderColor = Color.Gray;
            cmbEmployees.BorderThickness = 2;
            cmbEmployees.CornerRadius = 15;
            cmbEmployees.DrawMode = DrawMode.OwnerDrawFixed;
            cmbEmployees.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmployees.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            cmbEmployees.FormattingEnabled = true;
            cmbEmployees.Location = new Point(12, 366);
            cmbEmployees.Name = "cmbEmployees";
            cmbEmployees.Size = new Size(285, 34);
            cmbEmployees.TabIndex = 4;
            // 
            // btnDeleteEmployee
            // 
            btnDeleteEmployee.BackColor = Color.PaleTurquoise;
            btnDeleteEmployee.CornerRadius = 30;
            btnDeleteEmployee.FlatStyle = FlatStyle.Flat;
            btnDeleteEmployee.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnDeleteEmployee.Location = new Point(337, 347);
            btnDeleteEmployee.Name = "btnDeleteEmployee";
            btnDeleteEmployee.Size = new Size(153, 58);
            btnDeleteEmployee.TabIndex = 5;
            btnDeleteEmployee.Text = "Удалить сотрудника";
            btnDeleteEmployee.UseVisualStyleBackColor = false;
            btnDeleteEmployee.Click += btnDeleteEmployee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(52, 42);
            label1.Name = "label1";
            label1.Size = new Size(120, 25);
            label1.TabIndex = 6;
            label1.Text = "Полное имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(84, 114);
            label2.Name = "label2";
            label2.Size = new Size(60, 25);
            label2.TabIndex = 7;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(75, 190);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 8;
            label3.Text = "Пароль";
            // 
            // AdminForm
            // 
            BackColor = Color.FromArgb(0, 192, 192);
            ClientSize = new Size(521, 419);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnDeleteEmployee);
            Controls.Add(cmbEmployees);
            Controls.Add(btnAddEmployee);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtEmployeeName);
            Name = "AdminForm";
            Text = "VoidStrax: Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
    }
}
