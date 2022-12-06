using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUserControlPratic_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var kisiler = KisiKaynagi.Kisiler;
            foreach (var kisi in kisiler)
            {
                ucKisi yeniKisi = new ucKisi();
                yeniKisi.Baslik = kisi.Baslik;
                yeniKisi.Aciklama = kisi.Aciklama;
                yeniKisi.OgrenimDuzeyi = kisi.OgrenimDuzeyi;
                yeniKisi.Resim = kisi.Resim;
                flowLayoutPanel1.Controls.Add(yeniKisi);3
            }
        }
    }
}
