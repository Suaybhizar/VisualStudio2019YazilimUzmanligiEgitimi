using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan iki sayıyı çarpma operatörü kullanmadan çarpan uygulamayı geliştiriniz.

            //2*3=3+3
            //3*2=2+2+2

            Console.Write("Birinci sayı : ");
            int sayi1 = int.Parse(Console.ReadLine());
            Console.Write("İkinci sayı : ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            //sayi1 kadarsayı2'yi kendisi ile toplamak istiyorum.
            int sonuc = 0;
            for (int i = 0; i < sayi1; i++)
            {
                sonuc += sayi2;

            }
            Console.WriteLine("{0}*{1}={2}", sayi1, sayi2, sonuc);
            Console.ReadKey();
        }
    }
}
