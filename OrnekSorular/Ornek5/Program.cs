using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcadan vize ve final notunu alan vizenin %40'ı finalinde %60 toplandığında sonuç
            //50 den büyükse "GGEÇTİNİZ",aksi halde "KALDINIZ" yazdıran uygulamayı geliştiriniz.
            Console.Write("Vize : ");
            double vize = double.Parse(Console.ReadLine());
            Console.Write("Final : ");
            double final = Convert.ToDouble(Console.ReadLine());
            double sonuc = vize * (40D / 100D) + final * (60D / 100D);
            if (sonuc >= 50)
            {
                Console.WriteLine("GEÇTİNİZ");
            }
            else
                Console.WriteLine("KALDINIZ");

            Console.ReadKey();

        }
    }
}
