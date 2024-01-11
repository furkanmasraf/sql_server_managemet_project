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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.dataSet1.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            int.TryParse(textBox1.Text, out value);
            this.customerTableAdapter.Insert(value, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
            this.customerTableAdapter.Fill(this.dataSet1.Customer);
        }
    }
}
