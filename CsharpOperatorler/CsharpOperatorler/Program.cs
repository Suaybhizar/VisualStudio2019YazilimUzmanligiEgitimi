using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpOperatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //aritmetik operatörler
            double a = 10;
            double b = 20;
            double c = a + b;//c 30 olacak
            double d = a - b;//d -10 olacak
            double e = a / b;//0 vericek
            double f = a / b;

            //int x = 25;
            // x++;
            //x = x + 1;
            //++x;
            //int y = ++x;
            //int y = x++;
            //Console.WriteLine(x++);
            //Console.WriteLine(x);

            //x += 5;//x=x+5 demek

            //x *= 10;

            //int y = x % 3;

            //int y = (x - 3) * 2;
            //int y = (x % 2) * 3;

            //==, !=,  <, >, <=, >=, ,is

            //bool sonuc = x == 5;

            //bool sonuc = x != 5;

            //bool sonuc = x >= 25;

            //bool sonuc = x < 25;



            //MANYIKSAL OPERATÖRLER
            //&&, ||, !

            int x = -5;
            //x değişkeni 0 ile 100 arasında mı?
            //x<=100 x>=0

            //bool sonuc = (x <= 100) && (x >= 0);
            //true    &&  true

            //bool sonuc = x >= 0 || x <= 100;

            //bool sonuc = x >= 0 || x <= 100;

            //bool xIntMi = x is int;

            //var y = 2.3F / 4.2F;

            //bool yIntMi = y is float;

            //Type type = typeof(int);

            //int y = sizeof(int); //8 bit 1 byte

            //int y = sizeof(long);

            string metin = "ABCDEFG";
            //012 indis sıraları bu şekilde

            // A 65  B 66 C 67
            int ilkKarakterAscii = metin[2];

            //Console.WriteLine(metin[0].ToString()+metin[1].ToString()+metin[2].ToString());

            //Console.WriteLine(metin[metin.Length-1]);

            string sonuc = "İşlemin sonucu" + x;
            //"İşlemin sonucu" + "-5"
            Console.WriteLine(sonuc);
            Console.ReadKey();
        }
    }
}
