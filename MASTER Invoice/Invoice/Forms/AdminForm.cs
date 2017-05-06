using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Invoice
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDBDataSet1.UserAccounts' table. You can move, or remove it, as needed.
            this.userAccountsTableAdapter1.Fill(this.projectDBDataSet1.UserAccounts);
            // TODO: This line of code loads data into the 'projectDBDataSet1.Invoice' table. You can move, or remove it, as needed.
            this.invoiceTableAdapter1.Fill(this.projectDBDataSet1.Invoice);




        }

        private void activateAccountButton_Click(object sender, EventArgs e)
        {
            string data = "";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell clmSelect = new DataGridViewCheckBoxCell();
                clmSelect = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];
                if (clmSelect.Value != null &&
                       Convert.ToBoolean(clmSelect.Value) == true)
                {
                    data += "'" + (dataGridView1.Rows[i].Cells[1].Value.ToString()) + "' ,";
                }
            }

            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("Please select an account to activate");
            }

            data = data.TrimEnd(',');

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[selected.Name].Value) == true)
                {
                    Engine.Administration.activateAccount(data, row.Cells[1].Value.ToString());
                    if (Engine.Administration.datatable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = Engine.Administration.datatable;
                    }
                    
                }
            }
        }

        private void showUnconfirmedAccountsButton_Click_1(object sender, EventArgs e)
        {

            dataGridView2.Hide();
            dataGridView1.Show();
            Engine.Administration.unconfirmedAccounts();

            if (Engine.Administration.datatable.Rows.Count > 0)
            {
                dataGridView1.DataSource = Engine.Administration.datatable;
            }
            else
            {
                MessageBox.Show("All Accounts Activated");
            }
        }

        private void showAllAccountsButton_Click_1(object sender, EventArgs e)
        {

            dataGridView2.Hide();
            dataGridView1.Show();

            Engine.Administration.allAccounts();

            if (Engine.Administration.datatable.Rows.Count > 0)
            {
                dataGridView1.DataSource = Engine.Administration.datatable;
            }
            
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {

            dataGridView2.Hide();
            dataGridView1.Show();
            string data = "";
            string usertype = "";
            int count = 0;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell clmSelect = new DataGridViewCheckBoxCell();
                clmSelect = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];
                if (clmSelect.Value != null &&
                       Convert.ToBoolean(clmSelect.Value) == true)
                {
                    data += "'" + (dataGridView1.Rows[i].Cells[1].Value.ToString()) + "' ,";
                    usertype += "'" + (dataGridView1.Rows[i].Cells[3].Value.ToString()).ToLower() + "' ,";
                    count++;
                }
            }

            if(string.IsNullOrEmpty(data))
            {
                MessageBox.Show("Please select a user to delete");
            }

            data = data.TrimEnd(',');

            if (count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("You Are About To Delete " + count + " Users", "Delete Users", MessageBoxButtons.YesNo);

                if (deleteResult == DialogResult.Yes)
                {
                    Engine.Administration.deleteUsers(data, usertype);
                    MessageBox.Show(Engine.Administration.message);

                    if (Engine.Administration.datatable.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = Engine.Administration.datatable;
                    }
                }
            }
        }

        private void showAllInvoiceButton_Click(object sender, EventArgs e)
        {

            dataGridView1.Hide();
            dataGridView2.Show();

            Engine.Administration.allInvoices();

            dataGridView2.DataSource = Engine.Administration.datatable;
        }

        private LoginForm login = new LoginForm();
        private void logoutButton_Click(object sender, EventArgs e)
        {
            login.Show();
            this.Close();
        }

        private WorkOrderForm wof = new WorkOrderForm();
        private void showWorkOrderFormButton_Click(object sender, EventArgs e)
        {
            wof.Show();            
        }

        private ContractorWorkOrderForm cwof = new ContractorWorkOrderForm();
        private void showContractorWorkOrderFormButton_Click(object sender, EventArgs e)
        {    
            cwof.Show();
        }

        private NewWorkOrderForm nwof = new NewWorkOrderForm();
        private void showNewWorkOrderFormButton_Click(object sender, EventArgs e)
        {
            nwof.Show();
        }

        private OfficeWorkOrder owof = new OfficeWorkOrder();
        private void showOfficeWorkOrderForm_Click(object sender, EventArgs e)
        {
            owof.Show();
        }

        private void deleteInvoiceButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
            dataGridView2.Show();
            string data = "";
            int count = 0;
            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell clmSelect = new DataGridViewCheckBoxCell();
                clmSelect = (DataGridViewCheckBoxCell)dataGridView2.Rows[i].Cells[0];
                if (clmSelect.Value != null &&
                       Convert.ToBoolean(clmSelect.Value) == true)
                {
                    data += "'" + (dataGridView2.Rows[i].Cells[2].Value.ToString()) + "' ,";
                    count++;
                }
            }

            if (string.IsNullOrEmpty(data))
            {
                MessageBox.Show("Please select an invoice to delete");
            }

            data = data.TrimEnd(',');
            if(count > 0)
            {
                DialogResult deleteResult = MessageBox.Show("You Are About To Delete " + count + " Invoices", "Delete Work Order", MessageBoxButtons.YesNo);

                if (deleteResult == DialogResult.Yes)
                {
                    Engine.Administration.deleteInvoices(data);

                    if (Engine.Administration.datatable.Rows.Count > 0)
                    {
                        dataGridView2.DataSource = Engine.Administration.datatable;
                    }
                }
            }   
        }
    }
}
