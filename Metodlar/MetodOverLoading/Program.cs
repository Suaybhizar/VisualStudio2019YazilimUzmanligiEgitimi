using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodOverLoading
{
    class Program
    {
        //Topla(int,double)
        static int Topla(int s1, double s2)
        {
            return s1 + (int)s2;
        }
        //Topla(double,int)
        static int Toppla(double s1, int s2)
        {
            return (int)s1 + s2;
        }
        //Topla(int,int)
        static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        static int Topla(int a, int b, int c)
        {
            return a + b + c;
        }
        static void Main(string[] args)
        {

        }
    }
}
