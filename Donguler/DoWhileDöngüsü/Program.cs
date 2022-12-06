using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            //while (i<=10)
            //{
            //    Console.WriteLine("{0}. satır",i);
            //    i++;
            //}

            //do
            //{
            //    Console.WriteLine("{0}. satır", i);
            //    i++;

            //} while (i<=10);

            //while (1==2)
            //{
            //    Console.WriteLine("1 sayısı 2 ye eşittir.");
            //}

            do
            {
                Console.WriteLine("1 sayısı 2 ye eşittir.");
            } while (1==2);
            Console.ReadKey();
        }
    }
}
