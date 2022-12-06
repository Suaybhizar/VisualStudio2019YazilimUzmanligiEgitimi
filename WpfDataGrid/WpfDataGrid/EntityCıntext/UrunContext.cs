using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDataGrid.Models;
using System.Windows.Media;

namespace WpfDataGrid.EntityCıntext
{
    public class UrunContext
    {
        List<Urun> urunler;
        public UrunContext()
        {
            urunler = new List<Urun>
            {
                new Urun{Id=1,StokAdedi=5,UrunAdi="Ürün 1",Renk=new SolidColorBrush( Colors.Red)},
                 new Urun{Id=2,StokAdedi=3,UrunAdi="Ürün 2",Renk=new SolidColorBrush( Colors.Orange)},
                  new Urun{Id=3,StokAdedi=10,UrunAdi="Ürün 3",Renk=new SolidColorBrush( Colors.Yellow)},
                   
            };
        }

        public List<Urun> Urunler
        {
            get { return urunler; }
        }
    }
}
