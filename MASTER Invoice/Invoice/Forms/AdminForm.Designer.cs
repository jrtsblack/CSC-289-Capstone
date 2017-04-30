namespace Invoice
{
    partial class AdminForm
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
            this.updateInvoiceButton = new System.Windows.Forms.Button();
            this.showAllInvoiceButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.showAllAccountsButton = new System.Windows.Forms.Button();
            this.showUnconfirmedAccountsButton = new System.Windows.Forms.Button();
            this.activateAccountButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet = new Invoice.ProjectDBDataSet();
            this.logoutButton = new System.Windows.Forms.Button();
            this.showContractorWorkOrderFormButton = new System.Windows.Forms.Button();
            this.showWorkOrderFormButton = new System.Windows.Forms.Button();
            this.showOfficeWorkOrderForm = new System.Windows.Forms.Button();
            this.showNewWorkOrderFormButton = new System.Windows.Forms.Button();
            this.userAccountsTableAdapter = new Invoice.ProjectDBDataSetTableAdapters.UserAccountsTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Invoice.ProjectDBDataSetTableAdapters.InvoiceTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractorCompanyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contractorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.communityNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.occupantStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryExtensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primaryTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altExtensionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.permissionToEnterDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.petsDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.acceptedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.completeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.timeOfServiceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateInvoiceButton
            // 
            this.updateInvoiceButton.Location = new System.Drawing.Point(5, 18);
            this.updateInvoiceButton.Name = "updateInvoiceButton";
            this.updateInvoiceButton.Size = new System.Drawing.Size(86, 61);
            this.updateInvoiceButton.TabIndex = 16;
            this.updateInvoiceButton.Text = "Update Invoices";
            this.updateInvoiceButton.UseVisualStyleBackColor = true;
            this.updateInvoiceButton.Click += new System.EventHandler(this.updateInvoiceButton_Click);
            // 
            // showAllInvoiceButton
            // 
            this.showAllInvoiceButton.Location = new System.Drawing.Point(98, 18);
            this.showAllInvoiceButton.Name = "showAllInvoiceButton";
            this.showAllInvoiceButton.Size = new System.Drawing.Size(86, 61);
            this.showAllInvoiceButton.TabIndex = 15;
            this.showAllInvoiceButton.Text = "Show All Invoices";
            this.showAllInvoiceButton.UseVisualStyleBackColor = true;
            this.showAllInvoiceButton.Click += new System.EventHandler(this.showAllInvoiceButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(104, 85);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(86, 61);
            this.deleteUserButton.TabIndex = 14;
            this.deleteUserButton.Text = "Delete Selected User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // showAllAccountsButton
            // 
            this.showAllAccountsButton.Location = new System.Drawing.Point(5, 85);
            this.showAllAccountsButton.Name = "showAllAccountsButton";
            this.showAllAccountsButton.Size = new System.Drawing.Size(86, 61);
            this.showAllAccountsButton.TabIndex = 13;
            this.showAllAccountsButton.Text = "Show All Accounts";
            this.showAllAccountsButton.UseVisualStyleBackColor = true;
            this.showAllAccountsButton.Click += new System.EventHandler(this.showAllAccountsButton_Click_1);
            // 
            // showUnconfirmedAccountsButton
            // 
            this.showUnconfirmedAccountsButton.Location = new System.Drawing.Point(5, 18);
            this.showUnconfirmedAccountsButton.Name = "showUnconfirmedAccountsButton";
            this.showUnconfirmedAccountsButton.Size = new System.Drawing.Size(86, 61);
            this.showUnconfirmedAccountsButton.TabIndex = 12;
            this.showUnconfirmedAccountsButton.Text = "Show Accounts That Need Activation";
            this.showUnconfirmedAccountsButton.UseVisualStyleBackColor = true;
            this.showUnconfirmedAccountsButton.Click += new System.EventHandler(this.showUnconfirmedAccountsButton_Click_1);
            // 
            // activateAccountButton
            // 
            this.activateAccountButton.Location = new System.Drawing.Point(104, 18);
            this.activateAccountButton.Name = "activateAccountButton";
            this.activateAccountButton.Size = new System.Drawing.Size(86, 61);
            this.activateAccountButton.TabIndex = 11;
            this.activateAccountButton.Text = "Activate Account";
            this.activateAccountButton.UseVisualStyleBackColor = true;
            this.activateAccountButton.Click += new System.EventHandler(this.activateAccountButton_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.contractorCompanyIDDataGridViewTextBoxColumn,
            this.contractorIDDataGridViewTextBoxColumn,
            this.communityNameDataGridViewTextBoxColumn,
            this.occupantStatusDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn7,
            this.primaryDataGridViewTextBoxColumn,
            this.primaryExtensionDataGridViewTextBoxColumn,
            this.primaryTypeDataGridViewTextBoxColumn,
            this.altDataGridViewTextBoxColumn,
            this.altExtensionDataGridViewTextBoxColumn,
            this.altTypeDataGridViewTextBoxColumn,
            this.permissionToEnterDataGridViewCheckBoxColumn,
            this.petsDataGridViewCheckBoxColumn,
            this.acceptedDataGridViewCheckBoxColumn,
            this.completeDataGridViewCheckBoxColumn,
            this.timeOfServiceDataGridViewTextBoxColumn,
            this.dueDateDataGridViewTextBoxColumn,
            this.invoiceTypeDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.commentsDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.invoiceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(32, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(545, 192);
            this.dataGridView2.TabIndex = 17;
            this.dataGridView2.Visible = false;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "Selected";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewCheckBoxColumn2});
            this.dataGridView1.DataSource = this.userAccountsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(32, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 192);
            this.dataGridView1.TabIndex = 10;
            // 
            // selected
            // 
            this.selected.HeaderText = "Selected";
            this.selected.Name = "selected";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn1.HeaderText = "Email";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Password";
            this.dataGridViewTextBoxColumn2.HeaderText = "Password";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UserType";
            this.dataGridViewTextBoxColumn3.HeaderText = "UserType";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn2
            // 
            this.dataGridViewCheckBoxColumn2.DataPropertyName = "Confirmed";
            this.dataGridViewCheckBoxColumn2.HeaderText = "Confirmed";
            this.dataGridViewCheckBoxColumn2.Name = "dataGridViewCheckBoxColumn2";
            // 
            // userAccountsBindingSource
            // 
            this.userAccountsBindingSource.DataMember = "UserAccounts";
            this.userAccountsBindingSource.DataSource = this.projectDBDataSet;
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(266, 351);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // showContractorWorkOrderFormButton
            // 
            this.showContractorWorkOrderFormButton.Location = new System.Drawing.Point(5, 85);
            this.showContractorWorkOrderFormButton.Name = "showContractorWorkOrderFormButton";
            this.showContractorWorkOrderFormButton.Size = new System.Drawing.Size(86, 61);
            this.showContractorWorkOrderFormButton.TabIndex = 20;
            this.showContractorWorkOrderFormButton.Text = "Show Contractor WorkOrder Form";
            this.showContractorWorkOrderFormButton.UseVisualStyleBackColor = true;
            this.showContractorWorkOrderFormButton.Click += new System.EventHandler(this.showContractorWorkOrderFormButton_Click);
            // 
            // showWorkOrderFormButton
            // 
            this.showWorkOrderFormButton.Location = new System.Drawing.Point(5, 18);
            this.showWorkOrderFormButton.Name = "showWorkOrderFormButton";
            this.showWorkOrderFormButton.Size = new System.Drawing.Size(86, 61);
            this.showWorkOrderFormButton.TabIndex = 19;
            this.showWorkOrderFormButton.Text = "Show WorkOrder Form";
            this.showWorkOrderFormButton.UseVisualStyleBackColor = true;
            this.showWorkOrderFormButton.Click += new System.EventHandler(this.showWorkOrderFormButton_Click);
            // 
            // showOfficeWorkOrderForm
            // 
            this.showOfficeWorkOrderForm.Location = new System.Drawing.Point(98, 18);
            this.showOfficeWorkOrderForm.Name = "showOfficeWorkOrderForm";
            this.showOfficeWorkOrderForm.Size = new System.Drawing.Size(86, 61);
            this.showOfficeWorkOrderForm.TabIndex = 22;
            this.showOfficeWorkOrderForm.Text = "Show Office WorkOrder Form";
            this.showOfficeWorkOrderForm.UseVisualStyleBackColor = true;
            this.showOfficeWorkOrderForm.Click += new System.EventHandler(this.showOfficeWorkOrderForm_Click);
            // 
            // showNewWorkOrderFormButton
            // 
            this.showNewWorkOrderFormButton.Location = new System.Drawing.Point(98, 85);
            this.showNewWorkOrderFormButton.Name = "showNewWorkOrderFormButton";
            this.showNewWorkOrderFormButton.Size = new System.Drawing.Size(86, 61);
            this.showNewWorkOrderFormButton.TabIndex = 21;
            this.showNewWorkOrderFormButton.Text = "Show New WorkOrder Form";
            this.showNewWorkOrderFormButton.UseVisualStyleBackColor = true;
            this.showNewWorkOrderFormButton.Click += new System.EventHandler(this.showNewWorkOrderFormButton_Click);
            // 
            // userAccountsTableAdapter
            // 
            this.userAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activateAccountButton);
            this.groupBox1.Controls.Add(this.showUnconfirmedAccountsButton);
            this.groupBox1.Controls.Add(this.showAllAccountsButton);
            this.groupBox1.Controls.Add(this.deleteUserButton);
            this.groupBox1.Location = new System.Drawing.Point(9, 223);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(196, 153);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Tools";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.updateInvoiceButton);
            this.groupBox2.Controls.Add(this.showAllInvoiceButton);
            this.groupBox2.Location = new System.Drawing.Point(209, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(190, 123);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice Tools";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showWorkOrderFormButton);
            this.groupBox3.Controls.Add(this.showOfficeWorkOrderForm);
            this.groupBox3.Controls.Add(this.showContractorWorkOrderFormButton);
            this.groupBox3.Controls.Add(this.showNewWorkOrderFormButton);
            this.groupBox3.Location = new System.Drawing.Point(404, 223);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(189, 153);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Tools";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.projectDBDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Invoice_ID";
            this.dataGridViewTextBoxColumn4.HeaderText = "Invoice_ID";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Customer_ID";
            this.dataGridViewTextBoxColumn5.HeaderText = "Customer_ID";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "OfficeWorker_ID";
            this.dataGridViewTextBoxColumn6.HeaderText = "OfficeWorker_ID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // contractorCompanyIDDataGridViewTextBoxColumn
            // 
            this.contractorCompanyIDDataGridViewTextBoxColumn.DataPropertyName = "ContractorCompany_ID";
            this.contractorCompanyIDDataGridViewTextBoxColumn.HeaderText = "ContractorCompany_ID";
            this.contractorCompanyIDDataGridViewTextBoxColumn.Name = "contractorCompanyIDDataGridViewTextBoxColumn";
            // 
            // contractorIDDataGridViewTextBoxColumn
            // 
            this.contractorIDDataGridViewTextBoxColumn.DataPropertyName = "Contractor_ID";
            this.contractorIDDataGridViewTextBoxColumn.HeaderText = "Contractor_ID";
            this.contractorIDDataGridViewTextBoxColumn.Name = "contractorIDDataGridViewTextBoxColumn";
            // 
            // communityNameDataGridViewTextBoxColumn
            // 
            this.communityNameDataGridViewTextBoxColumn.DataPropertyName = "Community_Name";
            this.communityNameDataGridViewTextBoxColumn.HeaderText = "Community_Name";
            this.communityNameDataGridViewTextBoxColumn.Name = "communityNameDataGridViewTextBoxColumn";
            // 
            // occupantStatusDataGridViewTextBoxColumn
            // 
            this.occupantStatusDataGridViewTextBoxColumn.DataPropertyName = "OccupantStatus";
            this.occupantStatusDataGridViewTextBoxColumn.HeaderText = "OccupantStatus";
            this.occupantStatusDataGridViewTextBoxColumn.Name = "occupantStatusDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn7.HeaderText = "Email";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // primaryDataGridViewTextBoxColumn
            // 
            this.primaryDataGridViewTextBoxColumn.DataPropertyName = "Primary#";
            this.primaryDataGridViewTextBoxColumn.HeaderText = "Primary#";
            this.primaryDataGridViewTextBoxColumn.Name = "primaryDataGridViewTextBoxColumn";
            // 
            // primaryExtensionDataGridViewTextBoxColumn
            // 
            this.primaryExtensionDataGridViewTextBoxColumn.DataPropertyName = "Primary#Extension";
            this.primaryExtensionDataGridViewTextBoxColumn.HeaderText = "Primary#Extension";
            this.primaryExtensionDataGridViewTextBoxColumn.Name = "primaryExtensionDataGridViewTextBoxColumn";
            // 
            // primaryTypeDataGridViewTextBoxColumn
            // 
            this.primaryTypeDataGridViewTextBoxColumn.DataPropertyName = "Primary#Type";
            this.primaryTypeDataGridViewTextBoxColumn.HeaderText = "Primary#Type";
            this.primaryTypeDataGridViewTextBoxColumn.Name = "primaryTypeDataGridViewTextBoxColumn";
            // 
            // altDataGridViewTextBoxColumn
            // 
            this.altDataGridViewTextBoxColumn.DataPropertyName = "Alt#";
            this.altDataGridViewTextBoxColumn.HeaderText = "Alt#";
            this.altDataGridViewTextBoxColumn.Name = "altDataGridViewTextBoxColumn";
            // 
            // altExtensionDataGridViewTextBoxColumn
            // 
            this.altExtensionDataGridViewTextBoxColumn.DataPropertyName = "Alt#Extension";
            this.altExtensionDataGridViewTextBoxColumn.HeaderText = "Alt#Extension";
            this.altExtensionDataGridViewTextBoxColumn.Name = "altExtensionDataGridViewTextBoxColumn";
            // 
            // altTypeDataGridViewTextBoxColumn
            // 
            this.altTypeDataGridViewTextBoxColumn.DataPropertyName = "Alt#Type";
            this.altTypeDataGridViewTextBoxColumn.HeaderText = "Alt#Type";
            this.altTypeDataGridViewTextBoxColumn.Name = "altTypeDataGridViewTextBoxColumn";
            // 
            // permissionToEnterDataGridViewCheckBoxColumn
            // 
            this.permissionToEnterDataGridViewCheckBoxColumn.DataPropertyName = "PermissionToEnter";
            this.permissionToEnterDataGridViewCheckBoxColumn.HeaderText = "PermissionToEnter";
            this.permissionToEnterDataGridViewCheckBoxColumn.Name = "permissionToEnterDataGridViewCheckBoxColumn";
            // 
            // petsDataGridViewCheckBoxColumn
            // 
            this.petsDataGridViewCheckBoxColumn.DataPropertyName = "Pets";
            this.petsDataGridViewCheckBoxColumn.HeaderText = "Pets";
            this.petsDataGridViewCheckBoxColumn.Name = "petsDataGridViewCheckBoxColumn";
            // 
            // acceptedDataGridViewCheckBoxColumn
            // 
            this.acceptedDataGridViewCheckBoxColumn.DataPropertyName = "Accepted";
            this.acceptedDataGridViewCheckBoxColumn.HeaderText = "Accepted";
            this.acceptedDataGridViewCheckBoxColumn.Name = "acceptedDataGridViewCheckBoxColumn";
            // 
            // completeDataGridViewCheckBoxColumn
            // 
            this.completeDataGridViewCheckBoxColumn.DataPropertyName = "Complete";
            this.completeDataGridViewCheckBoxColumn.HeaderText = "Complete";
            this.completeDataGridViewCheckBoxColumn.Name = "completeDataGridViewCheckBoxColumn";
            // 
            // timeOfServiceDataGridViewTextBoxColumn
            // 
            this.timeOfServiceDataGridViewTextBoxColumn.DataPropertyName = "TimeOfService";
            this.timeOfServiceDataGridViewTextBoxColumn.HeaderText = "TimeOfService";
            this.timeOfServiceDataGridViewTextBoxColumn.Name = "timeOfServiceDataGridViewTextBoxColumn";
            // 
            // dueDateDataGridViewTextBoxColumn
            // 
            this.dueDateDataGridViewTextBoxColumn.DataPropertyName = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.HeaderText = "DueDate";
            this.dueDateDataGridViewTextBoxColumn.Name = "dueDateDataGridViewTextBoxColumn";
            // 
            // invoiceTypeDataGridViewTextBoxColumn
            // 
            this.invoiceTypeDataGridViewTextBoxColumn.DataPropertyName = "InvoiceType";
            this.invoiceTypeDataGridViewTextBoxColumn.HeaderText = "InvoiceType";
            this.invoiceTypeDataGridViewTextBoxColumn.Name = "invoiceTypeDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // commentsDataGridViewTextBoxColumn
            // 
            this.commentsDataGridViewTextBoxColumn.DataPropertyName = "Comments";
            this.commentsDataGridViewTextBoxColumn.HeaderText = "Comments";
            this.commentsDataGridViewTextBoxColumn.Name = "commentsDataGridViewTextBoxColumn";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 387);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button updateInvoiceButton;
        private System.Windows.Forms.Button showAllInvoiceButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button showAllAccountsButton;
        private System.Windows.Forms.Button showUnconfirmedAccountsButton;
        private System.Windows.Forms.Button activateAccountButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeWorkerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button showContractorWorkOrderFormButton;
        private System.Windows.Forms.Button showWorkOrderFormButton;
        private System.Windows.Forms.Button showOfficeWorkOrderForm;
        private System.Windows.Forms.Button showNewWorkOrderFormButton;
        private ProjectDBDataSet projectDBDataSet;
        private System.Windows.Forms.BindingSource userAccountsBindingSource;
        private ProjectDBDataSetTableAdapters.UserAccountsTableAdapter userAccountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ProjectDBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorCompanyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contractorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn communityNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn occupantStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryExtensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primaryTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altExtensionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn altTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn permissionToEnterDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn petsDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn acceptedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn completeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeOfServiceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentsDataGridViewTextBoxColumn;
    }
}