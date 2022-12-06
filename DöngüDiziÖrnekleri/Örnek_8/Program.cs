using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //1 2
            //1 2 3
            //1 2 3 4 
            //Yukarıda ki çıkktıyı geliştiriniz.

            Console.Write("Kaç satır yazdıralım : ");
            int satir = int.Parse(Console.ReadLine());

            for (int i = 1; i <= satir; i++)
            {
                for (int s = 1; s <= i; s++)
                {
                    Console.Write("{0} ", s);
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }
    }
}
