using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfIsimsizMetotlar
{
    class Program
    {
        //static int Topla(int sayi1,int sayi2)
        //{
        //    return sayi1 + sayi2;
        //}

        static void Main(string[] args)
        {
            //Func<int, int, int> th = delegate (int a, int b)
            //{
            //    return a + b;
            //};

            //Func<int, int, int> th = (int a, int b) =>
            //    {
            //        return a + b;
            //    };

            Func<int, int, int> th = (a, b) =>
              {
                  return a + b;
              };

            Action<char, int> yh = (chr, adet) =>
             {
                 for (int i = 0; i < adet; i++)
                 {
                     Console.WriteLine(chr);
                 }
                 Console.WriteLine();
             };

            yh('K', 10);

            Func<string, string> bhh = (str) =>
             {
                 return str.ToUpper();
             };

            Console.WriteLine(bhh("bu metnin tamamı küçük harf yazıldı."));
            Console.WriteLine();

            Func<int, int> fh = (sayi) =>
             {
                 int faktöryel = 1;
                 for (int i = 2; i <= sayi; i++)
                 {
                     faktöryel *= i;
                 }
                 return faktöryel;
             };
            Console.WriteLine("{0}! = {1}", 5, fh(5));


            Console.WriteLine();

            Console.WriteLine(th(3, 5));

            Console.ReadKey();
        }
    }
}
