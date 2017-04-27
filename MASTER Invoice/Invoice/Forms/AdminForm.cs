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
            // TODO: This line of code loads data into the 'projectDBDataSet.UserAccounts' table. You can move, or remove it, as needed.
            this.userAccountsTableAdapter.Fill(this.projectDBDataSet.UserAccounts);



        }
        SqlDataAdapter adapter;
        DataSet ds;
        static string path = AppDomain.CurrentDomain.SetupInformation.ApplicationBase;
        SqlConnection connection = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=" + path + @"ProjectDB.mdf;Integrated Security = True");

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
                    data += "'" + (dataGridView1.Rows[i].Cells[1].Value.ToString()) + "'" + ",";
                }
            }
            data = data.TrimEnd(',');

            string updatesql = "UPDATE UserAccounts SET Confirmed='1' WHERE email IN (" + data + ")";
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[selected.Name].Value) == true)
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(updatesql, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    string update = "SELECT * FROM UserAccounts";

                    SqlDataAdapter userAdapter = new SqlDataAdapter(update, connection);
                    DataTable users = new DataTable();
                    users.Clear();
                    userAdapter.Fill(users);

                    if (users.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = users;
                    }
                }
            }
        }

        private void showUnconfirmedAccountsButton_Click_1(object sender, EventArgs e)
        {

            dataGridView2.Hide();
            dataGridView1.Show();

            connection.Open();
            string unconfirmedsql = "SELECT * FROM UserAccounts WHERE confirmed=0";
            SqlDataAdapter unconfirmedAdapter = new SqlDataAdapter(unconfirmedsql, connection);
            DataTable users = new DataTable();
            users.Clear();
            unconfirmedAdapter.Fill(users);

            if (users.Rows.Count > 0)
            {
                dataGridView1.DataSource = users;
            }
            connection.Close();
        }

        private void showAllAccountsButton_Click_1(object sender, EventArgs e)
        {

            dataGridView2.Hide();
            dataGridView1.Show();

            connection.Open();
            string allsql = "SELECT * FROM UserAccounts";
            SqlDataAdapter allAdapter = new SqlDataAdapter(allsql, connection);
            DataTable users = new DataTable();
            users.Clear();
            allAdapter.Fill(users);

            if (users.Rows.Count > 0)
            {
                dataGridView1.DataSource = users;
            }
            connection.Close();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {

            dataGridView2.Hide();
            dataGridView1.Show();
            connection.Open();
            string data = "";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewCheckBoxCell clmSelect = new DataGridViewCheckBoxCell();
                clmSelect = (DataGridViewCheckBoxCell)dataGridView1.Rows[i].Cells[0];
                if (clmSelect.Value != null &&
                       Convert.ToBoolean(clmSelect.Value) == true)
                {
                    data += (dataGridView1.Rows[i].Cells[1].Value.ToString()) + ",";
                }
            }

            data = data.TrimEnd(',');

            string deletesql = "DELETE FROM UserAccounts WHERE email IN ('" + data + "')";

            SqlCommand cmd = new SqlCommand(deletesql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            string update = "SELECT * FROM UserAccounts";

            SqlDataAdapter userAdapter = new SqlDataAdapter(update, connection);
            DataTable users = new DataTable();
            users.Clear();
            userAdapter.Fill(users);

            if (users.Rows.Count > 0)
            {
                dataGridView1.DataSource = users;
            }
        }

        private void showAllInvoiceButton_Click(object sender, EventArgs e)
        {

            dataGridView1.Hide();
            dataGridView2.Show();
            connection.Open();
            string allinvoice = "SELECT * FROM Invoice";
            adapter = new SqlDataAdapter(allinvoice, connection);
            ds = new DataSet();
            adapter.Fill(ds, "Invoices");
            dataGridView2.DataSource = ds.Tables[0];

            connection.Close();
        }

        private void updateInvoiceButton_Click(object sender, EventArgs e)
        {

            SqlCommandBuilder cmdbl = new SqlCommandBuilder(adapter);
            adapter.Update(ds, "Invoices");
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            

            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void showWorkOrderFormButton_Click(object sender, EventArgs e)
        {
            WorkOrderForm wof = new WorkOrderForm();
            wof.Show();            
        }

        private void showContractorWorkOrderFormButton_Click(object sender, EventArgs e)
        {
            ContractorWorkOrderForm cwof = new ContractorWorkOrderForm();
            cwof.Show();
        }

        private void showNewWorkOrderFormButton_Click(object sender, EventArgs e)
        {
            NewWorkOrderForm nwof = new NewWorkOrderForm();
            nwof.Show();
        }
        
        private void showOfficeWorkOrderForm_Click(object sender, EventArgs e)
        {
            OfficeWorkOrder owof = new OfficeWorkOrder();
            owof.Show();
        }
    }
}
