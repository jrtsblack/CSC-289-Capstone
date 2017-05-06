using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class WorkOrders
    {
        static string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        static string connectionstring = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True";
        static string invoice;
        static string query = "SELECT i.Invoice_ID, c.First, c.last, o.First, o.Last, i.Community_Name, i.Address, i.Primary#, i.Primary#Extension, i.Primary#Type, i.Alt#, i.Alt#Extension, i.Alt#Type, " +
            "i.Email, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.OccupantStatus, i.Complete, i.Comments, " +
            "i.InvoiceName FROM Invoice i LEFT OUTER JOIN Customer c ON (i.Customer_ID=c.Customer_ID) LEFT OUTER JOIN OfficeWorker o ON (i.OfficeWorker_ID=o.OfficeWorker_ID)";

        static string query3 = "SELECT i.Invoice_ID, c.First, c.last, i.Community_Name, i.Address, i.Primary#, i.Primary#Extension, i.Primary#Type, i.Alt#, i.Alt#Extension, i.Alt#Type, " +
            "i.Email, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.OccupantStatus, i.Complete, i.Comments, " +
            "i.InvoiceName FROM Invoice i INNER JOIN Customer c ON i.Customer_ID=c.Customer_ID WHERE i.Customer_ID = " + ActiveUser.id;

        public static DataTable dt;

        public static string message;
        public static string firstname;
        public static string lastname;
        public static string customerfirstname;
        public static string customerlastname;
        public static string address;
        public static string community;
        public static string primarynum;
        public static string primaryext;
        public static string primarytype;
        public static string altnum;
        public static string altext;
        public static string alttype;
        public static string email;
        public static string invoicetype;
        public static string description;
        public static string tos;
        public static string pte;
        public static string pets;
        public static bool complete;
        public static string comments;
        public static bool occupantstatus;
        public static string contractorid;
        public static string contractorname;
        public static DateTime? date;

        public static List<string> Fill_ListBox()
        {
            
            List<string> invoices = new List<string>();
            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            if (ActiveUser.usertype.ToLower() == "office worker" || ActiveUser.usertype.ToLower() == "administrator")
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                
            }
            else if (ActiveUser.usertype.ToLower() == "occupant")
            {
                SqlCommand cmd = new SqlCommand(query3, connection);
                cmd.ExecuteNonQuery();
                dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

            }
            connection.Close();
            foreach (DataRow dr in dt.Rows)
            {
                invoices.Add(dr["InvoiceName"].ToString());
            }

                return invoices;
        }

        public static void updateInvoice(string company, string invoice, string address, string community, string phonenum, 
            string phoneext, string phonetype, string altnum, string altext, string alttype, string email, string workordertype,
            string tos, string pte, string pets, string comments, DateTime? date, string description, string first, string last)
        {
            SqlConnection connection = new SqlConnection(connectionstring);

            int? company_id = 0;
            string occupancy_status = " ";
            bool complete = false;
            string companyquery = "SELECT Company_ID FROM ContractorCompany WHERE Company_Name= '" + company + "'";

            string invoiceUpdate = "UPDATE Invoice SET Invoice.Address " +
                "= @address, Invoice.OfficeWorker_ID = @officeworkerid, Invoice.Primary# = @primenum, Invoice.Primary#Extension = @primenumext, Invoice.Primary#Type " +
                "= @primenumtype, Invoice.Alt# = @altnum, Invoice.Alt#Extension = @altnumext, Invoice.Alt#Type = @altnumtype, Invoice.Email = @email, Invoice.InvoiceType " +
                "= @invoicetype, Invoice.TimeOfService = @tos, Invoice.PermissionToEnter = @pte, Invoice.Pets = @pets, Invoice.Comments = @comments, Invoice.Complete " +
                "= @complete, Invoice.OccupantStatus = @occupantstatus, Invoice.ContractorCompany_ID = @contractorcompany_id, Invoice.DueDate = @duedate, Invoice.Description = @description " +
                "FROM Invoice LEFT OUTER JOIN Customer ON (Invoice.Customer_ID = Customer.Customer_ID) LEFT OUTER JOIN OfficeWorker ON (Invoice.OfficeWorker_ID = OfficeWorker.OfficeWorker_ID) WHERE InvoiceName =@invoicename";

            string customerUpdate = "UPDATE Customer SET Customer.First = @first, Customer.Last = @last FROM Customer INNER JOIN Invoice ON Invoice.Customer_ID = Customer.Customer_ID " +
                "WHERE InvoiceName =@invoicename AND Invoice.Customer_ID = Customer.Customer_ID";
            string officeUpdate = "UPDATE OfficeWorker SET OfficeWorker.First = @first, OfficeWorker.Last = @last FROM OfficeWorker INNER JOIN Invoice ON Invoice.OfficeWorker_ID = OfficeWorker.OfficeWorker_ID " +
                "WHERE InvoiceName =@invoicename AND Invoice.OfficeWorker_ID = OfficeWorker.OfficeWorker_ID";
            string name = invoice;
            using (connection)
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;
                transaction = connection.BeginTransaction("SampleTransaction");
                command.Connection = connection;
                command.Transaction = transaction;
                try
                {
                    command.CommandText = companyquery;
                    company_id = Convert.ToInt32(command.ExecuteScalar());
                    command.CommandText = invoiceUpdate;
                    command.Parameters.AddWithValue("@officeworkerid", ActiveUser.id);
                    command.Parameters.AddWithValue("@address", address);
                    command.Parameters.AddWithValue("@community", community);
                    command.Parameters.AddWithValue("@primenum", phonenum);
                    command.Parameters.AddWithValue("@primenumext", phoneext);
                    command.Parameters.AddWithValue("@primenumtype", phonetype);
                    command.Parameters.AddWithValue("@altnum", altnum);
                    command.Parameters.AddWithValue("@altnumext", altext);
                    command.Parameters.AddWithValue("@altnumtype", alttype);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@invoicetype", workordertype);
                    command.Parameters.AddWithValue("@tos", tos);
                    command.Parameters.AddWithValue("@pte", pte);
                    command.Parameters.AddWithValue("@pets", pets);
                    command.Parameters.AddWithValue("@comments", comments);
                    command.Parameters.AddWithValue("@complete", complete);
                    command.Parameters.AddWithValue("@occupantstatus", occupancy_status);
                    if (company_id == 0)
                    {
                        company_id = null;
                        command.Parameters.AddWithValue("@contractorcompany_id", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@contractorcompany_id", company_id);
                    }
                    if (date.HasValue)
                    {
                        command.Parameters.AddWithValue("@duedate", date.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@duedate", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@invoicename", name);
                    command.Parameters.AddWithValue("description", description);
                    command.ExecuteNonQuery();

                    command.CommandText = customerUpdate;
                    command.Parameters.AddWithValue("@first", first);
                    command.Parameters.AddWithValue("@last", last);
                    command.ExecuteNonQuery();
                    command.CommandText = officeUpdate;
                    command.ExecuteNonQuery();

                    transaction.Commit();
                    message = "Invoice Updated";
                }
                catch (Exception ex)
                {
                    message = ex.Message;
                }
                connection.Close();
            }
        }

        public static void selectedInvoice(string selectedinvoice)
        {
            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            invoice = selectedinvoice;

            string query2 = "SELECT i.Invoice_ID, c.Customer_ID, c.First as custFirst, c.Last as custLast, o.First as owFirst, o.Last as owLast, i.Community_Name, i.Address, i.Primary#, i.Primary#Extension, i.Primary#Type, i.Alt#, i.Alt#Extension, i.Alt#Type, i.Email, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.OccupantStatus, i.Complete, i.Comments, i.InvoiceName FROM Invoice i LEFT OUTER JOIN Customer c ON (i.Customer_ID=c.Customer_ID) LEFT OUTER JOIN OfficeWorker o ON (i.OfficeWorker_ID=o.OfficeWorker_ID) WHERE InvoiceName= '" + invoice + "'";

            SqlCommand cmd = new SqlCommand(query2, connection);
            cmd.ExecuteNonQuery();
            dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);

            foreach (DataRow dr in dt.Rows)
            {
                object value = dr["Customer_ID"];
                if (value == DBNull.Value)
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
                community = dr["Community_Name"].ToString();
                primarynum = dr["Primary#"].ToString();
                primaryext = dr["Primary#Extension"].ToString();
                primarytype = dr["Primary#Type"].ToString();
                altnum = dr["Alt#"].ToString();
                altext = dr["Alt#Extension"].ToString();
                alttype = dr["Alt#Type"].ToString();
                email = dr["Email"].ToString();
                invoicetype = dr["InvoiceType"].ToString();
                description = dr["Description"].ToString();
                tos = dr["TimeOfService"].ToString();
                if (dr["PermissionToEnter"].ToString().ToLower() == "true")
                {
                    pte = "True";
                }
                else if (dr["PermissionToEnter"].ToString().ToLower() == "false")
                {
                    pte = "False";
                }
                if (dr["Pets"].ToString().ToLower() == "true")
                {
                    pets = "True";
                }
                else if (dr["Pets"].ToString().ToLower() == "false")
                {
                    pets = "False";
                }
                if (dr["Complete"].ToString().ToLower() == "true")
                {
                    complete = true;
                }
                else if (dr["Complete"].ToString().ToLower() == "false")
                {
                    complete = false;
                }
                comments = dr["Comments"].ToString();
                if (dr["OccupantStatus"].ToString().ToLower() == "occupied")
                {
                    occupantstatus = true;
                }
                else if (dr["OccupantStatus"].ToString().ToLower() == "unoccupied")
                {
                   occupantstatus = false;
                }
                if (String.IsNullOrEmpty(dr["ContractorCompany_ID"].ToString()))
                {
                    contractorid = null;
                }
                else
                {
                    contractorid = dr["ContractorCompany_ID"].ToString();
                    SqlCommand contractorcomp = new SqlCommand("Select Company_Name FROM ContractorCompany WHERE Company_ID=" + Convert.ToInt32(contractorid), connection);
                    contractorcomp.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(contractorcomp);
                    da2.Fill(dt2);
                    contractorname = dt2.Rows[0]["Company_Name"].ToString();
                }
                if (dr["DueDate"] == DBNull.Value)
                {
                    date = null;
                }
                else
                {
                    date = Convert.ToDateTime(dr["DueDate"].ToString());
                }
            }
            connection.Close();

        }

        public static void saveInvoice(string altnum, string community, string address, string email, string primarynum, 
            string primarytype, string primaryext, string tos, string workordertype, string description, string permission, string animal)
        {
            SqlConnection connection = new SqlConnection(connectionstring);

            connection.Open();
            SqlCommand saveInvoice;
            SqlCommand invoicename = new SqlCommand("DECLARE @myVar int SET @myVar = 0 UPDATE Invoice SET @myVar = @myVar + 1, InvoiceName =  CONCAT(@address, @myvar) WHERE address = @address", connection);
            invoicename.Parameters.AddWithValue("@address", address);

            if (string.IsNullOrWhiteSpace(altnum))
            {
                saveInvoice = new SqlCommand("INSERT INTO invoice (Customer_ID, community_name, occupantStatus, "
                + "address, email, primary#, primary#type, primary#extension, "
                + "permissiontoenter, pets, accepted, complete, timeOfService, "
                + "invoiceType, description) VALUES (@custid, @communityname, @occStatus, @address, "
                + "@emailaddress, @primarynum, @phonetype, @primaryex,  @pte, @pet, @accepted, @complete, "
                + "@timeOfService, @invoiceType, @description)", connection);

                saveInvoice.Parameters.AddWithValue("@custid", ActiveUser.id);
                saveInvoice.Parameters.AddWithValue("@communityname", community);
                saveInvoice.Parameters.AddWithValue("@occStatus", "Occupied");
                saveInvoice.Parameters.AddWithValue("@address", address);
                saveInvoice.Parameters.AddWithValue("@emailaddress", email);
                saveInvoice.Parameters.AddWithValue("@primarynum", primarynum);
                saveInvoice.Parameters.AddWithValue("@phonetype", primarytype);
                saveInvoice.Parameters.AddWithValue("@primaryex", primaryext);
                saveInvoice.Parameters.AddWithValue("@pte", getPTE(permission));
                saveInvoice.Parameters.AddWithValue("@pet", getPET(animal));
                saveInvoice.Parameters.AddWithValue("@accepted", false);
                saveInvoice.Parameters.AddWithValue("@complete", false);
                saveInvoice.Parameters.AddWithValue("@timeOfService", tos);
                saveInvoice.Parameters.AddWithValue("@invoiceType", workordertype);
                saveInvoice.Parameters.AddWithValue("@description", description);
            }
            else
            {
                saveInvoice = new SqlCommand("INSERT INTO invoice (Customer_ID, community_name, occupantStatus, "
                + "address, email, primary#, primary#Type, primary#Extension, alt#, "
                + "alt#Extension, alt#Type, permissiontoenter, pets, accepted, complete, timeOfService, "
                + "invoiceType, description) VALUES (@custid, @communityname, @occStatus, @address, "
                + "@emailaddress, @primarynum, @phonetype, @primaryex, @altnum, @altphonetype, "
                + "@altex, @pte, @pet, @accepted, @complete, @timeOfService, @invoiceType, @description)", connection);

                saveInvoice.Parameters.AddWithValue("@custid", ActiveUser.id);
                saveInvoice.Parameters.AddWithValue("@communityname", community);
                saveInvoice.Parameters.AddWithValue("@occStatus", true);
                saveInvoice.Parameters.AddWithValue("@address", address);
                saveInvoice.Parameters.AddWithValue("@emailaddress", email);
                saveInvoice.Parameters.AddWithValue("@primarynum", primarynum);
                saveInvoice.Parameters.AddWithValue("@phonetype",primarytype);
                saveInvoice.Parameters.AddWithValue("@primaryex", primaryext);
                saveInvoice.Parameters.AddWithValue("@altnum", altnum);
                saveInvoice.Parameters.AddWithValue("@altphonetype", alttype);
                saveInvoice.Parameters.AddWithValue("@altex", altext);
                saveInvoice.Parameters.AddWithValue("@pte", getPTE(permission));
                saveInvoice.Parameters.AddWithValue("@pet", getPET(animal));
                saveInvoice.Parameters.AddWithValue("@accepted", false);
                saveInvoice.Parameters.AddWithValue("@complete", false);
                saveInvoice.Parameters.AddWithValue("@timeOfService", tos);
                saveInvoice.Parameters.AddWithValue("@invoiceType", invoicetype);
                saveInvoice.Parameters.AddWithValue("@description", description);
            }

            int i = 0;
            i += saveInvoice.ExecuteNonQuery();
            i += invoicename.ExecuteNonQuery();

            if(i > 1)
            {
                message = "Information Successfully Saved";
            }

            connection.Close();

        }

        private static bool getPTE(string permission)
        {
            bool permissionToEnter = false;
            if (permission == "yes")
            {
                permissionToEnter = true;
            }
            else if (permission == "no")
            {
                permissionToEnter = false;
            }
            return permissionToEnter;
        }

        private static bool getPET(string animals)
        {
            bool animal = false;
            if (animals == "yes")
            {
                animal = true;
            }
            else if (animals == "no")
            {
                animal = false;
            }
            return animal;
        }


    }
}
