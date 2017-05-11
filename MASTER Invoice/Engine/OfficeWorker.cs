using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class OfficeWorker
    {
        static string path = AppDomain.CurrentDomain.BaseDirectory;
        static SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True");
        public static string message;
        public static void SubmitWorkOrder(string company, string occupantstatus, string community, string address, DateTime date, 
            string workordertype, string description, string animals, string permission)
        {

            connection.Open();
            SqlCommand submit;
            SqlCommand checking = new SqlCommand("Select Company_ID from ContractorCompany where company_name= @name", connection);
            SqlCommand invoicename = new SqlCommand("DECLARE @myVar int SET @myVar = 0 UPDATE Invoice SET @myVar = @myVar + 1, InvoiceName =  CONCAT(@address, @myvar) WHERE address = @address", connection);
            invoicename.Parameters.AddWithValue("@address", address);
            checking.Parameters.AddWithValue("@name", company);
            checking.ExecuteNonQuery();
            SqlDataAdapter data = new SqlDataAdapter(checking);
            DataTable table = new DataTable();
            data.Fill(table);
            int id = Int32.Parse(table.Rows[0]["Company_ID"].ToString());
            message = occupantstatus + " " + ActiveUser.id;
            if (occupantstatus.ToLower() == "occupied" && ActiveUser.usertype == "office worker")
            {
                submit = new SqlCommand("Insert Into Invoice (OfficeWorker_ID, ContractorCompany_ID, Community_Name, OccupantStatus, Address, Email, Primary#, "
                     + "Primary#Extension, Primary#Type, PermissionToEnter, Pets, Accepted, Complete, TimeOfService, DueDate, InvoiceType, Description, InvoiceName) " +
                       "VALUES(@officeworkerid, @contractorcompid, @communityname, @occupantStatus, @address, @email, @number, @extension, @phonetype, @pte, @pet, @accepted, @complete, @tos, @due, " +
                       " @type, @desc, @invoicename)", connection);
                submit.Parameters.AddWithValue("@officeworkerid", ActiveUser.id);
                submit.Parameters.AddWithValue("@contractorcompid", id);
                submit.Parameters.AddWithValue("@communityname", community);
                submit.Parameters.AddWithValue("@occupantStatus", occupantstatus);
                submit.Parameters.AddWithValue("@address", address);
                submit.Parameters.AddWithValue("@email", ActiveUser.email);
                submit.Parameters.AddWithValue("@number", ActiveUser.phonenum);
                submit.Parameters.AddWithValue("@extension", "0");
                submit.Parameters.AddWithValue("@phonetype", "Work");
                submit.Parameters.AddWithValue("@pte", getPTE(permission));
                submit.Parameters.AddWithValue("@pet", getPET(animals));
                submit.Parameters.AddWithValue("@accepted", false);
                submit.Parameters.AddWithValue("@complete", false);
                submit.Parameters.AddWithValue("@tos", "any");
                submit.Parameters.AddWithValue("@due", date);
                submit.Parameters.AddWithValue("@type", workordertype);
                submit.Parameters.AddWithValue("@desc", description);


            }
            else if (occupantstatus.ToLower() == "unoccupied" && ActiveUser.usertype == "office worker")
            {
                submit = new SqlCommand("Insert Into Invoice (OfficeWorker_ID, ContractorCompany_ID, Community_Name, OccupantStatus, Address, Email, Primary#, "
                     + "Primary#Extension, Primary#Type, Accepted, Complete, TimeOfService, DueDate, InvoiceType, Description, PermissionToEnter, Pets) " +
                       "VALUES(@officeworkerid, @contractorcompid, @communityname, @occupantStatus, @address, @email, @number, @extension, @phonetype, @accepted, @complete, @tos, @due, " +
                       " @type, @desc, @pte, @pets)", connection);
                submit.Parameters.AddWithValue("@officeworkerid", ActiveUser.id);
                submit.Parameters.AddWithValue("@contractorcompid", id);
                submit.Parameters.AddWithValue("@communityname", community);
                submit.Parameters.AddWithValue("@occupantStatus", occupantstatus);
                submit.Parameters.AddWithValue("@address", address);
                submit.Parameters.AddWithValue("@email", ActiveUser.email);
                submit.Parameters.AddWithValue("@number", ActiveUser.phonenum);
                submit.Parameters.AddWithValue("@extension", "0");
                submit.Parameters.AddWithValue("@phonetype", "Work");
                submit.Parameters.AddWithValue("@accepted", false);
                submit.Parameters.AddWithValue("@complete", false);
                submit.Parameters.AddWithValue("@pte", true);
                submit.Parameters.AddWithValue("@pets", false);
                submit.Parameters.AddWithValue("@tos", "any");
                submit.Parameters.AddWithValue("@due", date);
                submit.Parameters.AddWithValue("@type", workordertype);
                submit.Parameters.AddWithValue("@desc", description);
            }
            else
            {
                submit = new SqlCommand("Insert Into Invoice ( ContractorCompany_ID, Community_Name, OccupantStatus, Address, Email, Primary#, "
                     + "Primary#Extension, Primary#Type, Accepted, Complete, TimeOfService, DueDate, InvoiceType, Description) " +
                       "VALUES(@contractorcompid, @communityname, @occupantStatus, @address, @email, @number, @extension, @phonetype, @accepted, @complete, @tos, @due, " +
                       " @type, @desc)", connection);
                submit.Parameters.AddWithValue("@contractorcompid", id);
                submit.Parameters.AddWithValue("@communityname", community);
                submit.Parameters.AddWithValue("@occupantStatus", "Occupied");
                submit.Parameters.AddWithValue("@address", address);
                submit.Parameters.AddWithValue("@email", ActiveUser.email);
                submit.Parameters.AddWithValue("@number", ActiveUser.phonenum);
                submit.Parameters.AddWithValue("@extension", "0");
                submit.Parameters.AddWithValue("@phonetype", "Work");
                submit.Parameters.AddWithValue("@accepted", false);
                submit.Parameters.AddWithValue("@complete", false);
                submit.Parameters.AddWithValue("@tos", "any");
                submit.Parameters.AddWithValue("@due", date);
                submit.Parameters.AddWithValue("@type", workordertype);
                submit.Parameters.AddWithValue("@desc", description);
            }
            submit.ExecuteNonQuery();
            invoicename.ExecuteNonQuery();
            message = "Invoice Created";
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
