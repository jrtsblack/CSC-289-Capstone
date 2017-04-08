namespace Invoice
{
    partial class ContractorWorkOrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDatePrompt = new System.Windows.Forms.Label();
            this.rtbxDescriptionOfRequest = new System.Windows.Forms.RichTextBox();
            this.lblPermissionToEnter = new System.Windows.Forms.Label();
            this.lblRequestTimeOfServicePrompt = new System.Windows.Forms.Label();
            this.lblPermissionToEnterPrompt = new System.Windows.Forms.Label();
            this.lblRequestTimeOfService = new System.Windows.Forms.Label();
            this.lblDescriptionPrompt = new System.Windows.Forms.Label();
            this.lblAnimalsPrompt = new System.Windows.Forms.Label();
            this.lblWorkOrderTypePrompt = new System.Windows.Forms.Label();
            this.lblAnimals = new System.Windows.Forms.Label();
            this.lblWorkOrderType = new System.Windows.Forms.Label();
            this.lblStreetAddressPrompt = new System.Windows.Forms.Label();
            this.lblStreetAddress = new System.Windows.Forms.Label();
            this.lblFirstNamePrompt = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastNamePrompt = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lbxWorkOrders = new System.Windows.Forms.ListBox();
            this.lblWorkOrderPrompt = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.rbtnIncomplete = new System.Windows.Forms.RadioButton();
            this.rbtnComplete = new System.Windows.Forms.RadioButton();
            this.rtxtComments = new System.Windows.Forms.RichTextBox();
            this.lblCommentsPrompt = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDate);
            this.groupBox1.Controls.Add(this.lblDatePrompt);
            this.groupBox1.Controls.Add(this.rtbxDescriptionOfRequest);
            this.groupBox1.Controls.Add(this.lblPermissionToEnter);
            this.groupBox1.Controls.Add(this.lblRequestTimeOfServicePrompt);
            this.groupBox1.Controls.Add(this.lblPermissionToEnterPrompt);
            this.groupBox1.Controls.Add(this.lblRequestTimeOfService);
            this.groupBox1.Controls.Add(this.lblDescriptionPrompt);
            this.groupBox1.Controls.Add(this.lblAnimalsPrompt);
            this.groupBox1.Controls.Add(this.lblWorkOrderTypePrompt);
            this.groupBox1.Controls.Add(this.lblAnimals);
            this.groupBox1.Controls.Add(this.lblWorkOrderType);
            this.groupBox1.Controls.Add(this.lblStreetAddressPrompt);
            this.groupBox1.Controls.Add(this.lblStreetAddress);
            this.groupBox1.Controls.Add(this.lblFirstNamePrompt);
            this.groupBox1.Controls.Add(this.lblFirstName);
            this.groupBox1.Controls.Add(this.lblLastNamePrompt);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Location = new System.Drawing.Point(339, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 452);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Work Order:";
            // 
            // lblDate
            // 
            this.lblDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDate.Location = new System.Drawing.Point(191, 421);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(236, 23);
            this.lblDate.TabIndex = 1053;
            // 
            // lblDatePrompt
            // 
            this.lblDatePrompt.AutoSize = true;
            this.lblDatePrompt.Location = new System.Drawing.Point(8, 422);
            this.lblDatePrompt.Name = "lblDatePrompt";
            this.lblDatePrompt.Size = new System.Drawing.Size(87, 13);
            this.lblDatePrompt.TabIndex = 1052;
            this.lblDatePrompt.Text = "Scheduled Date:";
            // 
            // rtbxDescriptionOfRequest
            // 
            this.rtbxDescriptionOfRequest.Location = new System.Drawing.Point(12, 196);
            this.rtbxDescriptionOfRequest.Margin = new System.Windows.Forms.Padding(4);
            this.rtbxDescriptionOfRequest.Name = "rtbxDescriptionOfRequest";
            this.rtbxDescriptionOfRequest.ReadOnly = true;
            this.rtbxDescriptionOfRequest.Size = new System.Drawing.Size(415, 117);
            this.rtbxDescriptionOfRequest.TabIndex = 1042;
            this.rtbxDescriptionOfRequest.Text = "";
            // 
            // lblPermissionToEnter
            // 
            this.lblPermissionToEnter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPermissionToEnter.Location = new System.Drawing.Point(191, 353);
            this.lblPermissionToEnter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPermissionToEnter.Name = "lblPermissionToEnter";
            this.lblPermissionToEnter.Size = new System.Drawing.Size(237, 23);
            this.lblPermissionToEnter.TabIndex = 1044;
            this.lblPermissionToEnter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRequestTimeOfServicePrompt
            // 
            this.lblRequestTimeOfServicePrompt.AutoSize = true;
            this.lblRequestTimeOfServicePrompt.Location = new System.Drawing.Point(8, 323);
            this.lblRequestTimeOfServicePrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestTimeOfServicePrompt.Name = "lblRequestTimeOfServicePrompt";
            this.lblRequestTimeOfServicePrompt.Size = new System.Drawing.Size(127, 13);
            this.lblRequestTimeOfServicePrompt.TabIndex = 1050;
            this.lblRequestTimeOfServicePrompt.Text = "Request Time of Service:";
            // 
            // lblPermissionToEnterPrompt
            // 
            this.lblPermissionToEnterPrompt.AutoSize = true;
            this.lblPermissionToEnterPrompt.Location = new System.Drawing.Point(8, 356);
            this.lblPermissionToEnterPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPermissionToEnterPrompt.Name = "lblPermissionToEnterPrompt";
            this.lblPermissionToEnterPrompt.Size = new System.Drawing.Size(130, 13);
            this.lblPermissionToEnterPrompt.TabIndex = 1046;
            this.lblPermissionToEnterPrompt.Text = "Permission to Enter (PTE):";
            // 
            // lblRequestTimeOfService
            // 
            this.lblRequestTimeOfService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRequestTimeOfService.Location = new System.Drawing.Point(191, 319);
            this.lblRequestTimeOfService.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRequestTimeOfService.Name = "lblRequestTimeOfService";
            this.lblRequestTimeOfService.Size = new System.Drawing.Size(237, 23);
            this.lblRequestTimeOfService.TabIndex = 1043;
            this.lblRequestTimeOfService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDescriptionPrompt
            // 
            this.lblDescriptionPrompt.AutoSize = true;
            this.lblDescriptionPrompt.Location = new System.Drawing.Point(8, 173);
            this.lblDescriptionPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescriptionPrompt.Name = "lblDescriptionPrompt";
            this.lblDescriptionPrompt.Size = new System.Drawing.Size(214, 13);
            this.lblDescriptionPrompt.TabIndex = 1049;
            this.lblDescriptionPrompt.Text = "Description of Request (Including Location):";
            // 
            // lblAnimalsPrompt
            // 
            this.lblAnimalsPrompt.AutoSize = true;
            this.lblAnimalsPrompt.Location = new System.Drawing.Point(8, 389);
            this.lblAnimalsPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimalsPrompt.Name = "lblAnimalsPrompt";
            this.lblAnimalsPrompt.Size = new System.Drawing.Size(88, 13);
            this.lblAnimalsPrompt.TabIndex = 1047;
            this.lblAnimalsPrompt.Text = "Animals in Home:";
            // 
            // lblWorkOrderTypePrompt
            // 
            this.lblWorkOrderTypePrompt.AutoSize = true;
            this.lblWorkOrderTypePrompt.Location = new System.Drawing.Point(9, 138);
            this.lblWorkOrderTypePrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkOrderTypePrompt.Name = "lblWorkOrderTypePrompt";
            this.lblWorkOrderTypePrompt.Size = new System.Drawing.Size(89, 13);
            this.lblWorkOrderTypePrompt.TabIndex = 1048;
            this.lblWorkOrderTypePrompt.Text = "Work Order Type";
            // 
            // lblAnimals
            // 
            this.lblAnimals.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnimals.Location = new System.Drawing.Point(191, 387);
            this.lblAnimals.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAnimals.Name = "lblAnimals";
            this.lblAnimals.Size = new System.Drawing.Size(237, 23);
            this.lblAnimals.TabIndex = 1045;
            this.lblAnimals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblWorkOrderType
            // 
            this.lblWorkOrderType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWorkOrderType.Location = new System.Drawing.Point(191, 135);
            this.lblWorkOrderType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWorkOrderType.Name = "lblWorkOrderType";
            this.lblWorkOrderType.Size = new System.Drawing.Size(237, 23);
            this.lblWorkOrderType.TabIndex = 1041;
            this.lblWorkOrderType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblStreetAddressPrompt
            // 
            this.lblStreetAddressPrompt.AutoSize = true;
            this.lblStreetAddressPrompt.Location = new System.Drawing.Point(9, 100);
            this.lblStreetAddressPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetAddressPrompt.Name = "lblStreetAddressPrompt";
            this.lblStreetAddressPrompt.Size = new System.Drawing.Size(79, 13);
            this.lblStreetAddressPrompt.TabIndex = 1040;
            this.lblStreetAddressPrompt.Text = "Street Address:";
            this.lblStreetAddressPrompt.Click += new System.EventHandler(this.lblStreetAddressPrompt_Click);
            // 
            // lblStreetAddress
            // 
            this.lblStreetAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStreetAddress.Location = new System.Drawing.Point(191, 97);
            this.lblStreetAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreetAddress.Name = "lblStreetAddress";
            this.lblStreetAddress.Size = new System.Drawing.Size(236, 23);
            this.lblStreetAddress.TabIndex = 1039;
            this.lblStreetAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFirstNamePrompt
            // 
            this.lblFirstNamePrompt.AutoSize = true;
            this.lblFirstNamePrompt.Location = new System.Drawing.Point(9, 24);
            this.lblFirstNamePrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstNamePrompt.Name = "lblFirstNamePrompt";
            this.lblFirstNamePrompt.Size = new System.Drawing.Size(60, 13);
            this.lblFirstNamePrompt.TabIndex = 1038;
            this.lblFirstNamePrompt.Text = "First Name:";
            this.lblFirstNamePrompt.Click += new System.EventHandler(this.lblFirstNamePrompt_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFirstName.Location = new System.Drawing.Point(191, 21);
            this.lblFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(236, 23);
            this.lblFirstName.TabIndex = 1035;
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastNamePrompt
            // 
            this.lblLastNamePrompt.AutoSize = true;
            this.lblLastNamePrompt.Location = new System.Drawing.Point(9, 62);
            this.lblLastNamePrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastNamePrompt.Name = "lblLastNamePrompt";
            this.lblLastNamePrompt.Size = new System.Drawing.Size(61, 13);
            this.lblLastNamePrompt.TabIndex = 1037;
            this.lblLastNamePrompt.Text = "Last Name:";
            this.lblLastNamePrompt.Click += new System.EventHandler(this.lblLastNamePrompt_Click);
            // 
            // lblLastName
            // 
            this.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLastName.Location = new System.Drawing.Point(191, 59);
            this.lblLastName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(236, 23);
            this.lblLastName.TabIndex = 1036;
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxWorkOrders
            // 
            this.lbxWorkOrders.FormattingEnabled = true;
            this.lbxWorkOrders.Location = new System.Drawing.Point(12, 29);
            this.lbxWorkOrders.Name = "lbxWorkOrders";
            this.lbxWorkOrders.Size = new System.Drawing.Size(320, 186);
            this.lbxWorkOrders.TabIndex = 1;
            // 
            // lblWorkOrderPrompt
            // 
            this.lblWorkOrderPrompt.AutoSize = true;
            this.lblWorkOrderPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblWorkOrderPrompt.Name = "lblWorkOrderPrompt";
            this.lblWorkOrderPrompt.Size = new System.Drawing.Size(107, 13);
            this.lblWorkOrderPrompt.TabIndex = 2;
            this.lblWorkOrderPrompt.Text = "Select a Work Order:";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.rbtnIncomplete);
            this.gbxUpdate.Controls.Add(this.rbtnComplete);
            this.gbxUpdate.Controls.Add(this.rtxtComments);
            this.gbxUpdate.Controls.Add(this.lblCommentsPrompt);
            this.gbxUpdate.Controls.Add(this.btnLogout);
            this.gbxUpdate.Controls.Add(this.btnClear);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Location = new System.Drawing.Point(12, 232);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(321, 232);
            this.gbxUpdate.TabIndex = 3;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Updates:";
            // 
            // rbtnIncomplete
            // 
            this.rbtnIncomplete.AutoSize = true;
            this.rbtnIncomplete.Checked = true;
            this.rbtnIncomplete.Location = new System.Drawing.Point(196, 154);
            this.rbtnIncomplete.Name = "rbtnIncomplete";
            this.rbtnIncomplete.Size = new System.Drawing.Size(77, 17);
            this.rbtnIncomplete.TabIndex = 6;
            this.rbtnIncomplete.TabStop = true;
            this.rbtnIncomplete.Text = "Incomplete";
            this.rbtnIncomplete.UseVisualStyleBackColor = true;
            // 
            // rbtnComplete
            // 
            this.rbtnComplete.AutoSize = true;
            this.rbtnComplete.Location = new System.Drawing.Point(31, 154);
            this.rbtnComplete.Name = "rbtnComplete";
            this.rbtnComplete.Size = new System.Drawing.Size(69, 17);
            this.rbtnComplete.TabIndex = 5;
            this.rbtnComplete.Text = "Complete";
            this.rbtnComplete.UseVisualStyleBackColor = true;
            // 
            // rtxtComments
            // 
            this.rtxtComments.Location = new System.Drawing.Point(10, 43);
            this.rtxtComments.Name = "rtxtComments";
            this.rtxtComments.Size = new System.Drawing.Size(305, 105);
            this.rtxtComments.TabIndex = 4;
            this.rtxtComments.Text = "";
            // 
            // lblCommentsPrompt
            // 
            this.lblCommentsPrompt.AutoSize = true;
            this.lblCommentsPrompt.Location = new System.Drawing.Point(7, 22);
            this.lblCommentsPrompt.Name = "lblCommentsPrompt";
            this.lblCommentsPrompt.Size = new System.Drawing.Size(87, 13);
            this.lblCommentsPrompt.TabIndex = 3;
            this.lblCommentsPrompt.Text = "Enter Comments:";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(240, 181);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 45);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(123, 181);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 45);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear Updates";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(6, 181);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 45);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Save Updates";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // ContractorWorkOrderForm
            // 
            this.ClientSize = new System.Drawing.Size(795, 473);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.lblWorkOrderPrompt);
            this.Controls.Add(this.lbxWorkOrders);
            this.Controls.Add(this.groupBox1);
            this.Name = "ContractorWorkOrderForm";
            this.Text = "Contractor Work Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ImageList FolderFileImageList;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colLastModified;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lbxWorkOrders;
        private System.Windows.Forms.Label lblWorkOrderPrompt;
        private System.Windows.Forms.Label lblFirstNamePrompt;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastNamePrompt;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblStreetAddressPrompt;
        private System.Windows.Forms.Label lblStreetAddress;
        private System.Windows.Forms.RichTextBox rtbxDescriptionOfRequest;
        private System.Windows.Forms.Label lblPermissionToEnter;
        private System.Windows.Forms.Label lblRequestTimeOfServicePrompt;
        private System.Windows.Forms.Label lblPermissionToEnterPrompt;
        private System.Windows.Forms.Label lblRequestTimeOfService;
        private System.Windows.Forms.Label lblDescriptionPrompt;
        private System.Windows.Forms.Label lblAnimalsPrompt;
        private System.Windows.Forms.Label lblWorkOrderTypePrompt;
        private System.Windows.Forms.Label lblAnimals;
        private System.Windows.Forms.Label lblWorkOrderType;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDatePrompt;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.RadioButton rbtnIncomplete;
        private System.Windows.Forms.RadioButton rbtnComplete;
        private System.Windows.Forms.RichTextBox rtxtComments;
        private System.Windows.Forms.Label lblCommentsPrompt;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnUpdate;
    }
}