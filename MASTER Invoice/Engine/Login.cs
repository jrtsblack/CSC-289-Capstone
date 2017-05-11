using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Engine
{
    public static class Login
    {
        static string path = AppDomain.CurrentDomain.BaseDirectory;
        static SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True");
        static string email; // Will be used to store the user name to validate who is logged in
        static string confirmed; // will be used to store the result when we check whether the user's account has been confirmed by the admin or not
        static string usertype; // will be used to hold the user's account type
        static string password; // will be used to hold the user's password
        public static bool success;
        public static string message;

        public static void logincomplete(string emailAddress, string pswd)
        {
            if (!string.IsNullOrEmpty(pswd) && !string.IsNullOrEmpty(emailAddress))
            {
                connection.Open();

                SqlCommand cmd = new SqlCommand("Select Email, Password, usertype, confirmed from UserAccounts where Email=@Email", connection);
                cmd.Parameters.AddWithValue("@Email", emailAddress.ToLower());
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                connection.Close();

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
                    bool verify = Engine.PasswordEncryption.VerifyPassword(pswd, password);

                    if (email == emailAddress.ToLower() && verify == true && confirmed == "True")
                    {
                        ActiveUser.email = email.ToLower();
                        ActiveUser.usertype = usertype;
                        getUserInfo(ActiveUser.usertype.ToLower(), ActiveUser.email.ToLower());
                        message = "Login Successful";
                        success = true;
                    }
                    else if (confirmed == "False")
                    {
                        message = "Your account has not been confirmed by the adminstrator yet";
                        success = false;
                    }
                    else if (verify == false)
                    {
                        message = "Invalid Password";
                        success = false;
                    }
                }
                else
                {
                    message = "That Email Address Was Not Found In Our Systems";
                    success = false;
                }
            }
        }

        private static void getUserInfo(string usertype, string email)
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
