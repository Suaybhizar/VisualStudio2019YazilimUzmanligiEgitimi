using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_7
{
    class Program
    {
        static void DegerArtir(ref int donguDegiskeni, int artisMiktari)
        {
            donguDegiskeni += artisMiktari;

        }
        static void Main(string[] args)
        {
            //Aşağıdaki resimde bir C# uygulamasının Main metoduna ait kodlar görülmektedir.
            //Kodlar incelendiğinde DegerArtir isimli metod yardımıyla döngü değişkeninin arrtım işlemi gerçekleştirilmektedir.
            //Örnekte DegerArtir metodu çağırılırken döngü değişkeni olan i ve 2 değeri metoda gönderilmiştir.
            //Burada ki 2 değeri döngü değişkeninin artım miktarıdır.
            //Program çalıştırıldığında aşağıdaki ekran çıktısı alınmaktadır.Döngü değişkeni ikişer ikişer artırılmaktadır


            for (int i = 0; i < 5;)
            {
                Console.WriteLine(i);
                DegerArtir(ref i, 2);
            }
            Console.ReadKey();
        }
    }
}
