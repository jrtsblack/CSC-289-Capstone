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

        private void btnoccupantInvoice_Click(object sender, EventArgs e)
        {
            NewWorkOrderForm occ = new NewWorkOrderForm();
            occ.Show();
        }

        private void btnofficeWorkerInvoice_Click(object sender, EventArgs e)
        {
            OfficeWorkOrder owo = new OfficeWorkOrder();
            owo.Show();
        }
    }
}
