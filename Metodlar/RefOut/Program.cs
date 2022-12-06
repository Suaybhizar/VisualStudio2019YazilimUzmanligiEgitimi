using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOut
{
    class Program
    {
        //out sadece değişkenlerin değeri yoksa kullanılır
        //değişkenlerin değerleri var ise ref kullanılır.
        static void YerDegistir(ref int s1, ref int s2)
        {
            int temp = s1;
            s1 = s2;
            s2 = temp;
        }
        static void Main(string[] args)
        {
            int sayi1 = 3;
            int sayi2 = 5;
            YerDegistir(ref sayi1, ref sayi2);

            Console.WriteLine("sayi1 : {0} , sayi2: {1} ", sayi1, sayi2);
            Console.ReadKey();
        }
    }
}
