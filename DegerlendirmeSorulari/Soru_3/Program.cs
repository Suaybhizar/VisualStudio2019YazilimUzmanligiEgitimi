using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_3
{
    class Program
    {
        static double OrtalamaHesapla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return (double)toplam / (double)sayilar.Length;
        }
        static void Main(string[] args)
        {
            //Kendisine gönderilen tamsayıların ortalamasını hesaplayarak sonucu döndüren metodu geliştiriniz.
            //(Metod değişken sayıda int alabilmelidir.)

            double ortalama = OrtalamaHesapla(1, 2, 3, 4, 5, 6, 7, 8);
            Console.WriteLine("Girilen sayıların ortalaması {0}", ortalama);
            Console.ReadKey();
        }
    }
}
