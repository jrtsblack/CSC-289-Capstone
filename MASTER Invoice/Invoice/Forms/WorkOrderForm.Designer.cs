namespace Invoice
{
    partial class WorkOrderForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkOrderForm));
            this.invoiceDatabaseListBox = new System.Windows.Forms.ListBox();
            this.invoiceDatabaseListboxLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceButton = new System.Windows.Forms.Button();
            this.invoiceInformationCancelButton = new System.Windows.Forms.Button();
            this.printInvoiceButton = new System.Windows.Forms.Button();
            this.invoiceInformationDescriptionOfRequestRichTextBox = new System.Windows.Forms.RichTextBox();
            this.invoiceInformationRequestTimeOfServiceLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationEmailLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationDescriptionLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationAlternatePhoneTypeLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationWorkOrderTypeLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationAnimalsLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationLastNameLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationPermissionToEnterLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationFirstNameLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationAlternatePhoneNumberLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationCommunityLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationStreetAddressLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.gbxCommentsAndStatus = new System.Windows.Forms.GroupBox();
            this.rTxtBoxComments = new System.Windows.Forms.RichTextBox();
            this.lblCommentsPrompt = new System.Windows.Forms.Label();
            this.rButtonIncomplete = new System.Windows.Forms.RadioButton();
            this.rButtonComplete = new System.Windows.Forms.RadioButton();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.invoiceInformationFirstNameLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationLastNameLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationStreetAddressLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationCommunityLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationPrimaryPhoneNumberLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationPrimaryPhoneExtensionLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationPrimaryPhoneTypeLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationAlternatePhoneNumberLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationAlternatePhoneTypeLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationAlternatePhoneExtensionLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationAnimalsLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationPermissionToEnterLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationRequestTimeOfServiceLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationWorkOrderTypeLabel = new System.Windows.Forms.TextBox();
            this.invoiceInformationEmailLabel = new System.Windows.Forms.TextBox();
            this.gbxOfficeWorkerTools = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblDueDatePrompt = new System.Windows.Forms.Label();
            this.dtpDue = new System.Windows.Forms.DateTimePicker();
            this.gbxOccupancyStatus = new System.Windows.Forms.GroupBox();
            this.rbtnOccupied = new System.Windows.Forms.RadioButton();
            this.rbtnUnoccupied = new System.Windows.Forms.RadioButton();
            this.lblSelectCompany = new System.Windows.Forms.Label();
            this.cbxCompanySelect = new System.Windows.Forms.ComboBox();
            this.invoiceInformationGroupBox.SuspendLayout();
            this.gbxCommentsAndStatus.SuspendLayout();
            this.gbxOfficeWorkerTools.SuspendLayout();
            this.gbxOccupancyStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoiceDatabaseListBox
            // 
            this.invoiceDatabaseListBox.FormattingEnabled = true;
            this.invoiceDatabaseListBox.ItemHeight = 16;
            this.invoiceDatabaseListBox.Location = new System.Drawing.Point(20, 31);
            this.invoiceDatabaseListBox.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceDatabaseListBox.Name = "invoiceDatabaseListBox";
            this.invoiceDatabaseListBox.Size = new System.Drawing.Size(377, 356);
            this.invoiceDatabaseListBox.TabIndex = 0;
            this.invoiceDatabaseListBox.SelectedIndexChanged += new System.EventHandler(this.invoiceDatabaseListBox_SelectedIndexChanged);
            // 
            // invoiceDatabaseListboxLabelPrompt
            // 
            this.invoiceDatabaseListboxLabelPrompt.AutoSize = true;
            this.invoiceDatabaseListboxLabelPrompt.Location = new System.Drawing.Point(16, 11);
            this.invoiceDatabaseListboxLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceDatabaseListboxLabelPrompt.Name = "invoiceDatabaseListboxLabelPrompt";
            this.invoiceDatabaseListboxLabelPrompt.Size = new System.Drawing.Size(277, 17);
            this.invoiceDatabaseListboxLabelPrompt.TabIndex = 1;
            this.invoiceDatabaseListboxLabelPrompt.Text = "Please select the invoice you wish to view. \r\n";
            // 
            // newInvoiceButton
            // 
            this.newInvoiceButton.Location = new System.Drawing.Point(8, 692);
            this.newInvoiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.newInvoiceButton.Name = "newInvoiceButton";
            this.newInvoiceButton.Size = new System.Drawing.Size(100, 28);
            this.newInvoiceButton.TabIndex = 1;
            this.newInvoiceButton.Text = "New";
            this.newInvoiceButton.UseVisualStyleBackColor = true;
            this.newInvoiceButton.Click += new System.EventHandler(this.newInvoiceButton_Click);
            // 
            // invoiceInformationCancelButton
            // 
            this.invoiceInformationCancelButton.Location = new System.Drawing.Point(224, 692);
            this.invoiceInformationCancelButton.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceInformationCancelButton.Name = "invoiceInformationCancelButton";
            this.invoiceInformationCancelButton.Size = new System.Drawing.Size(100, 28);
            this.invoiceInformationCancelButton.TabIndex = 3;
            this.invoiceInformationCancelButton.Text = "Close";
            this.invoiceInformationCancelButton.UseVisualStyleBackColor = true;
            this.invoiceInformationCancelButton.Click += new System.EventHandler(this.invoiceInformationCancelButton_Click);
            // 
            // printInvoiceButton
            // 
            this.printInvoiceButton.Location = new System.Drawing.Point(116, 692);
            this.printInvoiceButton.Margin = new System.Windows.Forms.Padding(4);
            this.printInvoiceButton.Name = "printInvoiceButton";
            this.printInvoiceButton.Size = new System.Drawing.Size(100, 28);
            this.printInvoiceButton.TabIndex = 2;
            this.printInvoiceButton.Text = "Print Invoice";
            this.printInvoiceButton.UseVisualStyleBackColor = true;
            this.printInvoiceButton.Click += new System.EventHandler(this.printInvoiceButton_Click);
            // 
            // invoiceInformationDescriptionOfRequestRichTextBox
            // 
            this.invoiceInformationDescriptionOfRequestRichTextBox.Location = new System.Drawing.Point(12, 452);
            this.invoiceInformationDescriptionOfRequestRichTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceInformationDescriptionOfRequestRichTextBox.Name = "invoiceInformationDescriptionOfRequestRichTextBox";
            this.invoiceInformationDescriptionOfRequestRichTextBox.ReadOnly = true;
            this.invoiceInformationDescriptionOfRequestRichTextBox.Size = new System.Drawing.Size(415, 117);
            this.invoiceInformationDescriptionOfRequestRichTextBox.TabIndex = 1014;
            this.invoiceInformationDescriptionOfRequestRichTextBox.Text = "";
            // 
            // invoiceInformationRequestTimeOfServiceLabelPrompt
            // 
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.AutoSize = true;
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.Location = new System.Drawing.Point(8, 578);
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.Name = "invoiceInformationRequestTimeOfServiceLabelPrompt";
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.Size = new System.Drawing.Size(167, 17);
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.TabIndex = 1031;
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.Text = "Request Time of Service:";
            // 
            // invoiceInformationPrimaryPhoneTypeLabelPrompt
            // 
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.AutoSize = true;
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.Location = new System.Drawing.Point(8, 230);
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.Name = "invoiceInformationPrimaryPhoneTypeLabelPrompt";
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.Size = new System.Drawing.Size(141, 17);
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.TabIndex = 1030;
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.Text = "Primary Phone Type:";
            // 
            // invoiceInformationEmailLabelPrompt
            // 
            this.invoiceInformationEmailLabelPrompt.AutoSize = true;
            this.invoiceInformationEmailLabelPrompt.Location = new System.Drawing.Point(8, 363);
            this.invoiceInformationEmailLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationEmailLabelPrompt.Name = "invoiceInformationEmailLabelPrompt";
            this.invoiceInformationEmailLabelPrompt.Size = new System.Drawing.Size(46, 17);
            this.invoiceInformationEmailLabelPrompt.TabIndex = 1029;
            this.invoiceInformationEmailLabelPrompt.Text = "Email:";
            // 
            // invoiceInformationDescriptionLabelPrompt
            // 
            this.invoiceInformationDescriptionLabelPrompt.AutoSize = true;
            this.invoiceInformationDescriptionLabelPrompt.Location = new System.Drawing.Point(8, 430);
            this.invoiceInformationDescriptionLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationDescriptionLabelPrompt.Name = "invoiceInformationDescriptionLabelPrompt";
            this.invoiceInformationDescriptionLabelPrompt.Size = new System.Drawing.Size(284, 17);
            this.invoiceInformationDescriptionLabelPrompt.TabIndex = 1028;
            this.invoiceInformationDescriptionLabelPrompt.Text = "Description of Request (Including Location):";
            // 
            // invoiceInformationPrimaryPhoneExtensionLabelPrompt
            // 
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.AutoSize = true;
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.Location = new System.Drawing.Point(8, 197);
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.Name = "invoiceInformationPrimaryPhoneExtensionLabelPrompt";
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.Size = new System.Drawing.Size(170, 17);
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.TabIndex = 1027;
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.Text = "Primary Phone Extension:";
            // 
            // invoiceInformationAlternatePhoneTypeLabelPrompt
            // 
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.AutoSize = true;
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.Location = new System.Drawing.Point(8, 330);
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.Name = "invoiceInformationAlternatePhoneTypeLabelPrompt";
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.Size = new System.Drawing.Size(150, 17);
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.TabIndex = 1022;
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.Text = "Alternate Phone Type:";
            // 
            // invoiceInformationWorkOrderTypeLabelPrompt
            // 
            this.invoiceInformationWorkOrderTypeLabelPrompt.AutoSize = true;
            this.invoiceInformationWorkOrderTypeLabelPrompt.Location = new System.Drawing.Point(8, 398);
            this.invoiceInformationWorkOrderTypeLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationWorkOrderTypeLabelPrompt.Name = "invoiceInformationWorkOrderTypeLabelPrompt";
            this.invoiceInformationWorkOrderTypeLabelPrompt.Size = new System.Drawing.Size(118, 17);
            this.invoiceInformationWorkOrderTypeLabelPrompt.TabIndex = 1025;
            this.invoiceInformationWorkOrderTypeLabelPrompt.Text = "Work Order Type";
            // 
            // invoiceInformationAnimalsLabelPrompt
            // 
            this.invoiceInformationAnimalsLabelPrompt.AutoSize = true;
            this.invoiceInformationAnimalsLabelPrompt.Location = new System.Drawing.Point(8, 641);
            this.invoiceInformationAnimalsLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationAnimalsLabelPrompt.Name = "invoiceInformationAnimalsLabelPrompt";
            this.invoiceInformationAnimalsLabelPrompt.Size = new System.Drawing.Size(117, 17);
            this.invoiceInformationAnimalsLabelPrompt.TabIndex = 1024;
            this.invoiceInformationAnimalsLabelPrompt.Text = "Animals in Home:";
            // 
            // invoiceInformationPrimaryPhoneNumberLabelPrompt
            // 
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.AutoSize = true;
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.Location = new System.Drawing.Point(8, 164);
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.Name = "invoiceInformationPrimaryPhoneNumberLabelPrompt";
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.Size = new System.Drawing.Size(159, 17);
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.TabIndex = 1033;
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.Text = "Primary Phone Number:";
            // 
            // invoiceInformationAlternatePhoneExtensionLabelPrompt
            // 
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.AutoSize = true;
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.Location = new System.Drawing.Point(8, 297);
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.Name = "invoiceInformationAlternatePhoneExtensionLabelPrompt";
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.Size = new System.Drawing.Size(179, 17);
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.TabIndex = 1021;
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.Text = "Alternate Phone Extension:";
            // 
            // invoiceInformationLastNameLabelPrompt
            // 
            this.invoiceInformationLastNameLabelPrompt.AutoSize = true;
            this.invoiceInformationLastNameLabelPrompt.Location = new System.Drawing.Point(8, 65);
            this.invoiceInformationLastNameLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationLastNameLabelPrompt.Name = "invoiceInformationLastNameLabelPrompt";
            this.invoiceInformationLastNameLabelPrompt.Size = new System.Drawing.Size(80, 17);
            this.invoiceInformationLastNameLabelPrompt.TabIndex = 1020;
            this.invoiceInformationLastNameLabelPrompt.Text = "Last Name:";
            // 
            // invoiceInformationPermissionToEnterLabelPrompt
            // 
            this.invoiceInformationPermissionToEnterLabelPrompt.AutoSize = true;
            this.invoiceInformationPermissionToEnterLabelPrompt.Location = new System.Drawing.Point(8, 609);
            this.invoiceInformationPermissionToEnterLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationPermissionToEnterLabelPrompt.Name = "invoiceInformationPermissionToEnterLabelPrompt";
            this.invoiceInformationPermissionToEnterLabelPrompt.Size = new System.Drawing.Size(176, 17);
            this.invoiceInformationPermissionToEnterLabelPrompt.TabIndex = 1019;
            this.invoiceInformationPermissionToEnterLabelPrompt.Text = "Permission to Enter (PTE):";
            // 
            // invoiceInformationFirstNameLabelPrompt
            // 
            this.invoiceInformationFirstNameLabelPrompt.AutoSize = true;
            this.invoiceInformationFirstNameLabelPrompt.Location = new System.Drawing.Point(8, 32);
            this.invoiceInformationFirstNameLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationFirstNameLabelPrompt.Name = "invoiceInformationFirstNameLabelPrompt";
            this.invoiceInformationFirstNameLabelPrompt.Size = new System.Drawing.Size(80, 17);
            this.invoiceInformationFirstNameLabelPrompt.TabIndex = 1034;
            this.invoiceInformationFirstNameLabelPrompt.Text = "First Name:";
            // 
            // invoiceInformationAlternatePhoneNumberLabelPrompt
            // 
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.AutoSize = true;
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.Location = new System.Drawing.Point(8, 263);
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.Name = "invoiceInformationAlternatePhoneNumberLabelPrompt";
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.Size = new System.Drawing.Size(168, 17);
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.TabIndex = 1018;
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.Text = "Alternate Phone Number:";
            // 
            // invoiceInformationCommunityLabelPrompt
            // 
            this.invoiceInformationCommunityLabelPrompt.AutoSize = true;
            this.invoiceInformationCommunityLabelPrompt.Location = new System.Drawing.Point(8, 132);
            this.invoiceInformationCommunityLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationCommunityLabelPrompt.Name = "invoiceInformationCommunityLabelPrompt";
            this.invoiceInformationCommunityLabelPrompt.Size = new System.Drawing.Size(81, 17);
            this.invoiceInformationCommunityLabelPrompt.TabIndex = 1026;
            this.invoiceInformationCommunityLabelPrompt.Text = "Community:";
            // 
            // invoiceInformationStreetAddressLabelPrompt
            // 
            this.invoiceInformationStreetAddressLabelPrompt.AutoSize = true;
            this.invoiceInformationStreetAddressLabelPrompt.Location = new System.Drawing.Point(8, 98);
            this.invoiceInformationStreetAddressLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invoiceInformationStreetAddressLabelPrompt.Name = "invoiceInformationStreetAddressLabelPrompt";
            this.invoiceInformationStreetAddressLabelPrompt.Size = new System.Drawing.Size(106, 17);
            this.invoiceInformationStreetAddressLabelPrompt.TabIndex = 1023;
            this.invoiceInformationStreetAddressLabelPrompt.Text = "Street Address:";
            // 
            // invoiceInformationGroupBox
            // 
            this.invoiceInformationGroupBox.Controls.Add(this.btnUpdate);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAnimalsLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPermissionToEnterLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationRequestTimeOfServiceLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationWorkOrderTypeLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.newInvoiceButton);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationEmailLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationLastNameLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationFirstNameLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationFirstNameLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationCancelButton);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationStreetAddressLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneTypeLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneExtensionLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.printInvoiceButton);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationCommunityLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneNumberLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationDescriptionOfRequestRichTextBox);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneTypeLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneExtensionLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneNumberLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneNumberLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationCommunityLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationStreetAddressLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationRequestTimeOfServiceLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPermissionToEnterLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneTypeLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationLastNameLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneExtensionLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationEmailLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationDescriptionLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneNumberLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneExtensionLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAnimalsLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationWorkOrderTypeLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneTypeLabelPrompt);
            this.invoiceInformationGroupBox.Location = new System.Drawing.Point(403, 11);
            this.invoiceInformationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.invoiceInformationGroupBox.Name = "invoiceInformationGroupBox";
            this.invoiceInformationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.invoiceInformationGroupBox.Size = new System.Drawing.Size(432, 737);
            this.invoiceInformationGroupBox.TabIndex = 1037;
            this.invoiceInformationGroupBox.TabStop = false;
            this.invoiceInformationGroupBox.Text = "Invoice Information";
            // 
            // gbxCommentsAndStatus
            // 
            this.gbxCommentsAndStatus.Controls.Add(this.rTxtBoxComments);
            this.gbxCommentsAndStatus.Controls.Add(this.lblCommentsPrompt);
            this.gbxCommentsAndStatus.Controls.Add(this.rButtonIncomplete);
            this.gbxCommentsAndStatus.Controls.Add(this.rButtonComplete);
            this.gbxCommentsAndStatus.Enabled = false;
            this.gbxCommentsAndStatus.Location = new System.Drawing.Point(20, 545);
            this.gbxCommentsAndStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCommentsAndStatus.Name = "gbxCommentsAndStatus";
            this.gbxCommentsAndStatus.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbxCommentsAndStatus.Size = new System.Drawing.Size(376, 203);
            this.gbxCommentsAndStatus.TabIndex = 1038;
            this.gbxCommentsAndStatus.TabStop = false;
            this.gbxCommentsAndStatus.Text = "Status of Work Order";
            // 
            // rTxtBoxComments
            // 
            this.rTxtBoxComments.Location = new System.Drawing.Point(11, 71);
            this.rTxtBoxComments.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rTxtBoxComments.Name = "rTxtBoxComments";
            this.rTxtBoxComments.ReadOnly = true;
            this.rTxtBoxComments.Size = new System.Drawing.Size(360, 128);
            this.rTxtBoxComments.TabIndex = 3;
            this.rTxtBoxComments.Text = "";
            // 
            // lblCommentsPrompt
            // 
            this.lblCommentsPrompt.AutoSize = true;
            this.lblCommentsPrompt.Location = new System.Drawing.Point(7, 50);
            this.lblCommentsPrompt.Name = "lblCommentsPrompt";
            this.lblCommentsPrompt.Size = new System.Drawing.Size(78, 17);
            this.lblCommentsPrompt.TabIndex = 2;
            this.lblCommentsPrompt.Text = "Comments:\r\n";
            // 
            // rButtonIncomplete
            // 
            this.rButtonIncomplete.AutoCheck = false;
            this.rButtonIncomplete.AutoSize = true;
            this.rButtonIncomplete.Location = new System.Drawing.Point(124, 22);
            this.rButtonIncomplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rButtonIncomplete.Name = "rButtonIncomplete";
            this.rButtonIncomplete.Size = new System.Drawing.Size(97, 21);
            this.rButtonIncomplete.TabIndex = 1;
            this.rButtonIncomplete.Text = "Incomplete";
            this.rButtonIncomplete.UseVisualStyleBackColor = true;
            // 
            // rButtonComplete
            // 
            this.rButtonComplete.AutoCheck = false;
            this.rButtonComplete.AutoSize = true;
            this.rButtonComplete.Location = new System.Drawing.Point(7, 22);
            this.rButtonComplete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rButtonComplete.Name = "rButtonComplete";
            this.rButtonComplete.Size = new System.Drawing.Size(88, 21);
            this.rButtonComplete.TabIndex = 0;
            this.rButtonComplete.Text = "Complete";
            this.rButtonComplete.UseVisualStyleBackColor = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // invoiceInformationFirstNameLabel
            // 
            this.invoiceInformationFirstNameLabel.Location = new System.Drawing.Point(191, 29);
            this.invoiceInformationFirstNameLabel.Name = "invoiceInformationFirstNameLabel";
            this.invoiceInformationFirstNameLabel.ReadOnly = true;
            this.invoiceInformationFirstNameLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationFirstNameLabel.TabIndex = 1039;
            // 
            // invoiceInformationLastNameLabel
            // 
            this.invoiceInformationLastNameLabel.Location = new System.Drawing.Point(191, 62);
            this.invoiceInformationLastNameLabel.Name = "invoiceInformationLastNameLabel";
            this.invoiceInformationLastNameLabel.ReadOnly = true;
            this.invoiceInformationLastNameLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationLastNameLabel.TabIndex = 1040;
            // 
            // invoiceInformationStreetAddressLabel
            // 
            this.invoiceInformationStreetAddressLabel.Location = new System.Drawing.Point(191, 95);
            this.invoiceInformationStreetAddressLabel.Name = "invoiceInformationStreetAddressLabel";
            this.invoiceInformationStreetAddressLabel.ReadOnly = true;
            this.invoiceInformationStreetAddressLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationStreetAddressLabel.TabIndex = 1041;
            // 
            // invoiceInformationCommunityLabel
            // 
            this.invoiceInformationCommunityLabel.Location = new System.Drawing.Point(191, 129);
            this.invoiceInformationCommunityLabel.Name = "invoiceInformationCommunityLabel";
            this.invoiceInformationCommunityLabel.ReadOnly = true;
            this.invoiceInformationCommunityLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationCommunityLabel.TabIndex = 1042;
            // 
            // invoiceInformationPrimaryPhoneNumberLabel
            // 
            this.invoiceInformationPrimaryPhoneNumberLabel.Location = new System.Drawing.Point(191, 161);
            this.invoiceInformationPrimaryPhoneNumberLabel.Name = "invoiceInformationPrimaryPhoneNumberLabel";
            this.invoiceInformationPrimaryPhoneNumberLabel.ReadOnly = true;
            this.invoiceInformationPrimaryPhoneNumberLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationPrimaryPhoneNumberLabel.TabIndex = 1043;
            // 
            // invoiceInformationPrimaryPhoneExtensionLabel
            // 
            this.invoiceInformationPrimaryPhoneExtensionLabel.Location = new System.Drawing.Point(191, 194);
            this.invoiceInformationPrimaryPhoneExtensionLabel.Name = "invoiceInformationPrimaryPhoneExtensionLabel";
            this.invoiceInformationPrimaryPhoneExtensionLabel.ReadOnly = true;
            this.invoiceInformationPrimaryPhoneExtensionLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationPrimaryPhoneExtensionLabel.TabIndex = 1044;
            // 
            // invoiceInformationPrimaryPhoneTypeLabel
            // 
            this.invoiceInformationPrimaryPhoneTypeLabel.Location = new System.Drawing.Point(191, 227);
            this.invoiceInformationPrimaryPhoneTypeLabel.Name = "invoiceInformationPrimaryPhoneTypeLabel";
            this.invoiceInformationPrimaryPhoneTypeLabel.ReadOnly = true;
            this.invoiceInformationPrimaryPhoneTypeLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationPrimaryPhoneTypeLabel.TabIndex = 1045;
            // 
            // invoiceInformationAlternatePhoneNumberLabel
            // 
            this.invoiceInformationAlternatePhoneNumberLabel.Location = new System.Drawing.Point(191, 260);
            this.invoiceInformationAlternatePhoneNumberLabel.Name = "invoiceInformationAlternatePhoneNumberLabel";
            this.invoiceInformationAlternatePhoneNumberLabel.ReadOnly = true;
            this.invoiceInformationAlternatePhoneNumberLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationAlternatePhoneNumberLabel.TabIndex = 1046;
            // 
            // invoiceInformationAlternatePhoneTypeLabel
            // 
            this.invoiceInformationAlternatePhoneTypeLabel.Location = new System.Drawing.Point(191, 327);
            this.invoiceInformationAlternatePhoneTypeLabel.Name = "invoiceInformationAlternatePhoneTypeLabel";
            this.invoiceInformationAlternatePhoneTypeLabel.ReadOnly = true;
            this.invoiceInformationAlternatePhoneTypeLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationAlternatePhoneTypeLabel.TabIndex = 1047;
            // 
            // invoiceInformationAlternatePhoneExtensionLabel
            // 
            this.invoiceInformationAlternatePhoneExtensionLabel.Location = new System.Drawing.Point(191, 294);
            this.invoiceInformationAlternatePhoneExtensionLabel.Name = "invoiceInformationAlternatePhoneExtensionLabel";
            this.invoiceInformationAlternatePhoneExtensionLabel.ReadOnly = true;
            this.invoiceInformationAlternatePhoneExtensionLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationAlternatePhoneExtensionLabel.TabIndex = 1048;
            // 
            // invoiceInformationAnimalsLabel
            // 
            this.invoiceInformationAnimalsLabel.Location = new System.Drawing.Point(191, 638);
            this.invoiceInformationAnimalsLabel.Name = "invoiceInformationAnimalsLabel";
            this.invoiceInformationAnimalsLabel.ReadOnly = true;
            this.invoiceInformationAnimalsLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationAnimalsLabel.TabIndex = 1049;
            // 
            // invoiceInformationPermissionToEnterLabel
            // 
            this.invoiceInformationPermissionToEnterLabel.Location = new System.Drawing.Point(191, 606);
            this.invoiceInformationPermissionToEnterLabel.Name = "invoiceInformationPermissionToEnterLabel";
            this.invoiceInformationPermissionToEnterLabel.ReadOnly = true;
            this.invoiceInformationPermissionToEnterLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationPermissionToEnterLabel.TabIndex = 1050;
            // 
            // invoiceInformationRequestTimeOfServiceLabel
            // 
            this.invoiceInformationRequestTimeOfServiceLabel.Location = new System.Drawing.Point(191, 575);
            this.invoiceInformationRequestTimeOfServiceLabel.Name = "invoiceInformationRequestTimeOfServiceLabel";
            this.invoiceInformationRequestTimeOfServiceLabel.ReadOnly = true;
            this.invoiceInformationRequestTimeOfServiceLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationRequestTimeOfServiceLabel.TabIndex = 1051;
            // 
            // invoiceInformationWorkOrderTypeLabel
            // 
            this.invoiceInformationWorkOrderTypeLabel.Location = new System.Drawing.Point(191, 395);
            this.invoiceInformationWorkOrderTypeLabel.Name = "invoiceInformationWorkOrderTypeLabel";
            this.invoiceInformationWorkOrderTypeLabel.ReadOnly = true;
            this.invoiceInformationWorkOrderTypeLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationWorkOrderTypeLabel.TabIndex = 1052;
            // 
            // invoiceInformationEmailLabel
            // 
            this.invoiceInformationEmailLabel.Location = new System.Drawing.Point(191, 360);
            this.invoiceInformationEmailLabel.Name = "invoiceInformationEmailLabel";
            this.invoiceInformationEmailLabel.ReadOnly = true;
            this.invoiceInformationEmailLabel.Size = new System.Drawing.Size(237, 22);
            this.invoiceInformationEmailLabel.TabIndex = 1053;
            // 
            // gbxOfficeWorkerTools
            // 
            this.gbxOfficeWorkerTools.Controls.Add(this.cbxCompanySelect);
            this.gbxOfficeWorkerTools.Controls.Add(this.lblSelectCompany);
            this.gbxOfficeWorkerTools.Controls.Add(this.gbxOccupancyStatus);
            this.gbxOfficeWorkerTools.Controls.Add(this.dtpDue);
            this.gbxOfficeWorkerTools.Controls.Add(this.lblDueDatePrompt);
            this.gbxOfficeWorkerTools.Location = new System.Drawing.Point(20, 391);
            this.gbxOfficeWorkerTools.Name = "gbxOfficeWorkerTools";
            this.gbxOfficeWorkerTools.Size = new System.Drawing.Size(376, 149);
            this.gbxOfficeWorkerTools.TabIndex = 1039;
            this.gbxOfficeWorkerTools.TabStop = false;
            this.gbxOfficeWorkerTools.Text = "Office Worker Tools";
            this.gbxOfficeWorkerTools.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(327, 692);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update Info";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblDueDatePrompt
            // 
            this.lblDueDatePrompt.AutoSize = true;
            this.lblDueDatePrompt.Location = new System.Drawing.Point(8, 27);
            this.lblDueDatePrompt.Name = "lblDueDatePrompt";
            this.lblDueDatePrompt.Size = new System.Drawing.Size(115, 17);
            this.lblDueDatePrompt.TabIndex = 0;
            this.lblDueDatePrompt.Text = "Select Due Date:";
            // 
            // dtpDue
            // 
            this.dtpDue.Location = new System.Drawing.Point(126, 22);
            this.dtpDue.Name = "dtpDue";
            this.dtpDue.Size = new System.Drawing.Size(238, 22);
            this.dtpDue.TabIndex = 1;
            // 
            // gbxOccupancyStatus
            // 
            this.gbxOccupancyStatus.Controls.Add(this.rbtnOccupied);
            this.gbxOccupancyStatus.Controls.Add(this.rbtnUnoccupied);
            this.gbxOccupancyStatus.Location = new System.Drawing.Point(11, 86);
            this.gbxOccupancyStatus.Name = "gbxOccupancyStatus";
            this.gbxOccupancyStatus.Size = new System.Drawing.Size(353, 57);
            this.gbxOccupancyStatus.TabIndex = 1038;
            this.gbxOccupancyStatus.TabStop = false;
            this.gbxOccupancyStatus.Text = "Occupancy Status:";
            // 
            // rbtnOccupied
            // 
            this.rbtnOccupied.AutoSize = true;
            this.rbtnOccupied.Location = new System.Drawing.Point(55, 21);
            this.rbtnOccupied.Name = "rbtnOccupied";
            this.rbtnOccupied.Size = new System.Drawing.Size(89, 21);
            this.rbtnOccupied.TabIndex = 1035;
            this.rbtnOccupied.Text = "Occupied";
            this.rbtnOccupied.UseVisualStyleBackColor = true;
            // 
            // rbtnUnoccupied
            // 
            this.rbtnUnoccupied.AutoSize = true;
            this.rbtnUnoccupied.Location = new System.Drawing.Point(193, 21);
            this.rbtnUnoccupied.Name = "rbtnUnoccupied";
            this.rbtnUnoccupied.Size = new System.Drawing.Size(104, 21);
            this.rbtnUnoccupied.TabIndex = 1036;
            this.rbtnUnoccupied.Text = "Unoccupied";
            this.rbtnUnoccupied.UseVisualStyleBackColor = true;
            // 
            // lblSelectCompany
            // 
            this.lblSelectCompany.AutoSize = true;
            this.lblSelectCompany.Location = new System.Drawing.Point(10, 63);
            this.lblSelectCompany.Name = "lblSelectCompany";
            this.lblSelectCompany.Size = new System.Drawing.Size(114, 17);
            this.lblSelectCompany.TabIndex = 1039;
            this.lblSelectCompany.Text = "Select Company:";
            // 
            // cbxCompanySelect
            // 
            this.cbxCompanySelect.FormattingEnabled = true;
            this.cbxCompanySelect.Location = new System.Drawing.Point(126, 60);
            this.cbxCompanySelect.Name = "cbxCompanySelect";
            this.cbxCompanySelect.Size = new System.Drawing.Size(238, 24);
            this.cbxCompanySelect.TabIndex = 1040;
            // 
            // WorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 759);
            this.Controls.Add(this.gbxOfficeWorkerTools);
            this.Controls.Add(this.gbxCommentsAndStatus);
            this.Controls.Add(this.invoiceInformationGroupBox);
            this.Controls.Add(this.invoiceDatabaseListBox);
            this.Controls.Add(this.invoiceDatabaseListboxLabelPrompt);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkOrderForm";
            this.Text = "Work Order Information";
            this.invoiceInformationGroupBox.ResumeLayout(false);
            this.invoiceInformationGroupBox.PerformLayout();
            this.gbxCommentsAndStatus.ResumeLayout(false);
            this.gbxCommentsAndStatus.PerformLayout();
            this.gbxOfficeWorkerTools.ResumeLayout(false);
            this.gbxOfficeWorkerTools.PerformLayout();
            this.gbxOccupancyStatus.ResumeLayout(false);
            this.gbxOccupancyStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox invoiceDatabaseListBox;
        private System.Windows.Forms.Label invoiceDatabaseListboxLabelPrompt;
        private System.Windows.Forms.Button newInvoiceButton;
        private System.Windows.Forms.Button invoiceInformationCancelButton;
        private System.Windows.Forms.Button printInvoiceButton;
        private System.Windows.Forms.RichTextBox invoiceInformationDescriptionOfRequestRichTextBox;
        private System.Windows.Forms.Label invoiceInformationRequestTimeOfServiceLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationPrimaryPhoneTypeLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationEmailLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationDescriptionLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationPrimaryPhoneExtensionLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationAlternatePhoneTypeLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationWorkOrderTypeLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationAnimalsLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationPrimaryPhoneNumberLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationAlternatePhoneExtensionLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationLastNameLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationPermissionToEnterLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationFirstNameLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationAlternatePhoneNumberLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationCommunityLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationStreetAddressLabelPrompt;
        private System.Windows.Forms.GroupBox invoiceInformationGroupBox;
        private System.Windows.Forms.GroupBox gbxCommentsAndStatus;
        private System.Windows.Forms.RichTextBox rTxtBoxComments;
        private System.Windows.Forms.Label lblCommentsPrompt;
        private System.Windows.Forms.RadioButton rButtonIncomplete;
        private System.Windows.Forms.RadioButton rButtonComplete;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.TextBox invoiceInformationFirstNameLabel;
        private System.Windows.Forms.TextBox invoiceInformationLastNameLabel;
        private System.Windows.Forms.TextBox invoiceInformationStreetAddressLabel;
        private System.Windows.Forms.TextBox invoiceInformationCommunityLabel;
        private System.Windows.Forms.TextBox invoiceInformationPrimaryPhoneNumberLabel;
        private System.Windows.Forms.TextBox invoiceInformationPrimaryPhoneExtensionLabel;
        private System.Windows.Forms.TextBox invoiceInformationPrimaryPhoneTypeLabel;
        private System.Windows.Forms.TextBox invoiceInformationAlternatePhoneNumberLabel;
        private System.Windows.Forms.TextBox invoiceInformationAlternatePhoneTypeLabel;
        private System.Windows.Forms.TextBox invoiceInformationAlternatePhoneExtensionLabel;
        private System.Windows.Forms.TextBox invoiceInformationAnimalsLabel;
        private System.Windows.Forms.TextBox invoiceInformationPermissionToEnterLabel;
        private System.Windows.Forms.TextBox invoiceInformationRequestTimeOfServiceLabel;
        private System.Windows.Forms.TextBox invoiceInformationWorkOrderTypeLabel;
        private System.Windows.Forms.TextBox invoiceInformationEmailLabel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox gbxOfficeWorkerTools;
        private System.Windows.Forms.DateTimePicker dtpDue;
        private System.Windows.Forms.Label lblDueDatePrompt;
        private System.Windows.Forms.GroupBox gbxOccupancyStatus;
        private System.Windows.Forms.RadioButton rbtnOccupied;
        private System.Windows.Forms.RadioButton rbtnUnoccupied;
        private System.Windows.Forms.ComboBox cbxCompanySelect;
        private System.Windows.Forms.Label lblSelectCompany;
    }
}