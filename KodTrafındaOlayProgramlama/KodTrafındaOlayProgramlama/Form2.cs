using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KodTrafındaOlayProgramlama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl.Text != (sender as Control).Text)
                {
                    ctl.Click -= KontrolTiklandi;
                    ctl.Click += KontrolTiklandi;
                }
               
            }
        }

        private void KontrolTiklandi(object sender, EventArgs e)
        {
            Control ctl = sender as Control;
            MessageBox.Show("Tıklanan Kontrolün tipi : " + ctl.GetType());
        }
    }
}
