using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfDataGrid.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }
        public SolidColorBrush Renk { get; set; }
        public int StokAdedi { get; set; }
    }
}
