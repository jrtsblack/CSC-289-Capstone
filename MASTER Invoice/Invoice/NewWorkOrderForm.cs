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
            // Primary phone number variables
            int primaryPhoneNumber;
            int primaryPhoneExtension;
            string primaryPhoneNum = newInvoicePrimaryPhoneNumberTextBox.Text.Trim();
            string primaryPhoneExten = newInvoicePrimaryPhoneExtensionTextBox.Text.Trim();
            // Alternate phone number variables
            int alternatePhoneNumber;
            int alternatePhoneExtension;
            string alternatePhoneNum = newInvoiceAlternatePhoneNumberTextBox.Text.Trim();
            string altPhoneExt = newInvoiceAlternatePhoneExtensionTextBox.Text.Trim();
            // Incrementory value 
            int i = 0;

            // Open DB connection to manipulate data
            conn.Open();

            // Save String Values into the Customer table
            OleDbCommand saveOccupant = new OleDbCommand("INSERT INTO customer (first, last, address, community_name, "
                + "email, primary_phone_type) VALUES ('" +
                newInvoiceFirstNameTextBox.Text.ToLower() + "', '" + newInvoiceLastNameTextBox.Text.ToLower() +
                "', '" + newInvoiceStreetAddressTextBox.Text.ToLower() +
                "', '" + newInvoiceCommunityComboBox.SelectedItem.ToString().ToLower() +
                "', '" + newInvoiceEmailTextBox.Text.ToLower() +
                "', '" + newInvoicePrimaryPhoneTypeComboBox.SelectedItem.ToString().ToLower() + "');", conn);
            
            // Save the String Values into the InvoiceStatus table
            OleDbCommand saveInvoiceStatus = new OleDbCommand("INSERT INTO invoiceStatus (invoice_type, description, " +
                "complete, timeOfService) VALUES ('" +
                newInvoiceWorkOrderTypeComboBox.SelectedItem.ToString().ToLower() +
                "', '" + newInvoiceDescriptionOfRequestRichTextBox.Text.ToString().ToLower() +
                "', false, '" + newInvoiceRequestTimeOfServiceComboBox.SelectedItem.ToString().ToLower() + "');", conn);

            if (string.IsNullOrEmpty(newInvoiceFirstNameTextBox.Text))
            {
                FirstNameToolTip();
                if (string.IsNullOrEmpty(newInvoiceLastNameTextBox.Text))
                {
                    LastNameToolTip();
                    if (string.IsNullOrEmpty(newInvoiceStreetAddressTextBox.Text))
                    {
                        AddressToolTip();
                        if (newInvoiceCommunityComboBox.SelectedIndex == -1)
                        {
                            CommunityToolTip();
                            if (string.IsNullOrEmpty(newInvoicePrimaryPhoneNumberTextBox.Text))
                            {
                                PrimaryPNumberToolTip();
                                if (newInvoicePrimaryPhoneTypeComboBox.SelectedIndex == -1)
                                {
                                    PrimaryPTypeToolTip();
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
                                        if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
                                        {
                                            DescriptionToolTip();
                                            if (newInvoiceRequestTimeOfServiceComboBox.SelectedIndex == -1)
                                            {
                                                TimeOfServiceToolTip();
                                                if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
                                                {
                                                    PTEToolTip();
                                                    if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
                                                    {
                                                        AnimalToolTip();
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            else if (string.IsNullOrEmpty(newInvoiceLastNameTextBox.Text))
            {
                LastNameToolTip();
                if (string.IsNullOrEmpty(newInvoiceStreetAddressTextBox.Text))
                {
                    AddressToolTip();
                    if (newInvoiceCommunityComboBox.SelectedIndex == -1)
                    {
                        CommunityToolTip();
                        if (string.IsNullOrEmpty(newInvoicePrimaryPhoneNumberTextBox.Text))
                        {
                            PrimaryPNumberToolTip();
                            if (newInvoicePrimaryPhoneTypeComboBox.SelectedIndex == -1)
                            {
                                PrimaryPTypeToolTip();
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
                                    if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
                                    {
                                        DescriptionToolTip();
                                        if (newInvoiceRequestTimeOfServiceComboBox.SelectedIndex == -1)
                                        {
                                            TimeOfServiceToolTip();
                                            if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
                                            {
                                                PTEToolTip();
                                                if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
                                                {
                                                    AnimalToolTip();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }

                }
            }
            else if (string.IsNullOrEmpty(newInvoiceStreetAddressTextBox.Text))
            {
                AddressToolTip();
                if (newInvoiceCommunityComboBox.SelectedIndex == -1)
                {
                    CommunityToolTip();
                    if (string.IsNullOrEmpty(newInvoicePrimaryPhoneNumberTextBox.Text))
                    {
                        PrimaryPNumberToolTip();
                        if (newInvoicePrimaryPhoneTypeComboBox.SelectedIndex == -1)
                        {
                            PrimaryPTypeToolTip();
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
                                if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
                                {
                                    DescriptionToolTip();
                                    if (newInvoiceRequestTimeOfServiceComboBox.SelectedIndex == -1)
                                    {
                                        TimeOfServiceToolTip();
                                        if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
                                        {
                                            PTEToolTip();
                                            if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
                                            {
                                                AnimalToolTip();
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }

            }
            else if (newInvoiceCommunityComboBox.SelectedIndex == -1)
            {
                CommunityToolTip();
                if (string.IsNullOrEmpty(newInvoicePrimaryPhoneNumberTextBox.Text))
                {
                    PrimaryPNumberToolTip();
                    if (newInvoicePrimaryPhoneTypeComboBox.SelectedIndex == -1)
                    {
                        PrimaryPTypeToolTip();
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
                            if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
                            {
                                DescriptionToolTip();
                                if (newInvoiceRequestTimeOfServiceComboBox.SelectedIndex == -1)
                                {
                                    TimeOfServiceToolTip();
                                    if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
                                    {
                                        PTEToolTip();
                                        if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
                                        {
                                            AnimalToolTip();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(newInvoicePrimaryPhoneNumberTextBox.Text))
            {
                PrimaryPNumberToolTip();
                if (newInvoicePrimaryPhoneTypeComboBox.SelectedIndex == -1)
                {
                    PrimaryPTypeToolTip();
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
                        if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
                        {
                            DescriptionToolTip();
                            if (newInvoiceRequestTimeOfServiceComboBox.SelectedIndex == -1)
                            {
                                TimeOfServiceToolTip();
                                if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
                                {
                                    PTEToolTip();
                                    if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
                                    {
                                        AnimalToolTip();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else if (newInvoicePrimaryPhoneTypeComboBox.SelectedIndex == -1)
            {
                PrimaryPTypeToolTip();
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
                    if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
                    {
                        DescriptionToolTip();
                        if (newInvoiceRequestTimeOfServiceComboBox.SelectedIndex == -1)
                        {
                            TimeOfServiceToolTip();
                            if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
                            {
                                PTEToolTip();
                                if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
                                {
                                    AnimalToolTip();
                                }
                            }
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(newInvoiceEmailTextBox.Text))
            {
                EmailToolTip();
                if (!string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text))
                {
                    if (newInvoiceAlternatePhoneTypeComboBox.SelectedIndex == -1)
                    {
                        AlternateTypeToolTip();
                    }
                }
                if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
                {
                    DescriptionToolTip();
                    if (newInvoiceRequestTimeOfServiceComboBox.SelectedIndex == -1)
                    {
                        TimeOfServiceToolTip();
                        if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
                        {
                            PTEToolTip();
                            if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
                            {
                                AnimalToolTip();
                            }
                        }
                    }
                }
            }
            else if (string.IsNullOrEmpty(newInvoiceDescriptionOfRequestRichTextBox.Text))
            {
                DescriptionToolTip();
                if (newInvoiceRequestTimeOfServiceComboBox.SelectedIndex == -1)
                {
                    TimeOfServiceToolTip();
                    if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
                    {
                        PTEToolTip();
                        if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
                        {
                            AnimalToolTip();
                        }
                    }
                }
            }
            else if (newInvoiceRequestTimeOfServiceComboBox.SelectedIndex == -1)
            {
                TimeOfServiceToolTip();
                if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
                {
                    PTEToolTip();
                    if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
                    {
                        AnimalToolTip();
                    }
                }
            }
            else if (newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
            {
                PTEToolTip();
                if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
                {
                    AnimalToolTip();
                }
            }
            else if (newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
            {
                AnimalToolTip();
            }
            else
            {
                // Check if the primary phone number is valid and add to database or display tooltip message and focus the textbox
                if (IsValidPrimaryPhoneNumber(primaryPhoneNum))
                {
                    int.TryParse(primaryPhoneNum, out primaryPhoneNumber);

                    if (newInvoicePrimaryPhoneExtensionTextBox.Text == null)
                    {
                        primaryPhoneExten = "0";

                        int.TryParse(primaryPhoneExten, out primaryPhoneExtension);
                        // Save default extension
                        OleDbCommand saveOccupantPrimaryPhone = new OleDbCommand("INSERT INTO customer (primary#, primary_extension) VALUES ('" +
                        primaryPhoneNumber + "', '" + primaryPhoneExtension + "');", conn);

                        // increment i to show something happened.
                        i += saveOccupantPrimaryPhone.ExecuteNonQuery();
                    }
                    else
                    {
                        int.TryParse(primaryPhoneExten, out primaryPhoneExtension);
                        // Save if extension included
                        OleDbCommand saveOccupantNumAndExt = new OleDbCommand("INSERT INTO customer (primary#, primary_extension) VALUES ('" +
                            primaryPhoneNumber + "', '" + primaryPhoneExtension + "');", conn);

                        // Increment i to show something happened
                        i += saveOccupantNumAndExt.ExecuteNonQuery();
                    }

                    // Check if the Alternate Phone Number textbox is not empty
                    if (!string.IsNullOrEmpty(newInvoiceAlternatePhoneNumberTextBox.Text))
                    {
                        // Check if Alternate phone number is valid
                        if (IsValidPrimaryPhoneNumber(alternatePhoneNum))
                        {
                            int.TryParse(alternatePhoneNum, out alternatePhoneNumber);
                            OleDbCommand saveOccupantAlternatePhone = new OleDbCommand("INSERT INTO customer (alternate_phone#) VALUES ('" +
                                alternatePhoneNumber + "');", conn);

                            if (newInvoiceAlternatePhoneExtensionTextBox.Text != null)
                            {
                                int.TryParse(altPhoneExt, out alternatePhoneExtension);
                                OleDbCommand saveOccAltExt = new OleDbCommand("INSERT INTO customer (alternate_extension) VALUES ('"
                                    + alternatePhoneExtension + "');", conn);
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
                    OleDbCommand pte = new OleDbCommand("INSERT INTO customer (permission_to_enter) VALUES (true);", conn);
                    i += pte.ExecuteNonQuery();
                }
                else
                {
                    OleDbCommand pteNeg = new OleDbCommand("INSERT INTO customer (permission_to_enter) VALUES (false);", conn);
                    i += pteNeg.ExecuteNonQuery();
                }

                // Check if the user selected yes or no for the AnimalsInHome combobox
                if (newInvoiceAnimalsInHomeComboBox.SelectedItem.ToString().ToLower() == "yes")
                {
                    OleDbCommand pets = new OleDbCommand("INSERT INTO customer (pets) VALUES (true);", conn);
                    i += pets.ExecuteNonQuery();
                }
                else
                {
                    OleDbCommand petsNeg = new OleDbCommand("INSERT INTO customer (pets) VALUES (false);", conn);
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
}
}
