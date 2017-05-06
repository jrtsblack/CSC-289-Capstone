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
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Invoice
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        /**
         * Clicking the register button will open up a new registration form
         * */
        private void registerButton_Click(object sender, EventArgs e)
        {
            RegisterForm register = new RegisterForm();
            register.Show();
            this.Hide();
        }

        /**
         *  Closes the application
         */
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /**
         * Checks Login creditials to determine if you can login
         */
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(passwordEntryTextBox.Text) && !string.IsNullOrEmpty(emailEntryTextBox.Text))
            {
                tooltip();
            }
            else
            {
                Engine.Login.logincomplete(emailEntryTextBox.Text, passwordEntryTextBox.Text);
                if (Engine.Login.success == true)
                {
                    MessageBox.Show("Login Successful");
                    this.Hide();
                    if (Engine.ActiveUser.usertype == "occupant" || Engine.ActiveUser.usertype == "office worker")
                    {
                        
                        WorkOrderForm invoice = new WorkOrderForm();
                        
                        invoice.Show();
                    }
                    else if (Engine.ActiveUser.usertype == "administrator")
                    {
                        
                        AdminForm admin = new AdminForm();
                        
                        admin.Show();
                    }
                    else if (Engine.ActiveUser.usertype == "contractor")
                    {
                        ContractorWorkOrderForm contractor = new ContractorWorkOrderForm();
                        
                        contractor.Show();
                    }
                }
                else
                {
                    MessageBox.Show(Engine.Login.message);
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void tooltip()
        {
            /**
             * If the email field is empty then a tooltip informs you that you need to enter an email address. 
             */
            if (string.IsNullOrEmpty(emailEntryTextBox.Text))
            {
                ToolTip tip = new ToolTip();
                tip.Show("Please Enter An Email Address", emailEntryTextBox, 10000);
            }
            /**
             * If the password field is empty then a tooltip informs you that you need to enter a password.
             */
            if (string.IsNullOrEmpty(passwordEntryTextBox.Text))
            {
                ToolTip tip2 = new ToolTip();
                tip2.Show("Please Enter A Password", passwordEntryTextBox, 10000);

            }
        }
    }
}
