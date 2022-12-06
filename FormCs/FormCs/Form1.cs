using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormCs
{
    public partial class Form1 : Form
    {
        //back-end programcı
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(200, 150, 50);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(textBox1.Text);
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(Convert.ToInt32(textBox2.Text));
            frm.Show();
        }
    }
}
