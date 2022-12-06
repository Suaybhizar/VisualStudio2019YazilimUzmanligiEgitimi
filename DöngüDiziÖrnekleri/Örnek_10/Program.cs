using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Örnek_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcıdan alınan n adet sayıdan en büyüğünü ekrana yazdıran uygulamayı geliştiriniz.
            //int.MinValue
            //int.MaxValue
            Console.Write("Kaç adet sayı girilecek : ");
            int adet = int.Parse(Console.ReadLine());
            int enb = int.MinValue;
            for (int i = 0; i < adet; i++)
            {
                Console.Write("{0}. sayıyı giriniz : ",i+1);
                int sayi = int.Parse(Console.ReadLine());
                if (sayi > enb)
                    enb = sayi;
            }

            Console.WriteLine("Girilen sayıların en büyüğü : {0}", enb);
            Console.ReadKey();
        }
    }
}
