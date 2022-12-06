using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfGridComboBoxOrnek.Models;

namespace WpfGridComboBoxOrnek.EntityContext
{
    public class UrunContext
    {
        static List<Kategori> kategoriler = new List<Kategori>
        {
            new Kategori {Id=1,Adi="Kategori 1"},
             new Kategori {Id=2,Adi="Kategori 2"},
              new Kategori {Id=3,Adi="Kategori 3"}
        };

        static List<Urun> urunler = new List<Urun>
        {
            new Urun{Id=1,Adi="Ürün 1",KategoriId=1},
            new Urun{Id=2,Adi="Ürün 2",KategoriId=1},
            new Urun{Id=3,Adi="Ürün 3",KategoriId=2},
            new Urun{Id=4,Adi="Ürün 4",KategoriId=3},
            new Urun{Id=5,Adi="Ürün 5",KategoriId=3},
        };

        public  List<Kategori> Kategoriler
        {
            get
            {
                return kategoriler;
            }


        }
        public  List<Urun> Urunler
        {
            get
            {
                return urunler;
            }
        }

    }
}
