using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLib
{
    public class Database
    {
        private readonly List<Sinif> siniflar;
        private readonly List<Ogrenci> ogrenciler;

        //Eager (aceleci) loading
        private static Database instance = null;

        private Database()
        {
            siniflar = new List<Sinif>
            {
                new Sinif
                {
                    SinifId=1,
                    SinifAdi="9-A"
                },
                new Sinif
                {
                    SinifId=2,
                    SinifAdi="10-B "
                },
                new Sinif
                {
                    SinifId=3,
                    SinifAdi="11-C"
                }
            };
            ogrenciler = new List<Ogrenci>
            {
                new Ogrenci
                {
                    OgrenciId=1,
                    Ad="Ögr1Ad",
                    Soyad="Ögr1SoyAd",
                    Sinif=siniflar[0]
                },
                new Ogrenci
                {
                    OgrenciId=2,
                    Ad="Ögr2Ad",
                    Soyad="Ögr2SoyAd",
                    Sinif=siniflar[0]
                },
                new Ogrenci
                {
                    OgrenciId=3,
                    Ad="Ögr3Ad",
                    Soyad="Ögr3SoyAd",
                    Sinif=siniflar[1]
                },
                new Ogrenci
                {
                    OgrenciId=4,
                    Ad="Ögr4Ad",
                    Soyad="Ögr4SoyAd",
                    Sinif=siniflar[2]
                },
                new Ogrenci
                {
                    OgrenciId=5,
                    Ad="Ögr5Ad",
                    Soyad="Ögr5Soyad",
                    Sinif=siniflar[2]
                }
            };
        }

        public static Database Instance
        {
            get
            {
                //lazy (temel) loading
                if (instance == null)
                    instance = new Database();
                return instance;
            }
        }
        public List<Sinif> Siniflar
        {
            get { return siniflar; }
        }
        public List<Ogrenci> Ogrenciler
        {
            get { return ogrenciler; }
        }
    }
}
