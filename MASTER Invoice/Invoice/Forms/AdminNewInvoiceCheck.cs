using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice.Forms
{
    public partial class AdminNewInvoiceCheck : Form
    {
        public AdminNewInvoiceCheck()
        {
            InitializeComponent();
        }

        private NewWorkOrderForm occ = new NewWorkOrderForm();
        private void btnoccupantInvoice_Click(object sender, EventArgs e)
        {  
            occ.Show();
            this.Close();
        }

        private OfficeWorkOrder owo = new OfficeWorkOrder();
        private void btnofficeWorkerInvoice_Click(object sender, EventArgs e)
        {
            owo.Show();
            this.Close();
        }

        private void AdminNewInvoiceCheck_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Form open = Application.OpenForms["WorkOrderForm"];
            open.Show();
            this.Close();
        }
    }
}
