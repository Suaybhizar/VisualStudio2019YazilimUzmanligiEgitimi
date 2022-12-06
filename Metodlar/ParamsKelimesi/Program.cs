using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKelimesi
{
    class Program
    {
        static int SayilariTopla(params int[] sayilar)
        {
            int toplam = 0;
            foreach (var sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }
        static void Main(string[] args)
        {

            //int toplam = SayilariTopla(new int[]{
            //    1,2,3,4,5,6
            //});
            int toplam = SayilariTopla(1, 2, 3, 4, 5, 6);
            Console.WriteLine("Sonuç : {0}", toplam);
            Console.ReadKey();
        }
    }
}
