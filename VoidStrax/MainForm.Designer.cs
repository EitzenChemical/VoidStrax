using System;
using System.Drawing;
using VoidStrax.Properties;

namespace InsuranceApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ComboBox cmbServices;
        private System.Windows.Forms.Button btnSubmitRequest;
        private System.Windows.Forms.ListBox lstRequests;
        private System.Windows.Forms.Button btnCancelRequest;

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
            this.cmbServices = new System.Windows.Forms.ComboBox();
            this.btnSubmitRequest = new System.Windows.Forms.Button();
            this.lstRequests = new System.Windows.Forms.ListBox();
            this.btnCancelRequest = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // 
            // cmbServices
            // 
            this.cmbServices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServices.FormattingEnabled = true;
            this.cmbServices.Location = new System.Drawing.Point(12, 12);
            this.cmbServices.Name = "cmbServices";
            this.cmbServices.Size = new System.Drawing.Size(260, 21);
            this.cmbServices.TabIndex = 0;

            // 
            // btnSubmitRequest
            // 
            this.btnSubmitRequest.Location = new System.Drawing.Point(12, 39);
            this.btnSubmitRequest.Name = "btnSubmitRequest";
            this.btnSubmitRequest.Size = new System.Drawing.Size(260, 23);
            this.btnSubmitRequest.TabIndex = 1;
            this.btnSubmitRequest.Text = "Отправить заявку";
            this.btnSubmitRequest.UseVisualStyleBackColor = true;
            this.btnSubmitRequest.Click += new System.EventHandler(this.btnSubmitRequest_Click);

            // 
            // lstRequests
            // 
            this.lstRequests.FormattingEnabled = true;
            this.lstRequests.Location = new System.Drawing.Point(12, 68);
            this.lstRequests.Name = "lstRequests";
            this.lstRequests.Size = new System.Drawing.Size(260, 121);
            this.lstRequests.TabIndex = 2;

            // 
            // btnCancelRequest
            // 
            this.btnCancelRequest.Location = new System.Drawing.Point(12, 195);
            this.btnCancelRequest.Name = "btnCancelRequest";
            this.btnCancelRequest.Size = new System.Drawing.Size(260, 23);
            this.btnCancelRequest.TabIndex = 3;
            this.btnCancelRequest.Text = "Отменить заявку";
            this.btnCancelRequest.UseVisualStyleBackColor = true;
            this.btnCancelRequest.Click += new System.EventHandler(this.btnCancelRequest_Click);

            // 
            // ClientMainForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 230);
            this.Controls.Add(this.btnCancelRequest);
            this.Controls.Add(this.lstRequests);
            this.Controls.Add(this.btnSubmitRequest);
            this.Controls.Add(this.cmbServices);
            this.Name = "ClientMainForm";
            this.Text = "Клиентское приложение";
            this.ResumeLayout(false);
        }
    }
}
