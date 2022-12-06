using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormUserControl.Properties;

namespace WinFormUserControl
{
    public class Kisi
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public Image Resim { get; set; }
    }

    public class KisiKaynagi
    {
        public static List<Kisi> Kisiler
        {
            get
            {
                return new List<Kisi>
            {
               new Kisi{Baslik="Kişi1",Aciklama="Açıklama1",Resim=Resources.erkek},
               new Kisi{Baslik="Kişi2",Aciklama="Açıklama2",Resim=Resources.kadin}
            };
            }
        }
    }
}
