using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTekMetotluDelegate
{
    class Program
    {

        static void EkraniBoya(ConsoleColor arkaplan, ConsoleColor yaziRengi)
        {
            Console.ForegroundColor = yaziRengi;
            Console.BackgroundColor = arkaplan;
            Console.Clear();
        }

        static double Topla(double sayi1, double sayi2)
        {
            return sayi1 + sayi2;
        }

        delegate void EkraniBoyaHandler(ConsoleColor renk1, ConsoleColor renk2);

        delegate double ToplaHandler(double sayi1, double sayi2);

        static void Main(string[] args)
        {
            //EkraniBoya(ConsoleColor.Blue, ConsoleColor.White);

            //EkraniBoyaHandler eboya = new EkraniBoyaHandler(EkraniBoya);

            //eboya.Invoke(ConsoleColor.Blue, ConsoleColor.White);

            //eboya(ConsoleColor.Red, ConsoleColor.White);

            //Console.WriteLine("Bu mesaj arka plan rengi kırmızı yazı rengi beyaz olarak yazıldı.");

            ToplaHandler th = new ToplaHandler(Topla);
            //double sonuc = th.Invoke(3, 5);
            double sonuc = th(3, 5);

            Console.WriteLine("3+5={0}",sonuc);

            Console.ReadKey();

        }

    }
}
