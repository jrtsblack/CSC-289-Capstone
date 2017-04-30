using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Invoice
{
    public partial class OfficeWorkOrder : Form
    {
        public OfficeWorkOrder()
        {
            InitializeComponent();
        }

        static string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True");

        private void OfficeWorkOrder_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet1.ContractorCompany' table. You can move, or remove it, as needed.
            this.contractorCompanyTableAdapter1.Fill(this.projectDBDataSet1.ContractorCompany);
            // TODO: This line of code loads data into the 'projectDBDataSet1.ContractorCompany' table. You can move, or remove it, as needed.
            this.contractorCompanyTableAdapter1.Fill(this.projectDBDataSet1.ContractorCompany);
            // TODO: This line of code loads data into the 'projectDBDataSet1.ContractorCompany' table. You can move, or remove it, as needed.
            this.contractorCompanyTableAdapter1.Fill(this.projectDBDataSet1.ContractorCompany);

        }

        private void rbtnOccupied_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnOccupied.Checked)
            {
                this.Size = new Size(378, 528);
                gbxOfficeWorkOrder.Size = new Size(338, 418);
                occupiedPanel.Visible = true;
                occupiedPanel.Size = new Size(320, 66);
                lblDescriptionPrompt.Location = new Point(9, 293);
                rtxtDescriptionOfRequest.Location = new Point(12, 308);
                btnSubmit.Location = new Point(10, 442);
                btnClear.Location = new Point(142, 442);
                btnCancel.Location = new Point(272, 442);
            }
            else if(rbtnUnoccupied.Checked)
            {
                this.Size = new Size(378, 443);
                gbxOfficeWorkOrder.Size = new Size(338, 333);
                occupiedPanel.Visible = false;
                occupiedPanel.Size = new Size(1, 1);
                lblDescriptionPrompt.Location = new Point(9, 215);
                rtxtDescriptionOfRequest.Location = new Point(12, 230);
                btnSubmit.Location = new Point(10, 358);
                btnClear.Location = new Point(142, 358);
                btnCancel.Location = new Point(272, 358);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult cancelResult = MessageBox.Show("Are you sure you want to cancel this Work Order?", "Cancel Work Order", MessageBoxButtons.YesNo);
            if(cancelResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if(cancelResult == DialogResult.No)
            {
                
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult clearResult = MessageBox.Show("Are you sure you want to clear this Work Order?", "Clear Work Order", MessageBoxButtons.YesNo);
            if (clearResult == DialogResult.Yes)
            {
                this.Close();
            }
            else if (clearResult == DialogResult.No)
            {

            }
        }

        private SqlCommand SubmitWorkOrder()
        {
            SqlCommand submit;
            SqlCommand checking = new SqlCommand("Select Company_ID from ContractorCompany where company_name= @name", connection);
            checking.Parameters.AddWithValue("@name", cmbxContractingCompany.Text);
            MessageBox.Show(cmbxContractingCompany.Text);
            checking.ExecuteNonQuery();
            SqlDataAdapter data = new SqlDataAdapter(checking);
            DataTable table = new DataTable();
            data.Fill(table);
            int id = Int32.Parse(table.Rows[0]["Company_ID"].ToString());


            if (rbtnOccupied.Checked && ActiveUser.usertype == "Office Worker")
            {
                submit = new SqlCommand("Insert Into Invoice (OfficeWorker_ID, ContractorCompany_ID, Community_Name, OccupantStatus, Address, Email, Primary#, "
                     + "Primary#Extension, Primary#Type, PermissionToEnter, Pets, Accepted, Complete, TimeOfService, DueDate, InvoiceType, Description, InvoiceName) " +
                       "VALUES(@officeworkerid, @contractorcompid, @communityname, @occupantStatus, @address, @email, @number, @extension, @phonetype, @pte, @pet, @accepted, @complete, @tos, @due, " +
                       " @type, @desc, @invoicename)", connection);
                submit.Parameters.AddWithValue("@officeworkerid", ActiveUser.id);
                submit.Parameters.AddWithValue("@contractorcompid", id);
                submit.Parameters.AddWithValue("@communityname", newInvoiceCommunityComboBox.SelectedItem.ToString());
                submit.Parameters.AddWithValue("@occupantStatus", rbtnOccupied.Text);
                submit.Parameters.AddWithValue("@address", txtStreetAddress.Text);
                submit.Parameters.AddWithValue("@email", ActiveUser.email);
                submit.Parameters.AddWithValue("@number", ActiveUser.phonenum);
                submit.Parameters.AddWithValue("@extension", "0");
                submit.Parameters.AddWithValue("@phonetype", "Work");
                submit.Parameters.AddWithValue("@pte", getPTE());
                submit.Parameters.AddWithValue("@pet", getPET());
                submit.Parameters.AddWithValue("@accepted", false);
                submit.Parameters.AddWithValue("@complete", false);
                submit.Parameters.AddWithValue("@tos", "any");
                submit.Parameters.AddWithValue("@due", dateTimePicker.Value);
                submit.Parameters.AddWithValue("@type", cmbxWorkOrderType.SelectedItem.ToString().ToLower());
                submit.Parameters.AddWithValue("@desc", rtxtDescriptionOfRequest.Text);

            }
            else if (rbtnUnoccupied.Checked && ActiveUser.usertype == "Office Worker") 
            {
                submit = new SqlCommand("Insert Into Invoice (OfficeWorker_ID, ContractorCompany_ID, Community_Name, OccupantStatus, Address, Email, Primary#, "
                     + "Primary#Extension, Primary#Type, Accepted, Complete, TimeOfService, DueDate, InvoiceType, Description) " +
                       "VALUES(@officeworkerid, @contractorcompid, @communityname, @occupantStatus, @address, @email, @number, @extension, @phonetype, @accepted, @complete, @tos, @due, " +
                       " @type, @desc)", connection);
                submit.Parameters.AddWithValue("@officeworkerid", ActiveUser.id);
                submit.Parameters.AddWithValue("@contractorcompid", id);
                submit.Parameters.AddWithValue("@communityname", newInvoiceCommunityComboBox.SelectedItem.ToString());
                submit.Parameters.AddWithValue("@occupantStatus", rbtnUnoccupied.Text);
                submit.Parameters.AddWithValue("@address", txtStreetAddress.Text);
                submit.Parameters.AddWithValue("@email", ActiveUser.email);
                submit.Parameters.AddWithValue("@number", ActiveUser.phonenum);
                submit.Parameters.AddWithValue("@extension", "0");
                submit.Parameters.AddWithValue("@phonetype", "Work");
                submit.Parameters.AddWithValue("@accepted", false);
                submit.Parameters.AddWithValue("@complete", false);
                submit.Parameters.AddWithValue("@tos", "any");
                submit.Parameters.AddWithValue("@due", dateTimePicker.Value);
                submit.Parameters.AddWithValue("@type", cmbxWorkOrderType.SelectedItem.ToString().ToLower());
                submit.Parameters.AddWithValue("@desc", rtxtDescriptionOfRequest.Text);
            }
            else
            {
                submit = new SqlCommand("Insert Into Invoice ( ContractorCompany_ID, Community_Name, OccupantStatus, Address, Email, Primary#, "
                     + "Primary#Extension, Primary#Type, Accepted, Complete, TimeOfService, DueDate, InvoiceType, Description) " +
                       "VALUES(@contractorcompid, @communityname, @occupantStatus, @address, @email, @number, @extension, @phonetype, @accepted, @complete, @tos, @due, " +
                       " @type, @desc)", connection);
                submit.Parameters.AddWithValue("@contractorcompid", id);
                submit.Parameters.AddWithValue("@communityname", newInvoiceCommunityComboBox.SelectedItem.ToString());
                submit.Parameters.AddWithValue("@occupantStatus", rbtnOccupied.Text);
                submit.Parameters.AddWithValue("@address", txtStreetAddress.Text);
                submit.Parameters.AddWithValue("@email", ActiveUser.email);
                submit.Parameters.AddWithValue("@number", ActiveUser.phonenum);
                submit.Parameters.AddWithValue("@extension", "0");
                submit.Parameters.AddWithValue("@phonetype", "Work");
                submit.Parameters.AddWithValue("@accepted", false);
                submit.Parameters.AddWithValue("@complete", false);
                submit.Parameters.AddWithValue("@tos", "any");
                submit.Parameters.AddWithValue("@due", dateTimePicker.Value);
                submit.Parameters.AddWithValue("@type", cmbxWorkOrderType.SelectedItem.ToString().ToLower());
                submit.Parameters.AddWithValue("@desc", rtxtDescriptionOfRequest.Text);
            }

            return submit;
        }

        private void getContractingCompanyId(string company)
        {

        }

        // Set bool to true or false if occupant consented to permission to enter
        private bool getPTE()
        {
            bool permissionToEnter = false;
            if (newInvoicePermissionToEnterComboBox.SelectedItem.ToString().ToLower() == "yes")
            {
                permissionToEnter = true;
            }
            else if (newInvoicePermissionToEnterComboBox.SelectedItem.ToString().ToLower() == "no")
            {
                permissionToEnter = false;
            }
            return permissionToEnter;
        }

        // Set bool to true or false if occupant has a pet
        private bool getPET()
        {
            bool animal = false;
            if (newInvoiceAnimalsInHomeComboBox.SelectedItem.ToString().ToLower() == "yes")
            {
                animal = true;
            }
            else if (newInvoiceAnimalsInHomeComboBox.SelectedItem.ToString().ToLower() == "no")
            {
                animal = false;
            }
            return animal;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            nullOrEmptyCheck();
            if(nullOrEmptyCheck())
            {
                connection.Open();
                SubmitWorkOrder().ExecuteNonQuery();
                SqlCommand invoiceName = new SqlCommand("UPDATE INVOICE SET InvoiceName= CONCAT(Address, Invoice_ID)  WHERE InvoiceName IS NULL", connection);
                invoiceName.ExecuteNonQuery();
                connection.Close();
            }
        }

        private bool nullOrEmptyCheck()
        {
            bool check = false;

            if (string.IsNullOrEmpty(txtStreetAddress.Text))
            {
                //Add Tooltip
            }
            if (newInvoiceCommunityComboBox.SelectedIndex == -1)
            {
                //Add Tooltip
            }
            if (cmbxWorkOrderType.SelectedIndex == -1)
            {
                //Add Tooltip
            }
            if (cmbxContractingCompany.SelectedIndex == -1)
            {
                //Add Tooltip
            }
            if(!rbtnOccupied.Checked || !rbtnUnoccupied.Checked)
            {
                //Add Tooltip
            }
            if (string.IsNullOrEmpty(rtxtDescriptionOfRequest.Text))
            {
                //Add Tooltip
            }
            if (rbtnOccupied.Checked && newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
            {
                //Add Tooltip
            }
            if (rbtnOccupied.Checked && newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
            {
                //Add Tooltip
            }
            // return true if required fields are not null
            else if (!string.IsNullOrEmpty(txtStreetAddress.Text) && newInvoiceCommunityComboBox.SelectedIndex != -1 && cmbxWorkOrderType.SelectedIndex != -1 &&
                     cmbxContractingCompany.SelectedIndex != -1 && (rbtnOccupied.Checked || rbtnUnoccupied.Checked) && !string.IsNullOrEmpty(rtxtDescriptionOfRequest.Text))
            {
                if(rbtnOccupied.Checked && newInvoicePermissionToEnterComboBox.SelectedIndex != -1 && newInvoiceAnimalsInHomeComboBox.SelectedIndex != -1)
                {
                    check = true;
                }
                else if(rbtnUnoccupied.Checked)
                {
                    check = true;
                }
            }
            return check;
        }
    }
}
