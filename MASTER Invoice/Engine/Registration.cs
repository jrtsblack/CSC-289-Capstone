using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Net;

namespace Engine
{
    public static class Registration
    {
        static string path = AppDomain.CurrentDomain.BaseDirectory;
        static SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True");


        public static bool success = false;
        public static string message;

        public static void completeRegistration(string email, string password, string confirm, string checkedbutton,
            string firstname, string lastname, string phone, string company, string companyAddress, string companyPhone, string companyEmail)
        {
            string emailCheck = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            string passwordCheck = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])[0-9a-zA-Z]{6,}$";


            if (Regex.IsMatch(email, emailCheck) && Regex.IsMatch(password, passwordCheck) && password == confirm && emailAvailable(email))
            {
                if (checkedbutton == "Office Worker" || checkedbutton == "Occupant")
                {
                    //
                    if (checkedbutton == "Office Worker")
                    {
                        success = registerOfficeWorker(firstname, lastname, email, phone, password);

                    }
                    else if (checkedbutton == "Occupant")
                    {
                        success = registerOccupant(firstname, lastname, email, phone, password);
                    }
                }
                else if (checkedbutton == "Contractor")
                {
                    if (Regex.IsMatch(companyEmail, emailCheck))
                    {
                        success = registerContractor(firstname, lastname, email, phone, password, company, companyAddress, companyPhone, companyEmail);
                    }
                    else
                    {
                        message = " Company Email is Invalid";
                    }
                }

            }
            else if (!Regex.IsMatch(email, emailCheck) && !string.IsNullOrEmpty(email))
            {
                message = "Email is invalid";
            }
            else if (!Regex.IsMatch(password, passwordCheck) && !string.IsNullOrEmpty(password))
            {
                message = "Password does not meet all requirements \n 1) Password Must Be At Minimum 6 Characters\n 2) Password Must Contain At Least One Uppercase Letter\n 3) Password Must Contain At Least One Lowercase Letter\n 4) Password Must Contain At Least One Number";
            }
            else if ((password != confirm) && !string.IsNullOrEmpty(password) && !string.IsNullOrEmpty(confirm))
            {
                message = "Passwords Do Not Match";
                
            }
            else if (!emailAvailable(email))
            {
                message = "Email already in use";
            }
            else if(string.IsNullOrEmpty(checkedbutton))
            {
                message = "No User Type Selected";
            }

        }
     

        private static bool emailAvailable(string email)
        {
            
            bool available = false;

            connection.Open();
            SqlCommand cmd = new SqlCommand("select email from UserAccounts where email=@email", connection);
            cmd.Parameters.AddWithValue("@email", email.ToLower());
            connection.Close();
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            data.Fill(table);
            if (table.Rows.Count > 0)
            {
                available = false;
            }
            else
            {
                available = true;
            }
            return available;
        }

        private static bool registerOfficeWorker(string firstname, string lastname, string email, string phone, string password)
        {
            connection.Open();
            string pswd = PasswordEncryption.CreateHash(password);
            SqlCommand cmd = new SqlCommand("insert into UserAccounts ([Email], [Password], [UserType], [Confirmed]) VALUES (@email, @password, @usertype, @confirmed)", connection);
            cmd.Parameters.AddWithValue("@email", email.ToLower());
            cmd.Parameters.AddWithValue("@password", pswd);
            cmd.Parameters.AddWithValue("@usertype", "Office Worker");
            cmd.Parameters.AddWithValue("@confirmed", 0);
            int i = cmd.ExecuteNonQuery();

            SqlCommand owcmd = new SqlCommand("Insert into OfficeWorker (First, Last, Email, Phone#) VALUES (@firstname, @lastname, @emailaddress, @phonenumber)", connection);
            owcmd.Parameters.AddWithValue("@firstname", firstname);
            owcmd.Parameters.AddWithValue("@lastname", lastname);
            owcmd.Parameters.AddWithValue("@emailaddress", email.ToLower());
            owcmd.Parameters.AddWithValue("@phonenumber", phone);
            int j = owcmd.ExecuteNonQuery();
            connection.Close();
            confirmationEmail(email, firstname + " " + lastname);
            if (i > 0 && j > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool registerOccupant(string firstname, string lastname, string email, string phone, string password)
        {
            connection.Open();
            string pswd = PasswordEncryption.CreateHash(password);
            SqlCommand cmd = new SqlCommand("insert into UserAccounts ([Email], [Password], [UserType], [Confirmed]) VALUES (@email, @password, @usertype, @confirmed)", connection);
            cmd.Parameters.AddWithValue("@email", email.ToLower());
            cmd.Parameters.AddWithValue("@password", pswd);
            cmd.Parameters.AddWithValue("@usertype", "Occupant");
            cmd.Parameters.AddWithValue("@confirmed", 0);
            int i = cmd.ExecuteNonQuery();

            SqlCommand occmd = new SqlCommand("Insert into Customer (First, Last, Email, Phone#) VALUES (@firstname, @lastname, @emailaddress, @phonenumber)", connection);
            occmd.Parameters.AddWithValue("@firstname", firstname);
            occmd.Parameters.AddWithValue("@lastname", lastname);
            occmd.Parameters.AddWithValue("@emailaddress", email.ToLower());
            occmd.Parameters.AddWithValue("@phonenumber", phone);
            int j = occmd.ExecuteNonQuery();
            connection.Close();
            confirmationEmail(email, firstname + " " + lastname);

            if (i > 0 && j > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool registerContractor(string firstname, string lastname, string email, string phone, string password, string company, string companyAddress, string companyPhone, string companyEmail)
        {
            connection.Open();
            string pswd = PasswordEncryption.CreateHash(password);
            SqlCommand cmd = new SqlCommand("insert into UserAccounts ([Email], [Password], [UserType], [Confirmed]) VALUES (@email, @password, @usertype, @confirmed)", connection);
            cmd.Parameters.AddWithValue("@email", email.ToLower());
            cmd.Parameters.AddWithValue("@password", pswd);
            cmd.Parameters.AddWithValue("@usertype", "Contractor");
            cmd.Parameters.AddWithValue("@confirmed", 0);
            int i = cmd.ExecuteNonQuery();

            int j = companyCheck(company, firstname, lastname, email, phone, companyAddress, companyPhone, companyEmail).ExecuteNonQuery();

            connection.Close();
            confirmationEmail(email, firstname + " " + lastname);

            if (i > 0 && j > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static SqlCommand companyCheck(string company, string first, string last, string email, string phone,
            string companyAddress, string companyPhone, string companyEmail)
        {
            SqlCommand existing;
            SqlCommand checking = new SqlCommand("Select * from ContractorCompany where company_name=@name", connection);
            checking.Parameters.AddWithValue("@name", System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(company));
            SqlDataAdapter data = new SqlDataAdapter(checking);
            DataTable table = new DataTable();
            data.Fill(table);

            if (table.Rows.Count > 0)
            {
                existing = new SqlCommand("Insert into Contractor (Company_ID, First, Last, Email, Phone#) VALUES (@compid, @firstname, @lastname, @emailaddress, @phonenumber)", connection);
                existing.Parameters.AddWithValue("@compid", table.Rows[0]["Company_ID"]);
                existing.Parameters.AddWithValue("@firstname", first);
                existing.Parameters.AddWithValue("@lastname", last);
                existing.Parameters.AddWithValue("@emailaddress", email);
                existing.Parameters.AddWithValue("@phonenumber", phone);
            }
            else
            {
                SqlCommand newCompany = new SqlCommand("insert into ContractorCompany ([Company_Name], [Company_Address], [Phone#], [Email]) VALUES (@compName, @compAddress, @phone, @email)", connection);
                newCompany.Parameters.AddWithValue("@compName", System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(company));
                newCompany.Parameters.AddWithValue("@compAddress", companyAddress);
                newCompany.Parameters.AddWithValue("@phone", companyPhone);
                newCompany.Parameters.AddWithValue("@email", companyEmail);

                newCompany.ExecuteNonQuery();

                SqlCommand getNew = new SqlCommand("Select * from ContractorCompany where company_name=@name", connection);
                getNew.Parameters.AddWithValue("@name", System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(company));
                SqlDataAdapter newData = new SqlDataAdapter(getNew);
                DataTable dt = new DataTable();
                data.Fill(dt);

                existing = new SqlCommand("Insert into Contractor (Company_ID, First, Last, Email, Phone#) VALUES (@compid, @firstname, @lastname, @emailaddress, @phonenumber)", connection);
                existing.Parameters.AddWithValue("@compid", dt.Rows[0]["Company_ID"]);
                existing.Parameters.AddWithValue("@firstname", first);
                existing.Parameters.AddWithValue("@lastname", last);
                existing.Parameters.AddWithValue("@emailaddress", email);
                existing.Parameters.AddWithValue("@phonenumber", phone);
            }
            return existing;

        }

        private static void confirmationEmail(string email, string name)
        {
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("csc289invoice@gmail.com");
            msg.To.Add(email);
            msg.Subject = "Welcome " + name + "!";
            msg.Body = "You have successfully registered for the invoice application. Your account is currently " +
                "pending approval. You will be contacted once it has been approved" ;
            SmtpClient client = new SmtpClient();
            client.UseDefaultCredentials = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.Credentials = new NetworkCredential("csc289invoice@gmail.com", "Capstone1");
            client.Timeout = 20000;
            try
            {
                client.Send(msg);
            }
            catch (Exception ex)
            {
                message = ex.Message;
            }
            finally
            {
                msg.Dispose();
            }
        }
    }
}
