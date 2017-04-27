using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace Invoice
{
    public partial class NewWorkOrderForm : Form
    {
        public NewWorkOrderForm()
        {
            InitializeComponent();
            newInvoiceEmailTextBox.Text = ActiveUser.email;
        }

        // Database connection statement
        static string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True");

        // Save values into the project DB
        private void saveInvoiceButton_Click(object sender, EventArgs e)
        {
            SaveWorkOrderInfo();
        }

        // Set the invoice fields to be empty
        private void clearFieldsButton_Click(object sender, EventArgs e)
        {
            newInvoiceFirstNameTextBox.Text = null;
            newInvoiceLastNameTextBox.Text = null;
            newInvoiceStreetAddressTextBox.Text = null;
            newInvoicePrimaryPhoneNumberTextBox.Text = null;
            newInvoicePrimaryPhoneExtensionTextBox.Text = null;
            newInvoiceAlternatePhoneNumberTextBox.Text = null;
            newInvoiceAlternatePhoneExtensionTextBox.Text = null;
            newInvoiceEmailTextBox.Text = null;

            newInvoiceDescriptionOfRequestRichTextBox.Text = null;

            newInvoiceCommunityComboBox.SelectedIndex = -1;
            newInvoiceRequestTimeOfServiceComboBox.SelectedIndex = -1;
            newInvoicePrimaryPhoneTypeComboBox.SelectedIndex = -1;
            newInvoiceAlternatePhoneTypeComboBox.SelectedIndex = -1;
            newInvoiceWorkOrderTypeComboBox.SelectedIndex = -1;
            newInvoicePermissionToEnterComboBox.SelectedIndex = -1; 
            newInvoiceAnimalsInHomeComboBox.SelectedIndex = -1;
            
        }

        // Close the NewWorkOrder form, and move back to the WorkOrderForm
        private void cancelButton_Click(object sender, EventArgs e)
        {
            // Message to be displayed in MessageBox
            const string prompt = "Are you sure you would like to cancel? You will lose any unsaved information.";
            const string caption = "Cancel New Work Order";

            // MessageBox pop up to confirm
            var result = MessageBox.Show(prompt, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // Close form if yes was pressed
            if (result == DialogResult.Yes)
            {
                this.Close();
                WorkOrderForm workOrder = new WorkOrderForm();
                workOrder.Show();
            }
            
            
        }

        // Save WorkOrderInfo Method saves the values entered into the ProjectDB
        private void SaveWorkOrderInfo()
        {
            // Incrementory value 
            int i = 0;

            nullOrEmptyCheck();
            if (nullOrEmptyCheck())
            {
                // Open DB connection to manipulate data
                conn.Open();
                i += saveOccupant().ExecuteNonQuery();
                i += saveInvoiceStatus().ExecuteNonQuery();
                conn.Close();

                if (i > 0)
                {
                    // Display confirmation that information has been saved
                    MessageBox.Show("Information successfully saved.");
                }

            }
        }

        // Display Tooltip If first name textbox is empty
        private void FirstNameToolTip()
        {
                ToolTip req = new ToolTip();
                req.Show("Please enter First Name", newInvoiceFirstNameTextBox, 10000);
        }

        // Display Tooltip if last name text box is empty
        private void LastNameToolTip()
        {
                ToolTip req = new ToolTip();
                req.Show("Please enter Last Name", newInvoiceLastNameTextBox, 10000);
        }

        // Diplay tooltip if address text box is empty
        private void AddressToolTip()
        {
                ToolTip req = new ToolTip();
                req.Show("Please enter Street Address", newInvoiceStreetAddressTextBox, 10000);
        }

        // Display tooltip if community combobox has nothing selected
        private void CommunityToolTip()
        {
                ToolTip req = new ToolTip();
                req.Show("Please select a Community", newInvoiceCommunityComboBox, 10000);
        }

        // Display tooltip if primary phone text box is empty
        private void PrimaryPNumberToolTip()
        {
                ToolTip req = new ToolTip();
                req.Show("Please enter Phone Number (ex: ##########)", newInvoicePrimaryPhoneNumberTextBox, 10000);
        }

        // Display tooltip if primary phone type combobox has nothing selected
        private void PrimaryPTypeToolTip()
        {
                ToolTip req = new ToolTip();
                req.Show("Please select Phone Type", newInvoicePrimaryPhoneTypeComboBox, 10000);
        }

        // Display tooltip if alternate phone number textbox IS filled, but alt phone type isn't
        private void AlternateTypeToolTip()
        {
                    ToolTip altReq = new ToolTip();
                    altReq.Show("Please select Alternate Phone Type", newInvoiceAlternatePhoneTypeComboBox, 10000);
        }
        
        // Display tooltip if email text box is empty
        private void EmailToolTip()
        {
                ToolTip req6 = new ToolTip();
                req6.Show("Please enter an email address", newInvoiceEmailTextBox, 10000);
        }

        // Display tooltip if workorder type combobox has nothing selected
        private void WorkOrderTypeToolTip()
        {
                ToolTip req7 = new ToolTip();
                req7.Show("Please select Work Order Type", newInvoiceWorkOrderTypeComboBox, 10000);
        }

        // Display tooltip if invoice description rich textbox is empty
        private void DescriptionToolTip()
        {
                ToolTip req8 = new ToolTip();
                req8.Show("Please describe what you need, including the location", newInvoiceDescriptionOfRequestRichTextBox, 10000);
        }

        // Display tooltip if time of service combobox is empty
        private void TimeOfServiceToolTip()
        {
                ToolTip req9 = new ToolTip();
                req9.Show("Please select Time of Service", newInvoiceRequestTimeOfServiceComboBox, 10000);
        }

        // Display tooltip if permission to enter combobox has nothing selected
        private void PTEToolTip()
        {
                ToolTip req10 = new ToolTip();
                req10.Show("Please select Yes/No", newInvoicePermissionToEnterComboBox, 10000);
        }

        // Display tooltip if animal in home combobox has nothing selected
        private void AnimalToolTip()
        {
                ToolTip req11 = new ToolTip();
                req11.Show("Please select Yes/No", newInvoiceAnimalsInHomeComboBox, 10000);
        }

        private void newInvoicePrimaryPhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;
            
            if(newInvoicePrimaryPhoneNumberTextBox.Text.Length == 3)
            {
                newInvoicePrimaryPhoneNumberTextBox.Text += "-";
                newInvoicePrimaryPhoneNumberTextBox.SelectionStart = 4;
            }
            if (newInvoicePrimaryPhoneNumberTextBox.Text.Length == 7)
            {
                newInvoicePrimaryPhoneNumberTextBox.Text += "-";
                newInvoicePrimaryPhoneNumberTextBox.SelectionStart = 8;
            }
        }

        private void newInvoiceAlternatePhoneNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back;

            if (newInvoiceAlternatePhoneNumberTextBox.Text.Length == 3)
            {
                newInvoiceAlternatePhoneNumberTextBox.Text += "-";
                newInvoiceAlternatePhoneNumberTextBox.SelectionStart = 4;
            }
            if (newInvoiceAlternatePhoneNumberTextBox.Text.Length == 7)
            {
                newInvoiceAlternatePhoneNumberTextBox.Text += "-";
                newInvoiceAlternatePhoneNumberTextBox.SelectionStart = 8;
            }
        }

        private bool nullOrEmptyCheck()
        {
            bool check = false;
            // Save String Values into the Customer table
            if (string.IsNullOrEmpty(newInvoiceFirstNameTextBox.Text))
            {
                FirstNameToolTip();
            }
            if (string.IsNullOrEmpty(newInvoiceLastNameTextBox.Text))
            {
                LastNameToolTip();
            }
            if (string.IsNullOrEmpty(newInvoiceStreetAddressTextBox.Text))
            {
                AddressToolTip();
            }
            if (newInvoiceCommunityComboBox.SelectedIndex == -1)
            {
                CommunityToolTip();
            }
            if (string.IsNullOrEmpty(newInvoicePrimaryPhoneNumberTextBox.Text))
            {
                PrimaryPNumberToolTip();
            }
            if (newInvoicePrimaryPhoneTypeComboBox.SelectedIndex == -1)
            {
                PrimaryPTypeToolTip();
            }
            if (!string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text))
            {
                if (newInvoiceAlternatePhoneTypeComboBox.SelectedIndex == -1)
                {
                    AlternateTypeToolTip();
                }
            }
            if (string.IsNullOrEmpty(newInvoiceEmailTextBox.Text))
            {
                EmailToolTip();
            }
            if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
            {
                DescriptionToolTip();
            }
            if (newInvoiceRequestTimeOfServiceComboBox.SelectedIndex == -1)
            {
                TimeOfServiceToolTip();
            }
            if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
            {
                PTEToolTip();
            }
            if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
            {
                AnimalToolTip();
            }
            else if (!string.IsNullOrEmpty(newInvoiceFirstNameTextBox.Text) && !string.IsNullOrEmpty(newInvoiceLastNameTextBox.Text) && !string.IsNullOrEmpty(newInvoiceStreetAddressTextBox.Text) &&
                newInvoiceCommunityComboBox.SelectedIndex != -1 && !string.IsNullOrEmpty(newInvoicePrimaryPhoneNumberTextBox.Text) && newInvoicePrimaryPhoneTypeComboBox.SelectedIndex != -1 &&
                ((!string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text) && newInvoiceAlternatePhoneTypeComboBox.SelectedIndex != -1) || string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text)) &&
                !string.IsNullOrEmpty(newInvoiceEmailTextBox.Text) && !string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text) && newInvoiceRequestTimeOfServiceComboBox.SelectedIndex != -1 &&
                newInvoiceRequestTimeOfServiceComboBox.SelectedIndex != -1 && newInvoiceAnimalsInHomeComboBox.SelectedIndex != -1)
            {
                if(string.IsNullOrEmpty(newInvoicePrimaryPhoneExtensionTextBox.Text))
                {
                    newInvoicePrimaryPhoneExtensionTextBox.Text = "0";
                }
                if(string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text))
                {
                    newInvoiceAlternatePhoneExtensionTextBox.Text = null;
                }
                else if(!string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text) && string.IsNullOrEmpty(newInvoicePrimaryPhoneExtensionTextBox.Text))
                {
                    newInvoiceAlternatePhoneExtensionTextBox.Text = "0";
                }

                check = true;
            }
            return check;
        }

        private bool getPTE()
        {
            bool permissionToEnter = false;
            if (newInvoicePermissionToEnterComboBox.SelectedItem.ToString().ToLower() == "yes")
            {
                permissionToEnter = true;
            }
            else if(newInvoicePermissionToEnterComboBox.SelectedItem.ToString().ToLower() == "no")
            {
                permissionToEnter = false;
            }
            return permissionToEnter;
        }

        private bool getPET()
        {
            bool animal = false;
            if (newInvoiceAnimalsInHomeComboBox.SelectedItem.ToString().ToLower() == "yes")
            {
                animal = true;
            }
            else if(newInvoiceAnimalsInHomeComboBox.SelectedItem.ToString().ToLower() == "no")
            {
                animal = false;
            }
            return animal;
        }

        private SqlCommand saveOccupant()
        {
            SqlCommand saveOccupant;

            if (string.IsNullOrWhiteSpace(newInvoiceAlternatePhoneNumberTextBox.Text))
            {
                saveOccupant = new SqlCommand("INSERT INTO customer (first, last, address, community_name, "
                + "email, primary#, primary_phone_type, primary_extension, "
                + "permission_to_enter, pets) VALUES (@firstname, @lastname, @address, "
                + "@communityname, @emailaddress, @primarynum, @phonetype, @primaryex,  @pte, @pet)", conn);

                saveOccupant.Parameters.AddWithValue("@firstname", newInvoiceFirstNameTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@lastname", newInvoiceLastNameTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@address", newInvoiceStreetAddressTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@communityname", newInvoiceCommunityComboBox.SelectedItem.ToString().ToLower());
                saveOccupant.Parameters.AddWithValue("@emailaddress", newInvoiceEmailTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@primarynum", newInvoicePrimaryPhoneNumberTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@phonetype", newInvoicePrimaryPhoneTypeComboBox.SelectedItem.ToString().ToLower());
                saveOccupant.Parameters.AddWithValue("@primaryex", newInvoicePrimaryPhoneExtensionTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@pte", getPTE());
                saveOccupant.Parameters.AddWithValue("@pet", getPET());
            }
            else
            {
                saveOccupant = new SqlCommand("INSERT INTO customer (first, last, address, community_name, "
                + "email, primary#, primary_phone_type, primary_extension, alternate_phone#, alternate_phone_type, "
                + "alternate_extension, permission_to_enter, pets) VALUES (@firstname, @lastname, @address, "
                + "@communityname, @emailaddress, @primarynum, @phonetype, @primaryex, @altnum, @altphonetype, @altex, @pte, @pet)", conn);

                saveOccupant.Parameters.AddWithValue("@firstname", newInvoiceFirstNameTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@lastname", newInvoiceLastNameTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@address", newInvoiceStreetAddressTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@communityname", newInvoiceCommunityComboBox.SelectedItem.ToString().ToLower());
                saveOccupant.Parameters.AddWithValue("@emailaddress", newInvoiceEmailTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@primarynum", newInvoicePrimaryPhoneNumberTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@phonetype", newInvoicePrimaryPhoneTypeComboBox.SelectedItem.ToString().ToLower());
                saveOccupant.Parameters.AddWithValue("@primaryex", newInvoicePrimaryPhoneExtensionTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@altnum", newInvoiceAlternatePhoneNumberTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@altphonetype", newInvoiceAlternatePhoneTypeComboBox.SelectedItem.ToString().ToLower());
                saveOccupant.Parameters.AddWithValue("@altex", newInvoiceAlternatePhoneExtensionTextBox.Text.ToLower());
                saveOccupant.Parameters.AddWithValue("@pte", getPTE());
                saveOccupant.Parameters.AddWithValue("@pet", getPET());
            }

            return saveOccupant;
            
        }

        private SqlCommand saveInvoiceStatus()
        {
            // Save the String Values into the InvoiceStatus table
            SqlCommand saveInvoiceStatus;
            saveInvoiceStatus = new SqlCommand("insert into invoiceStatus (invoice_type, description, timeOfService) VALUES(@invoice_type, @description, @timeOfService)", conn);
            saveInvoiceStatus.Parameters.AddWithValue("@invoice_type", newInvoiceWorkOrderTypeComboBox.SelectedItem.ToString().ToLower());
            saveInvoiceStatus.Parameters.AddWithValue("@description", newInvoiceDescriptionOfRequestRichTextBox.Text.ToString().ToLower());
            saveInvoiceStatus.Parameters.AddWithValue("@timeOfService", newInvoiceRequestTimeOfServiceComboBox.SelectedItem.ToString().ToLower());

            return saveInvoiceStatus;
        }
    }
}
