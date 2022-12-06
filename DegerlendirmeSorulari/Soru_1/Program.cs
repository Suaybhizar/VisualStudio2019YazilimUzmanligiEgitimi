using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_1
{
    class Program
    {
        static string TersCevir(string kaynak)
        {
            string ters = "";
            for (int i = kaynak.Length - 1; i >= 0; i--)
            {
                ters += kaynak[i];

            }
            return ters;
        }
        static void Main(string[] args)
        {
            //Kendisine gönderilen bir metni ters çeviren ve bu ters çevrilmiş metni geri döndüren metodu geliştiriniz.
            Console.Write("Ters çevirelecek metni giriniz : ");
            string metin = Console.ReadLine();
            Console.WriteLine("{0} metninin tersi {1}", metin, TersCevir(metin));
            Console.ReadKey();
        }
    }
}