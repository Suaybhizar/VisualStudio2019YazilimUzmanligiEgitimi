using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableArayuzu
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] sayilar = { 1, 2, 3, 10, 5, 4, 6 };
            //Array.Sort(sayilar);//Sort metodu dizi elemanlarını küçükten büyüğe doğru sıralar.
            //foreach (var item in sayilar)
            //{
            //    Console.WriteLine(item);
            //}

            Ogrenci[] ogrenciler =
            {
                new Ogrenci
                {
                    No=20,
                    Ad="Ad1",
                    Soyad= "Soyad1",
                    Yas=15

                },
                new Ogrenci
                {
                    No=2,
                    Ad= "Ad2",
                    Soyad= "Soyad2",
                    Yas=16

                },
                new Ogrenci
                {
                    No=3,
                    Ad="Ad3",
                    Soyad="Soyad3" ,
                    Yas=17

                },
            };

            Ogrenci ogr1 = new Ogrenci { No = 1, Ad = "Adı 1", Soyad = "Soyad 1", Yas = 15 };
            Ogrenci ogr2 = new Ogrenci { No = 1, Ad = "Adı 1", Soyad = "Soyad 1", Yas = 15 };

            if(ogr2.CompareTo(ogr1)==1)
                Console.WriteLine("ogr2 yaşı ogr1 yaşından büyüktür.");
            else if(ogr2.CompareTo(ogr1)==-1)
                Console.WriteLine("ogr1 yaşı ogr2 yaşından büyüktür.");
            else
                Console.WriteLine("ogr1 ve ogr2 aynı yaştalar.");

            //Array.Sort(ogrenciler);
            //foreach (var ogrenci in ogrenciler)
            //{
            //    Console.WriteLine(ogrenci);
            //}
            Console.ReadKey();
        } 
    }


    public class Ogrenci : IComparable//dizi elemanlarını karşilaştırıyor.
    {
        public int No { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }

        public int CompareTo(object obj)
        {
            //Ogrenci ogrKarsilastirilan = obj as Ogrenci;
            Ogrenci ogrKarsilastirilan = (Ogrenci)obj;
            if (this.Yas > ogrKarsilastirilan.Yas)
                return 1;
            else if (this.Yas < ogrKarsilastirilan.Yas)
                return -1;
            else
                return 0;
        }

        public override string ToString()
        {
            return string.Format("{0}-{1} {2} Yaşı {3}", No, Ad, Soyad, Yas);
        }
    }
}
