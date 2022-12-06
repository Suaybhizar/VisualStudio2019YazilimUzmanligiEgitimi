using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Konsol ekranı kullanıcıdan alınan bir renk değeri ile boyayan uygulamayı geliştiriniz.
            Console.Write("Konsol ekranı hangi renk ile boyansın (0-15 arası bir sayı) : ");
            byte renkDegeri = Convert.ToByte(Console.ReadLine());
            ConsoleColor renk = (ConsoleColor)renkDegeri;
            Console.BackgroundColor = renk;

            Console.Clear();

            //Console.WriteLine("Bu mesaj konsol rengi değiştirildikten sonra yazılmıştır.");

            Console.ReadKey();

        }
    }
}
