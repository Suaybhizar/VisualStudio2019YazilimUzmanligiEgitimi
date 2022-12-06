using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //0 ile n arasında ki çift sayıların toplamını hesaplayan uygulamayı geliştiriniz.
            Console.Write("n sayisi : ");
            int n = Convert.ToInt32(Console.ReadLine());

            //yığmalı toplama işlemi
            int toplam = 0;

            for (int i = 0; i <= n; i+=2)
            {
                toplam += i;//toplam=toplam+i;

            }
            Console.WriteLine("0-{0} arasındaki çift sayıların toplamı {1}",n,toplam);
            Console.ReadKey();
        }
    }
}
