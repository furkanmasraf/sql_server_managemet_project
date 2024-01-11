using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 brand = new Form2();
            brand.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 product = new Form3();
            product.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 seller = new Form4();
            seller.ShowDialog();    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 customer = new Form5();
            customer.ShowDialog();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 enroll = new Form6();
            enroll.ShowDialog();
        }
    }
}
