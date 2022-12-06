using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden basılan tuşa ait ascii kodu ekrana basan uygulamayı geliştiriniz.
            //ESC tuşuna basıldığında uygulama sonlanacaktır.

            char tus;
            do
            {
                tus = Console.ReadKey(true).KeyChar;
                if (tus == 27)
                    break;
                Console.Write("{0}-",(int)tus);
            } while (tus!=27);//ESC'nin ascii kodu 27 dir. 
            // break ifadesinden sonra çalışır.
        }
    }
}
