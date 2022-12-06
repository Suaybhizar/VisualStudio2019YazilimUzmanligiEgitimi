using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bilgisayarın tuttuğu bir sayıyı tahmin edeceğimiz uygulamayı geliştiriniz.
            //Bilgisayar 0-100 arasında bir sayı tutacaktır.Kullanıcının tahminine göre "Daha büyük bir sayı giriniz"
            //ve ya "Daha küçük bir  sayı giriniz" şeklinde yönergeler yardımıyla kullanıcının sayıyı tahmin etmesini
            //sağlayacaktır.

            int sayi = new Random().Next(1, 100);
            Console.WriteLine("Bilgisayar 0-100 arası bir sayı tutu.");

            int tahmin;
            int denemeSayisi = 0;
            do
            {
                Console.Write("Tahmininiz : ");
                tahmin = int.Parse(Console.ReadLine());
                if (tahmin > sayi)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz.");
                    denemeSayisi++;
                }
                else if (tahmin < sayi)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz.");
                    denemeSayisi++;
                }
                else
                    Console.WriteLine("Tebrikler tahmininiz doğru. {0} denemde buldunuz.",denemeSayisi);

            } while (sayi!=tahmin);
            Console.ReadKey();
        }
    }
}
