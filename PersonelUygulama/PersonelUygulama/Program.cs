using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersonelLib;

namespace PersonelUygulama
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonelBase[] personeller =
            {
                new KadroluPersonel(1,"KadroluAd","KadroluSoyad",3000,6),
                new SözlesmeliPersonel(2,"SözleşmeliAd","SözleşmeliSoyad",20,100),
                new StajyerPersonel(3,"StajyerAd","StajyerSoyad",50,60)
            };
            foreach (var personel in personeller)
            {
                Console.WriteLine("{0} - {1}", personel.AdSoyadGetir(), personel.AylikHesapla());
            }

            Console.ReadKey();
        }
    }
}
