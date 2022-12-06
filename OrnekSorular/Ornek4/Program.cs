using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan bir karakterin ascii karşılığını ekrana yazdıran uygulamayı geliştiriniz.
            Console.Write("Bir tuşa basın : ");
            char tus = Console.ReadKey(true).KeyChar;
            Console.WriteLine("{0} tuşunun ascii karşılığı {1}", tus, (int)tus);

            Console.ReadKey();

        }
    }
}
