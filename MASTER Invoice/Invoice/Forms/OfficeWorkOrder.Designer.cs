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
            this.components = new System.ComponentModel.Container();
            this.lblStreetAddressPrompt = new System.Windows.Forms.Label();
            this.rtxtDescriptionOfRequest = new System.Windows.Forms.RichTextBox();
            this.lblDescriptionPrompt = new System.Windows.Forms.Label();
            this.lblWorkOrderTypePrompt = new System.Windows.Forms.Label();
            this.gbxOfficeWorkOrder = new System.Windows.Forms.GroupBox();
            this.occupiedPanel = new System.Windows.Forms.Panel();
            this.newInvoiceAnimalsInHomeComboBox = new System.Windows.Forms.ComboBox();
            this.newInvoicePermissionToEnterLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoicePermissionToEnterComboBox = new System.Windows.Forms.ComboBox();
            this.newInvoiceAnimalsLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceCommunityComboBox = new System.Windows.Forms.ComboBox();
            this.newInvoiceCommunityLabelPrompt = new System.Windows.Forms.Label();
            this.cmbxContractingCompany = new System.Windows.Forms.ComboBox();
            this.contractorCompanyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet1 = new Invoice.ProjectDBDataSet();
            this.cmbxWorkOrderType = new System.Windows.Forms.ComboBox();
            this.gbxOccupancyStatus = new System.Windows.Forms.GroupBox();
            this.rbtnOccupied = new System.Windows.Forms.RadioButton();
            this.rbtnUnoccupied = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.lblContractingCompanyPrompt = new System.Windows.Forms.Label();
            this.lblDueDatePrompt = new System.Windows.Forms.Label();
            this.txtStreetAddress = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.contractorCompanyTableAdapter1 = new Invoice.ProjectDBDataSetTableAdapters.ContractorCompanyTableAdapter();
            this.adminFormButton = new System.Windows.Forms.Button();
            this.gbxOfficeWorkOrder.SuspendLayout();
            this.occupiedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractorCompanyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).BeginInit();
            this.gbxOccupancyStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStreetAddressPrompt
            // 
            this.lblStreetAddressPrompt.AutoSize = true;
            this.lblStreetAddressPrompt.Location = new System.Drawing.Point(10, 20);
            this.lblStreetAddressPrompt.Name = "lblStreetAddressPrompt";
            this.lblStreetAddressPrompt.Size = new System.Drawing.Size(79, 13);
            this.lblStreetAddressPrompt.TabIndex = 1025;
            this.lblStreetAddressPrompt.Text = "Street Address:";
            // 
            // rtxtDescriptionOfRequest
            // 
            this.rtxtDescriptionOfRequest.Location = new System.Drawing.Point(12, 245);
            this.rtxtDescriptionOfRequest.Name = "rtxtDescriptionOfRequest";
            this.rtxtDescriptionOfRequest.Size = new System.Drawing.Size(312, 96);
            this.rtxtDescriptionOfRequest.TabIndex = 1030;
            this.rtxtDescriptionOfRequest.Text = "";
            // 
            // lblDescriptionPrompt
            // 
            this.lblDescriptionPrompt.AutoSize = true;
            this.lblDescriptionPrompt.Location = new System.Drawing.Point(9, 230);
            this.lblDescriptionPrompt.Name = "lblDescriptionPrompt";
            this.lblDescriptionPrompt.Size = new System.Drawing.Size(214, 13);
            this.lblDescriptionPrompt.TabIndex = 1032;
            this.lblDescriptionPrompt.Text = "Description of Request (Including Location):";
            // 
            // lblWorkOrderTypePrompt
            // 
            this.lblWorkOrderTypePrompt.AutoSize = true;
            this.lblWorkOrderTypePrompt.Location = new System.Drawing.Point(10, 72);
            this.lblWorkOrderTypePrompt.Name = "lblWorkOrderTypePrompt";
            this.lblWorkOrderTypePrompt.Size = new System.Drawing.Size(89, 13);
            this.lblWorkOrderTypePrompt.TabIndex = 1031;
            this.lblWorkOrderTypePrompt.Text = "Work Order Type";
            // 
            // gbxOfficeWorkOrder
            // 
            this.gbxOfficeWorkOrder.Controls.Add(this.occupiedPanel);
            this.gbxOfficeWorkOrder.Controls.Add(this.newInvoiceCommunityComboBox);
            this.gbxOfficeWorkOrder.Controls.Add(this.newInvoiceCommunityLabelPrompt);
            this.gbxOfficeWorkOrder.Controls.Add(this.cmbxContractingCompany);
            this.gbxOfficeWorkOrder.Controls.Add(this.cmbxWorkOrderType);
            this.gbxOfficeWorkOrder.Controls.Add(this.gbxOccupancyStatus);
            this.gbxOfficeWorkOrder.Controls.Add(this.dateTimePicker);
            this.gbxOfficeWorkOrder.Controls.Add(this.lblContractingCompanyPrompt);
            this.gbxOfficeWorkOrder.Controls.Add(this.lblDueDatePrompt);
            this.gbxOfficeWorkOrder.Controls.Add(this.txtStreetAddress);
            this.gbxOfficeWorkOrder.Controls.Add(this.rtxtDescriptionOfRequest);
            this.gbxOfficeWorkOrder.Controls.Add(this.lblDescriptionPrompt);
            this.gbxOfficeWorkOrder.Controls.Add(this.lblStreetAddressPrompt);
            this.gbxOfficeWorkOrder.Controls.Add(this.lblWorkOrderTypePrompt);
            this.gbxOfficeWorkOrder.Location = new System.Drawing.Point(10, 11);
            this.gbxOfficeWorkOrder.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOfficeWorkOrder.Name = "gbxOfficeWorkOrder";
            this.gbxOfficeWorkOrder.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOfficeWorkOrder.Size = new System.Drawing.Size(338, 351);
            this.gbxOfficeWorkOrder.TabIndex = 1033;
            this.gbxOfficeWorkOrder.TabStop = false;
            this.gbxOfficeWorkOrder.Text = "Work Order Information:";
            // 
            // occupiedPanel
            // 
            this.occupiedPanel.Controls.Add(this.newInvoiceAnimalsInHomeComboBox);
            this.occupiedPanel.Controls.Add(this.newInvoicePermissionToEnterLabelPrompt);
            this.occupiedPanel.Controls.Add(this.newInvoicePermissionToEnterComboBox);
            this.occupiedPanel.Controls.Add(this.newInvoiceAnimalsLabelPrompt);
            this.occupiedPanel.Location = new System.Drawing.Point(13, 231);
            this.occupiedPanel.Name = "occupiedPanel";
            this.occupiedPanel.Size = new System.Drawing.Size(1, 1);
            this.occupiedPanel.TabIndex = 1106;
            // 
            // newInvoiceAnimalsInHomeComboBox
            // 
            this.newInvoiceAnimalsInHomeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newInvoiceAnimalsInHomeComboBox.FormattingEnabled = true;
            this.newInvoiceAnimalsInHomeComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.newInvoiceAnimalsInHomeComboBox.Location = new System.Drawing.Point(167, 39);
            this.newInvoiceAnimalsInHomeComboBox.Name = "newInvoiceAnimalsInHomeComboBox";
            this.newInvoiceAnimalsInHomeComboBox.Size = new System.Drawing.Size(145, 21);
            this.newInvoiceAnimalsInHomeComboBox.TabIndex = 1108;
            // 
            // newInvoicePermissionToEnterLabelPrompt
            // 
            this.newInvoicePermissionToEnterLabelPrompt.AutoSize = true;
            this.newInvoicePermissionToEnterLabelPrompt.Location = new System.Drawing.Point(6, 15);
            this.newInvoicePermissionToEnterLabelPrompt.Name = "newInvoicePermissionToEnterLabelPrompt";
            this.newInvoicePermissionToEnterLabelPrompt.Size = new System.Drawing.Size(130, 13);
            this.newInvoicePermissionToEnterLabelPrompt.TabIndex = 1109;
            this.newInvoicePermissionToEnterLabelPrompt.Text = "Permission to Enter (PTE):";
            // 
            // newInvoicePermissionToEnterComboBox
            // 
            this.newInvoicePermissionToEnterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newInvoicePermissionToEnterComboBox.FormattingEnabled = true;
            this.newInvoicePermissionToEnterComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.newInvoicePermissionToEnterComboBox.Location = new System.Drawing.Point(167, 12);
            this.newInvoicePermissionToEnterComboBox.Name = "newInvoicePermissionToEnterComboBox";
            this.newInvoicePermissionToEnterComboBox.Size = new System.Drawing.Size(145, 21);
            this.newInvoicePermissionToEnterComboBox.TabIndex = 1107;
            // 
            // newInvoiceAnimalsLabelPrompt
            // 
            this.newInvoiceAnimalsLabelPrompt.AutoSize = true;
            this.newInvoiceAnimalsLabelPrompt.Location = new System.Drawing.Point(6, 42);
            this.newInvoiceAnimalsLabelPrompt.Name = "newInvoiceAnimalsLabelPrompt";
            this.newInvoiceAnimalsLabelPrompt.Size = new System.Drawing.Size(88, 13);
            this.newInvoiceAnimalsLabelPrompt.TabIndex = 1110;
            this.newInvoiceAnimalsLabelPrompt.Text = "Animals in Home:";
            // 
            // newInvoiceCommunityComboBox
            // 
            this.newInvoiceCommunityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newInvoiceCommunityComboBox.FormattingEnabled = true;
            this.newInvoiceCommunityComboBox.Items.AddRange(new object[] {
            "Ardennes/Bataan",
            "Casablanca/Anzio Acres",
            "Corregidor Courts/Bougainville",
            "Hammond Hills",
            "Linden Oaks",
            "Nijmegan/Cherbourg",
            "Normandy/Bastogne Gables",
            "Pope",
            "St Mere Eglise"});
            this.newInvoiceCommunityComboBox.Location = new System.Drawing.Point(140, 43);
            this.newInvoiceCommunityComboBox.Name = "newInvoiceCommunityComboBox";
            this.newInvoiceCommunityComboBox.Size = new System.Drawing.Size(179, 21);
            this.newInvoiceCommunityComboBox.TabIndex = 1104;
            // 
            // newInvoiceCommunityLabelPrompt
            // 
            this.newInvoiceCommunityLabelPrompt.AutoSize = true;
            this.newInvoiceCommunityLabelPrompt.Location = new System.Drawing.Point(10, 46);
            this.newInvoiceCommunityLabelPrompt.Name = "newInvoiceCommunityLabelPrompt";
            this.newInvoiceCommunityLabelPrompt.Size = new System.Drawing.Size(61, 13);
            this.newInvoiceCommunityLabelPrompt.TabIndex = 1105;
            this.newInvoiceCommunityLabelPrompt.Text = "Community:";
            // 
            // cmbxContractingCompany
            // 
            this.cmbxContractingCompany.DataSource = this.contractorCompanyBindingSource;
            this.cmbxContractingCompany.DisplayMember = "Company_Name";
            this.cmbxContractingCompany.FormattingEnabled = true;
            this.cmbxContractingCompany.Location = new System.Drawing.Point(140, 95);
            this.cmbxContractingCompany.Name = "cmbxContractingCompany";
            this.cmbxContractingCompany.Size = new System.Drawing.Size(180, 21);
            this.cmbxContractingCompany.TabIndex = 1040;
            this.cmbxContractingCompany.ValueMember = "Company_ID";
            // 
            // contractorCompanyBindingSource
            // 
            this.contractorCompanyBindingSource.DataMember = "ContractorCompany";
            this.contractorCompanyBindingSource.DataSource = this.projectDBDataSet1;
            // 
            // projectDBDataSet1
            // 
            this.projectDBDataSet1.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.cmbxWorkOrderType.Location = new System.Drawing.Point(140, 69);
            this.cmbxWorkOrderType.Name = "cmbxWorkOrderType";
            this.cmbxWorkOrderType.Size = new System.Drawing.Size(180, 21);
            this.cmbxWorkOrderType.TabIndex = 1037;
            // 
            // gbxOccupancyStatus
            // 
            this.gbxOccupancyStatus.Controls.Add(this.rbtnOccupied);
            this.gbxOccupancyStatus.Controls.Add(this.rbtnUnoccupied);
            this.gbxOccupancyStatus.Location = new System.Drawing.Point(13, 180);
            this.gbxOccupancyStatus.Margin = new System.Windows.Forms.Padding(2);
            this.gbxOccupancyStatus.Name = "gbxOccupancyStatus";
            this.gbxOccupancyStatus.Padding = new System.Windows.Forms.Padding(2);
            this.gbxOccupancyStatus.Size = new System.Drawing.Size(175, 46);
            this.gbxOccupancyStatus.TabIndex = 1037;
            this.gbxOccupancyStatus.TabStop = false;
            this.gbxOccupancyStatus.Text = "Occupancy Status:";
            // 
            // rbtnOccupied
            // 
            this.rbtnOccupied.AutoSize = true;
            this.rbtnOccupied.Location = new System.Drawing.Point(19, 17);
            this.rbtnOccupied.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnOccupied.Name = "rbtnOccupied";
            this.rbtnOccupied.Size = new System.Drawing.Size(71, 17);
            this.rbtnOccupied.TabIndex = 1035;
            this.rbtnOccupied.Text = "Occupied";
            this.rbtnOccupied.UseVisualStyleBackColor = true;
            this.rbtnOccupied.CheckedChanged += new System.EventHandler(this.rbtnOccupied_CheckedChanged);
            // 
            // rbtnUnoccupied
            // 
            this.rbtnUnoccupied.AutoSize = true;
            this.rbtnUnoccupied.Location = new System.Drawing.Point(90, 17);
            this.rbtnUnoccupied.Margin = new System.Windows.Forms.Padding(2);
            this.rbtnUnoccupied.Name = "rbtnUnoccupied";
            this.rbtnUnoccupied.Size = new System.Drawing.Size(83, 17);
            this.rbtnUnoccupied.TabIndex = 1036;
            this.rbtnUnoccupied.Text = "Unoccupied";
            this.rbtnUnoccupied.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(140, 121);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(179, 20);
            this.dateTimePicker.TabIndex = 1039;
            // 
            // lblContractingCompanyPrompt
            // 
            this.lblContractingCompanyPrompt.AutoSize = true;
            this.lblContractingCompanyPrompt.Location = new System.Drawing.Point(10, 98);
            this.lblContractingCompanyPrompt.Name = "lblContractingCompanyPrompt";
            this.lblContractingCompanyPrompt.Size = new System.Drawing.Size(111, 13);
            this.lblContractingCompanyPrompt.TabIndex = 1035;
            this.lblContractingCompanyPrompt.Text = "Contracting Company:";
            // 
            // lblDueDatePrompt
            // 
            this.lblDueDatePrompt.AutoSize = true;
            this.lblDueDatePrompt.Location = new System.Drawing.Point(10, 124);
            this.lblDueDatePrompt.Name = "lblDueDatePrompt";
            this.lblDueDatePrompt.Size = new System.Drawing.Size(56, 13);
            this.lblDueDatePrompt.TabIndex = 1036;
            this.lblDueDatePrompt.Text = "Due Date:";
            // 
            // txtStreetAddress
            // 
            this.txtStreetAddress.Location = new System.Drawing.Point(140, 17);
            this.txtStreetAddress.Margin = new System.Windows.Forms.Padding(2);
            this.txtStreetAddress.Name = "txtStreetAddress";
            this.txtStreetAddress.Size = new System.Drawing.Size(179, 20);
            this.txtStreetAddress.TabIndex = 1034;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(11, 390);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(76, 36);
            this.btnSubmit.TabIndex = 1034;
            this.btnSubmit.Text = "Submit Work Order";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(143, 390);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(76, 36);
            this.btnClear.TabIndex = 1035;
            this.btnClear.Text = "Clear Screen";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(273, 390);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(76, 36);
            this.btnCancel.TabIndex = 1036;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // contractorCompanyTableAdapter1
            // 
            this.contractorCompanyTableAdapter1.ClearBeforeFill = true;
            // 
            // adminFormButton
            // 
            this.adminFormButton.Enabled = false;
            this.adminFormButton.Location = new System.Drawing.Point(143, 436);
            this.adminFormButton.Name = "adminFormButton";
            this.adminFormButton.Size = new System.Drawing.Size(75, 47);
            this.adminFormButton.TabIndex = 1107;
            this.adminFormButton.Text = "Return To Admin Form";
            this.adminFormButton.UseVisualStyleBackColor = true;
            this.adminFormButton.Visible = false;
            this.adminFormButton.Click += new System.EventHandler(this.adminFormButton_Click);
            // 
            // OfficeWorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 429);
            this.Controls.Add(this.adminFormButton);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.gbxOfficeWorkOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OfficeWorkOrder";
            this.Text = "Work Order";
            this.Load += new System.EventHandler(this.OfficeWorkOrder_Load);
            this.gbxOfficeWorkOrder.ResumeLayout(false);
            this.gbxOfficeWorkOrder.PerformLayout();
            this.occupiedPanel.ResumeLayout(false);
            this.occupiedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contractorCompanyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).EndInit();
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
        private System.Windows.Forms.Label lblContractingCompanyPrompt;
        private System.Windows.Forms.Label lblDueDatePrompt;
        private System.Windows.Forms.TextBox txtStreetAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox cmbxWorkOrderType;
        private System.Windows.Forms.ComboBox cmbxContractingCompany;
        private System.Windows.Forms.ComboBox newInvoiceCommunityComboBox;
        private System.Windows.Forms.Label newInvoiceCommunityLabelPrompt;
        private System.Windows.Forms.Panel occupiedPanel;
        private System.Windows.Forms.ComboBox newInvoiceAnimalsInHomeComboBox;
        private System.Windows.Forms.Label newInvoicePermissionToEnterLabelPrompt;
        private System.Windows.Forms.ComboBox newInvoicePermissionToEnterComboBox;
        private System.Windows.Forms.Label newInvoiceAnimalsLabelPrompt;
        private ProjectDBDataSet projectDBDataSet1;
        private System.Windows.Forms.BindingSource contractorCompanyBindingSource;
        private ProjectDBDataSetTableAdapters.ContractorCompanyTableAdapter contractorCompanyTableAdapter1;
        private System.Windows.Forms.Button adminFormButton;
    }
}