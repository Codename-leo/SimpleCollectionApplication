﻿using System;
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
    public partial class QueueForm : Form
    {
        public QueueForm()
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

        private void btnNextForm_Click(object sender, EventArgs e)
        {

            CashierWindowQueueForm_cs Form = new CashierWindowQueueForm_cs();
            Form.ShowDialog();
        }
    }
}
