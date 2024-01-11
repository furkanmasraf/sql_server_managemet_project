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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Seller' table. You can move, or remove it, as needed.
            this.sellerTableAdapter.Fill(this.dataSet1.Seller);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vp;
            int vp2;
            int.TryParse(textBox1.Text, out vp);
            int.TryParse(comboBox1.Text, out vp2);
            this.sellerTableAdapter.Insert(vp, textBox2.Text, textBox3.Text, textBox4.Text, vp2);
            this.sellerTableAdapter.Fill(this.dataSet1.Seller);
        }
    }
}
