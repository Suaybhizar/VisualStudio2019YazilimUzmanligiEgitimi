using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using UzaktanEgitim.WpfApp2.Business;

namespace UzaktanEgitim.WpfApp2
{
    public class KategoriAdiKategoriIdCevir : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string kategoriAdi=value.ToString();
            return KategoriBusiness.KategoriAdinaIdGetir(kategoriAdi);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
