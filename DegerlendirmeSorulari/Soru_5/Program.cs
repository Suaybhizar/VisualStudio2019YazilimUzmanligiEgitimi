using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_5
{
    class Program
    {
        static int Faktoryel(int n)
        {
            if (n == 0)
                return 1;
            return n * Faktoryel(n - 1);
        }

        
        //static int Kombinasyon(int n,int r)
        //{
        //    return Faktoryel(n) / (Faktoryel(n - r) * Faktoryel(r));

        //}
        static int Kombinasyon(int n, int r)
        {
            int carpim = 1;
            for (int i = 0; i < r; i++)
            {
                carpim *= n--;

            }
            return carpim / Faktoryel(r);
        }
        static void Main(string[] args)
        {
            //Kendisine gönderilen iki adet sayıyı kullanarak (n ve r değişkenleri) n sayısının r'li kombinasyonunu
            //hesaplayan ve sonucu döndüren metodu geliştiriniz.

            Console.Write("n sayısı :");
            int n = int.Parse(Console.ReadLine());
            Console.Write("r sayısı :");
            int r = int.Parse(Console.ReadLine());

            Console.WriteLine("{0} sayısının {1}'li kombinasyonu {2}", n, r, Kombinasyon(n, r));
            Console.ReadKey();
        }
    }
}

