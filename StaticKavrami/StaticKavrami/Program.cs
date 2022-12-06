using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKavrami
{
    //static void MesajVer(string mesaj)
    //{
    //    Console.WriteLine(mesaj);
    //}


    class Program
    {
        static void Main(string[] args)
        {
           

            //Matematik mat = new Matematik();
            int sonuc = Matematik.Topla(2, 5);
            double bolme = Matematik.Bol(5, 2);

            Console.WriteLine(bolme);
            double us = Math.Pow(2, 3);//Math.Pow us almaya yarar.
            Console.WriteLine(us);

            Console.ReadKey();
            
        }
    }

    public class Matematik
    {
        //constant
        const double pi = 3.14;//const lar kendiliğinden statictir.
        public static int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
        public static double Bol(double sayi1, double sayi2)
        {
            return sayi1 / sayi2;
        }
        public static int Carp(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        public double DaireAlan(double yaricap)
        {
            return pi * yaricap * yaricap;
        }
    }
}
