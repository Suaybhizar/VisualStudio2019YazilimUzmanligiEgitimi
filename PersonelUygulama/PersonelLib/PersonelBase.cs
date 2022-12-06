using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelLib
{
    public abstract class PersonelBase
    {
        int id;
        string ad;
        string soyad;

        public PersonelBase(int id, string ad, string soyad)
        {
            Id = id;
            Ad = ad;
            Soyad = soyad;

        }
        public PersonelBase() : base()
        {

        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Ad
        {
            get
            {
                return ad;
            }

            set
            {
                ad = value.Trim().ToUpper();
            }
        }

        public string Soyad
        {
            get
            {
                return soyad;
            }

            set
            {
                soyad = value.Trim().ToUpper();
            }
        }

        public string AdSoyadGetir()
        {
            return string.Format("{0} {1}", Ad, Soyad);
        }

        public abstract double AylikHesapla();
    }
}
