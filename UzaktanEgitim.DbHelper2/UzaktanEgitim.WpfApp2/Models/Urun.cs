using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.CustomControls;

namespace UzaktanEgitim.WpfApp2.Models
{
    public class Urun
    {
        [Kolon(Gorunur = false)]
        public int UrunId { get; set; }

        [Kolon(Baslik = "Ürün Adı")]
        public string UrunAdi { get; set; }

        [Kolon(Baslik = "Birim Fiyatı")]
        public decimal BirimFiyati { get; set; }

        [Kolon(Baslik = "Stok Adedi")]
        public int StokAdedi { get; set; }

        [Kolon(Baslik = "Kategorisi")]
        public string KategoriAdi { get; set; }



        // public int KategoriId { get; set; }
    }
}
