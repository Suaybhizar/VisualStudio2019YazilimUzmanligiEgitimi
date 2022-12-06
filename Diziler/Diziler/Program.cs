using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte  1 sayi saklar
            //byte[] sauıları saklar
            //byte[] sayilar = new byte[5];
            //sayilar[2] = 5;

            //for (int i = 0; i < sayilar.Length; i++)
            //{
            //    Console.WriteLine(sayilar[i]);
            //}

            //var sayilar = new char[]
            //{
            //    'A','1',' ','a'
            //};

            //var karakterler = new char[4];
            //karakterler[0] = 'A';
            //karakterler[1] = '1';
            //karakterler[2] = ' ';
            //karakterler[3] = 'a';

            //char[] karakterler = { 'A', '1', ' ', 'a' };


            //int[,] sayilar = new int[2, 3];
            //sayilar[0, 0] = 10;
            //sayilar[0, 1] = 5;
            //sayilar[0, 2] = 3;

            //sayilar[1, 0] = 2;
            //sayilar[1, 1] = 6;
            //sayilar[1, 2] = 8;

            //int[,,] sayilar = new int[2, 3, 4];

            int x = 3;
            int y = x;
            x = 5;

            byte[] sayilar = new byte[] { 2, 5 };

            byte[] sayilar2 = sayilar;

            sayilar2[0] = 2;
            sayilar[0] = 5;

            foreach (var sayi in sayilar2)
            {
                Console.WriteLine(sayi);
            }


            Console.ReadKey();

        }
    }
}
