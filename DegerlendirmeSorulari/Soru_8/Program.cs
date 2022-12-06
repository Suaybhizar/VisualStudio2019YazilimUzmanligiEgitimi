using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kendisine gönderilen bir metni ekranın ortasına yazan metodu geliştiriniz.

            Console.Write("Ekrana yazılacak bilgi : ");
            string metin = Console.ReadLine();
            Console.Clear();
            Console.SetCursorPosition(Console.WindowWidth / 2 - metin.Length / 2, Console.WindowHeight / 2);//bu metod imleci ekranın istediğimiz konuma yerleştirmemizi sağlar.
            Console.Write(metin);
            Console.ReadKey();
        }
    }
}
