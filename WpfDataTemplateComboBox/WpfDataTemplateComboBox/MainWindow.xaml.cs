using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using System.Windows;
using System.Globalization;

namespace WpfDataTemplateComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ObservableCollection<Urun> urunler = new ObservableCollection<Urun>
           {
                new Urun{Id=1,Adi="Ürün 1",StokAdedi=5,KritikStokAdedi=6,Satistami=false},
                new Urun{Id=2,Adi="Ürün 2",StokAdedi=10,KritikStokAdedi=8,Satistami=true},
                new Urun{Id=3,Adi="Ürün 3",StokAdedi=50,KritikStokAdedi=40,Satistami=false},
                new Urun{Id=4,Adi="Ürün 4",StokAdedi=30,KritikStokAdedi=35,Satistami=true}

           };


            cmbUrunler.ItemsSource = urunler;
            lstUrunler.ItemsSource = urunler;
        }
    }

    public class boolToBackraoundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool stokAdediKritik = System.Convert.ToBoolean(value);
            if (stokAdediKritik)
                return new SolidColorBrush(Colors.PaleVioletRed);
            else
                return new SolidColorBrush(Colors.Lime);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class boolToForegroundColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool satistaMi = System.Convert.ToBoolean(value);
            if (satistaMi)
                return new SolidColorBrush(Colors.Black);
            else
                return new SolidColorBrush(Colors.Gray);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }



    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public int StokAdedi { get; set; }
        public int KritikStokAdedi { get; set; }
        public bool Satistami { get; set; }

        public bool StokAdediKritik
        {
            get
            {
                return StokAdedi < KritikStokAdedi;
            }
        }


    }
}
