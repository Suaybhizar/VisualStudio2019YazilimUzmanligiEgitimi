using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fibonacci serisinde her sayı kendıisinden önceki iki sayının toplamı ile hesaplanmaktadır.
            //Serinin ilk elemanı 0, ikinci elemanı 1'dir.Bundan sonra ki sayılar bu sayıların toplamı ile hesaplanmaktadır.
            //Kullanıcıdan kaç adet Fibonacci sayısı görüntülemek istediğini alıyoruz.
            //Ekrana bu kadar sayıda Fibonacci sayısını yazdırıyoruz.

            Console.Write("Kaç adet Fibonacci görüntülensin : ");
            int adet = int.Parse(Console.ReadLine());
            int a = 0;
            int b = 1;

            Console.Write("{0} {1}", a, b);

            for (int i = 0; i < adet-2; i++)
            {
                int c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
            Console.ReadKey();
        }
    }
}
