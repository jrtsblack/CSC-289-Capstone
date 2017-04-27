namespace Invoice
{
    partial class OfficeWorkOrder
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
            this.lblStreetAddressPrompt = new System.Windows.Forms.Label();
            this.rtxtDescriptionOfRequest = new System.Windows.Forms.RichTextBox();
            this.lblDescriptionPrompt = new System.Windows.Forms.Label();
            this.lblWorkOrderTypePrompt = new System.Windows.Forms.Label();
            this.gbxOfficeWorkOrder = new System.Windows.Forms.GroupBox();
            this.gbxOccupancyStatus = new System.Windows.Forms.GroupBox();
            this.rbtnOccupied = new System.Windows.Forms.RadioButton();
            this.rbtnUnoccupied = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtContractingCompany = new System.Windows.Forms.TextBox();
            this.lblContractingCompanyPrompt = new System.Windows.Forms.Label();
            this.lblDueDatePrompt = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cmbxWorkOrderType = new System.Windows.Forms.ComboBox();
            this.gbxOfficeWorkOrder.SuspendLayout();
            this.gbxOccupancyStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStreetAddressPrompt
            // 
            this.lblStreetAddressPrompt.AutoSize = true;
            this.lblStreetAddressPrompt.Location = new System.Drawing.Point(13, 24);
            this.lblStreetAddressPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetAddressPrompt.Name = "lblStreetAddressPrompt";
            this.lblStreetAddressPrompt.Size = new System.Drawing.Size(106, 17);
            this.lblStreetAddressPrompt.TabIndex = 1025;
            this.lblStreetAddressPrompt.Text = "Street Address:";
            // 
            // rtxtDescriptionOfRequest
            // 
            this.rtxtDescriptionOfRequest.Location = new System.Drawing.Point(16, 251);
            this.rtxtDescriptionOfRequest.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtDescriptionOfRequest.Name = "rtxtDescriptionOfRequest";
            this.rtxtDescriptionOfRequest.Size = new System.Drawing.Size(415, 117);
            this.rtxtDescriptionOfRequest.TabIndex = 1030;
            this.rtxtDescriptionOfRequest.Text = "";
            // 
            // lblDescriptionPrompt
            // 
            this.lblDescriptionPrompt.AutoSize = true;
            this.lblDescriptionPrompt.Location = new System.Drawing.Point(12, 228);
            this.lblDescriptionPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionPrompt.Name = "lblDescriptionPrompt";
            this.lblDescriptionPrompt.Size = new System.Drawing.Size(284, 17);
            this.lblDescriptionPrompt.TabIndex = 1032;
            this.lblDescriptionPrompt.Text = "Description of Request (Including Location):";
            // 
            // lblWorkOrderTypePrompt
            // 
            this.lblWorkOrderTypePrompt.AutoSize = true;
            this.lblWorkOrderTypePrompt.Location = new System.Drawing.Point(14, 62);
            this.lblWorkOrderTypePrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkOrderTypePrompt.Name = "lblWorkOrderTypePrompt";
            this.lblWorkOrderTypePrompt.Size = new System.Drawing.Size(118, 17);
            this.lblWorkOrderTypePrompt.TabIndex = 1031;
            this.lblWorkOrderTypePrompt.Text = "Work Order Type";
            // 
            // gbxOfficeWorkOrder
            // 
            this.gbxOfficeWorkOrder.Controls.Add(this.cmbxWorkOrderType);
            this.gbxOfficeWorkOrder.Controls.Add(this.gbxOccupancyStatus);
            this.gbxOfficeWorkOrder.Controls.Add(this.dateTimePicker);
            this.gbxOfficeWorkOrder.Controls.Add(this.txtContractingCompany);
            this.gbxOfficeWorkOrder.Controls.Add(this.lblContractingCompanyPrompt);
            this.gbxOfficeWorkOrder.Controls.Add(this.lblDueDatePrompt);
            this.gbxOfficeWorkOrder.Controls.Add(this.txtStreetAddress);
            this.gbxOfficeWorkOrder.Controls.Add(this.rtxtDescriptionOfRequest);
            this.gbxOfficeWorkOrder.Controls.Add(this.lblDescriptionPrompt);
            this.gbxOfficeWorkOrder.Controls.Add(this.lblStreetAddressPrompt);
            this.gbxOfficeWorkOrder.Controls.Add(this.lblWorkOrderTypePrompt);
            this.gbxOfficeWorkOrder.Location = new System.Drawing.Point(13, 13);
            this.gbxOfficeWorkOrder.Name = "gbxOfficeWorkOrder";
            this.gbxOfficeWorkOrder.Size = new System.Drawing.Size(451, 383);
            this.gbxOfficeWorkOrder.TabIndex = 1033;
            this.gbxOfficeWorkOrder.TabStop = false;
            this.gbxOfficeWorkOrder.Text = "Work Order Information:";
            // 
            // gbxOccupancyStatus
            // 
            this.gbxOccupancyStatus.Controls.Add(this.rbtnOccupied);
            this.gbxOccupancyStatus.Controls.Add(this.rbtnUnoccupied);
            this.gbxOccupancyStatus.Location = new System.Drawing.Point(17, 168);
            this.gbxOccupancyStatus.Name = "gbxOccupancyStatus";
            this.gbxOccupancyStatus.Size = new System.Drawing.Size(233, 57);
            this.gbxOccupancyStatus.TabIndex = 1037;
            this.gbxOccupancyStatus.TabStop = false;
            this.gbxOccupancyStatus.Text = "Occupancy Status:";
            // 
            // rbtnOccupied
            // 
            this.rbtnOccupied.AutoSize = true;
            this.rbtnOccupied.Location = new System.Drawing.Point(25, 21);
            this.rbtnOccupied.Name = "rbtnOccupied";
            this.rbtnOccupied.Size = new System.Drawing.Size(89, 21);
            this.rbtnOccupied.TabIndex = 1035;
            this.rbtnOccupied.Text = "Occupied";
            this.rbtnOccupied.UseVisualStyleBackColor = true;
            // 
            // rbtnUnoccupied
            // 
            this.rbtnUnoccupied.AutoSize = true;
            this.rbtnUnoccupied.Location = new System.Drawing.Point(120, 21);
            this.rbtnUnoccupied.Name = "rbtnUnoccupied";
            this.rbtnUnoccupied.Size = new System.Drawing.Size(104, 21);
            this.rbtnUnoccupied.TabIndex = 1036;
            this.rbtnUnoccupied.Text = "Unoccupied";
            this.rbtnUnoccupied.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(187, 133);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(237, 22);
            this.dateTimePicker.TabIndex = 1039;
            // 
            // txtContractingCompany
            // 
            this.txtContractingCompany.Location = new System.Drawing.Point(187, 97);
            this.txtContractingCompany.Name = "txtContractingCompany";
            this.txtContractingCompany.Size = new System.Drawing.Size(237, 22);
            this.txtContractingCompany.TabIndex = 1038;
            // 
            // lblContractingCompanyPrompt
            // 
            this.lblContractingCompanyPrompt.AutoSize = true;
            this.lblContractingCompanyPrompt.Location = new System.Drawing.Point(13, 100);
            this.lblContractingCompanyPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContractingCompanyPrompt.Name = "lblContractingCompanyPrompt";
            this.lblContractingCompanyPrompt.Size = new System.Drawing.Size(147, 17);
            this.lblContractingCompanyPrompt.TabIndex = 1035;
            this.lblContractingCompanyPrompt.Text = "Contracting Company:";
            // 
            // lblDueDatePrompt
            // 
            this.lblDueDatePrompt.AutoSize = true;
            this.lblDueDatePrompt.Location = new System.Drawing.Point(14, 138);
            this.lblDueDatePrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDueDatePrompt.Name = "lblDueDatePrompt";
            this.lblDueDatePrompt.Size = new System.Drawing.Size(72, 17);
            this.lblDueDatePrompt.TabIndex = 1036;
            this.lblDueDatePrompt.Text = "Due Date:";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(187, 21);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(237, 22);
            this.txtStreetAddress.TabIndex = 1034;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(13, 402);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(102, 44);
            this.btnSubmit.TabIndex = 1034;
            this.btnSubmit.Text = "Submit Work Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(189, 402);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 44);
            this.btnClear.TabIndex = 1035;
            this.btnClear.Text = "Clear Screen";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(362, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 44);
            this.btnCancel.TabIndex = 1036;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // cmbxWorkOrderType
            // 
            this.cmbxWorkOrderType.FormattingEnabled = true;
            this.cmbxWorkOrderType.Items.AddRange(new object[] {
            "Plumbing",
            "Carpentry",
            "Electrical",
            "HVAC",
            "Other"});
            this.cmbxWorkOrderType.Location = new System.Drawing.Point(186, 59);
            this.cmbxWorkOrderType.Margin = new System.Windows.Forms.Padding(4);
            this.cmbxWorkOrderType.Name = "cmbxWorkOrderType";
            this.cmbxWorkOrderType.Size = new System.Drawing.Size(238, 24);
            this.cmbxWorkOrderType.TabIndex = 1037;
            // 
            // OfficeWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(483, 453);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxOfficeWorkOrder);
            this.Name = "OfficeWorkOrder";
            this.Text = "Work Order";
            this.gbxOfficeWorkOrder.ResumeLayout(false);
            this.gbxOfficeWorkOrder.PerformLayout();
            this.gbxOccupancyStatus.ResumeLayout(false);
            this.gbxOccupancyStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblStreetAddressPrompt;
        private System.Windows.Forms.RichTextBox rtxtDescriptionOfRequest;
        private System.Windows.Forms.Label lblDescriptionPrompt;
        private System.Windows.Forms.Label lblWorkOrderTypePrompt;
        private System.Windows.Forms.GroupBox gbxOfficeWorkOrder;
        private System.Windows.Forms.GroupBox gbxOccupancyStatus;
        private System.Windows.Forms.RadioButton rbtnOccupied;
        private System.Windows.Forms.RadioButton rbtnUnoccupied;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox txtContractingCompany;
        private System.Windows.Forms.Label lblContractingCompanyPrompt;
        private System.Windows.Forms.Label lblDueDatePrompt;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbxWorkOrderType;
    }
}