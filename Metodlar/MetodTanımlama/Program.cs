using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodTanımlama

{
    class Test
    {
        public static void MesajVer()
        {
            Console.WriteLine("BU mesaj Test sınıfının MesajVer metodundan geliyor");
        }
    }

    class Program
    {
        static private int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        static void Main(string[] args)
        {
            //Console.Write("Birinci sayı : ");
            //int sayi1 = int.Parse(Console.ReadLine());
            //Console.Write("İkinci sayı : ");
            //int sayi2 = int.Parse(Console.ReadLine());
            //int sonuc = Topla(sayi1, sayi2);
            //Console.WriteLine("{0}+{1}={2}", sayi1, sayi2, sonuc);
            //Console.ReadKey();

            Test.MesajVer();
            Console.ReadKey();

        }
    }
}
