using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            //int i = 0;
            //while (i<10)
            //{
            //    if (i == 3)
            //        break;
            //    Console.WriteLine("Döngüde yazılan {0}. satır",i+1);
            //    i++;
            //}
            float f;

            for (f = 0.1f; f <= 0.5; f += 1)

                Console.Write(++f);

            Console.Write(“|”)

                               Console.ReadLine();

            Console.ReadKey();
        }
    }
}
