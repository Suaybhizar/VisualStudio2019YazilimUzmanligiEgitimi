using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLib
{
    public class Ogrenci
    {
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public Sinif Sinif { get; set; }

        public override string ToString()
        {
            return string.Format("Id: {0}\n Adı: {1}\n Soyadı: {2}\n Sınıfı: {3} / {4}",
                 OgrenciId, Ad, Soyad, Sinif.SinifId, Sinif.SinifAdi);
        }

    }
}
