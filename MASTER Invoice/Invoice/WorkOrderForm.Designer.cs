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
            this.newInvoiceButtonLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationCancelButton = new System.Windows.Forms.Button();
            this.printInvoiceButton = new System.Windows.Forms.Button();
            this.invoiceInformationDescriptionOfRequestRichTextBox = new System.Windows.Forms.RichTextBox();
            this.invoiceInformationPermissionToEnterLabel = new System.Windows.Forms.Label();
            this.invoiceInformationRequestTimeOfServiceLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationPrimaryPhoneTypeLabel = new System.Windows.Forms.Label();
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationRequestTimeOfServiceLabel = new System.Windows.Forms.Label();
            this.invoiceInformationEmailLabel = new System.Windows.Forms.Label();
            this.invoiceInformationEmailLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationDescriptionLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationPrimaryPhoneExtensionLabel = new System.Windows.Forms.Label();
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationAlternatePhoneTypeLabel = new System.Windows.Forms.Label();
            this.invoiceInformationAnimalsLabel = new System.Windows.Forms.Label();
            this.invoiceInformationAlternatePhoneTypeLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationWorkOrderTypeLabel = new System.Windows.Forms.Label();
            this.invoiceInformationWorkOrderTypeLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationAnimalsLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationPrimaryPhoneNumberLabel = new System.Windows.Forms.Label();
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationAlternatePhoneExtensionLabel = new System.Windows.Forms.Label();
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationLastNameLabel = new System.Windows.Forms.Label();
            this.invoiceInformationLastNameLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationPermissionToEnterLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationFirstNameLabel = new System.Windows.Forms.Label();
            this.invoiceInformationAlternatePhoneNumberLabel = new System.Windows.Forms.Label();
            this.invoiceInformationFirstNameLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationCommunityLabel = new System.Windows.Forms.Label();
            this.invoiceInformationAlternatePhoneNumberLabelPrompt = new System.Windows.Forms.Label();
            this.invoiceInformationStreetAddressLabel = new System.Windows.Forms.Label();
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
            this.invoiceInformationGroupBox.SuspendLayout();
            this.gbxCommentsAndStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoiceDatabaseListBox
            // 
            this.invoiceDatabaseListBox.FormattingEnabled = true;
            this.invoiceDatabaseListBox.Location = new System.Drawing.Point(15, 25);
            this.invoiceDatabaseListBox.Name = "invoiceDatabaseListBox";
            this.invoiceDatabaseListBox.Size = new System.Drawing.Size(284, 381);
            this.invoiceDatabaseListBox.TabIndex = 0;
            // 
            // invoiceDatabaseListboxLabelPrompt
            // 
            this.invoiceDatabaseListboxLabelPrompt.AutoSize = true;
            this.invoiceDatabaseListboxLabelPrompt.Location = new System.Drawing.Point(12, 9);
            this.invoiceDatabaseListboxLabelPrompt.Name = "invoiceDatabaseListboxLabelPrompt";
            this.invoiceDatabaseListboxLabelPrompt.Size = new System.Drawing.Size(212, 13);
            this.invoiceDatabaseListboxLabelPrompt.TabIndex = 1;
            this.invoiceDatabaseListboxLabelPrompt.Text = "Please select the invoice you wish to view. \r\n";
            // 
            // newInvoiceButton
            // 
            this.newInvoiceButton.Location = new System.Drawing.Point(12, 588);
            this.newInvoiceButton.Name = "newInvoiceButton";
            this.newInvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.newInvoiceButton.TabIndex = 1;
            this.newInvoiceButton.Text = "New";
            this.newInvoiceButton.UseVisualStyleBackColor = true;
            this.newInvoiceButton.Click += new System.EventHandler(this.newInvoiceButton_Click);
            // 
            // newInvoiceButtonLabelPrompt
            // 
            this.newInvoiceButtonLabelPrompt.AutoSize = true;
            this.newInvoiceButtonLabelPrompt.Location = new System.Drawing.Point(12, 572);
            this.newInvoiceButtonLabelPrompt.Name = "newInvoiceButtonLabelPrompt";
            this.newInvoiceButtonLabelPrompt.Size = new System.Drawing.Size(245, 13);
            this.newInvoiceButtonLabelPrompt.TabIndex = 3;
            this.newInvoiceButtonLabelPrompt.Text = "Or create a new one by pressing the button below.";
            // 
            // invoiceInformationCancelButton
            // 
            this.invoiceInformationCancelButton.Location = new System.Drawing.Point(200, 558);
            this.invoiceInformationCancelButton.Name = "invoiceInformationCancelButton";
            this.invoiceInformationCancelButton.Size = new System.Drawing.Size(75, 23);
            this.invoiceInformationCancelButton.TabIndex = 3;
            this.invoiceInformationCancelButton.Text = "Cancel";
            this.invoiceInformationCancelButton.UseVisualStyleBackColor = true;
            this.invoiceInformationCancelButton.Click += new System.EventHandler(this.invoiceInformationCancelButton_Click);
            // 
            // printInvoiceButton
            // 
            this.printInvoiceButton.Location = new System.Drawing.Point(58, 558);
            this.printInvoiceButton.Name = "printInvoiceButton";
            this.printInvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.printInvoiceButton.TabIndex = 2;
            this.printInvoiceButton.Text = "Print Invoice";
            this.printInvoiceButton.UseVisualStyleBackColor = true;
            this.printInvoiceButton.Click += new System.EventHandler(this.printInvoiceButton_Click);
            // 
            // invoiceInformationDescriptionOfRequestRichTextBox
            // 
            this.invoiceInformationDescriptionOfRequestRichTextBox.Location = new System.Drawing.Point(9, 367);
            this.invoiceInformationDescriptionOfRequestRichTextBox.Name = "invoiceInformationDescriptionOfRequestRichTextBox";
            this.invoiceInformationDescriptionOfRequestRichTextBox.ReadOnly = true;
            this.invoiceInformationDescriptionOfRequestRichTextBox.Size = new System.Drawing.Size(312, 96);
            this.invoiceInformationDescriptionOfRequestRichTextBox.TabIndex = 1014;
            this.invoiceInformationDescriptionOfRequestRichTextBox.Text = "";
            // 
            // invoiceInformationPermissionToEnterLabel
            // 
            this.invoiceInformationPermissionToEnterLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationPermissionToEnterLabel.Location = new System.Drawing.Point(143, 494);
            this.invoiceInformationPermissionToEnterLabel.Name = "invoiceInformationPermissionToEnterLabel";
            this.invoiceInformationPermissionToEnterLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationPermissionToEnterLabel.TabIndex = 1016;
            this.invoiceInformationPermissionToEnterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationRequestTimeOfServiceLabelPrompt
            // 
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.AutoSize = true;
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.Location = new System.Drawing.Point(6, 470);
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.Name = "invoiceInformationRequestTimeOfServiceLabelPrompt";
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.Size = new System.Drawing.Size(127, 13);
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.TabIndex = 1031;
            this.invoiceInformationRequestTimeOfServiceLabelPrompt.Text = "Request Time of Service:";
            // 
            // invoiceInformationPrimaryPhoneTypeLabel
            // 
            this.invoiceInformationPrimaryPhoneTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationPrimaryPhoneTypeLabel.Location = new System.Drawing.Point(143, 184);
            this.invoiceInformationPrimaryPhoneTypeLabel.Name = "invoiceInformationPrimaryPhoneTypeLabel";
            this.invoiceInformationPrimaryPhoneTypeLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationPrimaryPhoneTypeLabel.TabIndex = 1007;
            this.invoiceInformationPrimaryPhoneTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationPrimaryPhoneTypeLabelPrompt
            // 
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.AutoSize = true;
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.Location = new System.Drawing.Point(6, 187);
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.Name = "invoiceInformationPrimaryPhoneTypeLabelPrompt";
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.Size = new System.Drawing.Size(105, 13);
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.TabIndex = 1030;
            this.invoiceInformationPrimaryPhoneTypeLabelPrompt.Text = "Primary Phone Type:";
            // 
            // invoiceInformationRequestTimeOfServiceLabel
            // 
            this.invoiceInformationRequestTimeOfServiceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationRequestTimeOfServiceLabel.Location = new System.Drawing.Point(143, 467);
            this.invoiceInformationRequestTimeOfServiceLabel.Name = "invoiceInformationRequestTimeOfServiceLabel";
            this.invoiceInformationRequestTimeOfServiceLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationRequestTimeOfServiceLabel.TabIndex = 1015;
            this.invoiceInformationRequestTimeOfServiceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationEmailLabel
            // 
            this.invoiceInformationEmailLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationEmailLabel.Location = new System.Drawing.Point(143, 292);
            this.invoiceInformationEmailLabel.Name = "invoiceInformationEmailLabel";
            this.invoiceInformationEmailLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationEmailLabel.TabIndex = 1011;
            this.invoiceInformationEmailLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationEmailLabelPrompt
            // 
            this.invoiceInformationEmailLabelPrompt.AutoSize = true;
            this.invoiceInformationEmailLabelPrompt.Location = new System.Drawing.Point(6, 295);
            this.invoiceInformationEmailLabelPrompt.Name = "invoiceInformationEmailLabelPrompt";
            this.invoiceInformationEmailLabelPrompt.Size = new System.Drawing.Size(35, 13);
            this.invoiceInformationEmailLabelPrompt.TabIndex = 1029;
            this.invoiceInformationEmailLabelPrompt.Text = "Email:";
            // 
            // invoiceInformationDescriptionLabelPrompt
            // 
            this.invoiceInformationDescriptionLabelPrompt.AutoSize = true;
            this.invoiceInformationDescriptionLabelPrompt.Location = new System.Drawing.Point(6, 349);
            this.invoiceInformationDescriptionLabelPrompt.Name = "invoiceInformationDescriptionLabelPrompt";
            this.invoiceInformationDescriptionLabelPrompt.Size = new System.Drawing.Size(214, 13);
            this.invoiceInformationDescriptionLabelPrompt.TabIndex = 1028;
            this.invoiceInformationDescriptionLabelPrompt.Text = "Description of Request (Including Location):";
            // 
            // invoiceInformationPrimaryPhoneExtensionLabel
            // 
            this.invoiceInformationPrimaryPhoneExtensionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationPrimaryPhoneExtensionLabel.Location = new System.Drawing.Point(143, 157);
            this.invoiceInformationPrimaryPhoneExtensionLabel.Name = "invoiceInformationPrimaryPhoneExtensionLabel";
            this.invoiceInformationPrimaryPhoneExtensionLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationPrimaryPhoneExtensionLabel.TabIndex = 1006;
            this.invoiceInformationPrimaryPhoneExtensionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationPrimaryPhoneExtensionLabelPrompt
            // 
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.AutoSize = true;
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.Location = new System.Drawing.Point(6, 160);
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.Name = "invoiceInformationPrimaryPhoneExtensionLabelPrompt";
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.Size = new System.Drawing.Size(127, 13);
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.TabIndex = 1027;
            this.invoiceInformationPrimaryPhoneExtensionLabelPrompt.Text = "Primary Phone Extension:";
            // 
            // invoiceInformationAlternatePhoneTypeLabel
            // 
            this.invoiceInformationAlternatePhoneTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationAlternatePhoneTypeLabel.Location = new System.Drawing.Point(143, 265);
            this.invoiceInformationAlternatePhoneTypeLabel.Name = "invoiceInformationAlternatePhoneTypeLabel";
            this.invoiceInformationAlternatePhoneTypeLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationAlternatePhoneTypeLabel.TabIndex = 1010;
            this.invoiceInformationAlternatePhoneTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationAnimalsLabel
            // 
            this.invoiceInformationAnimalsLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationAnimalsLabel.Location = new System.Drawing.Point(143, 521);
            this.invoiceInformationAnimalsLabel.Name = "invoiceInformationAnimalsLabel";
            this.invoiceInformationAnimalsLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationAnimalsLabel.TabIndex = 1017;
            this.invoiceInformationAnimalsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationAlternatePhoneTypeLabelPrompt
            // 
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.AutoSize = true;
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.Location = new System.Drawing.Point(6, 268);
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.Name = "invoiceInformationAlternatePhoneTypeLabelPrompt";
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.Size = new System.Drawing.Size(113, 13);
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.TabIndex = 1022;
            this.invoiceInformationAlternatePhoneTypeLabelPrompt.Text = "Alternate Phone Type:";
            // 
            // invoiceInformationWorkOrderTypeLabel
            // 
            this.invoiceInformationWorkOrderTypeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationWorkOrderTypeLabel.Location = new System.Drawing.Point(143, 319);
            this.invoiceInformationWorkOrderTypeLabel.Name = "invoiceInformationWorkOrderTypeLabel";
            this.invoiceInformationWorkOrderTypeLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationWorkOrderTypeLabel.TabIndex = 1013;
            this.invoiceInformationWorkOrderTypeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationWorkOrderTypeLabelPrompt
            // 
            this.invoiceInformationWorkOrderTypeLabelPrompt.AutoSize = true;
            this.invoiceInformationWorkOrderTypeLabelPrompt.Location = new System.Drawing.Point(6, 323);
            this.invoiceInformationWorkOrderTypeLabelPrompt.Name = "invoiceInformationWorkOrderTypeLabelPrompt";
            this.invoiceInformationWorkOrderTypeLabelPrompt.Size = new System.Drawing.Size(89, 13);
            this.invoiceInformationWorkOrderTypeLabelPrompt.TabIndex = 1025;
            this.invoiceInformationWorkOrderTypeLabelPrompt.Text = "Work Order Type";
            // 
            // invoiceInformationAnimalsLabelPrompt
            // 
            this.invoiceInformationAnimalsLabelPrompt.AutoSize = true;
            this.invoiceInformationAnimalsLabelPrompt.Location = new System.Drawing.Point(6, 521);
            this.invoiceInformationAnimalsLabelPrompt.Name = "invoiceInformationAnimalsLabelPrompt";
            this.invoiceInformationAnimalsLabelPrompt.Size = new System.Drawing.Size(88, 13);
            this.invoiceInformationAnimalsLabelPrompt.TabIndex = 1024;
            this.invoiceInformationAnimalsLabelPrompt.Text = "Animals in Home:";
            // 
            // invoiceInformationPrimaryPhoneNumberLabel
            // 
            this.invoiceInformationPrimaryPhoneNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationPrimaryPhoneNumberLabel.Location = new System.Drawing.Point(143, 130);
            this.invoiceInformationPrimaryPhoneNumberLabel.Name = "invoiceInformationPrimaryPhoneNumberLabel";
            this.invoiceInformationPrimaryPhoneNumberLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationPrimaryPhoneNumberLabel.TabIndex = 1005;
            this.invoiceInformationPrimaryPhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationPrimaryPhoneNumberLabelPrompt
            // 
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.AutoSize = true;
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.Location = new System.Drawing.Point(6, 133);
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.Name = "invoiceInformationPrimaryPhoneNumberLabelPrompt";
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.Size = new System.Drawing.Size(118, 13);
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.TabIndex = 1033;
            this.invoiceInformationPrimaryPhoneNumberLabelPrompt.Text = "Primary Phone Number:";
            // 
            // invoiceInformationAlternatePhoneExtensionLabel
            // 
            this.invoiceInformationAlternatePhoneExtensionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationAlternatePhoneExtensionLabel.Location = new System.Drawing.Point(143, 238);
            this.invoiceInformationAlternatePhoneExtensionLabel.Name = "invoiceInformationAlternatePhoneExtensionLabel";
            this.invoiceInformationAlternatePhoneExtensionLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationAlternatePhoneExtensionLabel.TabIndex = 1009;
            this.invoiceInformationAlternatePhoneExtensionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationAlternatePhoneExtensionLabelPrompt
            // 
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.AutoSize = true;
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.Location = new System.Drawing.Point(6, 241);
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.Name = "invoiceInformationAlternatePhoneExtensionLabelPrompt";
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.Size = new System.Drawing.Size(135, 13);
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.TabIndex = 1021;
            this.invoiceInformationAlternatePhoneExtensionLabelPrompt.Text = "Alternate Phone Extension:";
            // 
            // invoiceInformationLastNameLabel
            // 
            this.invoiceInformationLastNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationLastNameLabel.Location = new System.Drawing.Point(143, 50);
            this.invoiceInformationLastNameLabel.Name = "invoiceInformationLastNameLabel";
            this.invoiceInformationLastNameLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationLastNameLabel.TabIndex = 1002;
            this.invoiceInformationLastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationLastNameLabelPrompt
            // 
            this.invoiceInformationLastNameLabelPrompt.AutoSize = true;
            this.invoiceInformationLastNameLabelPrompt.Location = new System.Drawing.Point(6, 53);
            this.invoiceInformationLastNameLabelPrompt.Name = "invoiceInformationLastNameLabelPrompt";
            this.invoiceInformationLastNameLabelPrompt.Size = new System.Drawing.Size(61, 13);
            this.invoiceInformationLastNameLabelPrompt.TabIndex = 1020;
            this.invoiceInformationLastNameLabelPrompt.Text = "Last Name:";
            // 
            // invoiceInformationPermissionToEnterLabelPrompt
            // 
            this.invoiceInformationPermissionToEnterLabelPrompt.AutoSize = true;
            this.invoiceInformationPermissionToEnterLabelPrompt.Location = new System.Drawing.Point(6, 495);
            this.invoiceInformationPermissionToEnterLabelPrompt.Name = "invoiceInformationPermissionToEnterLabelPrompt";
            this.invoiceInformationPermissionToEnterLabelPrompt.Size = new System.Drawing.Size(130, 13);
            this.invoiceInformationPermissionToEnterLabelPrompt.TabIndex = 1019;
            this.invoiceInformationPermissionToEnterLabelPrompt.Text = "Permission to Enter (PTE):";
            // 
            // invoiceInformationFirstNameLabel
            // 
            this.invoiceInformationFirstNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationFirstNameLabel.Location = new System.Drawing.Point(143, 23);
            this.invoiceInformationFirstNameLabel.Name = "invoiceInformationFirstNameLabel";
            this.invoiceInformationFirstNameLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationFirstNameLabel.TabIndex = 1001;
            this.invoiceInformationFirstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationAlternatePhoneNumberLabel
            // 
            this.invoiceInformationAlternatePhoneNumberLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationAlternatePhoneNumberLabel.Location = new System.Drawing.Point(143, 211);
            this.invoiceInformationAlternatePhoneNumberLabel.Name = "invoiceInformationAlternatePhoneNumberLabel";
            this.invoiceInformationAlternatePhoneNumberLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationAlternatePhoneNumberLabel.TabIndex = 1008;
            this.invoiceInformationAlternatePhoneNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationFirstNameLabelPrompt
            // 
            this.invoiceInformationFirstNameLabelPrompt.AutoSize = true;
            this.invoiceInformationFirstNameLabelPrompt.Location = new System.Drawing.Point(6, 26);
            this.invoiceInformationFirstNameLabelPrompt.Name = "invoiceInformationFirstNameLabelPrompt";
            this.invoiceInformationFirstNameLabelPrompt.Size = new System.Drawing.Size(60, 13);
            this.invoiceInformationFirstNameLabelPrompt.TabIndex = 1034;
            this.invoiceInformationFirstNameLabelPrompt.Text = "First Name:";
            // 
            // invoiceInformationCommunityLabel
            // 
            this.invoiceInformationCommunityLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationCommunityLabel.Location = new System.Drawing.Point(143, 104);
            this.invoiceInformationCommunityLabel.Name = "invoiceInformationCommunityLabel";
            this.invoiceInformationCommunityLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationCommunityLabel.TabIndex = 1004;
            this.invoiceInformationCommunityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationAlternatePhoneNumberLabelPrompt
            // 
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.AutoSize = true;
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.Location = new System.Drawing.Point(6, 214);
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.Name = "invoiceInformationAlternatePhoneNumberLabelPrompt";
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.Size = new System.Drawing.Size(126, 13);
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.TabIndex = 1018;
            this.invoiceInformationAlternatePhoneNumberLabelPrompt.Text = "Alternate Phone Number:";
            // 
            // invoiceInformationStreetAddressLabel
            // 
            this.invoiceInformationStreetAddressLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.invoiceInformationStreetAddressLabel.Location = new System.Drawing.Point(143, 77);
            this.invoiceInformationStreetAddressLabel.Name = "invoiceInformationStreetAddressLabel";
            this.invoiceInformationStreetAddressLabel.Size = new System.Drawing.Size(178, 19);
            this.invoiceInformationStreetAddressLabel.TabIndex = 1003;
            this.invoiceInformationStreetAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // invoiceInformationCommunityLabelPrompt
            // 
            this.invoiceInformationCommunityLabelPrompt.AutoSize = true;
            this.invoiceInformationCommunityLabelPrompt.Location = new System.Drawing.Point(6, 107);
            this.invoiceInformationCommunityLabelPrompt.Name = "invoiceInformationCommunityLabelPrompt";
            this.invoiceInformationCommunityLabelPrompt.Size = new System.Drawing.Size(61, 13);
            this.invoiceInformationCommunityLabelPrompt.TabIndex = 1026;
            this.invoiceInformationCommunityLabelPrompt.Text = "Community:";
            // 
            // invoiceInformationStreetAddressLabelPrompt
            // 
            this.invoiceInformationStreetAddressLabelPrompt.AutoSize = true;
            this.invoiceInformationStreetAddressLabelPrompt.Location = new System.Drawing.Point(6, 80);
            this.invoiceInformationStreetAddressLabelPrompt.Name = "invoiceInformationStreetAddressLabelPrompt";
            this.invoiceInformationStreetAddressLabelPrompt.Size = new System.Drawing.Size(79, 13);
            this.invoiceInformationStreetAddressLabelPrompt.TabIndex = 1023;
            this.invoiceInformationStreetAddressLabelPrompt.Text = "Street Address:";
            // 
            // invoiceInformationGroupBox
            // 
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationFirstNameLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationCancelButton);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationStreetAddressLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.printInvoiceButton);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationCommunityLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationDescriptionOfRequestRichTextBox);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationStreetAddressLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPermissionToEnterLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneNumberLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationCommunityLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneNumberLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationRequestTimeOfServiceLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationFirstNameLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneTypeLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPermissionToEnterLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneTypeLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationLastNameLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationRequestTimeOfServiceLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationLastNameLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationEmailLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneExtensionLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationEmailLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneExtensionLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationDescriptionLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneNumberLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneExtensionLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneNumberLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationPrimaryPhoneExtensionLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAnimalsLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneTypeLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationWorkOrderTypeLabelPrompt);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAnimalsLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationWorkOrderTypeLabel);
            this.invoiceInformationGroupBox.Controls.Add(this.invoiceInformationAlternatePhoneTypeLabelPrompt);
            this.invoiceInformationGroupBox.Location = new System.Drawing.Point(302, 9);
            this.invoiceInformationGroupBox.Name = "invoiceInformationGroupBox";
            this.invoiceInformationGroupBox.Size = new System.Drawing.Size(324, 601);
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
            this.gbxCommentsAndStatus.Location = new System.Drawing.Point(15, 411);
            this.gbxCommentsAndStatus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCommentsAndStatus.Name = "gbxCommentsAndStatus";
            this.gbxCommentsAndStatus.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbxCommentsAndStatus.Size = new System.Drawing.Size(282, 158);
            this.gbxCommentsAndStatus.TabIndex = 1038;
            this.gbxCommentsAndStatus.TabStop = false;
            this.gbxCommentsAndStatus.Text = "Status of Work Order";
            // 
            // rTxtBoxComments
            // 
            this.rTxtBoxComments.Location = new System.Drawing.Point(8, 58);
            this.rTxtBoxComments.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rTxtBoxComments.Name = "rTxtBoxComments";
            this.rTxtBoxComments.ReadOnly = true;
            this.rTxtBoxComments.Size = new System.Drawing.Size(271, 97);
            this.rTxtBoxComments.TabIndex = 3;
            this.rTxtBoxComments.Text = "";
            // 
            // lblCommentsPrompt
            // 
            this.lblCommentsPrompt.AutoSize = true;
            this.lblCommentsPrompt.Location = new System.Drawing.Point(5, 41);
            this.lblCommentsPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCommentsPrompt.Name = "lblCommentsPrompt";
            this.lblCommentsPrompt.Size = new System.Drawing.Size(59, 13);
            this.lblCommentsPrompt.TabIndex = 2;
            this.lblCommentsPrompt.Text = "Comments:\r\n";
            // 
            // rButtonIncomplete
            // 
            this.rButtonIncomplete.AutoSize = true;
            this.rButtonIncomplete.Location = new System.Drawing.Point(93, 18);
            this.rButtonIncomplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rButtonIncomplete.Name = "rButtonIncomplete";
            this.rButtonIncomplete.Size = new System.Drawing.Size(77, 17);
            this.rButtonIncomplete.TabIndex = 1;
            this.rButtonIncomplete.Text = "Incomplete";
            this.rButtonIncomplete.UseVisualStyleBackColor = true;
            // 
            // rButtonComplete
            // 
            this.rButtonComplete.AutoSize = true;
            this.rButtonComplete.Location = new System.Drawing.Point(5, 18);
            this.rButtonComplete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rButtonComplete.Name = "rButtonComplete";
            this.rButtonComplete.Size = new System.Drawing.Size(69, 17);
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
            // WorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 613);
            this.Controls.Add(this.gbxCommentsAndStatus);
            this.Controls.Add(this.invoiceInformationGroupBox);
            this.Controls.Add(this.newInvoiceButtonLabelPrompt);
            this.Controls.Add(this.invoiceDatabaseListBox);
            this.Controls.Add(this.newInvoiceButton);
            this.Controls.Add(this.invoiceDatabaseListboxLabelPrompt);
            this.Name = "WorkOrderForm";
            this.Text = "Work Order Information";
            this.invoiceInformationGroupBox.ResumeLayout(false);
            this.invoiceInformationGroupBox.PerformLayout();
            this.gbxCommentsAndStatus.ResumeLayout(false);
            this.gbxCommentsAndStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox invoiceDatabaseListBox;
        private System.Windows.Forms.Label invoiceDatabaseListboxLabelPrompt;
        private System.Windows.Forms.Button newInvoiceButton;
        private System.Windows.Forms.Label newInvoiceButtonLabelPrompt;
        private System.Windows.Forms.Button invoiceInformationCancelButton;
        private System.Windows.Forms.Button printInvoiceButton;
        private System.Windows.Forms.RichTextBox invoiceInformationDescriptionOfRequestRichTextBox;
        private System.Windows.Forms.Label invoiceInformationPermissionToEnterLabel;
        private System.Windows.Forms.Label invoiceInformationRequestTimeOfServiceLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationPrimaryPhoneTypeLabel;
        private System.Windows.Forms.Label invoiceInformationPrimaryPhoneTypeLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationRequestTimeOfServiceLabel;
        private System.Windows.Forms.Label invoiceInformationEmailLabel;
        private System.Windows.Forms.Label invoiceInformationEmailLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationDescriptionLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationPrimaryPhoneExtensionLabel;
        private System.Windows.Forms.Label invoiceInformationPrimaryPhoneExtensionLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationAlternatePhoneTypeLabel;
        private System.Windows.Forms.Label invoiceInformationAnimalsLabel;
        private System.Windows.Forms.Label invoiceInformationAlternatePhoneTypeLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationWorkOrderTypeLabel;
        private System.Windows.Forms.Label invoiceInformationWorkOrderTypeLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationAnimalsLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationPrimaryPhoneNumberLabel;
        private System.Windows.Forms.Label invoiceInformationPrimaryPhoneNumberLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationAlternatePhoneExtensionLabel;
        private System.Windows.Forms.Label invoiceInformationAlternatePhoneExtensionLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationLastNameLabel;
        private System.Windows.Forms.Label invoiceInformationLastNameLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationPermissionToEnterLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationFirstNameLabel;
        private System.Windows.Forms.Label invoiceInformationAlternatePhoneNumberLabel;
        private System.Windows.Forms.Label invoiceInformationFirstNameLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationCommunityLabel;
        private System.Windows.Forms.Label invoiceInformationAlternatePhoneNumberLabelPrompt;
        private System.Windows.Forms.Label invoiceInformationStreetAddressLabel;
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
    }
}