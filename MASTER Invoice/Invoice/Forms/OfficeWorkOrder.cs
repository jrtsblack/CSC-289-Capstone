﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Invoice
{
    public partial class OfficeWorkOrder : Form
    {
        public OfficeWorkOrder()
        {
            InitializeComponent();
        }
        
        private void OfficeWorkOrder_Load(object sender, EventArgs e)
        {
            this.contractorCompanyTableAdapter1.Fill(this.projectDBDataSet1.ContractorCompany);
            if(Engine.ActiveUser.usertype.ToLower() == "administrator")
            {
                this.Height = 502;
                adminFormButton.Enabled = true;
                adminFormButton.Visible = true;
            }
        }

        private void rbtnOccupied_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnOccupied.Checked)
            {
                if(Engine.ActiveUser.usertype.ToLower() == "administrator")
                {
                    this.Height = 578;
                    adminFormButton.Location = new Point(142, 488);
                }
                else
                {
                    this.Size = new Size(378, 528);
                }
                gbxOfficeWorkOrder.Size = new Size(338, 418);
                occupiedPanel.Visible = true;
                occupiedPanel.Size = new Size(320, 66);
                lblDescriptionPrompt.Location = new Point(9, 293);
                rtxtDescriptionOfRequest.Location = new Point(12, 308);
                btnSubmit.Location = new Point(10, 442);
                btnClear.Location = new Point(142, 442);
                btnCancel.Location = new Point(272, 442);
            }
            else if(rbtnUnoccupied.Checked)
            {

                if (Engine.ActiveUser.usertype.ToLower() == "administrator")
                {
                    this.Height = 502;
                    adminFormButton.Location = new Point(142, 408);
                }
                else
                {
                    this.Size = new Size(378, 443);
                }
                gbxOfficeWorkOrder.Size = new Size(338, 333);
                occupiedPanel.Visible = false;
                occupiedPanel.Size = new Size(1, 1);
                lblDescriptionPrompt.Location = new Point(9, 215);
                rtxtDescriptionOfRequest.Location = new Point(12, 230);
                btnSubmit.Location = new Point(10, 358);
                btnClear.Location = new Point(142, 358);
                btnCancel.Location = new Point(272, 358);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult cancelResult = MessageBox.Show("Are you sure you want to cancel this Work Order?", "Cancel Work Order", MessageBoxButtons.YesNo);
            if(cancelResult == DialogResult.Yes)
            {
                this.Close();
                WorkOrderForm workorders = new WorkOrderForm();

                workorders.Show();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            DialogResult clearResult = MessageBox.Show("Are you sure you want to clear this Work Order?", "Clear Work Order", MessageBoxButtons.YesNo);
            if (clearResult == DialogResult.Yes)
            {
                txtStreetAddress.Text = null;
                newInvoiceCommunityComboBox.SelectedIndex = -1;
                cmbxWorkOrderType.SelectedIndex = -1;
                cmbxContractingCompany.SelectedIndex = -1;
                dateTimePicker.Value = DateTimePicker.MinimumDateTime;
                rtxtDescriptionOfRequest.Text = null;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            nullOrEmptyCheck();
            if (nullOrEmptyCheck())
            {
                string occstat = " ";
                string animal = " ";
                string pte = " ";
                if (rbtnOccupied.Checked)
                {
                    occstat = rbtnOccupied.Text;
                    animal = newInvoiceAnimalsInHomeComboBox.SelectedItem.ToString().ToLower();
                    pte = newInvoicePermissionToEnterComboBox.SelectedItem.ToString().ToLower();
                }
                else if (rbtnUnoccupied.Checked)
                {
                    occstat = rbtnUnoccupied.Text;
                    animal = " ";
                    pte = " ";
                }
                Engine.OfficeWorker.SubmitWorkOrder(cmbxContractingCompany.Text, occstat, newInvoiceCommunityComboBox.SelectedItem.ToString(),
                    txtStreetAddress.Text, dateTimePicker.Value, cmbxWorkOrderType.SelectedItem.ToString().ToLower(), rtxtDescriptionOfRequest.Text,
                    animal, pte);

                MessageBox.Show(Engine.OfficeWorker.message);
                this.Close();
                WorkOrderForm workorders = new WorkOrderForm();

                workorders.Show();
            }
        }

        private bool nullOrEmptyCheck()
        {
            bool check = false;

            if (string.IsNullOrEmpty(txtStreetAddress.Text))
            {
                //Add Tooltip
            }
            if (newInvoiceCommunityComboBox.SelectedIndex == -1)
            {
                //Add Tooltip
            }
            if (cmbxWorkOrderType.SelectedIndex == -1)
            {
                //Add Tooltip
            }
            if (cmbxContractingCompany.SelectedIndex == -1)
            {
                //Add Tooltip
            }
            if(!rbtnOccupied.Checked || !rbtnUnoccupied.Checked)
            {
                //Add Tooltip
            }
            if (string.IsNullOrEmpty(rtxtDescriptionOfRequest.Text))
            {
                //Add Tooltip
            }
            if (rbtnOccupied.Checked && newInvoicePermissionToEnterComboBox.SelectedIndex == -1)
            {
                //Add Tooltip
            }
            if (rbtnOccupied.Checked && newInvoiceAnimalsInHomeComboBox.SelectedIndex == -1)
            {
                //Add Tooltip
            }
            // return true if required fields are not null
            else if (!string.IsNullOrEmpty(txtStreetAddress.Text) && newInvoiceCommunityComboBox.SelectedIndex != -1 && cmbxWorkOrderType.SelectedIndex != -1 &&
                     cmbxContractingCompany.SelectedIndex != -1 && (rbtnOccupied.Checked || rbtnUnoccupied.Checked) && !string.IsNullOrEmpty(rtxtDescriptionOfRequest.Text))
            {
                if(rbtnOccupied.Checked && newInvoicePermissionToEnterComboBox.SelectedIndex != -1 && newInvoiceAnimalsInHomeComboBox.SelectedIndex != -1)
                {
                    check = true;
                }
                else if(rbtnUnoccupied.Checked)
                {
                    check = true;
                }
            }
            return check;
        }

        private void adminFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
            AdminForm admin = new AdminForm();
            admin.Show();
        }
    }
}
