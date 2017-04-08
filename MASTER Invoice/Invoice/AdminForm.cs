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
            
        }
        OleDbDataAdapter adapter;
        DataSet ds;

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
                    data += (dataGridView1.Rows[i].Cells[1].Value.ToString()) + ",";
                }
            }
            data = data.TrimEnd(',');
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDB.accdb");

            string updatesql = "UPDATE UserAccounts SET Confirmed='1' WHERE email IN ('" + data + "')";

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (Convert.ToBoolean(row.Cells[selected.Name].Value) == true)
                {
                    connection.Open();
                    OleDbCommand cmd = new OleDbCommand(updatesql, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    string update = "SELECT * FROM UserAccounts";

                    OleDbDataAdapter userAdapter = new OleDbDataAdapter(update, connection);
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
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDB.accdb");

            dataGridView2.Hide();
            dataGridView1.Show();

            connection.Open();
            string unconfirmedsql = "SELECT * FROM UserAccounts WHERE confirmed=0";
            OleDbDataAdapter unconfirmedAdapter = new OleDbDataAdapter(unconfirmedsql, connection);
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
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDB.accdb");

            dataGridView2.Hide();
            dataGridView1.Show();

            connection.Open();
            string allsql = "SELECT * FROM UserAccounts";
            OleDbDataAdapter allAdapter = new OleDbDataAdapter(allsql, connection);
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
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDB.accdb");

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

            OleDbCommand cmd = new OleDbCommand(deletesql, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            string update = "SELECT * FROM UserAccounts";

            OleDbDataAdapter userAdapter = new OleDbDataAdapter(update, connection);
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
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDB.accdb");

            dataGridView1.Hide();
            dataGridView2.Show();
            connection.Open();
            string allinvoice = "SELECT * FROM Invoice";
            adapter = new OleDbDataAdapter(allinvoice, connection);
            ds = new DataSet();
            adapter.Fill(ds, "Invoices");
            dataGridView2.DataSource = ds.Tables[0];

            connection.Close();
        }

        private void updateInvoiceButton_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=ProjectDB.accdb");

            OleDbCommandBuilder cmdbl = new OleDbCommandBuilder(adapter);
            adapter.Update(ds, "Invoices");
        }
    }
}
