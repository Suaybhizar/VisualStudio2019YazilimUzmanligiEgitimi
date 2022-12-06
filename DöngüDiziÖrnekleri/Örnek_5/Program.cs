using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan bir sayının basamaklarının toplamını hesaplayan uygulamayı geliştiriniz.
            //Örneğin 123 sayısı girdiğinde 1+2+3=6 çıktısı verilecek.

            Console.Write("Sayıyı Giriniz : ");
            string sayi = Console.ReadLine();
            int toplam = 0;
            for (int i = 0; i < sayi.Length; i++)
            {
                int siradakiBasamakDegeri = Convert.ToInt32 (sayi[i].ToString());
                toplam += siradakiBasamakDegeri;
            }
            Console.WriteLine("Basamaklar Toplamı : {0}", toplam);
            Console.ReadKey();
        }
    }
}
