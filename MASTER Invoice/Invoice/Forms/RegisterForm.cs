using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Text.RegularExpressions;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Reflection;

namespace Invoice
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }


        private void registerButton_Click_1(object sender, EventArgs e)
        {
            RadioButton[] rb = new RadioButton[] { occupantRadioButton, officeWorkerRadioButton, contractorRadioButton };

            var checkedButton = rolePanel.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            if ((occupantRadioButton.Checked || officeWorkerRadioButton.Checked) &&
                string.IsNullOrEmpty(emailEntryTextBox.Text) || string.IsNullOrEmpty(passwordEntryTextBox.Text) ||
                string.IsNullOrEmpty(confirmPasswordEntryTextBox.Text) || string.IsNullOrEmpty(firstNameTextBox.Text) ||
                string.IsNullOrEmpty(lastNameTextBox.Text) || string.IsNullOrEmpty(phoneNumberTextBox.Text) ||
                (contractorRadioButton.Checked && 
                (string.IsNullOrEmpty(companyNameEntryTextBox.Text) || string.IsNullOrEmpty(companyEmailEntryTextBox.Text) ||
                string.IsNullOrEmpty(companyAddressEntryTextBox.Text) || string.IsNullOrEmpty(companyPhoneEntryTextBox.Text))))
            {
                tooltip();
            }
            else
            {
                Engine.Registration.completeRegistration(emailEntryTextBox.Text, passwordEntryTextBox.Text, confirmPasswordEntryTextBox.Text, checkedButton.Text, firstNameTextBox.Text, lastNameTextBox.Text, phoneNumberTextBox.Text, companyNameEntryTextBox.Text, companyAddressEntryTextBox.Text, companyPhoneEntryTextBox.Text, companyEmailEntryTextBox.Text);
                if (Engine.Registration.success == true)
                {
                    MessageBox.Show("Registration Successful");
                    this.Close();
                    LoginForm login = new LoginForm();
                    login.Show();
                }
                else
                {
                    MessageBox.Show(Engine.Registration.message);

                    if (passwordEntryTextBox.Text != confirmPasswordEntryTextBox.Text)
                    {
                        passwordEntryTextBox.Clear();
                        confirmPasswordEntryTextBox.Clear();
                        passwordEntryTextBox.Focus();
                    }
                }
            }
        }


        /**
         * Returns application to the Login Form
         */
        private void cancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void contractorRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (contractorRadioButton.Checked)
            {
                this.Size = new Size(300, 440);
                personalInfoPanel.Visible = true;
                companyPanel.Visible = true;
                personalInfoPanel.Size = new Size(280, 80);
                companyPanel.Size = new Size(280, 109);
                companyPanel.Location = new Point(2, 195);
                rolePanel.Location = new Point(14, 332);
                registerButton.Location = new Point(14, 365);
                cancelButton.Location = new Point(196, 365);
            }
            else if (occupantRadioButton.Checked || officeWorkerRadioButton.Checked)
            {
                this.Size = new Size(300, 300);
                companyPanel.Visible = false;
                companyPanel.Size = new Size(1, 1);
                rolePanel.Location = new Point(14, 201);
                registerButton.Location = new Point(14, 231);
                cancelButton.Location = new Point(196, 231);
            }
        }

        private void phoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

            if (phoneNumberTextBox.Text.Length == 3)
            {
                phoneNumberTextBox.Text += "-";
                phoneNumberTextBox.SelectionStart = 4;
            }
            if (phoneNumberTextBox.Text.Length == 7)
            {
                phoneNumberTextBox.Text += "-";
                phoneNumberTextBox.SelectionStart = 8;
            }
        }

        private void companyPhoneEntryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

            if (companyPhoneEntryTextBox.Text.Length == 3)
            {
                companyPhoneEntryTextBox.Text += "-";
                companyPhoneEntryTextBox.SelectionStart = 4;
            }
            if (companyPhoneEntryTextBox.Text.Length == 7)
            {
                companyPhoneEntryTextBox.Text += "-";
                companyPhoneEntryTextBox.SelectionStart = 8;
            }
        }

        private void tooltip()
        {
            if (string.IsNullOrEmpty(emailEntryTextBox.Text))
            {
                ToolTip tip2 = new ToolTip();
                tip2.Show("Please Enter An Email", emailEntryTextBox, 10000);
            }
            if (string.IsNullOrEmpty(passwordEntryTextBox.Text))
            {
                ToolTip tip2 = new ToolTip();
                tip2.Show("Please Enter An Password", passwordEntryTextBox, 10000);
            }
            if (string.IsNullOrEmpty(confirmPasswordEntryTextBox.Text))
            {
                ToolTip tip2 = new ToolTip();
                tip2.Show("Please Enter An Email", confirmPasswordEntryTextBox, 10000);
            }
            if (string.IsNullOrEmpty(firstNameTextBox.Text))
            {
                ToolTip tip2 = new ToolTip();
                tip2.Show("Please Enter An Email", firstNameTextBox, 10000);
            }
            if (string.IsNullOrEmpty(lastNameTextBox.Text))
            {
                ToolTip tip2 = new ToolTip();
                tip2.Show("Please Enter An Email", lastNameTextBox, 10000);
            }
            if (string.IsNullOrEmpty(phoneNumberTextBox.Text))
            {
                ToolTip tip2 = new ToolTip();
                tip2.Show("Please Enter An Email", phoneNumberTextBox, 10000);
            }
            if (contractorRadioButton.Checked)
            {
                if (string.IsNullOrEmpty(companyNameEntryTextBox.Text))
                {
                    ToolTip tip2 = new ToolTip();
                    tip2.Show("Please Enter A Company Name", companyNameEntryTextBox, 10000);
                }
                if (string.IsNullOrEmpty(companyEmailEntryTextBox.Text))
                {
                    ToolTip tip2 = new ToolTip();
                    tip2.Show("Please Enter A Company Email", companyEmailEntryTextBox, 10000);
                }
                if (string.IsNullOrEmpty(companyAddressEntryTextBox.Text))
                {
                    ToolTip tip2 = new ToolTip();
                    tip2.Show("Please Enter A Company Address", companyAddressEntryTextBox, 10000);
                }
                if (string.IsNullOrEmpty(companyPhoneEntryTextBox.Text))
                {
                    ToolTip tip2 = new ToolTip();
                    tip2.Show("Please Enter A Company Phone Number", companyPhoneEntryTextBox, 10000);
                }
            }
        }
    }
}
