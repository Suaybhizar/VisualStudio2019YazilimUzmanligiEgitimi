using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUserControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKisileriYukle_Click(object sender, EventArgs e)
        {
            var Kisiler = KisiKaynagi.Kisiler;
            foreach (var kisi in Kisiler)
            {
                UCKisi yeniKisi = new UCKisi();
                yeniKisi.Baslik = kisi.Baslik;
                yeniKisi.Aciklama = kisi.Aciklama;
                yeniKisi.Resim = kisi.Resim;
                yeniKisi.Height = 80;
                FlowKisiler.Controls.Add(yeniKisi);
            }
        }
    }
}
