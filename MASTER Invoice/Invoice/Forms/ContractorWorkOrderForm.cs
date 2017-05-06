using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace Invoice
{
    public partial class ContractorWorkOrderForm : Form
    {

        string invoicestatus = " ";
        public ContractorWorkOrderForm()
        {
            InitializeComponent();
            foreach(string s in Engine.Contractor.Fill_AvailableInvoices())
            {
                lbxAvailableWorkOrders.Items.Add(s);
            }

            foreach(string s in Engine.Contractor.Fill_AcceptedInvoices())
            {
                lbxAcceptedWorkOrders.Items.Add(s);
            }
            

        }

        private void btnAcceptWorkOrder_Click(object sender, EventArgs e)
        {
            if(lbxAvailableWorkOrders.SelectedIndex != -1)
            {
                Engine.Contractor.acceptWorkOrder(lbxAvailableWorkOrders.GetItemText(lbxAvailableWorkOrders.SelectedItem));
                lbxAcceptedWorkOrders.Items.Add(lbxAvailableWorkOrders.SelectedItem);
                lbxAvailableWorkOrders.Items.Remove(lbxAvailableWorkOrders.SelectedItem);
            }
        }

        private void lbxAvailableWorkOrders_SelectedIndexChanged(object sender, EventArgs e)
        {

            lbxAcceptedWorkOrders.SelectedIndex = -1;
            gbxUpdate.Enabled = false;
            if (lbxAvailableWorkOrders.SelectedIndex != -1)
            {
                lblacceptedavailable.Text = "Available Work Order";
                Engine.Contractor.selectedInvoice(lbxAvailableWorkOrders.GetItemText(lbxAvailableWorkOrders.SelectedItem));
                lblFirstName.Text = Engine.Contractor.firstname;
                lblLastName.Text = Engine.Contractor.lastname;
                lblStreetAddress.Text = Engine.Contractor.address;
                lblWorkOrderType.Text = Engine.Contractor.workordertype;
                rtbxDescriptionOfRequest.Text = Engine.Contractor.description;
                lblRequestTimeOfService.Text = Engine.Contractor.tos;
                lblPermissionToEnter.Text = Engine.Contractor.pte;
                lblAnimals.Text = Engine.Contractor.pets;
                lblDate.Text = Engine.Contractor.date;

                if (Engine.Contractor.complete)
                {
                    rbtnComplete.Checked = true;
                }
                else
                {
                    rbtnIncomplete.Checked = true;
                }
            }
        }
         
        private void lbxAcceptedWorkOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxAvailableWorkOrders.SelectedIndex = -1;
            gbxUpdate.Enabled = true;

            if (lbxAcceptedWorkOrders.SelectedIndex != -1)
            {
                lblacceptedavailable.Text = "Accepted Work Order";
                Engine.Contractor.selectedInvoice(lbxAcceptedWorkOrders.GetItemText(lbxAcceptedWorkOrders.SelectedItem));
                lblFirstName.Text = Engine.Contractor.firstname;
                lblLastName.Text = Engine.Contractor.lastname;
                lblStreetAddress.Text = Engine.Contractor.address;
                lblWorkOrderType.Text = Engine.Contractor.workordertype;
                rtbxDescriptionOfRequest.Text = Engine.Contractor.description;
                lblRequestTimeOfService.Text = Engine.Contractor.tos;
                lblPermissionToEnter.Text = Engine.Contractor.pte;
                lblAnimals.Text = Engine.Contractor.pets;
                lblDate.Text = Engine.Contractor.date;

                if (Engine.Contractor.complete)
                {
                    rbtnComplete.Checked = true;
                }
                else
                {
                    rbtnIncomplete.Checked = true;
                }
                rtxtComments.Text = Engine.Contractor.comments;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbxAcceptedWorkOrders.SelectedIndex != -1)
            {
                if (rbtnComplete.Checked)
                {
                    invoicestatus = "complete";
                    
                }
                else if (rbtnIncomplete.Checked)
                {
                    invoicestatus = "incomplete";
                }
                Engine.Contractor.updateInvoice(rtxtComments.Text.ToString(), invoicestatus,
                    lbxAcceptedWorkOrders.GetItemText(lbxAcceptedWorkOrders.SelectedItem));
                MessageBox.Show(Engine.Contractor.message);
            }
            else
            {
                MessageBox.Show("Please select an invoice");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (Engine.ActiveUser.usertype.ToLower() == "administrator")
            {
                this.Close();
            }
            else
            {
                LoginForm login = new LoginForm();
                login.Show();
                this.Close();
            }
        }
    }
}
