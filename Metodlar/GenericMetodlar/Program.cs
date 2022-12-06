using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMetodlar
{
    class Program
    {
        static void Degistir<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static T NesneOlustur<T>() where T : new()
        {
            return new T();
        }

        //static void Degistir(ref double a, ref double b)
        //{
        //    int temp = a;
        //    a = b;
        //    b = temp;
        //}
        //static void Degistir(ref char a, ref char b)
        //{
        //    char temp = a;
        //    a = b;
        //    b = temp;
        //}
        static void Main(string[] args)
        {
            double x = 5;
            double y = 10;
            //char x = 'A';
            //char y = 'B';
            //Degistir<double>(ref x, ref y);
            //Console.WriteLine("x : {0} , y :{1}",x,y);

            Random rnd = NesneOlustur<Random>();
            int sayi = NesneOlustur<int>();
            Console.WriteLine(rnd.Next(0, 100));
            Console.ReadKey();
        }
    }
}
