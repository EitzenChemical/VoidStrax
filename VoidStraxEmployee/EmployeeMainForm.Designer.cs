using System.Data.SqlClient;

namespace VoidStraxEmployee
{
    partial class EmployeeMainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox lstServices;
        private RoundedTextBox txtServiceName;
        private RoundedTextBox txtServiceDescription;
        private RoundedButton btnAddService;
        private RoundedButton btnDeleteService;
        private System.Windows.Forms.ListBox lstClientRequests;
        private RoundedComboBox cmbStatus;
        private RoundedButton btnChangeStatus;

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
            lstServices = new ListBox();
            txtServiceName = new RoundedTextBox();
            txtServiceDescription = new RoundedTextBox();
            btnAddService = new RoundedButton();
            btnDeleteService = new RoundedButton();
            lstClientRequests = new ListBox();
            cmbStatus = new RoundedComboBox();
            btnChangeStatus = new RoundedButton();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // lstServices
            // 
            lstServices.BackColor = Color.PaleTurquoise;
            lstServices.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lstServices.FormattingEnabled = true;
            lstServices.ItemHeight = 25;
            lstServices.Location = new Point(12, 37);
            lstServices.Name = "lstServices";
            lstServices.Size = new Size(997, 129);
            lstServices.TabIndex = 0;
            // 
            // txtServiceName
            // 
            txtServiceName.BackColor = Color.MediumTurquoise;
            txtServiceName.BorderColor = Color.Gray;
            txtServiceName.BorderThickness = 2;
            txtServiceName.CornerRadius = 15;
            txtServiceName.Location = new Point(184, 176);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Padding = new Padding(2);
            txtServiceName.Placeholder = "Название услуги";
            txtServiceName.Size = new Size(353, 48);
            txtServiceName.TabIndex = 1;
            txtServiceName.TextColor = Color.Black;
            txtServiceName.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // txtServiceDescription
            // 
            txtServiceDescription.BackColor = Color.MediumTurquoise;
            txtServiceDescription.BorderColor = Color.Gray;
            txtServiceDescription.BorderThickness = 2;
            txtServiceDescription.CornerRadius = 15;
            txtServiceDescription.Location = new Point(184, 248);
            txtServiceDescription.Name = "txtServiceDescription";
            txtServiceDescription.Padding = new Padding(2);
            txtServiceDescription.Placeholder = "Описание услуги";
            txtServiceDescription.Size = new Size(353, 94);
            txtServiceDescription.TabIndex = 2;
            txtServiceDescription.TextColor = Color.Black;
            txtServiceDescription.TextFont = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            // 
            // btnAddService
            // 
            btnAddService.BackColor = Color.PaleTurquoise;
            btnAddService.CornerRadius = 30;
            btnAddService.FlatStyle = FlatStyle.Flat;
            btnAddService.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnAddService.Location = new Point(184, 361);
            btnAddService.Name = "btnAddService";
            btnAddService.Size = new Size(353, 56);
            btnAddService.TabIndex = 3;
            btnAddService.Text = "Добавить услугу";
            btnAddService.UseVisualStyleBackColor = true;
            btnAddService.Click += btnAddService_Click;
            // 
            // btnDeleteService
            // 
            btnDeleteService.BackColor = Color.PaleTurquoise;
            btnDeleteService.CornerRadius = 30;
            btnDeleteService.FlatStyle = FlatStyle.Flat;
            btnDeleteService.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnDeleteService.Location = new Point(184, 440);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(353, 50);
            btnDeleteService.TabIndex = 4;
            btnDeleteService.Text = "Удалить услугу";
            btnDeleteService.UseVisualStyleBackColor = true;
            btnDeleteService.Click += btnDeleteService_Click;
            // 
            // lstClientRequests
            // 
            lstClientRequests.BackColor = Color.PaleTurquoise;
            lstClientRequests.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lstClientRequests.FormattingEnabled = true;
            lstClientRequests.ItemHeight = 25;
            lstClientRequests.Location = new Point(13, 507);
            lstClientRequests.Name = "lstClientRequests";
            lstClientRequests.Size = new Size(996, 129);
            lstClientRequests.TabIndex = 5;
            // 
            // cmbStatus
            // 
            cmbStatus.BackColor = Color.DarkTurquoise;
            cmbStatus.BackColorCustom = Color.White;
            cmbStatus.BorderColor = Color.Gray;
            cmbStatus.BorderThickness = 2;
            cmbStatus.CornerRadius = 15;
            cmbStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "На рассмотрении", "Принято", "Отклонено", "Завершено" });
            cmbStatus.Location = new Point(142, 642);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(260, 34);
            cmbStatus.TabIndex = 6;
            // 
            // btnChangeStatus
            // 
            btnChangeStatus.BackColor = Color.PaleTurquoise;
            btnChangeStatus.CornerRadius = 30;
            btnChangeStatus.FlatStyle = FlatStyle.Flat;
            btnChangeStatus.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnChangeStatus.Location = new Point(101, 682);
            btnChangeStatus.Name = "btnChangeStatus";
            btnChangeStatus.Size = new Size(353, 52);
            btnChangeStatus.TabIndex = 7;
            btnChangeStatus.Text = "Изменить статус заявки";
            btnChangeStatus.UseVisualStyleBackColor = true;
            btnChangeStatus.Click += btnChangeStatus_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(11, 189);
            label1.Name = "label1";
            label1.Size = new Size(163, 25);
            label1.TabIndex = 8;
            label1.Text = "Название услуги";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(11, 235);
            label2.Name = "label2";
            label2.Size = new Size(164, 25);
            label2.TabIndex = 9;
            label2.Text = "Описание услуги";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label3.Location = new Point(13, 9);
            label3.Name = "label3";
            label3.Size = new Size(134, 25);
            label3.TabIndex = 10;
            label3.Text = "Наши услуги:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            label4.Location = new Point(13, 479);
            label4.Name = "label4";
            label4.Size = new Size(79, 25);
            label4.TabIndex = 11;
            label4.Text = "Заявки:";
            // 
            // EmployeeMainForm
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(1033, 746);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnChangeStatus);
            Controls.Add(cmbStatus);
            Controls.Add(lstClientRequests);
            Controls.Add(btnDeleteService);
            Controls.Add(btnAddService);
            Controls.Add(txtServiceDescription);
            Controls.Add(txtServiceName);
            Controls.Add(lstServices);
            Name = "EmployeeMainForm";
            Text = "VoidStrax: Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}