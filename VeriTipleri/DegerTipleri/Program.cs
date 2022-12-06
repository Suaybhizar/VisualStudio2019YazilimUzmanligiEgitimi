using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegerTipleri
{
    enum RenkTercihiniz
    { 
        Kirmizi, Mavi, Sari
    }

    struct Urun
    {
        public string Marka;
        public int StokAdedi;
        public string Model;
    }
    class Program
    {
        enum KayitDurumu
        {
            Aktif, Pasif
        }
        static void Main(string[] args)
        {
            //stack alanında sakanırlar.
            //tam sayi           int
            //ondalıklı sayi     double
            //karakter           char
            //true false         boolean
            //"string"           string

            int sayi = -5;

            float x = 2.3F;

            double y = -3.7;//M eki decimal demek 128 bit

            //double  D,d
            //float   F,f
            //decimal M,m

            var a = 3;
            var str = "A" + "B";
            var b = 3 / 2;
            var c = 2.3 / 5;

            //int      0
            //boolean  false
            //string   ""

            int intDefault = default(int);
            char charDefault = default(char);
            bool booleanDefault = default(bool);
            double doubleDefault = default(double);
            Console.WriteLine(intDefault);
            Console.WriteLine(charDefault);//  default değeri= \0
            Console.WriteLine(booleanDefault);
            Console.WriteLine(doubleDefault);

            //değişken isminde boşluk kullanılmaz
            //değişken isminde -*/? gibi özel karakterler olmaz
            //değişken ismi sayı ile başlamaz

            KayitDurumu durum = KayitDurumu.Aktif;
            RenkTercihiniz renk = RenkTercihiniz.Mavi;

            Urun urun1 = new Urun();
            urun1.Marka = "Marka1";
            urun1.Model = "Model1";
            urun1.StokAdedi = 10;

            Urun urun2;
            urun2.Marka = "Marka2";
            urun2.Model = "Model2";
            urun2.StokAdedi = 20;

            int sayi1 = 20;
            {
                Console.WriteLine(sayi1);
            }

            int a;
            a = 10;
            Console.WriteLine(a);//C# dili type safe bir dildir

            int s1=10, s2, s3=20;
            s2 = 15;


            Console.ReadKey();

        }
    }
}
