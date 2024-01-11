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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Enroll' table. You can move, or remove it, as needed.
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vp;
            int vp1;
            int vp2;
            int.TryParse(this.comboBox1.Text, out vp);
            int.TryParse(this.comboBox2.Text, out vp1);
            int.TryParse(this.textBox1.Text, out vp2);
            this.enrollTableAdapter.Insert(vp2, vp1, vp);
            this.enrollTableAdapter.Fill(this.dataSet1.Enroll);
        }
    }
}
