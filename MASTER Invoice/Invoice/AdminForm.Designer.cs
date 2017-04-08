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
            this.invoiceIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officeWorkerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceStatusIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDBData = new Invoice.ProjectDBData();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.userAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Invoice.ProjectDBDataTableAdapters.InvoiceTableAdapter();
            this.userAccountsTableAdapter = new Invoice.ProjectDBDataTableAdapters.UserAccountsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateInvoiceButton
            // 
            this.updateInvoiceButton.Location = new System.Drawing.Point(469, 294);
            this.updateInvoiceButton.Name = "updateInvoiceButton";
            this.updateInvoiceButton.Size = new System.Drawing.Size(86, 61);
            this.updateInvoiceButton.TabIndex = 16;
            this.updateInvoiceButton.Text = "Update Invoices";
            this.updateInvoiceButton.UseVisualStyleBackColor = true;
            this.updateInvoiceButton.Click += new System.EventHandler(this.updateInvoiceButton_Click);
            // 
            // showAllInvoiceButton
            // 
            this.showAllInvoiceButton.Location = new System.Drawing.Point(341, 294);
            this.showAllInvoiceButton.Name = "showAllInvoiceButton";
            this.showAllInvoiceButton.Size = new System.Drawing.Size(86, 61);
            this.showAllInvoiceButton.TabIndex = 15;
            this.showAllInvoiceButton.Text = "Show All Invoices";
            this.showAllInvoiceButton.UseVisualStyleBackColor = true;
            this.showAllInvoiceButton.Click += new System.EventHandler(this.showAllInvoiceButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(600, 201);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(86, 61);
            this.deleteUserButton.TabIndex = 14;
            this.deleteUserButton.Text = "Delete Selected User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // showAllAccountsButton
            // 
            this.showAllAccountsButton.Location = new System.Drawing.Point(469, 201);
            this.showAllAccountsButton.Name = "showAllAccountsButton";
            this.showAllAccountsButton.Size = new System.Drawing.Size(86, 61);
            this.showAllAccountsButton.TabIndex = 13;
            this.showAllAccountsButton.Text = "Show All Accounts";
            this.showAllAccountsButton.UseVisualStyleBackColor = true;
            this.showAllAccountsButton.Click += new System.EventHandler(this.showAllAccountsButton_Click_1);
            // 
            // showUnconfirmedAccountsButton
            // 
            this.showUnconfirmedAccountsButton.Location = new System.Drawing.Point(341, 201);
            this.showUnconfirmedAccountsButton.Name = "showUnconfirmedAccountsButton";
            this.showUnconfirmedAccountsButton.Size = new System.Drawing.Size(86, 61);
            this.showUnconfirmedAccountsButton.TabIndex = 12;
            this.showUnconfirmedAccountsButton.Text = "Show Accounts That Need Activation";
            this.showUnconfirmedAccountsButton.UseVisualStyleBackColor = true;
            this.showUnconfirmedAccountsButton.Click += new System.EventHandler(this.showUnconfirmedAccountsButton_Click_1);
            // 
            // activateAccountButton
            // 
            this.activateAccountButton.Location = new System.Drawing.Point(225, 201);
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
            this.invoiceIDDataGridViewTextBoxColumn,
            this.customerIDDataGridViewTextBoxColumn,
            this.officeWorkerIDDataGridViewTextBoxColumn,
            this.invoiceStatusIDDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.invoiceBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(141, 3);
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
            // invoiceIDDataGridViewTextBoxColumn
            // 
            this.invoiceIDDataGridViewTextBoxColumn.DataPropertyName = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.HeaderText = "Invoice_ID";
            this.invoiceIDDataGridViewTextBoxColumn.Name = "invoiceIDDataGridViewTextBoxColumn";
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
            // invoiceStatusIDDataGridViewTextBoxColumn
            // 
            this.invoiceStatusIDDataGridViewTextBoxColumn.DataPropertyName = "Invoice_Status_ID";
            this.invoiceStatusIDDataGridViewTextBoxColumn.HeaderText = "Invoice_Status_ID";
            this.invoiceStatusIDDataGridViewTextBoxColumn.Name = "invoiceStatusIDDataGridViewTextBoxColumn";
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.projectDBData;
            // 
            // projectDBData
            // 
            this.projectDBData.DataSetName = "ProjectDBData";
            this.projectDBData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selected,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.userTypeDataGridViewTextBoxColumn,
            this.confirmedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.userAccountsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(141, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 192);
            this.dataGridView1.TabIndex = 10;
            // 
            // selected
            // 
            this.selected.HeaderText = "Selected";
            this.selected.Name = "selected";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // userTypeDataGridViewTextBoxColumn
            // 
            this.userTypeDataGridViewTextBoxColumn.DataPropertyName = "UserType";
            this.userTypeDataGridViewTextBoxColumn.HeaderText = "UserType";
            this.userTypeDataGridViewTextBoxColumn.Name = "userTypeDataGridViewTextBoxColumn";
            // 
            // confirmedDataGridViewCheckBoxColumn
            // 
            this.confirmedDataGridViewCheckBoxColumn.DataPropertyName = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.HeaderText = "Confirmed";
            this.confirmedDataGridViewCheckBoxColumn.Name = "confirmedDataGridViewCheckBoxColumn";
            // 
            // userAccountsBindingSource
            // 
            this.userAccountsBindingSource.DataMember = "UserAccounts";
            this.userAccountsBindingSource.DataSource = this.projectDBData;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // userAccountsTableAdapter
            // 
            this.userAccountsTableAdapter.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 367);
            this.Controls.Add(this.updateInvoiceButton);
            this.Controls.Add(this.showAllInvoiceButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.showAllAccountsButton);
            this.Controls.Add(this.showUnconfirmedAccountsButton);
            this.Controls.Add(this.activateAccountButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn selected;
        private ProjectDBData projectDBData;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ProjectDBDataTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officeWorkerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceStatusIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userAccountsBindingSource;
        private ProjectDBDataTableAdapters.UserAccountsTableAdapter userAccountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn confirmedDataGridViewCheckBoxColumn;
    }
}