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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.dataSet1.Brand);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            int.TryParse(textBox1.Text, out value);
            this.brandTableAdapter.Insert(value, textBox2.Text);
            this.brandTableAdapter.Fill(this.dataSet1.Brand);
        }
    }
}
