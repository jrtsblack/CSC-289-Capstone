using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace Invoice
{
    public partial class WorkOrderForm : Form
    {
        public WorkOrderForm()
        {
            InitializeComponent();

            Fill_ListBox();
            checkUserType();
        }
        static string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        string connectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True";
        string query = "SELECT i.Invoice_ID, c.First, c.last, o.First, o.Last, i.Community_Name, i.Address, i.Primary#, i.Primary#Extension, i.Primary#Type, i.Alt#, i.Alt#Extension, i.Alt#Type, " +
            "i.Email, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.OccupantStatus, i.Complete, i.Comments, " +
            "i.InvoiceName FROM Invoice i LEFT OUTER JOIN Customer c ON (i.Customer_ID=c.Customer_ID) LEFT OUTER JOIN OfficeWorker o ON (i.OfficeWorker_ID=o.OfficeWorker_ID)";

        string query3 = "SELECT i.Invoice_ID, c.First, c.last, i.Community_Name, i.Address, i.Primary#, i.Primary#Extension, i.Primary#Type, i.Alt#, i.Alt#Extension, i.Alt#Type, " +
            "i.Email, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.OccupantStatus, i.Complete, i.Comments, " +
            "i.InvoiceName FROM Invoice i INNER JOIN Customer c ON i.Customer_ID=c.Customer_ID WHERE i.Customer_ID = " + ActiveUser.id;
        private void newInvoiceButton_Click(object sender, EventArgs e)
        {
            if (ActiveUser.usertype.ToLower() == "occupant")
            {
                NewWorkOrderForm newWorkOrder = new NewWorkOrderForm();
                newWorkOrder.Show();
                this.Hide();
            }
            if(ActiveUser.usertype.ToLower() == "office worker")
            {
                OfficeWorkOrder newOfficeWorkOrder = new OfficeWorkOrder();
                newOfficeWorkOrder.Show();
                this.Hide();
            }
            if(ActiveUser.usertype.ToLower() == "administrator")
            {
                Forms.AdminNewInvoiceCheck admin = new Forms.AdminNewInvoiceCheck();
                admin.Show();
            }
        }
        Bitmap bit;

        private void printInvoiceButton_Click(object sender, EventArgs e)
        {
            // Creates the bitmap that is the same size as the groupbox
            Graphics graphics = invoiceInformationGroupBox.CreateGraphics();
            Size size = invoiceInformationGroupBox.ClientSize;
            bit = new Bitmap(size.Width, size.Height, graphics);
            graphics = Graphics.FromImage(bit);

            // Copy the area of the screen that the groupbox covers
            Point grpbxLocation = PointToScreen(invoiceInformationGroupBox.Location);
            graphics.CopyFromScreen(grpbxLocation.X, grpbxLocation.Y, 0, 0, size);
            printPreviewDialog1.Document = printDocument1;

            // Show Print Preview 
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void invoiceInformationCancelButton_Click(object sender, EventArgs e)
        {
            // Message to be displayed in MessageBox
            const string prompt = "Are you sure you want to log out of the program?";
            const string caption = "Logout?";

            // MessageBox pop up to confirm
            var result = MessageBox.Show(prompt, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Close form if yes was pressed
            if (result == DialogResult.Yes)
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bit, e.MarginBounds);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateInvoice();
        }

        private void invoiceDatabaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            string query2 = "SELECT i.Invoice_ID, c.Customer_ID, c.First as custFirst, c.Last as custLast, o.First as owFirst, o.Last as owLast, i.Community_Name, i.Address, i.Primary#, i.Primary#Extension, i.Primary#Type, i.Alt#, i.Alt#Extension, i.Alt#Type, i.Email, i.InvoiceType, i.Description, i.TimeOfService, i.PermissionToEnter, i.Pets, i.DueDate, i.ContractorCompany_ID, i.OccupantStatus, i.Complete, i.Comments, i.InvoiceName FROM Invoice i LEFT OUTER JOIN Customer c ON (i.Customer_ID=c.Customer_ID) LEFT OUTER JOIN OfficeWorker o ON (i.OfficeWorker_ID=o.OfficeWorker_ID) WHERE InvoiceName= '" + invoiceDatabaseListBox.SelectedItem.ToString()+"'";

            SqlCommand cmd = new SqlCommand(query2, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Customer_ID"] == DBNull.Value)
                {
                    invoiceInformationFirstNameLabel.Text = dr["owFirst"].ToString();
                    invoiceInformationLastNameLabel.Text = dr["owLast"].ToString();
                }
                else
                {
                    invoiceInformationFirstNameLabel.Text = dr["custFirst"].ToString();
                    invoiceInformationLastNameLabel.Text = dr["custLast"].ToString();
                }
                
                invoiceInformationStreetAddressLabel.Text = dr["Address"].ToString();
                invoiceInformationCommunityLabel.Text = dr["Community_Name"].ToString();
                invoiceInformationPrimaryPhoneNumberLabel.Text = dr["Primary#"].ToString();
                invoiceInformationPrimaryPhoneExtensionLabel.Text = dr["Primary#Extension"].ToString();
                invoiceInformationPrimaryPhoneTypeLabel.Text = dr["Primary#Type"].ToString();
                invoiceInformationAlternatePhoneNumberLabel.Text = dr["Alt#"].ToString();
                invoiceInformationAlternatePhoneExtensionLabel.Text = dr["Alt#Extension"].ToString();
                invoiceInformationAlternatePhoneTypeLabel.Text = dr["Alt#Type"].ToString();
                invoiceInformationEmailLabel.Text = dr["Email"].ToString();
                invoiceInformationWorkOrderTypeLabel.Text = dr["InvoiceType"].ToString();
                invoiceInformationDescriptionOfRequestRichTextBox.Text = dr["Description"].ToString();
                invoiceInformationRequestTimeOfServiceLabel.Text = dr["TimeOfService"].ToString();
                if(dr["PermissionToEnter"].ToString().ToLower() == "true")
                {
                    invoiceInformationPermissionToEnterLabel.Text = "True";
                }
                else if(dr["PermissionToEnter"].ToString().ToLower() == "false")
                {
                    invoiceInformationPermissionToEnterLabel.Text = "False";
                }
                if (dr["Pets"].ToString().ToLower() == "true")
                {
                    invoiceInformationAnimalsLabel.Text = "True";
                }
                else if (dr["Pets"].ToString().ToLower() == "false")
                {
                    invoiceInformationAnimalsLabel.Text = "False";
                }
                if (dr["Complete"].ToString().ToLower() == "true")
                {
                    rButtonComplete.Checked = true;
                }
                else if (dr["Complete"].ToString().ToLower() == "false")
                {
                    rButtonIncomplete.Checked = true;
                }
                rTxtBoxComments.Text = dr["Comments"].ToString();
                if (dr["OccupantStatus"].ToString().ToLower() == "1")
                {
                    rbtnOccupied.Checked = true;
                }
                else if (dr["OccupantStatus"].ToString().ToLower() == "0")
                {
                    rbtnUnoccupied.Checked = true;
                }
                if(String.IsNullOrEmpty(dr["ContractorCompany_ID"].ToString()))
                {
                    cbxCompanySelect.SelectedIndex = -1;
                }
                else
                {
                    SqlCommand contractorcomp = new SqlCommand("Select Company_Name FROM ContractorCompany WHERE Company_ID=" + Convert.ToInt32(dr["ContractorCompany_ID"].ToString()), conn);
                    contractorcomp.ExecuteNonQuery();
                    DataTable dt2 = new DataTable();
                    SqlDataAdapter da2 = new SqlDataAdapter(contractorcomp);
                    da2.Fill(dt2);
                    cbxCompanySelect.Text = dt2.Rows[0]["Company_Name"].ToString();
                }
                if(dr["DueDate"] == DBNull.Value)
                {
                    dtpDue.Checked = false;
                    dtpDue.CustomFormat = " ";
                    dtpDue.Format = DateTimePickerFormat.Custom;
                }
                else
                {
                    dtpDue.Checked = true;
                    dtpDue.CustomFormat = null;
                    dtpDue.Format = DateTimePickerFormat.Long;
                    dtpDue.Value = Convert.ToDateTime(dr["DueDate"].ToString());
                }
            }

        }

        private void Fill_ListBox()
        {
            invoiceDatabaseListBox.Items.Clear();
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();
            if (ActiveUser.usertype.ToLower() == "office worker" || ActiveUser.usertype.ToLower() == "administrator")
            {
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    invoiceDatabaseListBox.Items.Add(dr["InvoiceName"].ToString());
                }
            }
            else if(ActiveUser.usertype.ToLower() == "occupant")
            {
                SqlCommand cmd = new SqlCommand(query3, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    invoiceDatabaseListBox.Items.Add(dr["InvoiceName"].ToString());
                }
            }
            

        }



        private void updateInvoice()
        {
            int? company_id = 0;
            string occupancy_status = " ";
            bool complete = false;
            string companyquery = "SELECT Company_ID FROM ContractorCompany WHERE Company_Name= '" + cbxCompanySelect.Text + "'";

            string invoiceUpdate = "UPDATE Invoice SET Invoice.Address " +
                "= @address, Invoice.Primary# = @primenum, Invoice.Primary#Extension = @primenumext, Invoice.Primary#Type " +
                "= @primenumtype, Invoice.Alt# = @altnum, Invoice.Alt#Extension = @altnumext, Invoice.Alt#Type = @altnumtype, Invoice.Email = @email, Invoice.InvoiceType " +
                "= @invoicetype, Invoice.TimeOfService = @tos, Invoice.PermissionToEnter = @pte, Invoice.Pets = @pets, Invoice.Comments = @comments, Invoice.Complete " +
                "= @complete, Invoice.OccupantStatus = @occupantstatus, Invoice.ContractorCompany_ID = @contractorcompany_id, Invoice.DueDate = @duedate, Invoice.Description = @description " +
                "FROM Invoice LEFT OUTER JOIN Customer ON (Invoice.Customer_ID = Customer.Customer_ID) LEFT OUTER JOIN OfficeWorker ON (Invoice.OfficeWorker_ID = OfficeWorker.OfficeWorker_ID) WHERE InvoiceName =@invoicename";

            string customerUpdate = "UPDATE Customer SET Customer.First = @first, Customer.Last = @last FROM Customer INNER JOIN Invoice ON Invoice.Customer_ID = Customer.Customer_ID " +
                "WHERE InvoiceName =@invoicename AND Invoice.Customer_ID = Customer.Customer_ID";
            string officeUpdate = "UPDATE OfficeWorker SET OfficeWorker.First = @first, OfficeWorker.Last = @last FROM OfficeWorker INNER JOIN Invoice ON Invoice.OfficeWorker_ID = OfficeWorker.OfficeWorker_ID " +
                "WHERE InvoiceName =@invoicename AND Invoice.OfficeWorker_ID = OfficeWorker.OfficeWorker_ID";
            string name = invoiceDatabaseListBox.GetItemText(invoiceDatabaseListBox.SelectedItem);
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = conn.CreateCommand();
                SqlTransaction transaction;
                transaction = conn.BeginTransaction("SampleTransaction");
                command.Connection = conn;
                command.Transaction = transaction;
                try
                {
                    command.CommandText = companyquery;
                    company_id = Convert.ToInt32(command.ExecuteScalar());
                    
                    command.CommandText = invoiceUpdate;
                    
                    command.Parameters.AddWithValue("@address", invoiceInformationStreetAddressLabel.Text);
                    command.Parameters.AddWithValue("@community", invoiceInformationCommunityLabel.Text);
                    command.Parameters.AddWithValue("@primenum", invoiceInformationPrimaryPhoneNumberLabel.Text);
                    command.Parameters.AddWithValue("@primenumext", invoiceInformationPrimaryPhoneExtensionLabel.Text);
                    command.Parameters.AddWithValue("@primenumtype", invoiceInformationPrimaryPhoneTypeLabel.Text);
                    command.Parameters.AddWithValue("@altnum", invoiceInformationAlternatePhoneNumberLabel.Text);
                    command.Parameters.AddWithValue("@altnumext", invoiceInformationAlternatePhoneExtensionLabel.Text);
                    command.Parameters.AddWithValue("@altnumtype", invoiceInformationAlternatePhoneTypeLabel.Text);
                    command.Parameters.AddWithValue("@email", invoiceInformationEmailLabel.Text);
                    command.Parameters.AddWithValue("@invoicetype", invoiceInformationWorkOrderTypeLabel.Text);
                    command.Parameters.AddWithValue("@tos", invoiceInformationRequestTimeOfServiceLabel.Text);
                    command.Parameters.AddWithValue("@pte", invoiceInformationPermissionToEnterLabel.Text);
                    command.Parameters.AddWithValue("@pets", invoiceInformationPermissionToEnterLabel.Text);
                    command.Parameters.AddWithValue("@comments", rTxtBoxComments.Text);
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
                    if(dtpDue.Checked == true)
                    {
                        command.Parameters.AddWithValue("@duedate", dtpDue.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@duedate", DBNull.Value);
                    }
                    command.Parameters.AddWithValue("@invoicename", name);
                    command.Parameters.AddWithValue("description", invoiceInformationDescriptionOfRequestRichTextBox.Text);
                    command.ExecuteNonQuery();

                    command.CommandText = customerUpdate;
                    command.Parameters.AddWithValue("@first", invoiceInformationFirstNameLabel.Text);
                    command.Parameters.AddWithValue("@last", invoiceInformationLastNameLabel.Text);
                    command.ExecuteNonQuery();
                    command.CommandText = officeUpdate;
                    command.ExecuteNonQuery();
                    
                    transaction.Commit();
                    MessageBox.Show("Invoice Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkUserType()
        {
            if(ActiveUser.usertype.ToLower() == "occupant")
            {
                //
            }
            if(ActiveUser.usertype.ToLower() == "office worker")
            {
                btnUpdate.Visible = true;
                gbxOfficeWorkerTools.Visible = true;
                gbxCommentsAndStatus.Enabled = true;
                invoiceInformationFirstNameLabel.ReadOnly = false;
                invoiceInformationLastNameLabel.ReadOnly = false;
                invoiceInformationStreetAddressLabel.ReadOnly = false;
                invoiceInformationCommunityLabel.ReadOnly = false;
                invoiceInformationPrimaryPhoneNumberLabel.ReadOnly = false;
                invoiceInformationPrimaryPhoneExtensionLabel.ReadOnly = false;
                invoiceInformationPrimaryPhoneTypeLabel.ReadOnly = false;
                invoiceInformationAlternatePhoneNumberLabel.ReadOnly = false;
                invoiceInformationAlternatePhoneExtensionLabel.ReadOnly = false;
                invoiceInformationAlternatePhoneTypeLabel.ReadOnly = false;
                invoiceInformationEmailLabel.ReadOnly = false;
                invoiceInformationWorkOrderTypeLabel.ReadOnly = false;
                invoiceInformationDescriptionOfRequestRichTextBox.ReadOnly = false;
                invoiceInformationRequestTimeOfServiceLabel.ReadOnly = false;
                invoiceInformationPermissionToEnterLabel.ReadOnly = false;
                invoiceInformationAnimalsLabel.ReadOnly = false;
            }
        }

        private void WorkOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet.ContractorCompany' table. You can move, or remove it, as needed.
            this.contractorCompanyTableAdapter.Fill(this.projectDBDataSet.ContractorCompany);

        }
    }
}
