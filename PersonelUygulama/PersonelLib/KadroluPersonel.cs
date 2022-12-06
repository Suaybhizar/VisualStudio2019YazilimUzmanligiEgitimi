using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelLib
{
    public class KadroluPersonel : PersonelBase
    {
        double aylik;
        int rapor;

        public KadroluPersonel(int id, string ad, string soyad, double aylik, int rapor) : base(id, ad, soyad)
        {
            Aylik = aylik;
            Rapor = rapor;
        }
        public KadroluPersonel() : base()
        {

        }

        public double Aylik
        {
            get
            {
                return aylik;
            }

            set
            {
                aylik = value;
            }
        }

        public int Rapor
        {
            get
            {
                return rapor;
            }

            set
            {
                rapor = value;
            }
        }

        public override double AylikHesapla()
        {
            if (Rapor <= 5)
                return Aylik;
            else
                return Aylik - (Aylik / 30) * (Rapor - 5);
        }
    }
}
