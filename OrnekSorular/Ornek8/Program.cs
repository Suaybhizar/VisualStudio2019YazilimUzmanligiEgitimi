using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan 0-100 arası puanını alarak beşlik sistemde not karşılığını veren uygulamayı geliştiriniz.
            //0-24   0
            //25-44  1
            //45-54  2
            //55-69  3
            //70-84  4
            //85-100 5

            Console.Write("0-100 arası puanınız : ");
            byte puani = byte.Parse(Console.ReadLine());
            //byte puanni = Convert.ToByte(Console.ReadLine());
            byte notu;
            if (puani < 25)

                notu = 0;
            else if (puani < 45)

                notu = 1;

            else if (puani < 55)

                notu = 2;

            else if (puani < 70)

                notu = 3;

            else if (puani < 85)

                notu = 4;

            else
                notu = 5;

            Console.WriteLine("Notunuz : {0}",notu);

            Console.ReadKey();
            }
        }
    }

