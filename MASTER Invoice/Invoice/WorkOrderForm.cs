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

        // Get user information to determine what to display
        private void GetUserInfo()
        {
            // Open DB connection
            conn.Open();

            // Command to grab user information from the database
            OleDbCommand user = new OleDbCommand("SELECT Community_Name, First, Last, Address, " +
                "Email, Primary#, Primary_Phone_Type, Primary_Extension, Alternate_Phone#, Alternate_Phone_Type, " +
                "Alternate_Extension, Permission_To_Enter, Pets, Invoice_ID, Invoice_Type, Description, " +
                "Complete, TimeOfService FROM Customer, Invoice, InvoiceStatus WHERE Customer.Email = UserAccounts.Email " +
                "AND Customer.Customer_ID LIKE Invoice.Customer_ID AND Invoice.Invoice_Status_ID LIKE " + 
                "InvoiceStatus.Invoice_Status_ID;");
            OleDbDataAdapter data = new OleDbDataAdapter(user);
            // Table to hold the user data
            DataTable table1 = new DataTable();
            // Fill table with the data
            data.Fill(table1);

            // Close DB connection
            conn.Close();
        }

        private void newInvoiceButton_Click(object sender, EventArgs e)
        {
            NewWorkOrderForm newWorkOrder = new NewWorkOrderForm();
            newWorkOrder.Show();
            this.Hide();
        }

        private void printInvoiceButton_Click(object sender, EventArgs e)
        {

        }

        private void invoiceInformationCancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
