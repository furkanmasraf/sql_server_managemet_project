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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.dataSet1.Brand);
            // TODO: This line of code loads data into the 'dataSet1.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.dataSet1.Product);

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
            this.productTableAdapter.Insert(vp, textBox2.Text, textBox3.Text, textBox4.Text, vp2);
            this.productTableAdapter.Fill(this.dataSet1.Product);
        }
    }
}
