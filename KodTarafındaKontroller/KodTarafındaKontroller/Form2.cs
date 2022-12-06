using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodTarafındaKontroller
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl.Controls.Count != 0)
                {
                    foreach (Control child in ctl.Controls)
                    {
                        child.BackColor = Color.Red;
                    }
                }
            }
        }
    }
}
