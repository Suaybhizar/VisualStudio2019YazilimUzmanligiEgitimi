using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringMetodu
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi = new Kisi {
                KisiNo = 1,
                Ad="ad1",
                Soyad="soyad1"
            };
            Console.WriteLine(kisi);

            Console.ReadKey();
        }
    }

    public class Kisi
    {
        public int KisiNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public override string ToString()
        {
            return string.Format("{0} : {1}  {2}", KisiNo, Ad, Soyad);
        }

    }

}
