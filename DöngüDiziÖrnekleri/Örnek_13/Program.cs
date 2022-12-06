using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan taban ve üs bilgisini alarak üs alma işlemini gerçekleştiren uygulamayı geliştiriniz.
            Console.Write("Taban : ");
            int taban = int.Parse(Console.ReadLine());
            Console.Write("Üs    : ");
            int us = int.Parse(Console.ReadLine());

            int sonuc = 1;
            for (int i = 0; i < us; i++)
            {
                sonuc *= taban;
            }
            Console.WriteLine("{0} üzeri {1} = {2}", taban, us, sonuc);
            Console.ReadKey();
        }
    }
}
