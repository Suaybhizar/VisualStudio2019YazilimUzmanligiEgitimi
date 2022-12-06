using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormUserControlPratic.Properties;

namespace WinFormUserControlPratic
{
    public class Kisi
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string Sinif { get; set; }
        public Image Resim { get; set; }
    }
    public class KisiKaynagi
    {
        public static List<Kisi> Kisiler
        {
            get
            {
                return new List<Kisi>
                {
                    new Kisi{Baslik="Ali Eren ERDAYI",Aciklama="Grafik ve Tasarım Alanında 3 Yıldır Çalışmaktadır.",
                    Sinif="Grafik ve Tasarım Alanında Yüksek Liisans 2.Sınıf Öğrencisi",Resim=Resources.erkek},
                    new Kisi{Baslik="Furkan SAĞTAŞ",Aciklama="Hemşirelik Alanında 4 Yıldır Çalışmaktadır.",
                    Sinif="Hemşirelik Alanında Yüksek Lisans 1.Sınıf Öğrencisi",Resim=Resources.erkek},
                    new Kisi{Baslik="Şuayb HIZAR",Aciklama="Sağlık Bilişimi Alnında Henüz İşe Başlamamıştır.",
                    Sinif="Sağlık Bilişimi Alanında Yüksek Lisan 2.Sınıf Öğrencisi",Resim=Resources.erkek},
                    new Kisi{Baslik="Damla AYCI",Aciklama="Tekstil Alanında 1 Yıldır Çalışmaktadır.",
                    Sinif="Sağlık Yçnetimi Mezunu",Resim=Resources.kadin}
                };
            }
        }
    }
}
