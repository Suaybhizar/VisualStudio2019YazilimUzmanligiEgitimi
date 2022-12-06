using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TasarimEkranindaOlayProgramlama
{
    public partial class Form1 : Form
    {
        Color orjRenk;
        public Form1()
        {
            InitializeComponent();
            orjRenk = button1.BackColor;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.BackColor = Color.Lime;
           
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = orjRenk;
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show(string.Format("Farenin sol tuşuna {0},{1} konumunda tıkladınız. ", e.X, e.Y));
            }
            else if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show(string.Format("Farenin sağ tuşuna {0},{1} konumunda tıkladınız. ", e.X, e.Y));
            }
            else if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show(string.Format("Farenin orta tuşuna {0},{1} konumunda tıkladınız. ", e.X, e.Y));
            }
        }
    }
}
