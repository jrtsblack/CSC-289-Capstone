using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class Contractor
    {
        static string path = AppDomain.CurrentDomain.BaseDirectory;
        static SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True");

        static string query = "SELECT i.Invoice_ID, i.Contractor_ID, c.First, c.last, cont.First, cont.Last, i.Community_Name, i.Address, i.Primary#, i.Primary#Extension, i.Primary#Type, i.Alt#, i.Alt#Extension, i.Alt#Type, " +
            "i.Email, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.OccupantStatus, i.Complete, i.Comments, " +
            "i.InvoiceName FROM Invoice i LEFT OUTER JOIN Customer c ON (i.Customer_ID=c.Customer_ID) LEFT OUTER JOIN Contractor cont ON (i.Contractor_ID=cont.Contractor_ID) WHERE i.ContractorCompany_ID = 5 AND i.Contractor_ID IS NULL";

        static string query2 = "SELECT i.Invoice_ID, c.First, c.last, cont.First, cont.Last, i.Community_Name, i.Address, i.Primary#, i.Primary#Extension, i.Primary#Type, i.Alt#, i.Alt#Extension, i.Alt#Type, " +
            "i.Email, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.OccupantStatus, i.Complete, i.Comments, " +
            "i.InvoiceName FROM Invoice i LEFT OUTER JOIN Customer c ON (i.Customer_ID=c.Customer_ID) LEFT OUTER JOIN Contractor cont ON (i.Contractor_ID=cont.Contractor_ID) WHERE i.ContractorCompany_ID = " + ActiveUser.companyid + " AND i.Contractor_ID = " + ActiveUser.id;

        static string query4 = "UPDATE INVOICE SET ACCEPTED =@accepted , Contractor_ID =@contractorid WHERE InvoiceName =@invoicename";

        static string query5 = "UPDATE INVOICE SET Comments =@comments , Complete =@complete WHERE InvoiceName = @invoicename";

        public static string message;
        public static string firstname = " nothing assigned";
        public static string lastname;
        public static string address;
        public static string workordertype;
        public static string description;
        public static string tos;
        public static string pte;
        public static string pets;
        public static string date;
        public static bool complete;
        public static string comments;

        public static List<string> Fill_AvailableInvoices()
        {

            List<string> invoices = new List<string>();

            connection.Open();
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@compid", ActiveUser.companyid);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                invoices.Add(dr["InvoiceName"].ToString());
            }
            connection.Close();
            return invoices;
        }

        public static List<string> Fill_AcceptedInvoices()
        {
            List<string> invoices = new List<string>();

            connection.Open();
            SqlCommand cmd = new SqlCommand(query2, connection);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                invoices.Add(dr["InvoiceName"].ToString());
            }
            connection.Close();
            return invoices;
        }

        public static void updateInvoice(string comments, string status, string invoicename)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query5, connection);
            cmd.Parameters.AddWithValue("@comments", comments);
            if (status.ToLower() == "complete")
            {
                cmd.Parameters.AddWithValue("@complete", 1);
            }
            else if (status.ToLower() == "incomplete")
            {
                cmd.Parameters.AddWithValue("@complete", 0);
            }
            cmd.Parameters.AddWithValue("@invoicename", invoicename);
            cmd.ExecuteNonQuery();
            message = "Invoice Updated";
            connection.Close();
        }

        public static void acceptWorkOrder(string invoicename)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand(query4, connection);
            cmd.Parameters.AddWithValue("@accepted", 1);
            cmd.Parameters.AddWithValue("@contractorid", ActiveUser.id);
            cmd.Parameters.AddWithValue("@invoicename", invoicename);
            cmd.ExecuteNonQuery();
            connection.Close();
        }

        public static void selectedInvoice(string selectedinvoice)
        {
            connection.Open();
            string query3 = "SELECT i.Invoice_ID, c.Customer_ID, c.First as custFirst, c.Last as custLast, o.First as owFirst, o.Last as owLast, i.Address, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.Complete, i.Comments, i.InvoiceName FROM Invoice i LEFT OUTER JOIN Customer c ON (i.Customer_ID=c.Customer_ID) LEFT OUTER JOIN OfficeWorker o ON (i.OfficeWorker_ID=o.OfficeWorker_ID) WHERE InvoiceName=@selectedinvoice";

            SqlCommand cmd = new SqlCommand(query3, connection);
            cmd.Parameters.AddWithValue("@selectedinvoice", selectedinvoice);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Customer_ID"] == DBNull.Value)
                {
                    firstname = dr["owFirst"].ToString();
                    lastname = dr["owLast"].ToString();
                }
                else
                {
                    firstname = dr["custFirst"].ToString();
                    lastname = dr["custLast"].ToString();
                }
                    address = dr["Address"].ToString();
                    workordertype = dr["InvoiceType"].ToString();
                    description = dr["Description"].ToString();
                    tos = dr["TimeOfService"].ToString().ToUpper();
                    if (dr["PermissionToEnter"].ToString().ToLower() == "true")
                    {
                        pte = "Yes";
                    }
                    else if (dr["PermissionToEnter"].ToString().ToLower() == "false")
                    {
                        pte = "No";
                    }
                    if (dr["Pets"].ToString().ToLower() == "true")
                    {
                        pets = "True";
                    }
                    else if (dr["Pets"].ToString().ToLower() == "false")
                    {
                        pets = "False";
                    }
                    date = dr["DueDate"].ToString();
                    if (dr["Complete"].ToString().ToLower() == "true")
                    {
                        complete = true;
                    }
                    else if (dr["Complete"].ToString().ToLower() == "false")
                    {
                        complete = false;
                    }
                    comments = dr["Comments"].ToString();
                
            }
            connection.Close();
        }

       
    }
}
