using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_9
{
    class Program
    {
        //5.sırada ki Fibonacci sayısı
        //4.sırada ki + 3.sıradaki 
        static int Fibonacci(int sira)
        {
            if (sira == 1)
                return 0;
            if (sira == 2)
                return 1;
            return Fibonacci(sira - 1) + Fibonacci(sira - 2);
        }
        static string Sifrele(string orjinal)
        {
            string sifrelenmis = "";
            for (int i = 0; i < orjinal.Length; i++)
            {
                int ascii = orjinal[i];
                int fibonacci = Fibonacci(i + 1);
                int yeniAscii = ascii + fibonacci;
                sifrelenmis += (char)yeniAscii;
            }
            return sifrelenmis;
        }
        static string SifreCoz(String sifrelenmis)
        {
            string orjinal = "";
            for (int i = 0; i < sifrelenmis.Length; i++)
            {
                int ascii = sifrelenmis[i];
                int fibonacci = Fibonacci(i + 1);
                int yeniAscii = ascii - fibonacci;
                orjinal += (char)yeniAscii;
            }
            return orjinal;
        }


        static void Main(string[] args)
        {
            //Kendisine gönderilen bir metnin her karakterini sıradaki fibonacci sayısı ile şifreleyen ve sifrelenmiş 
            //metni çözen iki ayrı metod geliştiriniz.


            char secim;
            do
            {
                Console.WriteLine("Menü");
                Console.WriteLine("------------------");
                Console.WriteLine("1-Şifrele");
                Console.WriteLine("2-Şifre Çöz");
                Console.WriteLine("3-Çıkış");
                Console.Write("Seçiminiz");
                secim = Console.ReadKey().KeyChar;
                if (secim == '1')
                {
                    Console.Clear();
                    Console.Write("Şifrelenecek metin : ");
                    string sifrelenecek = Console.ReadLine();
                    Console.WriteLine("Şifrelenmiş metin : {0}", Sifrele(sifrelenecek));
                    Console.ReadKey();
                    Console.Clear();
                }
                else if (secim == '2')
                {
                    Console.Clear();
                    Console.Write("Şifrelenecek metin : ");
                    string cozulecek = Console.ReadLine();
                    Console.WriteLine("Orjinal Şifrelenmiş metin : {0}", SifreCoz(cozulecek));
                    Console.ReadKey();
                    Console.Clear();

                }
                else if (secim == '3')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Geçerli bir seçim yapmadınız.Lütfen 1-3 arası bir seçim yapınız.");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (true);
        }
    }
}
