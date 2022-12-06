using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcı tarafından girilen 3 adet sayıyı büyükten küçüğe doğru sıralayan uygulamayı geliştiriniz.
            //Sayıları alalım
            Console.Write("1.Sayı : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("2.Sayı : ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("3.Sayı : ");
            int c = int.Parse(Console.ReadLine());

            //a>b>c
            //b>a>c
            //c>b>a
            //3>2>1 6 farklı kombinasyon vardır.
            if (a > b && a > c)
            {
                if (b > c)
                    Console.WriteLine("a>b>c");
                else
                    Console.WriteLine("a>c>b");
            }
            else if (b > a && b > c)
            {
                if (a > c)
                    Console.WriteLine("b>a>c");
                else
                    Console.WriteLine("b>c>a");
            }
            else
            {
                if (a > b)
                    Console.WriteLine("c>a>b");
                else
                    Console.WriteLine("c>b>a");
            }
            Console.ReadKey();
        }
    }
}
