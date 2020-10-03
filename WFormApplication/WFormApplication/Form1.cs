using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            getAnswer divide = new getAnswer(Formm.Division);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(divide(num1, num2).ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            getAnswer multiply = new getAnswer(Formm.Multiplication);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(multiply(num1, num2).ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getAnswer Add = new getAnswer(Formm.Addition);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(Add(num1, num2).ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            getAnswer subtract = new getAnswer(Formm.Subtraction);

            int num1 = Int32.Parse(textBox1.Text);
            int num2 = Int32.Parse(textBox2.Text);

            MessageBox.Show(subtract(num1, num2).ToString());
        }
    }
}
