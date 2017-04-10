﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Invoice
{
    public partial class WorkOrderForm : Form
    {
        public WorkOrderForm()
        {
            InitializeComponent();
        }

        // Database connection statement
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = ProjectDB.accdb;Persist Security Info=True");
        // Username information entered on login form.
        private LoginForm userName = new LoginForm();

        // Get user information to determine what to display
        private void GetOccupantAcctInfo()
        {
            // Open DB connection
            conn.Open();
            string commName, firstName, lastName, address, email, primPhoneType, altPhoneType, pte, pets, invoiceType, description,
                complete, tos, primNum, primExtension, altNum, altExtension, invoiceID, comments;          

            // Command to grab user information from the database
            OleDbCommand user = new OleDbCommand($"SELECT Community_Name, First, Last, Address,  Email, Primary#, Primary_Phone_Type, Primary_Extension, " + 
                "Alternate_Phone#, Alternate_Phone_Type, Alternate_Extension, Permission_To_Enter, Pets, Invoice_ID, Invoice_Type, Description, Complete, TimeOfService, Comments " +
                "FROM Customer, Invoice, InvoiceStatus WHERE Customer.Email ={userName.emailEntryTextBox.Text} AND Customer.Customer_ID LIKE Invoice.Customer_ID AND Invoice.Invoice_Status_ID " + 
                "LIKE  InvoiceStatus.Invoice_Status_ID;");
            OleDbDataAdapter data = new OleDbDataAdapter(user);
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
                primPhoneType = table1.Rows[0]["Primary_Phone_Type"].ToString();
                primExtension = table1.Rows[0]["Primary_Extension"].ToString();
                altNum = table1.Rows[0]["Alternate_Phone#"].ToString();
                altPhoneType = table1.Rows[0]["Alternate_Phone_Type"].ToString();
                altExtension = table1.Rows[0]["Alternate_Extension"].ToString();
                pte = table1.Rows[0]["Permission_To_Enter"].ToString();
                pets = table1.Rows[0]["Pets"].ToString();
                invoiceType = table1.Rows[0]["Invoice_Type"].ToString();
                description = table1.Rows[0]["Description"].ToString();
                complete = table1.Rows[0]["Complete"].ToString();
                tos = table1.Rows[0]["TimeOfService"].ToString();
                invoiceID = table1.Rows[0]["Invoice_ID"].ToString();
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
            // Close DB connection
            conn.Close();
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
            Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bit, e.MarginBounds);
        }
    }
}
