using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapmMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("1. Sayiyi giriniz: ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("2. Sayiyi giriniz: ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("+");
            Console.WriteLine("-");
            Console.WriteLine("*");
            Console.WriteLine("/");
            Console.WriteLine("İsleminizi seciniz: ");
            string islem = Console.ReadLine();

            if (islem == "+")
            {
                Console.WriteLine("İslemin sonucu = " + (sayi1 + sayi2));
            }
            else if (islem == "-")
            {
                Console.WriteLine("İslemin sonucu = " + (sayi1 - sayi2));
            }
            else if (islem == "*")
            {
                Console.WriteLine("İslemin sonucu = " + (sayi1 * sayi2));
            }
            else if (islem == "/")
            {
                Console.WriteLine("İslemin sonucu = " + (sayi1 / sayi2));
            }
            else
            {
                Console.WriteLine("Yanlis secim yaptınız !!");
            }
            Console.ReadLine();
        }
    }
}