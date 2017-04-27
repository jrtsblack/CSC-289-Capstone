namespace Invoice
{
    partial class NewWorkOrderForm
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
            this.titlePrompt = new System.Windows.Forms.Label();
            this.submitInvoiceButton = new System.Windows.Forms.Button();
            this.clearFieldsButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.newInvoiceRequestTimeOfServiceLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoicePrimaryPhoneTypeLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceEmailLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceDescriptionLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoicePrimaryPhoneExtensionLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceAlternatePhoneTypeLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceWorkOrderTypeLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceAnimalsLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoicePrimaryPhoneNumberLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceAlternatePhoneExtensionLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceLastNameLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoicePermissionToEnterLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceFirstNameLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceAlternatePhoneNumberLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceStreetAddressLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.newInvoiceLastNameTextBox = new System.Windows.Forms.TextBox();
            this.newInvoiceStreetAddressTextBox = new System.Windows.Forms.TextBox();
            this.newInvoicePrimaryPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.newInvoicePrimaryPhoneExtensionTextBox = new System.Windows.Forms.TextBox();
            this.newInvoiceAlternatePhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.newInvoiceAlternatePhoneExtensionTextBox = new System.Windows.Forms.TextBox();
            this.newInvoiceEmailTextBox = new System.Windows.Forms.TextBox();
            this.newInvoiceCommunityLabelPrompt = new System.Windows.Forms.Label();
            this.newInvoiceCommunityComboBox = new System.Windows.Forms.ComboBox();
            this.newInvoicePrimaryPhoneTypeComboBox = new System.Windows.Forms.ComboBox();
            this.newInvoiceAlternatePhoneTypeComboBox = new System.Windows.Forms.ComboBox();
            this.newInvoiceWorkOrderTypeComboBox = new System.Windows.Forms.ComboBox();
            this.newInvoiceDescriptionOfRequestRichTextBox = new System.Windows.Forms.RichTextBox();
            this.newInvoicePermissionToEnterComboBox = new System.Windows.Forms.ComboBox();
            this.newInvoiceAnimalsInHomeComboBox = new System.Windows.Forms.ComboBox();
            this.newInvoiceRequestTimeOfServiceComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // titlePrompt
            // 
            this.titlePrompt.Location = new System.Drawing.Point(13, 18);
            this.titlePrompt.Name = "titlePrompt";
            this.titlePrompt.Size = new System.Drawing.Size(320, 31);
            this.titlePrompt.TabIndex = 99;
            this.titlePrompt.Text = "Please enter the information requested below then click Save. \r\nThis will create " +
    "a new invoice.\r\n";
            // 
            // submitInvoiceButton
            // 
            this.submitInvoiceButton.Location = new System.Drawing.Point(57, 584);
            this.submitInvoiceButton.Name = "submitInvoiceButton";
            this.submitInvoiceButton.Size = new System.Drawing.Size(75, 23);
            this.submitInvoiceButton.TabIndex = 16;
            this.submitInvoiceButton.Text = "Submit";
            this.submitInvoiceButton.UseVisualStyleBackColor = true;
            this.submitInvoiceButton.Click += new System.EventHandler(this.saveInvoiceButton_Click);
            // 
            // clearFieldsButton
            // 
            this.clearFieldsButton.Location = new System.Drawing.Point(138, 584);
            this.clearFieldsButton.Name = "clearFieldsButton";
            this.clearFieldsButton.Size = new System.Drawing.Size(75, 23);
            this.clearFieldsButton.TabIndex = 17;
            this.clearFieldsButton.Text = "Clear Fields";
            this.clearFieldsButton.UseVisualStyleBackColor = true;
            this.clearFieldsButton.Click += new System.EventHandler(this.clearFieldsButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(219, 584);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 18;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // newInvoiceRequestTimeOfServiceLabelPrompt
            // 
            this.newInvoiceRequestTimeOfServiceLabelPrompt.AutoSize = true;
            this.newInvoiceRequestTimeOfServiceLabelPrompt.Location = new System.Drawing.Point(9, 507);
            this.newInvoiceRequestTimeOfServiceLabelPrompt.Name = "newInvoiceRequestTimeOfServiceLabelPrompt";
            this.newInvoiceRequestTimeOfServiceLabelPrompt.Size = new System.Drawing.Size(127, 13);
            this.newInvoiceRequestTimeOfServiceLabelPrompt.TabIndex = 399;
            this.newInvoiceRequestTimeOfServiceLabelPrompt.Text = "Request Time of Service:";
            // 
            // newInvoicePrimaryPhoneTypeLabelPrompt
            // 
            this.newInvoicePrimaryPhoneTypeLabelPrompt.AutoSize = true;
            this.newInvoicePrimaryPhoneTypeLabelPrompt.Location = new System.Drawing.Point(13, 216);
            this.newInvoicePrimaryPhoneTypeLabelPrompt.Name = "newInvoicePrimaryPhoneTypeLabelPrompt";
            this.newInvoicePrimaryPhoneTypeLabelPrompt.Size = new System.Drawing.Size(105, 13);
            this.newInvoicePrimaryPhoneTypeLabelPrompt.TabIndex = 99;
            this.newInvoicePrimaryPhoneTypeLabelPrompt.Text = "Primary Phone Type:";
            // 
            // newInvoiceEmailLabelPrompt
            // 
            this.newInvoiceEmailLabelPrompt.AutoSize = true;
            this.newInvoiceEmailLabelPrompt.Location = new System.Drawing.Point(13, 324);
            this.newInvoiceEmailLabelPrompt.Name = "newInvoiceEmailLabelPrompt";
            this.newInvoiceEmailLabelPrompt.Size = new System.Drawing.Size(35, 13);
            this.newInvoiceEmailLabelPrompt.TabIndex = 59;
            this.newInvoiceEmailLabelPrompt.Text = "Email:";
            // 
            // newInvoiceDescriptionLabelPrompt
            // 
            this.newInvoiceDescriptionLabelPrompt.AutoSize = true;
            this.newInvoiceDescriptionLabelPrompt.Location = new System.Drawing.Point(13, 377);
            this.newInvoiceDescriptionLabelPrompt.Name = "newInvoiceDescriptionLabelPrompt";
            this.newInvoiceDescriptionLabelPrompt.Size = new System.Drawing.Size(214, 13);
            this.newInvoiceDescriptionLabelPrompt.TabIndex = 699;
            this.newInvoiceDescriptionLabelPrompt.Text = "Description of Request (Including Location):";
            // 
            // newInvoicePrimaryPhoneExtensionLabelPrompt
            // 
            this.newInvoicePrimaryPhoneExtensionLabelPrompt.AutoSize = true;
            this.newInvoicePrimaryPhoneExtensionLabelPrompt.Location = new System.Drawing.Point(13, 189);
            this.newInvoicePrimaryPhoneExtensionLabelPrompt.Name = "newInvoicePrimaryPhoneExtensionLabelPrompt";
            this.newInvoicePrimaryPhoneExtensionLabelPrompt.Size = new System.Drawing.Size(127, 13);
            this.newInvoicePrimaryPhoneExtensionLabelPrompt.TabIndex = 99;
            this.newInvoicePrimaryPhoneExtensionLabelPrompt.Text = "Primary Phone Extension:";
            // 
            // newInvoiceAlternatePhoneTypeLabelPrompt
            // 
            this.newInvoiceAlternatePhoneTypeLabelPrompt.AutoSize = true;
            this.newInvoiceAlternatePhoneTypeLabelPrompt.Location = new System.Drawing.Point(13, 297);
            this.newInvoiceAlternatePhoneTypeLabelPrompt.Name = "newInvoiceAlternatePhoneTypeLabelPrompt";
            this.newInvoiceAlternatePhoneTypeLabelPrompt.Size = new System.Drawing.Size(113, 13);
            this.newInvoiceAlternatePhoneTypeLabelPrompt.TabIndex = 99;
            this.newInvoiceAlternatePhoneTypeLabelPrompt.Text = "Alternate Phone Type:";
            // 
            // newInvoiceWorkOrderTypeLabelPrompt
            // 
            this.newInvoiceWorkOrderTypeLabelPrompt.AutoSize = true;
            this.newInvoiceWorkOrderTypeLabelPrompt.Location = new System.Drawing.Point(13, 350);
            this.newInvoiceWorkOrderTypeLabelPrompt.Name = "newInvoiceWorkOrderTypeLabelPrompt";
            this.newInvoiceWorkOrderTypeLabelPrompt.Size = new System.Drawing.Size(89, 13);
            this.newInvoiceWorkOrderTypeLabelPrompt.TabIndex = 99;
            this.newInvoiceWorkOrderTypeLabelPrompt.Text = "Work Order Type";
            // 
            // newInvoiceAnimalsLabelPrompt
            // 
            this.newInvoiceAnimalsLabelPrompt.AutoSize = true;
            this.newInvoiceAnimalsLabelPrompt.Location = new System.Drawing.Point(9, 561);
            this.newInvoiceAnimalsLabelPrompt.Name = "newInvoiceAnimalsLabelPrompt";
            this.newInvoiceAnimalsLabelPrompt.Size = new System.Drawing.Size(88, 13);
            this.newInvoiceAnimalsLabelPrompt.TabIndex = 1099;
            this.newInvoiceAnimalsLabelPrompt.Text = "Animals in Home:";
            // 
            // newInvoicePrimaryPhoneNumberLabelPrompt
            // 
            this.newInvoicePrimaryPhoneNumberLabelPrompt.AutoSize = true;
            this.newInvoicePrimaryPhoneNumberLabelPrompt.Location = new System.Drawing.Point(13, 162);
            this.newInvoicePrimaryPhoneNumberLabelPrompt.Name = "newInvoicePrimaryPhoneNumberLabelPrompt";
            this.newInvoicePrimaryPhoneNumberLabelPrompt.Size = new System.Drawing.Size(118, 13);
            this.newInvoicePrimaryPhoneNumberLabelPrompt.TabIndex = 99;
            this.newInvoicePrimaryPhoneNumberLabelPrompt.Text = "Primary Phone Number:";
            // 
            // newInvoiceAlternatePhoneExtensionLabelPrompt
            // 
            this.newInvoiceAlternatePhoneExtensionLabelPrompt.AutoSize = true;
            this.newInvoiceAlternatePhoneExtensionLabelPrompt.Location = new System.Drawing.Point(13, 270);
            this.newInvoiceAlternatePhoneExtensionLabelPrompt.Name = "newInvoiceAlternatePhoneExtensionLabelPrompt";
            this.newInvoiceAlternatePhoneExtensionLabelPrompt.Size = new System.Drawing.Size(135, 13);
            this.newInvoiceAlternatePhoneExtensionLabelPrompt.TabIndex = 99;
            this.newInvoiceAlternatePhoneExtensionLabelPrompt.Text = "Alternate Phone Extension:";
            // 
            // newInvoiceLastNameLabelPrompt
            // 
            this.newInvoiceLastNameLabelPrompt.AutoSize = true;
            this.newInvoiceLastNameLabelPrompt.Location = new System.Drawing.Point(13, 82);
            this.newInvoiceLastNameLabelPrompt.Name = "newInvoiceLastNameLabelPrompt";
            this.newInvoiceLastNameLabelPrompt.Size = new System.Drawing.Size(61, 13);
            this.newInvoiceLastNameLabelPrompt.TabIndex = 99;
            this.newInvoiceLastNameLabelPrompt.Text = "Last Name:";
            // 
            // newInvoicePermissionToEnterLabelPrompt
            // 
            this.newInvoicePermissionToEnterLabelPrompt.AutoSize = true;
            this.newInvoicePermissionToEnterLabelPrompt.Location = new System.Drawing.Point(9, 535);
            this.newInvoicePermissionToEnterLabelPrompt.Name = "newInvoicePermissionToEnterLabelPrompt";
            this.newInvoicePermissionToEnterLabelPrompt.Size = new System.Drawing.Size(130, 13);
            this.newInvoicePermissionToEnterLabelPrompt.TabIndex = 149;
            this.newInvoicePermissionToEnterLabelPrompt.Text = "Permission to Enter (PTE):";
            // 
            // newInvoiceFirstNameLabelPrompt
            // 
            this.newInvoiceFirstNameLabelPrompt.AutoSize = true;
            this.newInvoiceFirstNameLabelPrompt.Location = new System.Drawing.Point(13, 55);
            this.newInvoiceFirstNameLabelPrompt.Name = "newInvoiceFirstNameLabelPrompt";
            this.newInvoiceFirstNameLabelPrompt.Size = new System.Drawing.Size(60, 13);
            this.newInvoiceFirstNameLabelPrompt.TabIndex = 99;
            this.newInvoiceFirstNameLabelPrompt.Text = "First Name:";
            // 
            // newInvoiceAlternatePhoneNumberLabelPrompt
            // 
            this.newInvoiceAlternatePhoneNumberLabelPrompt.AutoSize = true;
            this.newInvoiceAlternatePhoneNumberLabelPrompt.Location = new System.Drawing.Point(13, 243);
            this.newInvoiceAlternatePhoneNumberLabelPrompt.Name = "newInvoiceAlternatePhoneNumberLabelPrompt";
            this.newInvoiceAlternatePhoneNumberLabelPrompt.Size = new System.Drawing.Size(126, 13);
            this.newInvoiceAlternatePhoneNumberLabelPrompt.TabIndex = 99;
            this.newInvoiceAlternatePhoneNumberLabelPrompt.Text = "Alternate Phone Number:";
            // 
            // newInvoiceStreetAddressLabelPrompt
            // 
            this.newInvoiceStreetAddressLabelPrompt.AutoSize = true;
            this.newInvoiceStreetAddressLabelPrompt.Location = new System.Drawing.Point(13, 108);
            this.newInvoiceStreetAddressLabelPrompt.Name = "newInvoiceStreetAddressLabelPrompt";
            this.newInvoiceStreetAddressLabelPrompt.Size = new System.Drawing.Size(79, 13);
            this.newInvoiceStreetAddressLabelPrompt.TabIndex = 99;
            this.newInvoiceStreetAddressLabelPrompt.Text = "Street Address:";
            // 
            // newInvoiceFirstNameTextBox
            // 
            this.newInvoiceFirstNameTextBox.Location = new System.Drawing.Point(174, 52);
            this.newInvoiceFirstNameTextBox.Name = "newInvoiceFirstNameTextBox";
            this.newInvoiceFirstNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.newInvoiceFirstNameTextBox.TabIndex = 0;
            // 
            // newInvoiceLastNameTextBox
            // 
            this.newInvoiceLastNameTextBox.Location = new System.Drawing.Point(174, 79);
            this.newInvoiceLastNameTextBox.Name = "newInvoiceLastNameTextBox";
            this.newInvoiceLastNameTextBox.Size = new System.Drawing.Size(185, 20);
            this.newInvoiceLastNameTextBox.TabIndex = 1;
            // 
            // newInvoiceStreetAddressTextBox
            // 
            this.newInvoiceStreetAddressTextBox.Location = new System.Drawing.Point(174, 105);
            this.newInvoiceStreetAddressTextBox.Name = "newInvoiceStreetAddressTextBox";
            this.newInvoiceStreetAddressTextBox.Size = new System.Drawing.Size(185, 20);
            this.newInvoiceStreetAddressTextBox.TabIndex = 2;
            // 
            // newInvoicePrimaryPhoneNumberTextBox
            // 
            this.newInvoicePrimaryPhoneNumberTextBox.Location = new System.Drawing.Point(174, 159);
            this.newInvoicePrimaryPhoneNumberTextBox.MaxLength = 12;
            this.newInvoicePrimaryPhoneNumberTextBox.Name = "newInvoicePrimaryPhoneNumberTextBox";
            this.newInvoicePrimaryPhoneNumberTextBox.Size = new System.Drawing.Size(185, 20);
            this.newInvoicePrimaryPhoneNumberTextBox.TabIndex = 4;
            this.newInvoicePrimaryPhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newInvoicePrimaryPhoneNumberTextBox_KeyPress);
            // 
            // newInvoicePrimaryPhoneExtensionTextBox
            // 
            this.newInvoicePrimaryPhoneExtensionTextBox.Location = new System.Drawing.Point(174, 186);
            this.newInvoicePrimaryPhoneExtensionTextBox.Name = "newInvoicePrimaryPhoneExtensionTextBox";
            this.newInvoicePrimaryPhoneExtensionTextBox.Size = new System.Drawing.Size(185, 20);
            this.newInvoicePrimaryPhoneExtensionTextBox.TabIndex = 5;
            // 
            // newInvoiceAlternatePhoneNumberTextBox
            // 
            this.newInvoiceAlternatePhoneNumberTextBox.Location = new System.Drawing.Point(174, 240);
            this.newInvoiceAlternatePhoneNumberTextBox.MaxLength = 12;
            this.newInvoiceAlternatePhoneNumberTextBox.Name = "newInvoiceAlternatePhoneNumberTextBox";
            this.newInvoiceAlternatePhoneNumberTextBox.Size = new System.Drawing.Size(185, 20);
            this.newInvoiceAlternatePhoneNumberTextBox.TabIndex = 7;
            this.newInvoiceAlternatePhoneNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.newInvoiceAlternatePhoneNumberTextBox_KeyPress);
            // 
            // newInvoiceAlternatePhoneExtensionTextBox
            // 
            this.newInvoiceAlternatePhoneExtensionTextBox.Location = new System.Drawing.Point(174, 267);
            this.newInvoiceAlternatePhoneExtensionTextBox.Name = "newInvoiceAlternatePhoneExtensionTextBox";
            this.newInvoiceAlternatePhoneExtensionTextBox.Size = new System.Drawing.Size(185, 20);
            this.newInvoiceAlternatePhoneExtensionTextBox.TabIndex = 8;
            // 
            // newInvoiceEmailTextBox
            // 
            this.newInvoiceEmailTextBox.Location = new System.Drawing.Point(174, 321);
            this.newInvoiceEmailTextBox.Name = "newInvoiceEmailTextBox";
            this.newInvoiceEmailTextBox.Size = new System.Drawing.Size(185, 20);
            this.newInvoiceEmailTextBox.TabIndex = 10;
            // 
            // newInvoiceCommunityLabelPrompt
            // 
            this.newInvoiceCommunityLabelPrompt.AutoSize = true;
            this.newInvoiceCommunityLabelPrompt.Location = new System.Drawing.Point(13, 134);
            this.newInvoiceCommunityLabelPrompt.Name = "newInvoiceCommunityLabelPrompt";
            this.newInvoiceCommunityLabelPrompt.Size = new System.Drawing.Size(61, 13);
            this.newInvoiceCommunityLabelPrompt.TabIndex = 99;
            this.newInvoiceCommunityLabelPrompt.Text = "Community:";
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
            this.newInvoiceCommunityComboBox.Location = new System.Drawing.Point(174, 131);
            this.newInvoiceCommunityComboBox.Name = "newInvoiceCommunityComboBox";
            this.newInvoiceCommunityComboBox.Size = new System.Drawing.Size(185, 21);
            this.newInvoiceCommunityComboBox.TabIndex = 3;
            // 
            // newInvoicePrimaryPhoneTypeComboBox
            // 
            this.newInvoicePrimaryPhoneTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newInvoicePrimaryPhoneTypeComboBox.FormattingEnabled = true;
            this.newInvoicePrimaryPhoneTypeComboBox.Items.AddRange(new object[] {
            "Home",
            "Work",
            "Mobile"});
            this.newInvoicePrimaryPhoneTypeComboBox.Location = new System.Drawing.Point(174, 213);
            this.newInvoicePrimaryPhoneTypeComboBox.Name = "newInvoicePrimaryPhoneTypeComboBox";
            this.newInvoicePrimaryPhoneTypeComboBox.Size = new System.Drawing.Size(185, 21);
            this.newInvoicePrimaryPhoneTypeComboBox.TabIndex = 6;
            // 
            // newInvoiceAlternatePhoneTypeComboBox
            // 
            this.newInvoiceAlternatePhoneTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newInvoiceAlternatePhoneTypeComboBox.FormattingEnabled = true;
            this.newInvoiceAlternatePhoneTypeComboBox.Items.AddRange(new object[] {
            "None",
            "Home",
            "Work",
            "Mobile"});
            this.newInvoiceAlternatePhoneTypeComboBox.Location = new System.Drawing.Point(174, 294);
            this.newInvoiceAlternatePhoneTypeComboBox.Name = "newInvoiceAlternatePhoneTypeComboBox";
            this.newInvoiceAlternatePhoneTypeComboBox.Size = new System.Drawing.Size(185, 21);
            this.newInvoiceAlternatePhoneTypeComboBox.TabIndex = 9;
            // 
            // newInvoiceWorkOrderTypeComboBox
            // 
            this.newInvoiceWorkOrderTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newInvoiceWorkOrderTypeComboBox.FormattingEnabled = true;
            this.newInvoiceWorkOrderTypeComboBox.Items.AddRange(new object[] {
            "Plumbing",
            "Carpentry",
            "Electrical",
            "HVAC",
            "Other"});
            this.newInvoiceWorkOrderTypeComboBox.Location = new System.Drawing.Point(174, 348);
            this.newInvoiceWorkOrderTypeComboBox.Name = "newInvoiceWorkOrderTypeComboBox";
            this.newInvoiceWorkOrderTypeComboBox.Size = new System.Drawing.Size(185, 21);
            this.newInvoiceWorkOrderTypeComboBox.TabIndex = 11;
            // 
            // newInvoiceDescriptionOfRequestRichTextBox
            // 
            this.newInvoiceDescriptionOfRequestRichTextBox.Location = new System.Drawing.Point(16, 393);
            this.newInvoiceDescriptionOfRequestRichTextBox.Name = "newInvoiceDescriptionOfRequestRichTextBox";
            this.newInvoiceDescriptionOfRequestRichTextBox.Size = new System.Drawing.Size(343, 96);
            this.newInvoiceDescriptionOfRequestRichTextBox.TabIndex = 12;
            this.newInvoiceDescriptionOfRequestRichTextBox.Text = "";
            // 
            // newInvoicePermissionToEnterComboBox
            // 
            this.newInvoicePermissionToEnterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newInvoicePermissionToEnterComboBox.FormattingEnabled = true;
            this.newInvoicePermissionToEnterComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.newInvoicePermissionToEnterComboBox.Location = new System.Drawing.Point(174, 531);
            this.newInvoicePermissionToEnterComboBox.Name = "newInvoicePermissionToEnterComboBox";
            this.newInvoicePermissionToEnterComboBox.Size = new System.Drawing.Size(185, 21);
            this.newInvoicePermissionToEnterComboBox.TabIndex = 14;
            // 
            // newInvoiceAnimalsInHomeComboBox
            // 
            this.newInvoiceAnimalsInHomeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newInvoiceAnimalsInHomeComboBox.FormattingEnabled = true;
            this.newInvoiceAnimalsInHomeComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.newInvoiceAnimalsInHomeComboBox.Location = new System.Drawing.Point(174, 558);
            this.newInvoiceAnimalsInHomeComboBox.Name = "newInvoiceAnimalsInHomeComboBox";
            this.newInvoiceAnimalsInHomeComboBox.Size = new System.Drawing.Size(185, 21);
            this.newInvoiceAnimalsInHomeComboBox.TabIndex = 15;
            // 
            // newInvoiceRequestTimeOfServiceComboBox
            // 
            this.newInvoiceRequestTimeOfServiceComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "AM",
            "PM",
            "Any"});
            this.newInvoiceRequestTimeOfServiceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.newInvoiceRequestTimeOfServiceComboBox.FormattingEnabled = true;
            this.newInvoiceRequestTimeOfServiceComboBox.Items.AddRange(new object[] {
            "AM",
            "PM",
            "Any"});
            this.newInvoiceRequestTimeOfServiceComboBox.Location = new System.Drawing.Point(174, 505);
            this.newInvoiceRequestTimeOfServiceComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.newInvoiceRequestTimeOfServiceComboBox.Name = "newInvoiceRequestTimeOfServiceComboBox";
            this.newInvoiceRequestTimeOfServiceComboBox.Size = new System.Drawing.Size(185, 21);
            this.newInvoiceRequestTimeOfServiceComboBox.TabIndex = 13;
            // 
            // NewWorkOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 618);
            this.Controls.Add(this.newInvoiceRequestTimeOfServiceComboBox);
            this.Controls.Add(this.newInvoiceDescriptionOfRequestRichTextBox);
            this.Controls.Add(this.newInvoiceAnimalsInHomeComboBox);
            this.Controls.Add(this.newInvoicePermissionToEnterComboBox);
            this.Controls.Add(this.newInvoiceWorkOrderTypeComboBox);
            this.Controls.Add(this.newInvoiceAlternatePhoneTypeComboBox);
            this.Controls.Add(this.newInvoicePrimaryPhoneTypeComboBox);
            this.Controls.Add(this.newInvoiceCommunityComboBox);
            this.Controls.Add(this.newInvoiceEmailTextBox);
            this.Controls.Add(this.newInvoiceAlternatePhoneExtensionTextBox);
            this.Controls.Add(this.newInvoiceAlternatePhoneNumberTextBox);
            this.Controls.Add(this.newInvoicePrimaryPhoneExtensionTextBox);
            this.Controls.Add(this.newInvoicePrimaryPhoneNumberTextBox);
            this.Controls.Add(this.newInvoiceStreetAddressTextBox);
            this.Controls.Add(this.newInvoiceLastNameTextBox);
            this.Controls.Add(this.newInvoiceFirstNameTextBox);
            this.Controls.Add(this.newInvoiceRequestTimeOfServiceLabelPrompt);
            this.Controls.Add(this.newInvoicePrimaryPhoneTypeLabelPrompt);
            this.Controls.Add(this.newInvoiceEmailLabelPrompt);
            this.Controls.Add(this.newInvoiceDescriptionLabelPrompt);
            this.Controls.Add(this.newInvoicePrimaryPhoneExtensionLabelPrompt);
            this.Controls.Add(this.newInvoiceAlternatePhoneTypeLabelPrompt);
            this.Controls.Add(this.newInvoiceWorkOrderTypeLabelPrompt);
            this.Controls.Add(this.newInvoiceAnimalsLabelPrompt);
            this.Controls.Add(this.newInvoicePrimaryPhoneNumberLabelPrompt);
            this.Controls.Add(this.newInvoiceAlternatePhoneExtensionLabelPrompt);
            this.Controls.Add(this.newInvoiceLastNameLabelPrompt);
            this.Controls.Add(this.newInvoicePermissionToEnterLabelPrompt);
            this.Controls.Add(this.newInvoiceFirstNameLabelPrompt);
            this.Controls.Add(this.newInvoiceCommunityLabelPrompt);
            this.Controls.Add(this.newInvoiceAlternatePhoneNumberLabelPrompt);
            this.Controls.Add(this.newInvoiceStreetAddressLabelPrompt);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.clearFieldsButton);
            this.Controls.Add(this.submitInvoiceButton);
            this.Controls.Add(this.titlePrompt);
            this.Name = "NewWorkOrderForm";
            this.Text = "New Work Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titlePrompt;
        private System.Windows.Forms.Button submitInvoiceButton;
        private System.Windows.Forms.Button clearFieldsButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label newInvoiceRequestTimeOfServiceLabelPrompt;
        private System.Windows.Forms.Label newInvoicePrimaryPhoneTypeLabelPrompt;
        private System.Windows.Forms.Label newInvoiceEmailLabelPrompt;
        private System.Windows.Forms.Label newInvoiceDescriptionLabelPrompt;
        private System.Windows.Forms.Label newInvoicePrimaryPhoneExtensionLabelPrompt;
        private System.Windows.Forms.Label newInvoiceAlternatePhoneTypeLabelPrompt;
        private System.Windows.Forms.Label newInvoiceWorkOrderTypeLabelPrompt;
        private System.Windows.Forms.Label newInvoiceAnimalsLabelPrompt;
        private System.Windows.Forms.Label newInvoicePrimaryPhoneNumberLabelPrompt;
        private System.Windows.Forms.Label newInvoiceAlternatePhoneExtensionLabelPrompt;
        private System.Windows.Forms.Label newInvoiceLastNameLabelPrompt;
        private System.Windows.Forms.Label newInvoicePermissionToEnterLabelPrompt;
        private System.Windows.Forms.Label newInvoiceFirstNameLabelPrompt;
        private System.Windows.Forms.Label newInvoiceAlternatePhoneNumberLabelPrompt;
        private System.Windows.Forms.Label newInvoiceStreetAddressLabelPrompt;
        private System.Windows.Forms.TextBox newInvoiceFirstNameTextBox;
        private System.Windows.Forms.TextBox newInvoiceLastNameTextBox;
        private System.Windows.Forms.TextBox newInvoiceStreetAddressTextBox;
        private System.Windows.Forms.TextBox newInvoicePrimaryPhoneNumberTextBox;
        private System.Windows.Forms.TextBox newInvoicePrimaryPhoneExtensionTextBox;
        private System.Windows.Forms.TextBox newInvoiceAlternatePhoneNumberTextBox;
        private System.Windows.Forms.TextBox newInvoiceAlternatePhoneExtensionTextBox;
        private System.Windows.Forms.TextBox newInvoiceEmailTextBox;
        private System.Windows.Forms.Label newInvoiceCommunityLabelPrompt;
        private System.Windows.Forms.ComboBox newInvoiceCommunityComboBox;
        private System.Windows.Forms.ComboBox newInvoicePrimaryPhoneTypeComboBox;
        private System.Windows.Forms.ComboBox newInvoiceAlternatePhoneTypeComboBox;
        private System.Windows.Forms.ComboBox newInvoiceWorkOrderTypeComboBox;
        private System.Windows.Forms.RichTextBox newInvoiceDescriptionOfRequestRichTextBox;
        private System.Windows.Forms.ComboBox newInvoicePermissionToEnterComboBox;
        private System.Windows.Forms.ComboBox newInvoiceAnimalsInHomeComboBox;
        private System.Windows.Forms.ComboBox newInvoiceRequestTimeOfServiceComboBox;
    }
}