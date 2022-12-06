using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifelseYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci Sayi : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.WriteLine("İkinci Sayi : ");
            int sayi2 = int.Parse(Console.ReadLine());
            if (sayi1 > sayi2)
                Console.WriteLine("Birinci Sayi Büyüktür");
            else if (sayi1 == sayi2)
                Console.WriteLine("Sayilar Eşittir");
            else
                Console.WriteLine("İkinci Sayi Büyüktür");

            Console.ReadKey();
        }
    }
}
