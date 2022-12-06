using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan adını soyadını alan ve ekrana "Sayın [ad] [soyad] hoşgeldiniz yazdıran uygulamayı geliştiriniz.
            Console.Write("Adınız : ");
            string ad = Console.ReadLine();
            Console.WriteLine("Soyadınız : ");
            string soyad = Console.ReadLine();
            Console.WriteLine("Sayın {0} {1} hoşgeldiniz. ",ad,soyad);
            Console.ReadKey();

        }
    }
}
