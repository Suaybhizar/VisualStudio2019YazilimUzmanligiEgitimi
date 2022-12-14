using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormUserControlPratic
{
    public partial class ucKisi : UserControl
    {
        public ucKisi()
        {
            InitializeComponent();
        }
        public string Baslik
        {
            get { return lblBaslik.Text; }
            set { lblBaslik.Text = value; }
        }
        public string Aciklama
        {
            get { return lblAciklama.Text; }
            set { lblAciklama.Text = value; }
        }
        public string Sinif
        {
            get { return lblSinif.Text; }
            set { lblSinif.Text = value; }
        }
        public Image Resim
        {
            get { return pbResim.Image; }
            set { pbResim.Image = value; }
        }
    }
}
