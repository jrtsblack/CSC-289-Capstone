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
            defaultInformation();
            if (Engine.ActiveUser.usertype.ToLower() == "administrator")
            {
                this.Height = 700;
                adminFormButton.Enabled = true;
                adminFormButton.Visible = true;
            }
        }


        // Save values into the project DB
        private void saveInvoiceButton_Click(object sender, EventArgs e)
        {
            nullOrEmptyCheck();
            if (nullOrEmptyCheck())
            {
                string altnum = newInvoiceAlternatePhoneNumberTextBox.Text;
                string altphonetype;
                string altextension = newInvoiceAlternatePhoneExtensionTextBox.ToString();
                if (newInvoiceAlternatePhoneTypeComboBox.SelectedIndex != -1)
                {
                    altphonetype = newInvoiceAlternatePhoneTypeComboBox.SelectedItem.ToString();
                }
                else
                {
                    altphonetype = null;
                }

                Engine.WorkOrders.saveInvoice(altnum,altphonetype, altphonetype, newInvoiceCommunityComboBox.SelectedItem.ToString().ToLower(),
                                            newInvoiceStreetAddressTextBox.Text.ToLower(), newInvoiceEmailTextBox.Text.ToLower(), newInvoicePrimaryPhoneNumberTextBox.Text.ToLower(),
                                            newInvoicePrimaryPhoneTypeComboBox.SelectedItem.ToString().ToLower(), newInvoicePrimaryPhoneExtensionTextBox.Text.ToLower(),
                                            newInvoiceRequestTimeOfServiceComboBox.SelectedItem.ToString().ToLower(), newInvoiceWorkOrderTypeComboBox.SelectedItem.ToString().ToLower(),
                                            newInvoiceDescriptionOfRequestRichTextBox.Text.ToString().ToLower(), newInvoicePermissionToEnterComboBox.SelectedItem.ToString().ToLower(), newInvoiceAnimalsInHomeComboBox.SelectedItem.ToString().ToLower());


                MessageBox.Show(Engine.WorkOrders.message);

                WorkOrderForm workorder = new WorkOrderForm();
                workorder.Show();
                this.Close();
            }
            
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

            defaultInformation();
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

        // Automatically format phone numbers to correct format in the textbox
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

        // Automatically format phone numbers to correct format in the textbox
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

        // Display tooltips if values are empty
        private bool nullOrEmptyCheck()
        {
            bool check = false;
            
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
            // Set default values, if required fields are not null
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

        private void defaultInformation()
        {
            newInvoiceFirstNameTextBox.Text = Engine.ActiveUser.firstname;
            newInvoiceLastNameTextBox.Text = Engine.ActiveUser.lastname;
            newInvoiceEmailTextBox.Text = Engine.ActiveUser.email;
            newInvoicePrimaryPhoneNumberTextBox.Text = Engine.ActiveUser.phonenum;

        }

        private void adminFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm admin = new AdminForm();
            admin.Show();
        }
    }
}
