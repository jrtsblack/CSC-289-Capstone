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
using System.Data.OleDb;

namespace Invoice
{
    public partial class NewWorkOrderForm : Form
    {
        public NewWorkOrderForm()
        {
            InitializeComponent();
        }

        // Database connection statement
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProjectDB.accdb;Persist Security Info=True");

        // Save values into the project DB
        private void saveInvoiceButton_Click(object sender, EventArgs e)
        {
            DisplayTooltips();
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

            newInvoiceCommunityComboBox.DisplayMember = null;
            newInvoiceRequestTimeOfServiceComboBox.DisplayMember = null;
            newInvoicePrimaryPhoneTypeComboBox.DisplayMember = null;
            newInvoiceAlternatePhoneTypeComboBox.DisplayMember = null;
            newInvoiceWorkOrderTypeComboBox.DisplayMember = null;
            newInvoicePermissionToEnterComboBox.DisplayMember = null;
            newInvoiceAnimalsInHomeComboBox.DisplayMember = null;
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
            // Primary phone number variables
            short primaryPhoneNumber;
            short primaryPhoneExtension;
            string primaryPhoneNum = newInvoicePrimaryPhoneNumberTextBox.Text.Trim();
            string primaryPhoneExten = newInvoicePrimaryPhoneExtensionTextBox.Text.Trim();
            // Alternate phone number variables
            short alternatePhoneNumber;
            short alternatePhoneExtension;
            string alternatePhoneNum = newInvoiceAlternatePhoneNumberTextBox.Text.Trim();
            string altPhoneExt = newInvoiceAlternatePhoneExtensionTextBox.Text.Trim();
            // Incrementory value 
            int i = 0;

            // Open DB connection to manipulate data
            conn.Open();

            // Save String Values into the Customer table
            OleDbCommand saveOccupant = new OleDbCommand("INSERT INTO customer (first, last, address, community_name, "
                + "email, primary_phone_type) VALUES (" +
                newInvoiceFirstNameTextBox.Text.ToLower() + "," + newInvoiceLastNameTextBox.Text.ToLower() +
                "," + newInvoiceStreetAddressTextBox.Text.ToLower() +
                "," + newInvoiceCommunityComboBox.SelectedItem.ToString().ToLower() +
                "," + newInvoiceEmailTextBox.Text.ToLower() +
                "," + newInvoicePrimaryPhoneTypeComboBox.SelectedItem.ToString().ToLower() + ");");

            // Save the String Values into the InvoiceStatus table
            OleDbCommand saveInvoiceStatus = new OleDbCommand("INSERT INTO invoiceStatus (invoice_type, description, " +
                "complete, timeOfService) VALUES (" +
                newInvoiceWorkOrderTypeComboBox.SelectedItem.ToString().ToLower() +
                "," + newInvoiceDescriptionOfRequestRichTextBox.Text.ToString().ToLower() +
                ",false," + newInvoiceRequestTimeOfServiceComboBox.SelectedItem.ToString().ToLower() + ");");

            // Check if the primary phone number is valid and add to database or display tooltip message and focus the textbox
            if (IsValidPrimaryPhoneNumber(primaryPhoneNum))
            {
                Int16.TryParse(primaryPhoneNum, out primaryPhoneNumber);

                if (primaryPhoneExten != null)
                {
                    Int16.TryParse(primaryPhoneExten, out primaryPhoneExtension);
                    // Save if extension included
                    OleDbCommand saveOccupantPrimaryPhone = new OleDbCommand("INSERT INTO customer (primary#, parimary_extension) VALUES (" +
                    primaryPhoneNumber + ", " + primaryPhoneExtension + ");");

                    // increment i to show something happened.
                    i += saveOccupantPrimaryPhone.ExecuteNonQuery();
                }
                else
                {
                    // Save if no extension included
                    OleDbCommand saveOccPrimPhoneNum = new OleDbCommand("INSERT INTO customer (primary#) VALUES (" +
                        primaryPhoneNumber + ");");

                    // Increment i to show something happened
                    i += saveOccPrimPhoneNum.ExecuteNonQuery();
                }             

                // Check if the Alternate Phone Number textbox is not empty
                if (!string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text))
                {
                    // Check if Alternate phone number is valid
                    if (IsValidPrimaryPhoneNumber(alternatePhoneNum))
                    {
                        Int16.TryParse(alternatePhoneNum, out alternatePhoneNumber);
                        OleDbCommand saveOccupantAlternatePhone = new OleDbCommand("INSERT INTO customer (alternate_phone#) VALUES (" +
                            alternatePhoneNumber + ");");

                        if (altPhoneExt != null)
                        {
                            Int16.TryParse(altPhoneExt, out alternatePhoneExtension);
                            OleDbCommand saveOccAltExt = new OleDbCommand("INSERT INTO customer (alternate_extension) VALUES ("
                                + alternatePhoneExtension + ");");
                            i += saveOccAltExt.ExecuteNonQuery();
                        }

                        // increment i to show something happened
                        i += saveOccupantAlternatePhone.ExecuteNonQuery();
                    }
                    else
                    {
                        // Display Error
                        newInvoiceAlternatePhoneNumberTextBox.Focus();
                        ToolTip wrongFormat = new ToolTip();
                        wrongFormat.Show("Please use the correct format 9999999999", newInvoiceAlternatePhoneNumberTextBox, 10000);
                    }
                }
            }
            else
            {
                // Display Error
                newInvoicePrimaryPhoneNumberTextBox.Focus();
                ToolTip wrongFormat = new ToolTip();
                wrongFormat.Show("Please use the correct format 9999999999", newInvoicePrimaryPhoneNumberTextBox, 10000);
            }

