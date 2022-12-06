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

namespace WpfDataTrigger
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var urunler = new List<Urun>
            { 
                new Urun{Id=1,Adi="Ürün 1"},
                new Urun{Id=2,Adi="Ürün 2"}
            };
            cmbUrunler.ItemsSource = urunler;
        }
    }
    public class Urun
    {
        public int Id { get; set; }
        public string Adi { get; set; }
    }
}
