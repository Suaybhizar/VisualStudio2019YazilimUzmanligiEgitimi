using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Ornek10
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 haneli büyük ve küçük harflerden oluşan güvenlik resmini oluşturan uygulamayı geliştiriniz.
            //harf/sayi  ascii kodlar
            //A           65
            //Z           90

            //0           48
            //9           57

            //char chr = '1';
            //int ascii = (int)chr;
            //Random sınıfında ki Next metodu senin verdiğin başlangıç ve bitiş sayısı arasında
            //rastgele sayı tutmayı sağlıyor.


            Random rnd = new Random();
            //Büyük harf
            char ilkKarakter = (char)rnd.Next(65, 90);
            //Rakam
            char ikinciKarakter = (char)rnd.Next(48, 57);
            //Büyük harf
            char ucuncuKarakter = (char)rnd.Next(65, 90);
            //Rakam
            char dorduncuKarakter = (char)rnd.Next(49, 57);

            Console.WriteLine("Güvenlik Resmi : {0}{1}{2}{3}{4}", ilkKarakter, ikinciKarakter, ucuncuKarakter, dorduncuKarakter);

            Console.ReadKey();
        }
    }
}
