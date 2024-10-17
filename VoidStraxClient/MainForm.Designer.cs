using System;
using System.Drawing;

namespace InsuranceApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private RoundedComboBox cmbServices;
        private RoundedButton btnSubmitRequest;
        private System.Windows.Forms.ListBox lstRequests;
        private RoundedButton btnCancelRequest;

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
            cmbServices = new RoundedComboBox();
            btnSubmitRequest = new RoundedButton();
            lstRequests = new ListBox();
            btnCancelRequest = new RoundedButton();
            SuspendLayout();
            // 
            // cmbServices
            // 
            cmbServices.BackColor = Color.DarkTurquoise;
            cmbServices.BackColorCustom = Color.White;
            cmbServices.BorderColor = Color.Gray;
            cmbServices.BorderThickness = 2;
            cmbServices.CornerRadius = 15;
            cmbServices.DrawMode = DrawMode.OwnerDrawFixed;
            cmbServices.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbServices.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            cmbServices.FormattingEnabled = true;
            cmbServices.Location = new Point(257, 22);
            cmbServices.Name = "cmbServices";
            cmbServices.Size = new Size(508, 34);
            cmbServices.TabIndex = 0;
            // 
            // btnSubmitRequest
            // 
            btnSubmitRequest.BackColor = Color.PaleTurquoise;
            btnSubmitRequest.CornerRadius = 30;
            btnSubmitRequest.FlatStyle = FlatStyle.Flat;
            btnSubmitRequest.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnSubmitRequest.Location = new Point(257, 62);
            btnSubmitRequest.Name = "btnSubmitRequest";
            btnSubmitRequest.Size = new Size(508, 67);
            btnSubmitRequest.TabIndex = 1;
            btnSubmitRequest.Text = "Отправить заявку";
            btnSubmitRequest.UseVisualStyleBackColor = true;
            btnSubmitRequest.Click += btnSubmitRequest_Click;
            // 
            // lstRequests
            // 
            lstRequests.BackColor = Color.PaleTurquoise;
            lstRequests.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            lstRequests.FormattingEnabled = true;
            lstRequests.ItemHeight = 25;
            lstRequests.Location = new Point(42, 149);
            lstRequests.Name = "lstRequests";
            lstRequests.Size = new Size(977, 204);
            lstRequests.TabIndex = 2;
            // 
            // btnCancelRequest
            // 
            btnCancelRequest.BackColor = Color.PaleTurquoise;
            btnCancelRequest.CornerRadius = 30;
            btnCancelRequest.FlatStyle = FlatStyle.Flat;
            btnCancelRequest.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btnCancelRequest.Location = new Point(257, 381);
            btnCancelRequest.Name = "btnCancelRequest";
            btnCancelRequest.Size = new Size(508, 62);
            btnCancelRequest.TabIndex = 3;
            btnCancelRequest.Text = "Отменить заявку";
            btnCancelRequest.UseVisualStyleBackColor = true;
            btnCancelRequest.Click += btnCancelRequest_Click;
            // 
            // MainForm
            // 
            BackColor = Color.DarkTurquoise;
            ClientSize = new Size(1066, 471);
            Controls.Add(btnCancelRequest);
            Controls.Add(lstRequests);
            Controls.Add(btnSubmitRequest);
            Controls.Add(cmbServices);
            Name = "MainForm";
            Text = "VoidStrax: Client";
            ResumeLayout(false);
        }
    }
}
