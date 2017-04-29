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

            GetInvoices();
        }
        // Database connection statement
        static string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True");

        private void GetInvoices()
        {
            if (ActiveUser.usertype.ToLower() == "occupant")
            {
                // set office worker tools to invisible
                gbxOfficeWorkerTools.Visible = false;
                gbxOccupancyStatus.Visible = false;
                lblDueDatePrompt.Visible = false;
                lblSelectCompany.Visible = false;
                dtpDue.Visible = false;
                cbxCompanySelect.Visible = false;
                rbtnOccupied.Visible = false;
                rbtnUnoccupied.Visible = false;
                btnUpdate.Visible = false;

                // Make sure occupant can't update any fields
                invoiceInformationFirstNameLabel.ReadOnly = true;
                invoiceInformationLastNameLabel.ReadOnly = true;
                invoiceInformationStreetAddressLabel.ReadOnly = true;
                invoiceInformationCommunityLabel.ReadOnly = true;
                invoiceInformationPrimaryPhoneNumberLabel.ReadOnly = true;
                invoiceInformationPrimaryPhoneExtensionLabel.ReadOnly = true;
                invoiceInformationPrimaryPhoneTypeLabel.ReadOnly = true;
                invoiceInformationAlternatePhoneNumberLabel.ReadOnly = true;
                invoiceInformationAlternatePhoneTypeLabel.ReadOnly = true;
                invoiceInformationAlternatePhoneExtensionLabel.ReadOnly = true;
                invoiceInformationEmailLabel.ReadOnly = true;
                invoiceInformationWorkOrderTypeLabel.ReadOnly = true;
                invoiceInformationDescriptionOfRequestRichTextBox.ReadOnly = true;
                invoiceInformationRequestTimeOfServiceLabel.ReadOnly = true;
                invoiceInformationPermissionToEnterLabel.ReadOnly = true;
                invoiceInformationAnimalsLabel.ReadOnly = true;
                rTxtBoxComments.ReadOnly = true;
                rButtonComplete.AutoCheck = false;
                rButtonIncomplete.AutoCheck = false;

                // grab the active user info to compare in sql statement
                string occupantEmail = ActiveUser.email.ToString();
                conn.Open();
                // sql statement to grab the info to be displayed in the list box 
                SqlCommand findOccupantData = new SqlCommand("SELECT Invoice_ID, Address FROM Invoice WHERE" +
                    "Email = '" + occupantEmail + "';", conn);

                SqlDataAdapter occData = new SqlDataAdapter(findOccupantData);
                DataTable occTable = new DataTable();
                occData.Fill(occTable);


                if(occTable.Rows.Count > 0)
                {
                    // Add the rows to the list box
                    foreach (DataRow dr in occTable.Rows)
                    {
                        invoiceDatabaseListBox.Items.Add(dr);
                    }
                }
                else
                {
                    MessageBox.Show("Nothing in the dataTable.");
                }
                conn.Close();

            }
            else if (ActiveUser.usertype.ToLower() == "office worker")
            {
                // Set office worker tools to visible
                gbxOfficeWorkerTools.Visible = true;
                gbxOccupancyStatus.Visible = true;
                lblDueDatePrompt.Visible = true;
                lblSelectCompany.Visible = true;
                dtpDue.Visible = true;
                cbxCompanySelect.Visible = true;
                rbtnOccupied.Visible = true;
                rbtnUnoccupied.Visible = true;
                btnUpdate.Visible = true;

                // Allow office worker to edit fields
                invoiceInformationFirstNameLabel.ReadOnly = false;
                invoiceInformationLastNameLabel.ReadOnly = false;
                invoiceInformationStreetAddressLabel.ReadOnly = false;
                invoiceInformationCommunityLabel.ReadOnly = false;
                invoiceInformationPrimaryPhoneNumberLabel.ReadOnly = false;
                invoiceInformationPrimaryPhoneExtensionLabel.ReadOnly = false;
                invoiceInformationPrimaryPhoneTypeLabel.ReadOnly = false;
                invoiceInformationAlternatePhoneNumberLabel.ReadOnly = false;
                invoiceInformationAlternatePhoneTypeLabel.ReadOnly = false;
                invoiceInformationAlternatePhoneExtensionLabel.ReadOnly = false;
                invoiceInformationEmailLabel.ReadOnly = false;
                invoiceInformationWorkOrderTypeLabel.ReadOnly = false;
                invoiceInformationDescriptionOfRequestRichTextBox.ReadOnly = false;
                invoiceInformationRequestTimeOfServiceLabel.ReadOnly = false;
                invoiceInformationPermissionToEnterLabel.ReadOnly = false;
                invoiceInformationAnimalsLabel.ReadOnly = false;
                rTxtBoxComments.ReadOnly = false;
                rButtonComplete.AutoCheck = true;
                rButtonIncomplete.AutoCheck = true;

                conn.Open();
                // sql statement to grab the information to be displayed in the list box
                SqlCommand officeInvoiceList = new SqlCommand("SELECT Invoice_ID, Address FROM Invoice " +
                    "WHERE Complete = false;", conn);

                SqlDataAdapter offData = new SqlDataAdapter(officeInvoiceList);
                DataTable offTable = new DataTable();
                offData.Fill(offTable);

                if(offTable.Rows.Count > 0)
                {
                    // Add the rows to the list box
                    foreach (DataRow dr in offTable.Rows)
                    {
                        invoiceDatabaseListBox.Items.Add(dr);
                    }
                }
                else
                {
                    MessageBox.Show("Nothing in the dataTable.");
                }

                // Grab company names to fill combobox
                SqlCommand companyNames = new SqlCommand("SELECT Company_Name FROM ContractorCompany", conn);
                SqlDataAdapter nameData = new SqlDataAdapter(companyNames);
                DataTable nameTable = new DataTable();
                nameData.Fill(nameTable);

                if(nameTable.Rows.Count > 0)
                {
                    foreach (DataRow nDr in nameTable.Rows)
                    {
                        cbxCompanySelect.Items.Add(nDr);
                    }
                }

                conn.Close();
            }

        }

       
        // Username information entered on login form.
        private LoginForm userName = new LoginForm();

        // Get user information to determine what to display
        private void GetOccupantAcctInfo()
        {
            
            string commName, firstName, lastName, address, email, primPhoneType, altPhoneType, pte, pets, invoiceType, description,
                complete, tos, primNum, primExtension, altNum, altExtension, invoiceID, customerID, comments;
            // Command to grab user information from the database
            SqlCommand user = new SqlCommand("SELECT Invoice_ID, Customer_ID, Community_Name, Address, " +
                "Email, Primary#, Primary#Extension, Primary#Type, Alt#, Alt#Extension, Alt#Type, " +
                "PermissionToEnter, Pets, Complete, TimeOfService, InvoiceType, Description, Comments, " +
                "First, Last FROM Invoice, Customer WHERE Invoice.Email = '" + ActiveUser.email.ToString() + "' AND Invoice.Customer_ID = Customer.Customer_ID;", conn);

            SqlDataAdapter data = new SqlDataAdapter(user);
            // Table to hold the user data
            DataTable table1 = new DataTable();
            // Fill table with the data
            data.Fill(table1);

            // Check if something is in the table
            if (table1.Rows.Count > 0)
            {
                // Add content from table to variables
                commName = table1.Rows[0]["Community_Name"].ToString();
                firstName = table1.Rows[0]["First"].ToString();
                lastName = table1.Rows[0]["Last"].ToString();
                address = table1.Rows[0]["Address"].ToString();
                email = table1.Rows[0]["Email"].ToString();
                primNum = table1.Rows[0]["Primary#"].ToString();
                primPhoneType = table1.Rows[0]["Primary#Type"].ToString();
                primExtension = table1.Rows[0]["Primary#Extension"].ToString();
                altNum = table1.Rows[0]["Alt#"].ToString();
                altPhoneType = table1.Rows[0]["Alt#Type"].ToString();
                altExtension = table1.Rows[0]["Alt#Extension"].ToString();
                pte = table1.Rows[0]["PermissionToEnter"].ToString();
                pets = table1.Rows[0]["Pets"].ToString();
                invoiceType = table1.Rows[0]["InvoiceType"].ToString();
                description = table1.Rows[0]["Description"].ToString();
                complete = table1.Rows[0]["Complete"].ToString();
                tos = table1.Rows[0]["TimeOfService"].ToString();
                invoiceID = table1.Rows[0]["Invoice_ID"].ToString();
                customerID = table1.Rows[0]["Customer_ID"].ToString();
                comments = table1.Rows[0]["Comments"].ToString();

                invoiceInformationFirstNameLabel.Text = firstName;
                invoiceInformationLastNameLabel.Text = lastName;
                invoiceInformationStreetAddressLabel.Text = address;
                invoiceInformationCommunityLabel.Text = commName;
                invoiceInformationPrimaryPhoneNumberLabel.Text = primNum;
                invoiceInformationPrimaryPhoneExtensionLabel.Text = primExtension;
                invoiceInformationPrimaryPhoneTypeLabel.Text = primPhoneType;
                invoiceInformationAlternatePhoneNumberLabel.Text = altNum;
                invoiceInformationAlternatePhoneExtensionLabel.Text = altExtension;
                invoiceInformationAlternatePhoneTypeLabel.Text = altPhoneType;
                invoiceInformationEmailLabel.Text = email;
                invoiceInformationWorkOrderTypeLabel.Text = invoiceType;
                invoiceInformationDescriptionOfRequestRichTextBox.Text = description;
                invoiceInformationDescriptionOfRequestRichTextBox.AppendText(Environment.NewLine + invoiceID);
                invoiceInformationRequestTimeOfServiceLabel.Text = tos;
                rTxtBoxComments.Text = comments;

                if(pte == "true" || pte == "yes")
                {
                    invoiceInformationPermissionToEnterLabel.Text = "Yes";
                }
                else
                {
                    invoiceInformationPermissionToEnterLabel.Text = "No";
                }

                if(pets == "true" || pets == "yes")
                {
                    invoiceInformationAnimalsLabel.Text = "Yes";
                }
                else
                {
                    invoiceInformationAnimalsLabel.Text = "No";
                }

                if (complete == "true" || complete == "yes")
                {
                    rButtonComplete.Checked = true;
                }
                else
                {
                    rButtonIncomplete.Checked = true;
                }
            }
        }

        private void newInvoiceButton_Click(object sender, EventArgs e)
        {
            NewWorkOrderForm newWorkOrder = new NewWorkOrderForm();
            newWorkOrder.Show();
            this.Hide();
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
            const string prompt = "Are you sure you want to close the program?";
            const string caption = "Close?";

            // MessageBox pop up to confirm
            var result = MessageBox.Show(prompt, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Close form if yes was pressed
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bit, e.MarginBounds);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int i = 0, j = 0, k = 0, l = 0;
            // Message to be displayed in MessageBox
            const string prompt = "Are you sure you would like to save?";
            const string caption = "Update Work Order";

            // MessageBox pop up to confirm
            var result = MessageBox.Show(prompt, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                          
            // Close form if yes was pressed
            if (result == DialogResult.Yes)
            {
                bool occupied, status;
                conn.Open();
                
                // Create SQL statements to update information///////////////////////////////////////////////////////////////////////////////WIP
                SqlCommand update1 = new SqlCommand("UPDATE Customer SET [First] = '@first', [Last] = '@last' WHERE  = '" +
                     "';" , conn);
                SqlCommand update2 = new SqlCommand("UPDATE Invoice SET [Address] = '@address', [Community_Name] = '@commName', [Primary#] = '@primary#', " +
                    "[Primary#Extension] = '@p#Ext', [Primary#Type] = '@p#Type', [Email] = '@email', [InvoiceType] = '@invoiceType', [Description] = '" +
                    "@desc', [TimeOfService] = '@tos', [PermissionToEnter] = '@pte', [Pets] = '@pets', [Comments] = '@comments', " +
                    "[DueDate] = '@due' WHERE  = '" +  "';", conn);

                // add the values 
                update1.Parameters.AddWithValue("@first", invoiceInformationFirstNameLabel.Text.ToLower());
                update1.Parameters.AddWithValue("@last", invoiceInformationLastNameLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@address", invoiceInformationStreetAddressLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@commName", invoiceInformationCommunityLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@primary#", invoiceInformationPrimaryPhoneNumberLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@p#Ext", invoiceInformationPrimaryPhoneExtensionLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@p#Type", invoiceInformationPrimaryPhoneTypeLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@email", invoiceInformationEmailLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@invoiceType", invoiceInformationWorkOrderTypeLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@desc", invoiceInformationDescriptionOfRequestRichTextBox.Text.ToLower());
                update2.Parameters.AddWithValue("@tos", invoiceInformationRequestTimeOfServiceLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@pte", invoiceInformationPermissionToEnterLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@pets", invoiceInformationAnimalsLabel.Text.ToLower());
                update2.Parameters.AddWithValue("@comments", rTxtBoxComments.Text.ToLower());
                update2.Parameters.AddWithValue("@due", dtpDue.Text);

                if(rbtnOccupied.Checked)
                {
                    occupied = true;
                }
                else
                {
                    occupied = false;
                }

                if(rButtonComplete.Checked)
                {
                    status = true;
                }
                else
                {
                    status = false;
                }
                // Set up true/false update statement////////////////////////////////////////////////////////////////////////////////////////////////WIP
                SqlCommand update3 = new SqlCommand("UPDATE Invoice SET [OccupantStatus] = @status, [Complete] = @complete " +
                    "WHERE " +  "';", conn);
                update3.Parameters.AddWithValue("@status", occupied);
                update3.Parameters.AddWithValue("@complete", status);

                // Grab the company information to get the company ID
                SqlCommand companyID = new SqlCommand("SELECT ContractorCompany_ID FROM Invoice WHERE ContractorCompany.Company_Name = '" + 
                    cbxCompanySelect.SelectedItem.ToString() + "';");
                SqlDataAdapter comID = new SqlDataAdapter(companyID);
                DataTable compID = new DataTable();
                comID.Fill(compID);

                // Set up the final update//////////////////////////////////////////////////////////////////////////////////////////////// WIP
                if (compID.Rows.Count > 0)
                {
                    string num;
                    int cID;
                    num = compID.Rows[0]["ContractorCompany_ID"].ToString();
                    cID = int.Parse(num);
                    SqlCommand update4 = new SqlCommand("UPDATE Invoice SET [ContractorCompany_ID] = '" + cID + 
                        "WHERE Invoice_ID = '" +  "';", conn);
                    l += update4.ExecuteNonQuery();
                }

                i += update1.ExecuteNonQuery();
                j += update2.ExecuteNonQuery();
                k += update3.ExecuteNonQuery();

                conn.Close();
            }
        }

        private void invoiceDatabaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetOccupantAcctInfo();
        }
    }
}
