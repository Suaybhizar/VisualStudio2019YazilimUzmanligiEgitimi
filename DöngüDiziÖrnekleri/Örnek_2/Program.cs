using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Girilen bir sayıyı tersten yazacak uygulamayı geliştiriniz.
            Console.Write("Ters Çevirelecek Sayıyı Giriniz : ");
            string sayi = Console.ReadLine();
            Console.Write("{0} sayısının tersi : ", sayi);
            for (int i = sayi.Length-1 ; i >=0; i--)
            {
                Console.Write(sayi[i]);
            }
            Console.ReadKey();
        }
    }
}
