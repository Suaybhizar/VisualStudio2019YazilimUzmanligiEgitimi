using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfDataBinding.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public String UrunAdi { get; set; }
        public int StokAdedi { get; set; }
        public SolidColorBrush Renk { get; set; }

    }
}
