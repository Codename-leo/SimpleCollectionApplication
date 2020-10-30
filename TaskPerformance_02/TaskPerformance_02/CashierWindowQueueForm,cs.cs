using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskPerformance_02
{
    public partial class CashierWindowQueueForm_cs : Form
    {
        public CashierWindowQueueForm_cs()
        {
            InitializeComponent();
        }

        private int _tick;
        private void btnRefresh_Click(object sender, EventArgs e)
        {

            DisplayCashierQueue(CashierClass.CashierQueue);
            timer1.Stop();
        }
        public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (Object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

            private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                _tick++;
                lblTime.Text = _tick.ToString();
                if (_tick == 30)
                {
                    CustomerView Form3 = new CustomerView();
                    Form3.ShowDialog();
                    DisplayCashierQueue(CashierClass.CashierQueue.Dequeue());
                    DisplayCashierQueue(CashierClass.CashierQueue);
                    timer1.Stop();
                    _tick = 0;

                }
            }
            catch
            {
                timer1.Stop();
                MessageBox.Show("There is nothing in the queue right now", "Message");
                _tick = 0;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start(); 
        }

        private void CashierWindowQueueForm_cs_Load(object sender, EventArgs e)
        {
            DisplayCashierQueue(CashierClass.CashierQueue);
            timer1.Stop();
        }

        private void listCashierQueue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
