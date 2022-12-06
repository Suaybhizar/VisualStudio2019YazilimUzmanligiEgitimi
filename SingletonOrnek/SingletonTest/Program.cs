using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SingletonLib;

namespace SingletonTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db = Database.Instance;
            var ogrenciler = db.Ogrenciler;
            ogrenciler.Add(new Ogrenci
            {
                OgrenciId = 6,
                Ad = "sads",
                Soyad = "asdfg",
                Sinif = db.Siniflar[0]
            });
            foreach (var ogr in ogrenciler)
            {
                Console.WriteLine(ogr);
                Console.WriteLine("-------------------");
            }



            Database db2 = Database.Instance;
            db2.Ogrenciler.RemoveAt(5);
            var ogrenciler2 = db2.Ogrenciler;
            foreach (var ogr in ogrenciler2)
            {
                Console.WriteLine(ogr);
                Console.WriteLine("-------------------");
            }

            Console.ReadKey();
        }
    }
}
