using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfDataBinding.Models;

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Urun urun;
        public MainWindow()
        {
            InitializeComponent();

            urun = new Urun
            {
                Id = 1,
                UrunAdi = "ürün 1",
                StokAdedi = 5,
                Renk = new SolidColorBrush(Colors.Brown)
            };
            //gridUrun.DataContext = urun;
            this.DataContext = urun;
        }

        private void btnMesajVer_Click(object sender, RoutedEventArgs e)
        {
            // Urun urun = Resources["urunModel"] as Urun;
            MessageBox.Show(urun.StokAdedi.ToString());

        }
    }
}
