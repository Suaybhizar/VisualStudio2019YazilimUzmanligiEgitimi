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
    public partial class UCKisi : UserControl
    {
        public UCKisi()
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

        public Image Resim
        {
            get { return PbResim.Image; }
            set { PbResim.Image = value; }
        }
    }
}
