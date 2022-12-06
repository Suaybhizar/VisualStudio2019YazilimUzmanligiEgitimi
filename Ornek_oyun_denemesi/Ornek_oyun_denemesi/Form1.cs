using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ornek_oyun_denemesi
{
    public partial class Form1 : Form
    { 
        Form2 form2;
        public Form1()
        {
            InitializeComponent();
            //Form1 konumlandıralım
            this.Left = 200;
            //Form2 yi aç
            form2 = new Form2();
            form2.Left = this.Left + this.Width;
            form2.Show();

            
            
        }

        private void btnYukarı_Click(object sender, EventArgs e)
        {
            form2.Oyuncu.Top -= 5;
        }

        private void btnasagi_Click(object sender, EventArgs e)
        {
            form2.Oyuncu.Top += 5;
        }

        private void btnSag_Click(object sender, EventArgs e)
        {
            form2.Oyuncu.Left += 5;
        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            form2.Oyuncu.Left -= 5;
        }
    }
}
