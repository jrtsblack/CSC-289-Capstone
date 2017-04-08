namespace Invoice
{
    partial class LoginForm
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
            this.emailEntryTextBox = new System.Windows.Forms.TextBox();
            this.emailPromptLabel = new System.Windows.Forms.Label();
            this.passwordEntryTextBox = new System.Windows.Forms.TextBox();
            this.passwordPromptLabel = new System.Windows.Forms.Label();
            this.userPromptLabel = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailEntryTextBox
            // 
            this.emailEntryTextBox.Location = new System.Drawing.Point(101, 57);
            this.emailEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.emailEntryTextBox.Name = "emailEntryTextBox";
            this.emailEntryTextBox.Size = new System.Drawing.Size(249, 22);
            this.emailEntryTextBox.TabIndex = 0;
            // 
            // emailPromptLabel
            // 
            this.emailPromptLabel.AutoSize = true;
            this.emailPromptLabel.Location = new System.Drawing.Point(47, 60);
            this.emailPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailPromptLabel.Name = "emailPromptLabel";
            this.emailPromptLabel.Size = new System.Drawing.Size(46, 17);
            this.emailPromptLabel.TabIndex = 1;
            this.emailPromptLabel.Text = "Email:";
            // 
            // passwordEntryTextBox
            // 
            this.passwordEntryTextBox.Location = new System.Drawing.Point(101, 94);
            this.passwordEntryTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordEntryTextBox.Name = "passwordEntryTextBox";
            this.passwordEntryTextBox.PasswordChar = '*';
            this.passwordEntryTextBox.Size = new System.Drawing.Size(249, 22);
            this.passwordEntryTextBox.TabIndex = 1;
            this.passwordEntryTextBox.UseSystemPasswordChar = true;
            // 
            // passwordPromptLabel
            // 
            this.passwordPromptLabel.AutoSize = true;
            this.passwordPromptLabel.Location = new System.Drawing.Point(19, 97);
            this.passwordPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordPromptLabel.Name = "passwordPromptLabel";
            this.passwordPromptLabel.Size = new System.Drawing.Size(73, 17);
            this.passwordPromptLabel.TabIndex = 1;
            this.passwordPromptLabel.Text = "Password:";
            // 
            // userPromptLabel
            // 
            this.userPromptLabel.AutoSize = true;
            this.userPromptLabel.Location = new System.Drawing.Point(64, 11);
            this.userPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userPromptLabel.Name = "userPromptLabel";
            this.userPromptLabel.Size = new System.Drawing.Size(253, 17);
            this.userPromptLabel.TabIndex = 2;
            this.userPromptLabel.Text = "Please enter your email and password.";
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(23, 154);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(100, 28);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(137, 154);
            this.registerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(100, 28);
            this.registerButton.TabIndex = 3;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(252, 154);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(100, 28);
            this.cancelButton.TabIndex = 4;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 197);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.userPromptLabel);
            this.Controls.Add(this.passwordPromptLabel);
            this.Controls.Add(this.passwordEntryTextBox);
            this.Controls.Add(this.emailPromptLabel);
            this.Controls.Add(this.emailEntryTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.Text = "Work Order Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox emailEntryTextBox;
        private System.Windows.Forms.Label emailPromptLabel;
        private System.Windows.Forms.TextBox passwordEntryTextBox;
        private System.Windows.Forms.Label passwordPromptLabel;
        private System.Windows.Forms.Label userPromptLabel;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