            // Check if user selected yes or no for the permission to enter combobox
            if (newInvoicePermissionToEnterComboBox.SelectedItem.ToString().ToLower() == "yes")
            {
                OleDbCommand pte = new OleDbCommand("INSERT INTO customer (permission_to_enter) VALUES (true);");
                i += pte.ExecuteNonQuery();
            }
            else
            {
                OleDbCommand pteNeg = new OleDbCommand("INSERT INTO customer (permission_to_enter) VALUES (false);");
                i += pteNeg.ExecuteNonQuery();
            }
            
            // Check if the user selected yes or no for the AnimalsInHome combobox
            if (newInvoiceAnimalsInHomeComboBox.SelectedItem.ToString().ToLower() == "yes")
            {
                OleDbCommand pets = new OleDbCommand("INSERT INTO customer (pets) VALUES (true);");
                i += pets.ExecuteNonQuery();
            }
            else
            {
                OleDbCommand petsNeg = new OleDbCommand("INSERT INTO customer (pets) VALUES (false);");
                i += petsNeg.ExecuteNonQuery();
            }

            // Save information on the occupant and invoice commands.
            i += saveOccupant.ExecuteNonQuery();
            i += saveInvoiceStatus.ExecuteNonQuery();

            // Close the DB connection
            conn.Close();

            if (i > 0)
            {
                // Display confirmation that information has been saved
                MessageBox.Show("Information successfully saved.");
            }
        }

        // Check if the phone number is valid
        private bool IsValidPrimaryPhoneNumber(string num)
        {
            // To hold the valid length
            const int VALID_LENGTH = 10;
            // To hold true/false
            bool valid = true;

            // Check if num = valid length, and if right format
            if (num.Length == VALID_LENGTH)
            {
                foreach (char ch in num)
                {
                    if (!char.IsDigit(ch))
                    {
                        valid = false;
                    }
                }
            }
            else
            {
                valid = false;
            }

            return valid;
        }
        
        // Display Tooltips Method creates a tooltip over the items that are required
        private void DisplayTooltips()
        {
            // Display Tooltips if user hasn't entered in information 
            if (string.IsNullOrEmpty(newInvoiceFirstNameTextBox.Text))
            {
                ToolTip req = new ToolTip();
                req.Show("Please enter First Name", newInvoiceFirstNameTextBox, 10000);
            }
            if (string.IsNullOrEmpty(newInvoiceLastNameTextBox.Text))
            {
                ToolTip req1 = new ToolTip();
                req1.Show("Please enter Last Name", newInvoiceLastNameTextBox, 10000);
            }
            if (string.IsNullOrEmpty(newInvoiceStreetAddressTextBox.Text))
            {
                ToolTip req2 = new ToolTip();
                req2.Show("Please enter Street Address", newInvoiceStreetAddressTextBox, 10000);
            }
            if (newInvoiceCommunityComboBox.SelectedItem == null)
            {
                ToolTip req3 = new ToolTip();
                req3.Show("Please select a Community", newInvoiceCommunityComboBox, 10000);
            }
            if (string.IsNullOrEmpty(newInvoicePrimaryPhoneNumberTextBox.Text))
            {
                ToolTip req4 = new ToolTip();
                req4.Show("Please enter Phone Number (ex: ##########)", newInvoicePrimaryPhoneNumberTextBox, 10000);
            }
            if (newInvoicePrimaryPhoneTypeComboBox.SelectedItem == null)
            {
                ToolTip req5 = new ToolTip();
                req5.Show("Please select Phone Type", newInvoicePrimaryPhoneTypeComboBox, 10000);
            }
            if (!string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text))
            {
                if (newInvoiceAlternatePhoneTypeComboBox.SelectedItem == null)
                {
                    ToolTip altReq = new ToolTip();
                    altReq.Show("Please select Alternate Phone Type", newInvoiceAlternatePhoneTypeComboBox, 10000);
                }
            }
            if (string.IsNullOrEmpty(newInvoiceEmailTextBox.Text))
            {
                ToolTip req6 = new ToolTip();
                req6.Show("Please enter an email address", newInvoiceEmailTextBox, 10000);
            }
            if (newInvoiceWorkOrderTypeComboBox.SelectedItem == null)
            {
                ToolTip req7 = new ToolTip();
                req7.Show("Please select Work Order Type", newInvoiceWorkOrderTypeComboBox, 10000);
            }
            if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
            {
                ToolTip req8 = new ToolTip();
                req8.Show("Please describe what you need, including the location", newInvoiceDescriptionOfRequestRichTextBox, 10000);
            }
            if (newInvoiceRequestTimeOfServiceComboBox.SelectedItem == null)
            {
                ToolTip req9 = new ToolTip();
                req9.Show("Please select Time of Service", newInvoiceRequestTimeOfServiceComboBox, 10000);
            }
            if (newInvoicePermissionToEnterComboBox.SelectedItem == null)
            {
                ToolTip req10 = new ToolTip();
                req10.Show("Please select Yes/No", newInvoicePermissionToEnterComboBox, 10000);
            }
            if (newInvoiceAnimalsInHomeComboBox.SelectedItem == null)
            {
                ToolTip req11 = new ToolTip();
                req11.Show("Please select Yes/No", newInvoiceAnimalsInHomeComboBox, 10000);
            }
        }
    }
}
