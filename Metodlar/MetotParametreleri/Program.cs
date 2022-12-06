using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetotParametreleri
{
    class Program
    {
        static int BuyukSayiGetir(int s1 = 3, int s2 = 5)
        {
            if (s1 > s2)
                return s1;
            else
                return s2;

        }

        static int İlkSayiyiGetir(int sayi1, int sayi2)
        {
            return sayi1;
        }
        static void Main(string[] args)
        {
            //int buyukSayi = BuyukSayiGetir(10,15);
            //Console.WriteLine("Büyük sayı {0} ", buyukSayi);
            int ilkSayi = İlkSayiyiGetir(sayi2: 8, sayi1: 15);
            Console.WriteLine("İlk parametrenin değeri {0}", ilkSayi);
            Console.ReadKey();

        }
    }
}
