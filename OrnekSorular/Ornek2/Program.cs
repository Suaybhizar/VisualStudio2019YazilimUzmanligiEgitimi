using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan doğum yılını alan ve ekrana "Siz [yas] yaşındasınız."Yazdıran uygulamayı geliştiriniz.
            Console.Write("Doğum Yılınız : ");
            int dogumYili = int.Parse(Console.ReadLine());
            int yas = DateTime.Now.Year - dogumYili;
            Console.WriteLine("Siz {0} yaşındasınız.",yas);
            Console.ReadKey();
        }
    }
}
