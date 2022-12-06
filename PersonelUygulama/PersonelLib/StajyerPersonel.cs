using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelLib
{
    public class StajyerPersonel : PersonelBase
    {
        int saat;
        double saatlik;

        public StajyerPersonel(int id, string ad, string soyad, int saat, double saatlik) : base(id, ad, soyad)
        {
            Saat = saat;
            Saatlik = saatlik;
        }
        public StajyerPersonel() : base()
        {

        }

        public int Saat
        {
            get
            {
                return saat;
            }

            set
            {
                saat = value;
            }
        }

        public double Saatlik
        {
            get
            {
                return saatlik;
            }

            set
            {
                saatlik = value;
            }
        }

        public override double AylikHesapla()
        {
            return Saat * Saatlik;
        }
    }
}
