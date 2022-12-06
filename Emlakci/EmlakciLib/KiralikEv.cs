using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmlakciLib
{

    //her kiralık ev bir ev midir? evet
    //her kiralık ev bir satılık ev midir? hayır
    public class KiralikEv : IEv
    {
        //Fiealds
        double depozito;
        double kira;
        int odasayisi;
        int katno;
        string semt;
        double alan;


        //Constructors
        public KiralikEv(int odasayisi, int katno, string semt, double alan,
            double depozito, double kira)
        {
            Odasayisi = odasayisi;
            Katno = katno;
            Semt = semt;
            Alan = alan;
            Depozito = depozito;
            Kira = kira;

        }
        public KiralikEv() : base()
        {

        }

        //Properties
        public double Depozito
        {
            get { return depozito; }
            set { depozito = Math.Abs(value); }
        }

        public double Kira
        {
            get { return kira; }
            set { kira = Math.Abs(value); }
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
                semt = value.Trim().ToUpper();
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
                return "Kiralık Ev";
            }
        }

        //Methods
        public string EvBilgileriniGetir()
        {
            return string.Format("Oda sayısı : {0}\nKat No : {1}\nSemt : {2}\nAlan : {3}" +
                    "\nFiyat :{4}", Odasayisi, Katno, Semt, Alan, Depozito, Kira);
        }



    }
}
