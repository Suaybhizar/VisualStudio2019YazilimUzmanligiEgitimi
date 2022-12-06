using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UzaktanEgitim.CustomControls;

namespace UzaktanEgitim.WpfApp2.Models
{
    public class Kategori
    {
        [Kolon(Gorunur =false)]
        public int KategoriId { get; set; }

        [Kolon(Baslik ="Kategori Adı")]
        public string KategoriAdi { get; set; }
    }
}
