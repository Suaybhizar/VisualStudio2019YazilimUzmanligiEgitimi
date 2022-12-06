using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachDöngüsü
{
    class Program
    {
        static void Main(string[] args)
        {
            string mesaj = "C# Eğitimi";
            //for (int i = 0; i < mesaj.Length; i+=2)
            //{
            //    Console.Write(mesaj[i]);
            //}

            foreach (var siradakiHarf in mesaj)
            {
                Console.Write(siradakiHarf);
            }
            Console.ReadKey();
        }
    }
}
