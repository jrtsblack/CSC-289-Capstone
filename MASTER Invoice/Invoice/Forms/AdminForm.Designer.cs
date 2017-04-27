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
            this.logoutButton = new System.Windows.Forms.Button();
            this.showContractorWorkOrderFormButton = new System.Windows.Forms.Button();
            this.showWorkOrderFormButton = new System.Windows.Forms.Button();
            this.showOfficeWorkOrderForm = new System.Windows.Forms.Button();
            this.showNewWorkOrderFormButton = new System.Windows.Forms.Button();
            this.projectDBDataSet = new Invoice.ProjectDBDataSet();
            this.userAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userAccountsTableAdapter = new Invoice.ProjectDBDataSetTableAdapters.UserAccountsTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn2 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userAccountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // updateInvoiceButton
            // 
            this.updateInvoiceButton.Location = new System.Drawing.Point(465, 285);
            this.updateInvoiceButton.Name = "updateInvoiceButton";
            this.updateInvoiceButton.Size = new System.Drawing.Size(86, 61);
            this.updateInvoiceButton.TabIndex = 16;
            this.updateInvoiceButton.Text = "Update Invoices";
            this.updateInvoiceButton.UseVisualStyleBackColor = true;
            this.updateInvoiceButton.Click += new System.EventHandler(this.updateInvoiceButton_Click);
            // 
            // showAllInvoiceButton
            // 
            this.showAllInvoiceButton.Location = new System.Drawing.Point(345, 285);
            this.showAllInvoiceButton.Name = "showAllInvoiceButton";
            this.showAllInvoiceButton.Size = new System.Drawing.Size(86, 61);
            this.showAllInvoiceButton.TabIndex = 15;
            this.showAllInvoiceButton.Text = "Show All Invoices";
            this.showAllInvoiceButton.UseVisualStyleBackColor = true;
            this.showAllInvoiceButton.Click += new System.EventHandler(this.showAllInvoiceButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(585, 200);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(86, 61);
            this.deleteUserButton.TabIndex = 14;
            this.deleteUserButton.Text = "Delete Selected User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // showAllAccountsButton
            // 
            this.showAllAccountsButton.Location = new System.Drawing.Point(465, 200);
            this.showAllAccountsButton.Name = "showAllAccountsButton";
            this.showAllAccountsButton.Size = new System.Drawing.Size(86, 61);
            this.showAllAccountsButton.TabIndex = 13;
            this.showAllAccountsButton.Text = "Show All Accounts";
            this.showAllAccountsButton.UseVisualStyleBackColor = true;
            this.showAllAccountsButton.Click += new System.EventHandler(this.showAllAccountsButton_Click_1);
            // 
            // showUnconfirmedAccountsButton
            // 
            this.showUnconfirmedAccountsButton.Location = new System.Drawing.Point(345, 200);
            this.showUnconfirmedAccountsButton.Name = "showUnconfirmedAccountsButton";
            this.showUnconfirmedAccountsButton.Size = new System.Drawing.Size(86, 61);
            this.showUnconfirmedAccountsButton.TabIndex = 12;
            this.showUnconfirmedAccountsButton.Text = "Show Accounts That Need Activation";
            this.showUnconfirmedAccountsButton.UseVisualStyleBackColor = true;
            this.showUnconfirmedAccountsButton.Click += new System.EventHandler(this.showUnconfirmedAccountsButton_Click_1);
            // 
            // activateAccountButton
            // 
            this.activateAccountButton.Location = new System.Drawing.Point(225, 200);
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
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewCheckBoxColumn1});
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
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(756, 405);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(75, 23);
            this.logoutButton.TabIndex = 18;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // showContractorWorkOrderFormButton
            // 
            this.showContractorWorkOrderFormButton.Location = new System.Drawing.Point(345, 370);
            this.showContractorWorkOrderFormButton.Name = "showContractorWorkOrderFormButton";
            this.showContractorWorkOrderFormButton.Size = new System.Drawing.Size(86, 61);
            this.showContractorWorkOrderFormButton.TabIndex = 20;
            this.showContractorWorkOrderFormButton.Text = "Show Contractor WorkOrder Form";
            this.showContractorWorkOrderFormButton.UseVisualStyleBackColor = true;
            this.showContractorWorkOrderFormButton.Click += new System.EventHandler(this.showContractorWorkOrderFormButton_Click);
            // 
            // showWorkOrderFormButton
            // 
            this.showWorkOrderFormButton.Location = new System.Drawing.Point(225, 370);
            this.showWorkOrderFormButton.Name = "showWorkOrderFormButton";
            this.showWorkOrderFormButton.Size = new System.Drawing.Size(86, 61);
            this.showWorkOrderFormButton.TabIndex = 19;
            this.showWorkOrderFormButton.Text = "Show WorkOrder Form";
            this.showWorkOrderFormButton.UseVisualStyleBackColor = true;
            this.showWorkOrderFormButton.Click += new System.EventHandler(this.showWorkOrderFormButton_Click);
            // 
            // showOfficeWorkOrderForm
            // 
            this.showOfficeWorkOrderForm.Location = new System.Drawing.Point(585, 370);
            this.showOfficeWorkOrderForm.Name = "showOfficeWorkOrderForm";
            this.showOfficeWorkOrderForm.Size = new System.Drawing.Size(86, 61);
            this.showOfficeWorkOrderForm.TabIndex = 22;
            this.showOfficeWorkOrderForm.Text = "Show Office WorkOrder Form";
            this.showOfficeWorkOrderForm.UseVisualStyleBackColor = true;
            this.showOfficeWorkOrderForm.Click += new System.EventHandler(this.showOfficeWorkOrderForm_Click);
            // 
            // showNewWorkOrderFormButton
            // 
            this.showNewWorkOrderFormButton.Location = new System.Drawing.Point(465, 370);
            this.showNewWorkOrderFormButton.Name = "showNewWorkOrderFormButton";
            this.showNewWorkOrderFormButton.Size = new System.Drawing.Size(86, 61);
            this.showNewWorkOrderFormButton.TabIndex = 21;
            this.showNewWorkOrderFormButton.Text = "Show New WorkOrder Form";
            this.showNewWorkOrderFormButton.UseVisualStyleBackColor = true;
            this.showNewWorkOrderFormButton.Click += new System.EventHandler(this.showNewWorkOrderFormButton_Click);
            // 
            // projectDBDataSet
            // 
            this.projectDBDataSet.DataSetName = "ProjectDBDataSet";
            this.projectDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userAccountsBindingSource
            // 
            this.userAccountsBindingSource.DataMember = "UserAccounts";
            this.userAccountsBindingSource.DataSource = this.projectDBDataSet;
            // 
            // userAccountsTableAdapter
            // 
            this.userAccountsTableAdapter.ClearBeforeFill = true;
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 439);
            this.Controls.Add(this.showOfficeWorkOrderForm);
            this.Controls.Add(this.showNewWorkOrderFormButton);
            this.Controls.Add(this.showContractorWorkOrderFormButton);
            this.Controls.Add(this.showWorkOrderFormButton);
            this.Controls.Add(this.logoutButton);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDBDataSet)).EndInit();
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
    }
}