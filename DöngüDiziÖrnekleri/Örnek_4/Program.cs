using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen bir sayının asal olup olmadığını bulan programı for döngüsü kullanarak geliştirin.
            Console.Write("Asallığı test edilecek sayı : ");
            int sayi = int.Parse(Console.ReadLine());
            //asal sayı 1 ve kendisinden başka böleni olmayan sayıdır.

            //int bolenSayisi = 0;
            //for (int i = 1; i <=sayi ; i++)
            //{
            //    if (sayi % i == 0)
            //    {
            //        bolenSayisi++;
            //    }

            //}
            //if (bolenSayisi != 2)
            //{
            //    Console.WriteLine("{0} sayısı asala değil.", sayi);
            //}
            //else
            //{
            //    Console.WriteLine("{0} sayısı asaldır.", sayi);
            //}

            bool asalMi = true;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    asalMi = false;
                    break;
                }

            }
            if (asalMi)
                Console.WriteLine("{0} sayısı asaldır. ",sayi);
            else
                Console.WriteLine("{0} sayısı asal değildir. ",sayi);
            Console.ReadKey();

        }
    }
}
