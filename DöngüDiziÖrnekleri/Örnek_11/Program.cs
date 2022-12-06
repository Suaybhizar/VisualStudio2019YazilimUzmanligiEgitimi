using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //var sayilar={1,10,5,4,8}
            //Bu diziyi büyükten küçüğe doğru sıralayan uygulamayı geliştiiriniz.
            //BUBLE SORT (KABARCIK SIRALAMASI) ALGORİTMASI
            var sayilar = new int[]{ 1, 10, 5, 4, 8 };
            for (int i = 0; i < sayilar.Length-1; i++)
            {
                for (int s = i+1; s < sayilar.Length; s++)
                {
                    if (sayilar[i] < sayilar[s])
                    {
                        int temp = sayilar[i];
                        sayilar[i] = sayilar[s];
                        sayilar[s] = temp;
                    }
                }
            }
            Console.WriteLine("Sıralanmış Dizi");
            Console.WriteLine("-----------------");
            foreach (var siradakiSayi in sayilar)
            {
                Console.WriteLine(siradakiSayi);
            }
            Console.ReadKey(); 
        }
    }
}
