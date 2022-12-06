using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using WpfGridComboBoxOrnek.EntityContext;
using WpfGridComboBoxOrnek.Models;



namespace WpfGridComboBoxOrnek
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Urun> urunler = null;
        List<Kategori> kategoriler = null;

        public MainWindow()
        {
            InitializeComponent();
            // UrunContext urunDb = new UrunContext();

             kategoriler=new List<Kategori>
            {
                new Kategori {Id=1,Adi="Kategori 1"}, 
                new Kategori {Id=2,Adi="Kategori 2"},
                new Kategori {Id=3,Adi="Kategori 3"}
            };



            urunler = new ObservableCollection<Urun>
            {
                new Urun{ Id=1, Adi="Ürün 1", KategoriId=1},
                new Urun{ Id=2, Adi="Ürün 2", KategoriId=1},
                new Urun{ Id=3, Adi="Ürün 3", KategoriId=2},
                new Urun{ Id=4, Adi="Ürün 4", KategoriId=3},
                new Urun{ Id=5, Adi="Ürün 5", KategoriId=3},
            };

            //Kategoriler Bağlanıyor
            cmbKategoriler.DisplayMemberPath = "Adi";
            cmbKategoriler.SelectedValuePath = "Id";
            cmbKategoriler.ItemsSource = kategoriler;

            //datagrid'e veri bağlanıyor
            gridUrunler.ItemsSource = urunler;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //urunler[0].Adi = "Ürün 1 Yeni Adı";
            //urunler.RemoveAt(0);
            //urunler.Add(new Urun { Id = 6, Adi = "Ürün 6", KategoriId = 3 });
        }
    }



}
