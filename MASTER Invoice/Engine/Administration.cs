using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;


namespace Engine
{

    public static class Administration
    {
        static string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        static SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True");
        public static DataTable datatable;
        public static SqlDataAdapter invoiceAdapter;
        public static string message;
        public static DataTable activateAccount(string dt, string email)
        {
            string updatesql = "UPDATE UserAccounts SET Confirmed='1' WHERE email IN (" + dt + ")";

            connection.Open();
            SqlCommand cmd = new SqlCommand(updatesql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            string update = "SELECT * FROM UserAccounts";

            SqlDataAdapter userAdapter = new SqlDataAdapter(update, connection);
            datatable = new DataTable();
            datatable.Clear();
            userAdapter.Fill(datatable);

            confirmationEmail(email);
            return datatable;

        }

        public static DataTable unconfirmedAccounts()
        {
            connection.Open();
            string unconfirmedsql = "SELECT * FROM UserAccounts WHERE confirmed=0";
            SqlDataAdapter unconfirmedAdapter = new SqlDataAdapter(unconfirmedsql, connection);
            datatable = new DataTable();
            datatable.Clear();
            unconfirmedAdapter.Fill(datatable);
            connection.Close();

            return datatable;
        }

        public static DataTable allAccounts()
        {

            connection.Open();
            string allsql = "SELECT * FROM UserAccounts";
            SqlDataAdapter allAdapter = new SqlDataAdapter(allsql, connection);
            datatable = new DataTable();
            datatable.Clear();
            allAdapter.Fill(datatable);
            connection.Close();

            return datatable;
        }

        public static DataTable deleteUsers(string dt, string usertype)
        {
            connection.Open();
            string deletesql = "DELETE FROM UserAccounts WHERE email IN (" + dt + ")";
            message = deletesql;
            if(usertype.Contains("occupant"))
            {
               string deletesql2 = "DELETE FROM Customer WHERE email IN (" + dt + ")";
                SqlCommand cmd2 = new SqlCommand(deletesql2, connection);
                cmd2.ExecuteNonQuery();

            }
            if (usertype.Contains("office worker"))
            {
                string deletesql2 = "DELETE FROM OfficeWorker WHERE email IN (" + dt + ")";
                SqlCommand cmd2 = new SqlCommand(deletesql2, connection);
                cmd2.ExecuteNonQuery();

            }
            if (usertype.Contains("contractor"))
            {
                string deletesql2 = "DELETE FROM Contractor WHERE email IN (" + dt + ")";
                SqlCommand cmd2 = new SqlCommand(deletesql2, connection);
                cmd2.ExecuteNonQuery();
            }

            SqlCommand cmd = new SqlCommand(deletesql, connection);
            cmd.ExecuteNonQuery();
            string update = "SELECT * FROM UserAccounts";

            SqlDataAdapter userAdapter = new SqlDataAdapter(update, connection);
            datatable = new DataTable();
            datatable.Clear();
            userAdapter.Fill(datatable);
            connection.Close();

            return datatable;
        }

        public static DataTable deleteInvoices(string dt)
        {
            connection.Open();
            string deletesql = "DELETE FROM Invoice WHERE invoice_id IN (" + dt + ")";

            SqlCommand cmd = new SqlCommand(deletesql, connection);
            cmd.ExecuteNonQuery();
            string update = "SELECT * FROM invoice";

            SqlDataAdapter userAdapter = new SqlDataAdapter(update, connection);
            datatable = new DataTable();
            datatable.Clear();
            userAdapter.Fill(datatable);
            connection.Close();

            return datatable;
        }

        public static DataTable allInvoices()
        {
            connection.Open();
            string allinvoice = "SELECT * FROM Invoice";
            SqlDataAdapter invoiceAdapter = new SqlDataAdapter(allinvoice, connection);
            datatable = new DataTable();
            invoiceAdapter.Fill(datatable);

            connection.Close();
            return datatable;
        }

        private static void confirmationEmail(string email)
        {
            MailMessage msg = new MailMessage();

            msg.From = new MailAddress("csc289invoice@gmail.com");
            msg.To.Add(email);
            msg.Subject = "Invoice Account Update!";
            msg.Body = "Your account is now active.";
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
