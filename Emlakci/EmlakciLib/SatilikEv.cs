using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciLib
{
    public class SatilikEv : IEv
    {
        //Fields
        double fiyat;
        int odasayisi;
        int katno;
        string semt;
        double alan;

        //Constructors
        public SatilikEv(int odasayisi, int katno, string semt, double alan, double fiyat)
            
        {
            Odasayisi = odasayisi;
            Katno = katno;
            Semt = semt;
            Alan = alan;
            Fiyat = fiyat;
        }
        public SatilikEv() : base()
        {

        }

        //Properties
        public double Fiyat
        {
            get { return fiyat; }
            set { fiyat = Math.Abs(value); }
        }

        public int Odasayisi
        {
            get
            {
                return odasayisi;
            }

            set
            {
                odasayisi = Math.Abs(value);
            }
        }

        public int Katno
        {
            get
            {
                return katno;
            }

            set
            {
                katno = value;
            }
        }

        public string Semt
        {
            get
            {
                return semt;
            }

            set
            {
                semt = value.ToUpper().Trim();
            }
        }

        public double Alan
        {
            get
            {
                return alan;
            }

            set
            {
                alan = Math.Abs(value);
            }
        }

        public string EvTipi
        {
            get
            {
                return "Satılık Ev";
            }
        }

        //Methods

        public string EvBilgileriniGetir()
        {
            return string.Format("Oda sayısı : {0}\nKat No : {1}\nSemt : {2}\nAlan : {3}" +
                    "\nFiyat :{4}", Odasayisi, Katno, Semt, Alan, Fiyat);
        }





    }
}
