using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormUserControlPratic_2.Properties;

namespace WinFormUserControlPratic_2
{
    public class Kisi
    {
        public string Baslik { get; set; }
        public string Aciklama { get; set; }
        public string OgrenimDuzeyi { get; set; }
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
                new Kisi
                {
                    Baslik="Şuayb HIZAR",
                    Aciklama="İlgi Alanı Yapay Zeka",
                    OgrenimDuzeyi="Sağlık Yönetimi Mezunu ve Sağlık Bilşimi Alanında Yüksek Lisans 2.Sınıf Öpğrencisi.",
                    Resim=Resources.erkek
                },
                new Kisi
                {
                Baslik="Furkan SAĞTAŞ",
                Aciklama="Hemşire",
                OgrenimDuzeyi="Hemşirelik Mezunu ve Halk Sağlığı Alanında Yüksek Lisans 1.Sınıf Çğrencisi ",
                Resim=Resources.erkek
                }
            };
            }
        }
    }
}
