using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusum
{
    enum Durum
    {
        Aktif,Pasif
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Bilinçsiz Tür Dönüşümü (Implicitly)
            byte s1 = 200;
            int s2 = s1;

            //float sayi1 = 20.2F;
            //int sayi2 = sayi1;

            //byte x = 200;
            //sbyte y = x;

            //Bilinçli Tür Dönüşümü (Explicitly)
            //Console.Write("Yaşınız : ");
            //string yas = Console.ReadLine();
            ////string mesaj = (Convert.ToByte(yas) >= 35) ? "Orta yaşlısınız" : "Gençsiniz";
            //string mesaj = (byte.Parse(yas) >= 35) ? "Orta yaşlısınız" : "Gençsiniz";
            //convert.XXXX(herşey);
            //XXXX.Parse(string);
            //Console.WriteLine(mesaj);

            string str = "123";
            // int sayiDegeri = int.Parse(str);
            int sayiDegeri = Convert.ToInt32(str);

            double sayi1 = 20.5;
            //int sayi2 = (int)sayi1;
            //int sayi2 = Convert.ToInt32(sayi1);

            //char chr1 = '@';
            //int ascii1 = (int)chr1;
            //Console.WriteLine(ascii1);

            int ascii = 80;
            char chr = (char)ascii;
            Console.WriteLine(chr);

            Durum durum = Durum.Aktif;
            int secenekDegeri=(int)durum;

            int durumDegeri = 1;
            Durum durum2 = (Durum)durumDegeri;



            Console.ReadKey();

        }
    }
}
