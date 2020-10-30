using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hands_on_02
{
    public partial class Queuingform : Form
    {
        public Queuingform()
        {
            InitializeComponent();
        }
        private CashierClass cashier = new CashierClass();

        private void btnCashier_Click(object sender, EventArgs e)
        {
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getnumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getnumberInQueue);
        }

        private void lblQueue_Click(object sender, EventArgs e)
        {

        }

        private void btnNextForm_Click(object sender, EventArgs e)
        {
            CashierWindowQueueForm Form2 = new CashierWindowQueueForm();

            Form2.ShowDialog();
        }
    }
}
