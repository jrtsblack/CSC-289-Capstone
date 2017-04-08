namespace Invoice
{
    partial class RegisterForm
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
            this.rolePanel = new System.Windows.Forms.Panel();
            this.occupantRadioButton = new System.Windows.Forms.RadioButton();
            this.contractorRadioButton = new System.Windows.Forms.RadioButton();
            this.officeWorkerRadioButton = new System.Windows.Forms.RadioButton();
            this.registerHeaderLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.confirmPasswordEntryTextBox = new System.Windows.Forms.TextBox();
            this.passwordEntryTextBox = new System.Windows.Forms.TextBox();
            this.emailEntryTextBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordPromptLabel = new System.Windows.Forms.Label();
            this.passwordPromptLabel = new System.Windows.Forms.Label();
            this.emailLabelPrompt = new System.Windows.Forms.Label();
            this.companyPanel = new System.Windows.Forms.Panel();
            this.companyNameLabelPrompt = new System.Windows.Forms.Label();
            this.companyEmailLabelPrompt = new System.Windows.Forms.Label();
            this.companyAddressLabelPrompt = new System.Windows.Forms.Label();
            this.companyPhoneLabelPrompt = new System.Windows.Forms.Label();
            this.companyNameEntryTextBox = new System.Windows.Forms.TextBox();
            this.companyEmailEntryTextBox = new System.Windows.Forms.TextBox();
            this.companyAddressEntryTextBox = new System.Windows.Forms.TextBox();
            this.companyPhoneEntryTextBox = new System.Windows.Forms.TextBox();
            this.rolePanel.SuspendLayout();
            this.companyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // rolePanel
            // 
            this.rolePanel.Controls.Add(this.occupantRadioButton);
            this.rolePanel.Controls.Add(this.contractorRadioButton);
            this.rolePanel.Controls.Add(this.officeWorkerRadioButton);
            this.rolePanel.Location = new System.Drawing.Point(16, 169);
            this.rolePanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rolePanel.Name = "rolePanel";
            this.rolePanel.Size = new System.Drawing.Size(343, 30);
            this.rolePanel.TabIndex = 23;
            // 
            // occupantRadioButton
            // 
            this.occupantRadioButton.AutoSize = true;
            this.occupantRadioButton.Location = new System.Drawing.Point(4, 5);
            this.occupantRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.occupantRadioButton.Name = "occupantRadioButton";
            this.occupantRadioButton.Size = new System.Drawing.Size(90, 21);
            this.occupantRadioButton.TabIndex = 8;
            this.occupantRadioButton.TabStop = true;
            this.occupantRadioButton.Text = "Occupant";
            this.occupantRadioButton.UseVisualStyleBackColor = true;
            // 
            // contractorRadioButton
            // 
            this.contractorRadioButton.AutoSize = true;
            this.contractorRadioButton.Location = new System.Drawing.Point(237, 5);
            this.contractorRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contractorRadioButton.Name = "contractorRadioButton";
            this.contractorRadioButton.Size = new System.Drawing.Size(95, 21);
            this.contractorRadioButton.TabIndex = 10;
            this.contractorRadioButton.TabStop = true;
            this.contractorRadioButton.Text = "Contractor";
            this.contractorRadioButton.UseVisualStyleBackColor = true;
            this.contractorRadioButton.CheckedChanged += new System.EventHandler(this.contractorRadioButton_CheckedChanged);
            // 
            // officeWorkerRadioButton
            // 
            this.officeWorkerRadioButton.AutoSize = true;
            this.officeWorkerRadioButton.Location = new System.Drawing.Point(108, 5);
            this.officeWorkerRadioButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.officeWorkerRadioButton.Name = "officeWorkerRadioButton";
            this.officeWorkerRadioButton.Size = new System.Drawing.Size(116, 21);
            this.officeWorkerRadioButton.TabIndex = 9;
            this.officeWorkerRadioButton.TabStop = true;
            this.officeWorkerRadioButton.Text = "Office Worker";
            this.officeWorkerRadioButton.UseVisualStyleBackColor = true;
            // 
            // registerHeaderLabel
            // 
            this.registerHeaderLabel.AutoSize = true;
            this.registerHeaderLabel.Location = new System.Drawing.Point(45, 11);
            this.registerHeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.registerHeaderLabel.Name = "registerHeaderLabel";
            this.registerHeaderLabel.Size = new System.Drawing.Size(298, 17);
            this.registerHeaderLabel.TabIndex = 17;
            this.registerHeaderLabel.Text = "Please enter the information requested below:";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(263, 213);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click_1);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(16, 213);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 28);
            this.registerButton.TabIndex = 20;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click_1);
            // 
            // confirmPasswordEntryTextBox
            // 
            this.confirmPasswordEntryTextBox.Location = new System.Drawing.Point(148, 110);
            this.confirmPasswordEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.confirmPasswordEntryTextBox.Name = "confirmPasswordEntryTextBox";
            this.confirmPasswordEntryTextBox.PasswordChar = '*';
            this.confirmPasswordEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.confirmPasswordEntryTextBox.TabIndex = 19;
            this.confirmPasswordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // passwordEntryTextBox
            // 
            this.passwordEntryTextBox.Location = new System.Drawing.Point(148, 78);
            this.passwordEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordEntryTextBox.Name = "passwordEntryTextBox";
            this.passwordEntryTextBox.PasswordChar = '*';
            this.passwordEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.passwordEntryTextBox.TabIndex = 18;
            this.passwordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(151, 46);
            this.emailEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.emailEntryTextBox.TabIndex = 16;
            // 
            // confirmPasswordPromptLabel
            // 
            this.confirmPasswordPromptLabel.AutoSize = true;
            this.confirmPasswordPromptLabel.Location = new System.Drawing.Point(12, 118);
            this.confirmPasswordPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmPasswordPromptLabel.Name = "confirmPasswordPromptLabel";
            this.confirmPasswordPromptLabel.Size = new System.Drawing.Size(125, 17);
            this.confirmPasswordPromptLabel.TabIndex = 13;
            this.confirmPasswordPromptLabel.Text = "Confirm Password:";
            // 
            // passwordPromptLabel
            // 
            this.passwordPromptLabel.AutoSize = true;
            this.passwordPromptLabel.Location = new System.Drawing.Point(67, 81);
            this.passwordPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordPromptLabel.Name = "passwordPromptLabel";
            this.passwordPromptLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordPromptLabel.TabIndex = 14;
            this.passwordPromptLabel.Text = "Password:";
            // 
            // emailLabelPrompt
            // 
            this.emailLabelPrompt.AutoSize = true;
            this.emailLabelPrompt.Location = new System.Drawing.Point(93, 49);
            this.emailLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabelPrompt.Name = "emailLabelPrompt";
            this.emailLabelPrompt.Size = new System.Drawing.Size(46, 17);
            this.emailLabelPrompt.TabIndex = 15;
            this.emailLabelPrompt.Text = "Email:";
            // 
            // companyPanel
            // 
            this.companyPanel.Controls.Add(this.companyNameLabelPrompt);
            this.companyPanel.Controls.Add(this.companyEmailLabelPrompt);
            this.companyPanel.Controls.Add(this.companyAddressLabelPrompt);
            this.companyPanel.Controls.Add(this.companyPhoneLabelPrompt);
            this.companyPanel.Controls.Add(this.companyNameEntryTextBox);
            this.companyPanel.Controls.Add(this.companyEmailEntryTextBox);
            this.companyPanel.Controls.Add(this.companyAddressEntryTextBox);
            this.companyPanel.Controls.Add(this.companyPhoneEntryTextBox);
            this.companyPanel.Location = new System.Drawing.Point(3, 142);
            this.companyPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.companyPanel.Name = "companyPanel";
            this.companyPanel.Size = new System.Drawing.Size(1, 1);
            this.companyPanel.TabIndex = 24;
            this.companyPanel.Visible = false;
            // 
            // companyNameLabelPrompt
            // 
            this.companyNameLabelPrompt.AutoSize = true;
            this.companyNameLabelPrompt.Location = new System.Drawing.Point(24, 4);
            this.companyNameLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyNameLabelPrompt.Name = "companyNameLabelPrompt";
            this.companyNameLabelPrompt.Size = new System.Drawing.Size(112, 17);
            this.companyNameLabelPrompt.TabIndex = 0;
            this.companyNameLabelPrompt.Text = "Company Name:";
            // 
            // companyEmailLabelPrompt
            // 
            this.companyEmailLabelPrompt.AutoSize = true;
            this.companyEmailLabelPrompt.Location = new System.Drawing.Point(28, 36);
            this.companyEmailLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyEmailLabelPrompt.Name = "companyEmailLabelPrompt";
            this.companyEmailLabelPrompt.Size = new System.Drawing.Size(109, 17);
            this.companyEmailLabelPrompt.TabIndex = 0;
            this.companyEmailLabelPrompt.Text = "Company Email:";
            // 
            // companyAddressLabelPrompt
            // 
            this.companyAddressLabelPrompt.AutoSize = true;
            this.companyAddressLabelPrompt.Location = new System.Drawing.Point(11, 68);
            this.companyAddressLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyAddressLabelPrompt.Name = "companyAddressLabelPrompt";
            this.companyAddressLabelPrompt.Size = new System.Drawing.Size(127, 17);
            this.companyAddressLabelPrompt.TabIndex = 0;
            this.companyAddressLabelPrompt.Text = "Company Address:";
            // 
            // companyPhoneLabelPrompt
            // 
            this.companyPhoneLabelPrompt.AutoSize = true;
            this.companyPhoneLabelPrompt.Location = new System.Drawing.Point(20, 100);
            this.companyPhoneLabelPrompt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.companyPhoneLabelPrompt.Name = "companyPhoneLabelPrompt";
            this.companyPhoneLabelPrompt.Size = new System.Drawing.Size(116, 17);
            this.companyPhoneLabelPrompt.TabIndex = 0;
            this.companyPhoneLabelPrompt.Text = "Company Phone:";
            // 
            // companyNameEntryTextBox
            // 
            this.companyNameEntryTextBox.Location = new System.Drawing.Point(145, 0);
            this.companyNameEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.companyNameEntryTextBox.Name = "companyNameEntryTextBox";
            this.companyNameEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.companyNameEntryTextBox.TabIndex = 2;
            // 
            // companyEmailEntryTextBox
            // 
            this.companyEmailEntryTextBox.Location = new System.Drawing.Point(145, 32);
            this.companyEmailEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.companyEmailEntryTextBox.Name = "companyEmailEntryTextBox";
            this.companyEmailEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.companyEmailEntryTextBox.TabIndex = 2;
            // 
            // companyAddressEntryTextBox
            // 
            this.companyAddressEntryTextBox.Location = new System.Drawing.Point(145, 64);
            this.companyAddressEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.companyAddressEntryTextBox.Name = "companyAddressEntryTextBox";
            this.companyAddressEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.companyAddressEntryTextBox.TabIndex = 2;
            // 
            // companyPhoneEntryTextBox
            // 
            this.companyPhoneEntryTextBox.Location = new System.Drawing.Point(145, 96);
            this.companyPhoneEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.companyPhoneEntryTextBox.Name = "companyPhoneEntryTextBox";
            this.companyPhoneEntryTextBox.Size = new System.Drawing.Size(213, 22);
            this.companyPhoneEntryTextBox.TabIndex = 2;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 261);
            this.Controls.Add(this.companyPanel);
            this.Controls.Add(this.rolePanel);
            this.Controls.Add(this.registerHeaderLabel);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.confirmPasswordEntryTextBox);
            this.Controls.Add(this.passwordEntryTextBox);
            this.Controls.Add(this.emailEntryTextBox);
            this.Controls.Add(this.confirmPasswordPromptLabel);
            this.Controls.Add(this.passwordPromptLabel);
            this.Controls.Add(this.emailLabelPrompt);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RegisterForm";
            this.Text = "Register New Account";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.rolePanel.ResumeLayout(false);
            this.rolePanel.PerformLayout();
            this.companyPanel.ResumeLayout(false);
            this.companyPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel rolePanel;
        private System.Windows.Forms.RadioButton occupantRadioButton;
        private System.Windows.Forms.RadioButton contractorRadioButton;
        private System.Windows.Forms.RadioButton officeWorkerRadioButton;
        private System.Windows.Forms.Label registerHeaderLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox confirmPasswordEntryTextBox;
        private System.Windows.Forms.TextBox passwordEntryTextBox;
        private System.Windows.Forms.TextBox emailEntryTextBox;
        private System.Windows.Forms.Label confirmPasswordPromptLabel;
        private System.Windows.Forms.Label passwordPromptLabel;
        private System.Windows.Forms.Label emailLabelPrompt;
        private System.Windows.Forms.Panel companyPanel;
        private System.Windows.Forms.Label companyNameLabelPrompt;
        private System.Windows.Forms.Label companyEmailLabelPrompt;
        private System.Windows.Forms.Label companyAddressLabelPrompt;
        private System.Windows.Forms.Label companyPhoneLabelPrompt;
        private System.Windows.Forms.TextBox companyNameEntryTextBox;
        private System.Windows.Forms.TextBox companyEmailEntryTextBox;
        private System.Windows.Forms.TextBox companyAddressEntryTextBox;
        private System.Windows.Forms.TextBox companyPhoneEntryTextBox;
    }
}