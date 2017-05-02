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
        }

        private OfficeWorkOrder owo = new OfficeWorkOrder();
        private void btnofficeWorkerInvoice_Click(object sender, EventArgs e)
        {
            owo.Show();
        }
    }
}
