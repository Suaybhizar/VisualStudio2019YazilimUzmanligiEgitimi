using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqTemelleri
{
    class Program
    {
    //    static bool Test (int sayi)
    //    {
    //        return sayi < 6;
    //    }

        static void Main(string[] args)
        {
            var sayilar = new List<int>
            {
                1,2,3,4,5,6,7,8,9,10
            };
            //IEnumerable<int> sonuc = sayilar.TekSayilar();
            //IEnumerable<int> sonuc = sayilar.CiftSayilar();
            //IEnumerable<int> sonuc = sayilar.BestenBuyukSayilar();
            //IEnumerable<int> sonuc = sayilar.Filtre(s => s % 3 == 0);
            //IEnumerable<int> sonuc = sayilar.Filtre(s => s > 3 && s < 8);
            //IEnumerable<int> sonuc = sayilar.Filtre(sayi => sayi % 2 == 0 || sayi % 3 == 0);

            IEnumerable<int> sonuc = sayilar.Where(sayi => sayi % 2 == 0 || sayi % 3 == 0);

            //foreach (var siradakiSayi in sonuc)
            //{
            //    Console.WriteLine(siradakiSayi);
            //}

            int enb = sayilar.Max();

            double ortalama = sayilar.Average();
            Console.WriteLine(enb);
            Console.WriteLine(ortalama);

            Console.ReadKey();
        }
    }


    public static class FilterExtensions
    {
        public static IEnumerable<int> TekSayilar(this IEnumerable<int> kaynak)
        {
            
            foreach (var sayi in kaynak)
            {
                if (sayi % 2 != 0)
                    yield return sayi;
            }
            
        }
        public static IEnumerable<int> CiftSayilar(this IEnumerable<int> kaynak)
        {
            foreach (var sayi in kaynak)
            {
                if (sayi % 2 == 0)
                    yield return sayi;
            }
        }

        public static IEnumerable<int> BestenBuyukSayilar(this IEnumerable<int> kaynak)
        {
            foreach (var sayi in kaynak)
            {
                if (sayi > 5)
                    yield return sayi;
            }
        }

        public static IEnumerable<int> Filtre(this IEnumerable<int> kaynak,Func<int,bool> filtre)
        {
            foreach (var sayi in kaynak)
            {
                if (filtre(sayi))
                    yield return sayi;
            }
        }
    }
}
