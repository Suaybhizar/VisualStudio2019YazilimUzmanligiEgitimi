using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMulticastDelegate
{
    class Program
    {

        static void Topla(double s1, double s2) //void double,double   
        {
            Console.WriteLine((s1 + s2));
        }

        static void Cikar(double s1, double s2)//void double,double
        {
            Console.WriteLine((s1 - s2));
        }

        static void Carp(double sayi1, double sayi2)//void double,double
        {
            Console.WriteLine((sayi1 * sayi2));
        }

        static void Bol(double sayi1, double sayi2)//void double,double
        {
            Console.WriteLine((sayi1 / sayi2));
        }
        //metotların imzaları aynı olmalıdır ve dönüş tipleri void olmak zorundadır.

        delegate void DortIslemHandler(double s1, double s2);

        static void Main(string[] args)
        {
            //multicastdelegate
            DortIslemHandler dih = new DortIslemHandler(Cikar);
            dih += Topla;
            dih += Carp;
            dih += Bol;

            dih -= Cikar;

            dih.Invoke(12, 3);

            Console.ReadKey();
        }
    }
}
