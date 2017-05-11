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
            this.showAllInvoiceButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.showAllAccountsButton = new System.Windows.Forms.Button();
            this.showUnconfirmedAccountsButton = new System.Windows.Forms.Button();
            this.activateAccountButton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeWorkerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn3 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBDataSet1 = new Invoice.ProjectDBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userAccountsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.logoutButton = new System.Windows.Forms.Button();
            this.showContractorWorkOrderFormButton = new System.Windows.Forms.Button();
            this.showWorkOrderFormButton = new System.Windows.Forms.Button();
            this.showOfficeWorkOrderForm = new System.Windows.Forms.Button();
            this.showNewWorkOrderFormButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteInvoiceButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.invoiceTableAdapter1 = new Invoice.ProjectDBDataSetTableAdapters.InvoiceTableAdapter();
            this.userAccountsTableAdapter1 = new Invoice.ProjectDBDataSetTableAdapters.UserAccountsTableAdapter();
            this.confirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingSource1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // showAllInvoiceButton
            // 
            this.showAllInvoiceButton.Location = new System.Drawing.Point(5, 18);
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
            this.deleteUserButton.Text = "Delete Selected User(s)";
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
            this.dataGridViewTextBoxColumn24,
            this.invoiceIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.officeWorkerIDDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12,
            this.emailDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewCheckBoxColumn3,
            this.dataGridViewCheckBoxColumn4,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22,
            this.dataGridViewTextBoxColumn23});
            this.dataGridView2.DataSource = this.invoiceBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(32, 26);
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
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "InvoiceName";
            this.dataGridViewTextBoxColumn24.HeaderText = "InvoiceName";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            // 
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
            this.invoiceIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerIDDataGridViewTextBoxColumn
            // 
            this.customerIDDataGridViewTextBoxColumn.DataPropertyName = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.HeaderText = "Customer_ID";
            this.customerIDDataGridViewTextBoxColumn.Name = "customerIDDataGridViewTextBoxColumn";
            // 
            // officeWorkerIDDataGridViewTextBoxColumn
            // 
            this.officeWorkerIDDataGridViewTextBoxColumn.DataPropertyName = "OfficeWorker_ID";
            this.officeWorkerIDDataGridViewTextBoxColumn.HeaderText = "OfficeWorker_ID";
            this.officeWorkerIDDataGridViewTextBoxColumn.Name = "officeWorkerIDDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "ContractorCompany_ID";
            this.dataGridViewTextBoxColumn8.HeaderText = "ContractorCompany_ID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Contractor_ID";
            this.dataGridViewTextBoxColumn9.HeaderText = "Contractor_ID";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Community_Name";
            this.dataGridViewTextBoxColumn10.HeaderText = "Community_Name";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "OccupantStatus";
            this.dataGridViewTextBoxColumn11.HeaderText = "OccupantStatus";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn12.HeaderText = "Address";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "Primary#";
            this.dataGridViewTextBoxColumn13.HeaderText = "Primary#";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "Primary#Extension";
            this.dataGridViewTextBoxColumn14.HeaderText = "Primary#Extension";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "Primary#Type";
            this.dataGridViewTextBoxColumn15.HeaderText = "Primary#Type";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "Alt#";
            this.dataGridViewTextBoxColumn16.HeaderText = "Alt#";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Alt#Extension";
            this.dataGridViewTextBoxColumn17.HeaderText = "Alt#Extension";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "Alt#Type";
            this.dataGridViewTextBoxColumn18.HeaderText = "Alt#Type";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            // 
            // dataGridViewCheckBoxColumn3
            // 
            this.dataGridViewCheckBoxColumn3.DataPropertyName = "PermissionToEnter";
            this.dataGridViewCheckBoxColumn3.HeaderText = "PermissionToEnter";
            this.dataGridViewCheckBoxColumn3.Name = "dataGridViewCheckBoxColumn3";
            // 
            // dataGridViewCheckBoxColumn4
            // 
            this.dataGridViewCheckBoxColumn4.DataPropertyName = "Pets";
            this.dataGridViewCheckBoxColumn4.HeaderText = "Pets";
            this.dataGridViewCheckBoxColumn4.Name = "dataGridViewCheckBoxColumn4";
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.DataPropertyName = "Accepted";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Accepted";
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.DataPropertyName = "Complete";
            this.dataGridViewCheckBoxColumn6.HeaderText = "Complete";
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "TimeOfService";
            this.dataGridViewTextBoxColumn19.HeaderText = "TimeOfService";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "DueDate";
            this.dataGridViewTextBoxColumn20.HeaderText = "DueDate";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "InvoiceType";
            this.dataGridViewTextBoxColumn21.HeaderText = "InvoiceType";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn22.HeaderText = "Description";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "Comments";
            this.dataGridViewTextBoxColumn23.HeaderText = "Comments";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            // 
            // invoiceBindingSource1
            // 
            this.invoiceBindingSource1.DataMember = "Invoice";
            this.invoiceBindingSource1.DataSource = this.projectDBDataSet1;
            // 
            // projectDBDataSet1
            // 
            this.projectDBDataSet1.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.emailDataGridViewTextBoxColumn1,
            this.passwordDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.confirmedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.userAccountsBindingSource1;
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
            // userAccountsBindingSource1
            // 
            this.userAccountsBindingSource1.DataMember = "UserAccounts";
            this.userAccountsBindingSource1.DataSource = this.projectDBDataSet1;
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(267, 346);
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.activateAccountButton);
            this.groupBox1.Controls.Add(this.showUnconfirmedAccountsButton);
            this.groupBox1.Controls.Add(this.showAllAccountsButton);
            this.groupBox1.Controls.Add(this.deleteUserButton);
            this.groupBox1.Location = new System.Drawing.Point(9, 223);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(196, 153);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Account Tools";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteInvoiceButton);
            this.groupBox2.Controls.Add(this.showAllInvoiceButton);
            this.groupBox2.Location = new System.Drawing.Point(209, 223);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(190, 89);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Invoice Tools";
            // 
            // deleteInvoiceButton
            // 
            this.deleteInvoiceButton.Location = new System.Drawing.Point(99, 18);
            this.deleteInvoiceButton.Name = "deleteInvoiceButton";
            this.deleteInvoiceButton.Size = new System.Drawing.Size(86, 61);
            this.deleteInvoiceButton.TabIndex = 17;
            this.deleteInvoiceButton.Text = "Delete Selected Invoice(s)";
            this.deleteInvoiceButton.UseVisualStyleBackColor = true;
            this.deleteInvoiceButton.Click += new System.EventHandler(this.deleteInvoiceButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showWorkOrderFormButton);
            this.groupBox3.Controls.Add(this.showOfficeWorkOrderForm);
            this.groupBox3.Controls.Add(this.showContractorWorkOrderFormButton);
            this.groupBox3.Controls.Add(this.showNewWorkOrderFormButton);
            this.groupBox3.Location = new System.Drawing.Point(404, 223);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(189, 153);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Form Tools";
            // 
            // invoiceTableAdapter1
            // 
            this.invoiceTableAdapter1.ClearBeforeFill = true;
            // 
            // userAccountsTableAdapter1
            // 
            this.userAccountsTableAdapter1.ClearBeforeFill = true;
            // 
            // confirmedDataGridViewCheckBoxColumn
            // 
            this.confirmedDataGridViewCheckBoxColumn.DataPropertyName = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.HeaderText = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.Name = "confirmedDataGridViewCheckBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn1
            // 
            this.emailDataGridViewTextBoxColumn1.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn1.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn1.Name = "emailDataGridViewTextBoxColumn1";
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 420);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "AdminForm";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingSource1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button showAllInvoiceButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button showAllAccountsButton;
        private System.Windows.Forms.Button showUnconfirmedAccountsButton;
        private System.Windows.Forms.Button activateAccountButton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Button showContractorWorkOrderFormButton;
        private System.Windows.Forms.Button showWorkOrderFormButton;
        private System.Windows.Forms.Button showOfficeWorkOrderForm;
        private System.Windows.Forms.Button showNewWorkOrderFormButton;
        private ProjectDBDataSet projectDBDataSet;
        private ProjectDBDataSetTableAdapters.UserAccountsTableAdapter userAccountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private ProjectDBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.Button deleteInvoiceButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNameDataGridViewTextBoxColumn;
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
        private ProjectDBDataSet projectDBDataSet1;
        private ProjectDBDataSetTableAdapters.InvoiceTableAdapter invoiceTableAdapter1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeWorkerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn3;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private ProjectDBDataSetTableAdapters.UserAccountsTableAdapter userAccountsTableAdapter1;
        private System.Windows.Forms.BindingSource invoiceBindingSource1;
        private System.Windows.Forms.BindingSource userAccountsBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmedDataGridViewCheckBoxColumn;
    }
}