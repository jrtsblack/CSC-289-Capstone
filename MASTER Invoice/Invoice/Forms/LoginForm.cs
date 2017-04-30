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
        static string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True");

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
            string email; // Will be used to store the user name to validate who is logged in
            string confirmed; // will be used to store the result when we check whether the user's account has been confirmed by the admin or not
            string usertype; // will be used to hold the user's account type
            string password; // will be used to hold the user's password

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
            /**
             * If both fields are filled then a connection to the invoicelogin will be established.  
             */
            else if (!string.IsNullOrEmpty(passwordEntryTextBox.Text) && !string.IsNullOrEmpty(emailEntryTextBox.Text))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Select Email, Password, usertype, confirmed from UserAccounts where Email=@Email", connection);
                cmd.Parameters.AddWithValue("@Email", emailEntryTextBox.Text.ToLower());
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                /**
                 *  Fill the DataTable with results from the query. 
                 *  If the table has at least one row then that means the email that was entered was found in the database
                 * */
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    password = dt.Rows[0]["Password"].ToString();
                    email = dt.Rows[0]["Email"].ToString().ToLower();          // Store the username from your DataTable 
                    usertype = dt.Rows[0]["usertype"].ToString().ToLower(); // Store the usertype item from your dataTable into the usertype variable
                    confirmed = dt.Rows[0]["confirmed"].ToString(); // store the confirmed item from your dataTable
                    bool verify = Engine.PasswordEncryption.VerifyPassword(passwordEntryTextBox.Text, password);

                    if (email == emailEntryTextBox.Text.ToLower() && verify == true && confirmed == "True")
                    {
                        ActiveUser.email = email.ToLower();
                        ActiveUser.usertype = usertype;
                        getIDandUserInfo(ActiveUser.usertype.ToLower(), ActiveUser.email.ToLower());
                        if (usertype == "occupant" || usertype == "office worker")
                        {
                            
                            MessageBox.Show("Login Successful!");

                            WorkOrderForm invoice = new WorkOrderForm();
                            this.Hide();
                            invoice.Show();
                        }
                        else if (usertype == "administrator")
                        {
                            MessageBox.Show("Login Successful!");
                            AdminForm invoice = new AdminForm();
                            this.Hide();
                            invoice.Show();
                        }
                        else if (usertype == "contractor")
                        {
                            MessageBox.Show("Login Successful!");
                            ContractorWorkOrderForm workOrder = new ContractorWorkOrderForm();
                            this.Hide();
                            workOrder.Show();
                        }
                    }
                    /**
                     * Checks to see if the administrator has confirmed the account and if not then inform the user that it has yet to be confirmed/activated
                     */
                    else if (confirmed == "False")
                    {
                        MessageBox.Show("Your account has not been confirmed by the adminstrator yet");
                    }
                    else if (verify == false)
                    {
                        MessageBox.Show("Invalid Password");
                    }
                }
                else
                {
                    MessageBox.Show("That Email Address Was Not Found In Our Systems");
                }
                connection.Close();
            }

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        private void getIDandUserInfo(string usertype, string email)
        {
            int id;
            string firstname;
            string lastname;
            string phone;
            
            if (usertype == "occupant")
            {
                SqlCommand occ = new SqlCommand("Select * From Customer WHERE email =@email", connection);
                occ.Parameters.AddWithValue("@email", email);
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(occ);
                da.Fill(dt);

                id = Int32.Parse(dt.Rows[0]["Customer_ID"].ToString());
                firstname = dt.Rows[0]["First"].ToString();
                MessageBox.Show(firstname);
                lastname = dt.Rows[0]["Last"].ToString();
                phone = dt.Rows[0]["Phone#"].ToString();
                ActiveUser.id = id;
                ActiveUser.firstname = firstname;
                ActiveUser.lastname = lastname;
                ActiveUser.phonenum = phone;
            }
            else if (usertype == "office worker")
            {
                SqlCommand occ = new SqlCommand("Select * From OfficeWorker WHERE email =@email", connection);
                occ.Parameters.AddWithValue("@email", email);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(occ);
                da.Fill(dt);

                id = Int32.Parse(dt.Rows[0]["OfficeWorker_ID"].ToString());
                firstname = dt.Rows[0]["First"].ToString();
                lastname = dt.Rows[0]["Last"].ToString();
                phone = dt.Rows[0]["Phone#"].ToString();
                ActiveUser.id = id;
                ActiveUser.firstname = firstname;
                ActiveUser.lastname = lastname;
                ActiveUser.phonenum = phone;
            }
            else if (usertype == "contractor")
            {
                SqlCommand occ = new SqlCommand("Select * From Contractor WHERE email =@email", connection);
                occ.Parameters.AddWithValue("@email", email);
                

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(occ);
                da.Fill(dt);

                id = Int32.Parse(dt.Rows[0]["Contractor_ID"].ToString());
                firstname = dt.Rows[0]["First"].ToString();
                lastname = dt.Rows[0]["Last"].ToString();
                phone = dt.Rows[0]["Phone#"].ToString();
                int companyid = Int32.Parse(dt.Rows[0]["Company_ID"].ToString());
                ActiveUser.id = id;
                ActiveUser.firstname = firstname;
                ActiveUser.lastname = lastname;
                ActiveUser.phonenum = phone;
                ActiveUser.companyid = companyid;
            }
            else if (usertype == "Administrator")
            {
                ActiveUser.id = 0;
                ActiveUser.phonenum = "555-555-5555";
            }
        }
    }
}
