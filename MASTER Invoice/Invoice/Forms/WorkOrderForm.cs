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
                Form admin = Application.OpenForms["AdminForm"];
                if (admin != null)
                {
                    admin.Close();
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
            invoiceInformationStreetAddressLabel.Text = Engine.WorkOrders.address;
            invoiceInformationCommunityLabel.Text = Engine.WorkOrders.community;
            invoiceInformationPrimaryPhoneNumberLabel.Text = Engine.WorkOrders.primarynum;
            invoiceInformationPrimaryPhoneExtensionLabel.Text = Engine.WorkOrders.primaryext;
            invoiceInformationPrimaryPhoneTypeLabel.Text = Engine.WorkOrders.primarytype;
            invoiceInformationAlternatePhoneNumberLabel.Text = Engine.WorkOrders.altnum;
            invoiceInformationAlternatePhoneExtensionLabel.Text = Engine.WorkOrders.altext;
            invoiceInformationAlternatePhoneTypeLabel.Text = Engine.WorkOrders.alttype;
            invoiceInformationEmailLabel.Text = Engine.WorkOrders.email;
            invoiceInformationWorkOrderTypeLabel.Text = Engine.WorkOrders.invoicetype;
            invoiceInformationDescriptionOfRequestRichTextBox.Text = Engine.WorkOrders.description;
            invoiceInformationRequestTimeOfServiceLabel.Text = Engine.WorkOrders.tos;
            invoiceInformationPermissionToEnterLabel.Text = Engine.WorkOrders.pte;
            invoiceInformationAnimalsLabel.Text = Engine.WorkOrders.pets;
            if (Engine.WorkOrders.complete)
            {
                rButtonComplete.Checked = true;
            }
            else
            {
                rButtonIncomplete.Checked = true;
            }

            rTxtBoxComments.Text = Engine.WorkOrders.comments;

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
            if (Engine.WorkOrders.date == null)
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
                dtpDue.Value = Engine.WorkOrders.date.Value;
            }
        }
    }
}
