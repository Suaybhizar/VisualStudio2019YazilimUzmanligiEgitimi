using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_2
{
    class Program
    {
        static bool PalindromMu(string metin)
        {
            int bas = 0;
            int son = metin.Length - 1;
            bool palindrom = true;
            while (bas < son)
            {
                if (metin[bas] != metin[son])
                {
                    palindrom = false;
                    break;
                }
                bas++;
                son--;
            }
            return palindrom;
        }
        static void Main(string[] args)
        {
            //tersi ile kendisi aynı olan ifadelere palındrom denir. Örneğin "nazan","milim","küllük" kelimeleri
            //palındrom kelimelerdir. Kendisine gönderilen string palindrom ise true,değilse false döndüren metodu geliştiriniz.
            //n  a  z   a   n
            //0  1  2   3   4

            //0-4
            //1-3
            //2-2

            //k ü   l   l   ü   k
            //0 1   2   3   4   5

            //0-5
            //1-4
            //2-3

            Console.Write("Palindromluğu test edilecek metni giriniz :");
            string mesaj = Console.ReadLine();
            Console.WriteLine((PalindromMu(mesaj)) ? "Girilen metin palindromdur." : "Girilen metin palindrom değildir.");
            Console.ReadKey();
        }
    }
}
