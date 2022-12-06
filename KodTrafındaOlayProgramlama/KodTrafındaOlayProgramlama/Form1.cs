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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 1;
        private void ButtonTiklandi(object sender, EventArgs e)
        {
            //tıklanan buton
            Button btn = sender as Button;
            //yeni eklenen buton
            Button btnYeni = new Button();
            this.Controls.Add(btnYeni);
            //yeni butonun özellikleri ayarlanıyor.
            btnYeni.Top = btn.Top + btn.Height;
            btnYeni.Left = btn.Left;
            btnYeni.Text = "button " + (++sayac).ToString();
            int kirmizi = new Random().Next(1, 999) % 255;
            int yesil = new Random().Next(88, 888) % 255;
            int mavi = new Random().Next(55, 555) % 255;
            btnYeni.BackColor = Color.FromArgb(kirmizi, yesil, mavi);
            btnYeni.BringToFront();

            //yeni eklenen butona click olayını bağlayalım
            btnYeni.Click += ButtonTiklandi;

            //Tıklanan butondan click olayını kaldıralım
            btn.Click -= ButtonTiklandi;

        }

        
    }
}
