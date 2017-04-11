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
            // Assign false to logged in.
            if (!string.IsNullOrEmpty(emailEntryTextBox.Text))
            {
                // Open connection to ProjectDB
                OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProjectDB.accdb; Persist Security Info = True");
                connection.Open();

                // Set command to change login status to false
                OleDbCommand loggedOut = new OleDbCommand("UPDATE UserAccounts SET LoggedIn = '0'" + 
                    "WHERE Email = '" + emailEntryTextBox.Text.ToLower() + "';", connection);
                loggedOut.ExecuteNonQuery();

                // Close ProjectDB connection
                connection.Close();
            }
            Application.Exit();
        }

        /**
         * Checks Login creditials to determine if you can login
         */
        private void loginButton_Click(object sender, EventArgs e)
        {
            string email; // Will be used to store the user name to validate who is logged in
            string confirmed; // will be used to store the result when we check whether the user's account has been confirmed by the admin or not
            string usertype; // will be used to hold the user's account type
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
                tip2.Show("Please Enter A Passwords", passwordEntryTextBox, 10000);

            }
            /**
             * If both fields are filled then a connection to the invoicelogin will be established.  
             */
            else if (!string.IsNullOrEmpty(passwordEntryTextBox.Text) && !string.IsNullOrEmpty(emailEntryTextBox.Text))
            {
                OleDbConnection connection = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProjectDB.accdb; Persist Security Info = True");
                connection.Open();

                /**
                 * MySQLCommand that will be used to query the database using the entered email and password
                 */
                OleDbCommand command = new OleDbCommand("Select Email, Password, UserType, Confirmed from UserAccounts where Email='" + emailEntryTextBox.Text.ToLower() + "'and Password='" + passwordEntryTextBox.Text + "'", connection);

                /**
                 *  Fill the DataTable with results from the query. 
                 *  If the table has at least one row then that means the login information entered was that of a registered user and login was successful.
                 *  In the future logging successfully will result in you being taken to another form. For now you are only informed of your successful login. 
                 *  If the table has no rows, then either your email-password combination could not be found in our records and the login was unsuccessful. 
                 * */
                OleDbDataAdapter data = new OleDbDataAdapter(command);
                DataTable table = new DataTable();
                data.Fill(table);
                if (table.Rows.Count > 0)
                {
                    email = table.Rows[0]["email"].ToString();  // Store the username from your DataTable 
                    usertype = table.Rows[0]["usertype"].ToString(); // Store the usertype item from your dataTable into the usertype variable
                    confirmed = table.Rows[0]["confirmed"].ToString(); // store the confirmed item from your dataTable
                    /**
                     * Checks to see if the administrator has confirmed the account and if not then inform the user that it has yet to be confirmed/activated
                     */
                    if (confirmed == "False")
                    {
                        MessageBox.Show("Your account has not been confirmed by the adminstrator yet");
                    }
                    /**
                     * If the adminstrator has confirmed the user's account then next the usertype is checked to determine which form the user should see. 
                     * For now the occupant, contractor and office worker all see the same form but eventually all three will have different level's of access. 
                     */
                    else if (confirmed == "True")
                    {
                        if (usertype == "Occupant" || usertype == "Office Worker")
                        {
                            // Set user loggedIn status to True
                            OleDbCommand loggedIn = new OleDbCommand("UPDATE UserAccounts SET LoggedIn = '1'" +
                                "WHERE Email =" + "'" + email + "'", connection);
                            loggedIn.ExecuteNonQuery();

                            MessageBox.Show("Login Successful!");
                            WorkOrderForm invoice = new WorkOrderForm();
                            this.Hide();
                            invoice.Show();
                        }
                        else if (usertype == "Administrator")
                        {
                            // Set user loggedIn status to True
                            OleDbCommand loggedIn = new OleDbCommand("UPDATE UserAccounts SET LoggedIn = '1'" +
                                " WHERE Email =" + "'" + email + "'", connection);
                                loggedIn.ExecuteNonQuery();


                            MessageBox.Show("Login Successful!");
                            AdminForm invoice = new AdminForm();
                            this.Hide();
                            invoice.Show();
                        }
                        else if (usertype == "Contractor")
                        {
                            // Set user loggedIn status to True
                            OleDbCommand loggedIn = new OleDbCommand("UPDATE UserAccounts SET LoggedIn = '1'" +
                                "WHERE Email =" + "'" + email + "'", connection);
                            loggedIn.ExecuteNonQuery();

                            MessageBox.Show("Login Successful!");
                            ContractorWorkOrderForm workOrder = new ContractorWorkOrderForm();
                            this.Hide();
                            workOrder.Show();
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }
    }
}
