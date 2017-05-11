using System;
using System.Drawing;
using System.Windows.Forms;

namespace Invoice
{
    public partial class WorkOrderForm : Form
    {
        public WorkOrderForm()
        {
            InitializeComponent();
            invoiceDatabaseListBox.Items.Clear();
            invoiceDatabaseListBox.DataSource = Engine.WorkOrders.Fill_ListBox();
            checkUserType();
            dtpDue.MinDate = System.DateTime.Today;
        }

        Bitmap bit;
        private void WorkOrderForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet.ContractorCompany' table. You can move, or remove it, as needed.
            this.contractorCompanyTableAdapter.Fill(this.projectDBDataSet.ContractorCompany);
            
        }

        private void newInvoiceButton_Click(object sender, EventArgs e)
        {
            if (Engine.ActiveUser.usertype.ToLower() == "occupant")
            {
                NewWorkOrderForm newWorkOrder = new NewWorkOrderForm();
                newWorkOrder.Show();
                this.Hide();
            }
            if (Engine.ActiveUser.usertype.ToLower() == "office worker")
            {
                OfficeWorkOrder newOfficeWorkOrder = new OfficeWorkOrder();
                newOfficeWorkOrder.Show();
                this.Hide();
            }
            if (Engine.ActiveUser.usertype.ToLower() == "administrator")
            {
                Forms.AdminNewInvoiceCheck admin = new Forms.AdminNewInvoiceCheck();
                admin.Show();
                this.Hide();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            DateTime? date;
            if (dtpDue.Checked == true)
            {
                date = dtpDue.Value;
            }
            else
            {
                date = null;
            }
            Engine.WorkOrders.updateInvoice(cbxCompanySelect.Text, invoiceDatabaseListBox.GetItemText(invoiceDatabaseListBox.SelectedItem), invoiceInformationStreetAddressLabel.Text,
                invoiceInformationCommunityLabel.Text, invoiceInformationPrimaryPhoneNumberLabel.Text, invoiceInformationPrimaryPhoneExtensionLabel.Text, invoiceInformationPrimaryPhoneTypeLabel.Text,
                invoiceInformationAlternatePhoneNumberLabel.Text, invoiceInformationAlternatePhoneExtensionLabel.Text, invoiceInformationAlternatePhoneTypeLabel.Text, invoiceInformationEmailLabel.Text,
                invoiceInformationWorkOrderTypeLabel.Text, invoiceInformationRequestTimeOfServiceLabel.Text, invoiceInformationPermissionToEnterLabel.Text, invoiceInformationAnimalsLabel.Text,
                rTxtBoxComments.Text, date, invoiceInformationDescriptionOfRequestRichTextBox.Text, invoiceInformationFirstNameLabel.Text, invoiceInformationLastNameLabel.Text);

            MessageBox.Show(Engine.WorkOrders.message);
        }

        private void checkUserType()
        {
            if (Engine.ActiveUser.usertype.ToLower() == "office worker")
            {
                btnUpdate.Visible = true;
                btnUpdate.Enabled = true;
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
            if (Engine.ActiveUser.usertype.ToLower() == "administrator")
            {
                this.Height = 700;
                adminFormButton.Enabled = true;
                adminFormButton.Visible = true;
                invoiceInformationLogOutButton.Location = new Point(168, 587);
            }
            if(Engine.ActiveUser.usertype.ToLower() == "occupant")
            {
                invoiceInformationLogOutButton.Location = new Point(168, 587);
            }
        }

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

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bit, e.MarginBounds);
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
                for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
                {
                    if (Application.OpenForms[i].Name != "LoginForm")
                        Application.OpenForms[i].Close();
                }

                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }

        private void invoiceDatabaseListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Engine.WorkOrders.selectedInvoice(invoiceDatabaseListBox.SelectedItem.ToString());

            invoiceInformationFirstNameLabel.Text = Engine.WorkOrders.firstname;
            invoiceInformationLastNameLabel.Text = Engine.WorkOrders.lastname;
            invoiceInformationStreetAddressLabel.Text = Engine.WorkOrders.streetaddress;
            invoiceInformationCommunityLabel.Text = Engine.WorkOrders.communityname;
            invoiceInformationPrimaryPhoneNumberLabel.Text = Engine.WorkOrders.primarynumber;
            invoiceInformationPrimaryPhoneExtensionLabel.Text = Engine.WorkOrders.primaryextension;
            invoiceInformationPrimaryPhoneTypeLabel.Text = Engine.WorkOrders.primaryphonetype;
            invoiceInformationAlternatePhoneNumberLabel.Text = Engine.WorkOrders.altnumber;
            invoiceInformationAlternatePhoneExtensionLabel.Text = Engine.WorkOrders.altextension;
            invoiceInformationAlternatePhoneTypeLabel.Text = Engine.WorkOrders.altphonetype;
            invoiceInformationEmailLabel.Text = Engine.WorkOrders.emailaddress;
            invoiceInformationWorkOrderTypeLabel.Text = Engine.WorkOrders.invoicetype;
            invoiceInformationDescriptionOfRequestRichTextBox.Text = Engine.WorkOrders.desc;
            invoiceInformationRequestTimeOfServiceLabel.Text = Engine.WorkOrders.timeofservice;
            invoiceInformationPermissionToEnterLabel.Text = Engine.WorkOrders.permissiontoenter;
            invoiceInformationAnimalsLabel.Text = Engine.WorkOrders.petsinhome;
            if (Engine.WorkOrders.workordercomplete)
            {
                rButtonComplete.Checked = true;
            }
            else
            {
                rButtonIncomplete.Checked = true;
            }

            rTxtBoxComments.Text = Engine.WorkOrders.workordercomments;

            if (Engine.WorkOrders.occupantstatus)
            {
                rbtnOccupied.Checked = true;
            }
            else
            {
                rbtnUnoccupied.Checked = true;
            }
            if (String.IsNullOrEmpty(Engine.WorkOrders.contractorid))
            {
                cbxCompanySelect.SelectedIndex = -1;
            }
            else
            {
                cbxCompanySelect.Text = Engine.WorkOrders.contractorname;
            }
            if (Engine.WorkOrders.duedate == null)
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
                dtpDue.Value = Engine.WorkOrders.duedate.Value;
            }
        }

        private void adminFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm admin = new AdminForm();
            admin.Show();
        }
        

        
    }
}

