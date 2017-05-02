using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Invoice
{
    public partial class ContractorWorkOrderForm : Form
    {
        static string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;

        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True";

        string query = "SELECT i.Invoice_ID, i.Contractor_ID, c.First, c.last, cont.First, cont.Last, i.Community_Name, i.Address, i.Primary#, i.Primary#Extension, i.Primary#Type, i.Alt#, i.Alt#Extension, i.Alt#Type, " +
            "i.Email, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.OccupantStatus, i.Complete, i.Comments, " +
            "i.InvoiceName FROM Invoice i LEFT OUTER JOIN Customer c ON (i.Customer_ID=c.Customer_ID) LEFT OUTER JOIN Contractor cont ON (i.Contractor_ID=cont.Contractor_ID) WHERE i.ContractorCompany_ID = 5 AND i.Contractor_ID IS NULL";

        string query2 = "SELECT i.Invoice_ID, c.First, c.last, cont.First, cont.Last, i.Community_Name, i.Address, i.Primary#, i.Primary#Extension, i.Primary#Type, i.Alt#, i.Alt#Extension, i.Alt#Type, " +
            "i.Email, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.OccupantStatus, i.Complete, i.Comments, " +
            "i.InvoiceName FROM Invoice i LEFT OUTER JOIN Customer c ON (i.Customer_ID=c.Customer_ID) LEFT OUTER JOIN Contractor cont ON (i.Contractor_ID=cont.Contractor_ID) WHERE i.ContractorCompany_ID = " + ActiveUser.companyid + " AND i.Contractor_ID = " + ActiveUser.id;
        string query3 = "SELECT i.Invoice_ID, c.Customer_ID, c.First as custFirst, c.Last as custLast, o.First as owFirst, o.Last as owLast, i.Address, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.Complete, i.Comments, i.InvoiceName FROM Invoice i LEFT OUTER JOIN Customer c ON (i.Customer_ID=c.Customer_ID) LEFT OUTER JOIN OfficeWorker o ON (i.OfficeWorker_ID=o.OfficeWorker_ID) WHERE InvoiceName=@selectedinvoice";

        string query4 = "UPDATE INVOICE SET ACCEPTED =@accepted , Contractor_ID =@contractorid WHERE InvoiceName =@invoicename";

        string query5 = "UPDATE INVOICE SET Comments =@comments , Complete =@complete WHERE InvoiceName = @invoicename";

        public ContractorWorkOrderForm()
        {
            InitializeComponent();
            Fill_AvailableListBox();
            Fill_AcceptedListBox();
        }

        private void lblFirstNamePrompt_Click(object sender, EventArgs e)
        {

        }

        private void lblLastNamePrompt_Click(object sender, EventArgs e)
        {

        }

        private void lblStreetAddressPrompt_Click(object sender, EventArgs e)
        {

        }

        private void Fill_AvailableListBox()
        {
            
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@compid", ActiveUser.companyid);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lbxAvailableWorkOrders.Items.Add(dr["InvoiceName"].ToString());
            }
            conn.Close();
        }

        private void Fill_AcceptedListBox()
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query2, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                lbxAcceptedWorkOrders.Items.Add(dr["InvoiceName"].ToString());
            }
            conn.Close();
        }

        private void updateInvoice()
        {
            if(lbxAcceptedWorkOrders.SelectedIndex != -1)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query5, conn);
                cmd.Parameters.AddWithValue("@comments", rtxtComments.Text.ToString());
                if(rbtnComplete.Checked)
                {
                    cmd.Parameters.AddWithValue("@complete", 1);
                }
                else if(rbtnIncomplete.Checked)
                {
                    cmd.Parameters.AddWithValue("@complete", 0);
                }
                cmd.Parameters.AddWithValue("@invoicename", lbxAcceptedWorkOrders.GetItemText(lbxAcceptedWorkOrders.SelectedItem));
                cmd.ExecuteNonQuery();
                MessageBox.Show("Invoice Updated");
                conn.Close();
            }
            else
            {
                MessageBox.Show("Please select an invoice");
            }
                
            
        }

        private void btnAcceptWorkOrder_Click(object sender, EventArgs e)
        {
            if(lbxAvailableWorkOrders.SelectedIndex != -1)
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                SqlCommand cmd = new SqlCommand(query4, conn);
                cmd.Parameters.AddWithValue("@accepted", 1);
                cmd.Parameters.AddWithValue("@contractorid", ActiveUser.id);
                cmd.Parameters.AddWithValue("@invoicename", lbxAvailableWorkOrders.GetItemText(lbxAvailableWorkOrders.SelectedItem));


                cmd.ExecuteNonQuery();
                lbxAcceptedWorkOrders.Items.Add(lbxAvailableWorkOrders.SelectedItem);
                lbxAvailableWorkOrders.Items.Remove(lbxAvailableWorkOrders.SelectedItem);
                
            }
        }

        private void lbxAvailableWorkOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbxAcceptedWorkOrders.SelectedIndex = -1;
            gbxUpdate.Enabled = false;
            if(lbxAvailableWorkOrders.SelectedIndex != -1)
            {
                lblacceptedavailable.Text = "Available Work Order";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand(query3, conn);
                cmd.Parameters.AddWithValue("@selectedinvoice", lbxAvailableWorkOrders.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Customer_ID"] == DBNull.Value)
                    {
                        lblFirstName.Text = dr["owFirst"].ToString();
                        lblLastName.Text = dr["owLast"].ToString();
                    }
                    else
                    {
                        lblFirstName.Text = dr["custFirst"].ToString();
                        lblLastName.Text = dr["custLast"].ToString();
                        lblStreetAddress.Text = dr["Address"].ToString();
                        lblWorkOrderType.Text = dr["InvoiceType"].ToString();
                        rtbxDescriptionOfRequest.Text = dr["Description"].ToString();
                        lblRequestTimeOfService.Text = dr["TimeOfService"].ToString();
                        if (dr["PermissionToEnter"].ToString().ToLower() == "true")
                        {
                            lblPermissionToEnter.Text = "True";
                        }
                        else if (dr["PermissionToEnter"].ToString().ToLower() == "false")
                        {
                            lblPermissionToEnter.Text = "False";
                        }
                        if (dr["Pets"].ToString().ToLower() == "true")
                        {
                            lblAnimals.Text = "True";
                        }
                        else if (dr["Pets"].ToString().ToLower() == "false")
                        {
                            lblAnimals.Text = "False";
                        }
                        lblDate.Text = dr["DueDate"].ToString();
                        if (dr["Complete"].ToString().ToLower() == "true")
                        {
                            rbtnComplete.Checked = true;
                        }
                        else if (dr["Complete"].ToString().ToLower() == "false")
                        {
                            rbtnIncomplete.Checked = true;
                        }

                    }
                }
            }
            
        }

        private void lbxAcceptedWorkOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxAvailableWorkOrders.SelectedIndex = -1;
            gbxUpdate.Enabled = true;

            if (lbxAcceptedWorkOrders.SelectedIndex != -1)
            {
                lblacceptedavailable.Text = "Accepted Work Order";


                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                SqlCommand cmd = new SqlCommand(query3, conn);
                cmd.Parameters.AddWithValue("@selectedinvoice", lbxAcceptedWorkOrders.SelectedItem.ToString());
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    if (dr["Customer_ID"] == DBNull.Value)
                    {
                        lblFirstName.Text = dr["owFirst"].ToString();
                        lblLastName.Text = dr["owLast"].ToString();
                    }
                    else
                    {
                        lblFirstName.Text = dr["custFirst"].ToString();
                        lblLastName.Text = dr["custLast"].ToString();
                        lblStreetAddress.Text = dr["Address"].ToString();
                        lblWorkOrderType.Text = dr["InvoiceType"].ToString();
                        rtbxDescriptionOfRequest.Text = dr["Description"].ToString();
                        lblRequestTimeOfService.Text = dr["TimeOfService"].ToString().ToUpper();
                        if (dr["PermissionToEnter"].ToString().ToLower() == "true")
                        {
                            lblPermissionToEnter.Text = "Yes";
                        }
                        else if (dr["PermissionToEnter"].ToString().ToLower() == "false")
                        {
                            lblPermissionToEnter.Text = "No";
                        }
                        if (dr["Pets"].ToString().ToLower() == "true")
                        {
                            lblAnimals.Text = "True";
                        }
                        else if (dr["Pets"].ToString().ToLower() == "false")
                        {
                            lblAnimals.Text = "False";
                        }
                        lblDate.Text = dr["DueDate"].ToString();
                        if (dr["Complete"].ToString().ToLower() == "true")
                        {
                            rbtnComplete.Checked = true;
                        }
                        else if (dr["Complete"].ToString().ToLower() == "false")
                        {
                            rbtnIncomplete.Checked = true;
                        }
                        rtxtComments.Text = dr["Comments"].ToString();
                     

                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateInvoice();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (ActiveUser.usertype.ToLower() == "administrator")
            {
                this.Close();
            }
            else
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }
    }
}
