using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelLib
{
    public class SözlesmeliPersonel : PersonelBase
    {
        int gun;
        double gunluk;

        public SözlesmeliPersonel(int id, string ad, string soyad, int gun, double gunluk) : base(id, ad, soyad)
        {
            Gun = gun;
            Gunluk = gunluk;
        }
        public SözlesmeliPersonel()
        {

        }

        public int Gun
        {
            get
            {
                return gun;
            }

            set
            {
                gun = value;
            }
        }

        public double Gunluk
        {
            get
            {
                return gunluk;
            }

            set
            {
                gunluk = value;
            }
        }

        public override double AylikHesapla()
        {
            return Gun * Gunluk;

        }
    }
}
