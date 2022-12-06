using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan sayının faktöryelini hesaplayan uygulamayı geliştiriniz.
            //4 ! =1*2*3*4
            //5 ! =1*2*3*4*5
            Console.Write("Faktöryeli alınacak sayı : ");
            int sayi = int.Parse(Console.ReadLine());
            int faktoryel = 1;
            for (int i = 1; i <= sayi; i++)
            {
                faktoryel *= i;
            }
            Console.WriteLine("{0}! = {1}", sayi, faktoryel);
            Console.ReadKey();
        }
    }
}
