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

namespace WpfComboBox
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            cmbKisiler.DisplayMemberPath = "AdSoyad";
            cmbKisiler.SelectedValuePath = "Id";
            cmbKisiler.ItemsSource = KisiContext.Kisiler;
            cmbKisiler.SelectedIndex = 2;
        }

        private void btnSeciliKisiIdGetir_Click(object sender, RoutedEventArgs e)
        {
            //Kisi seciliKisId = cmbKisiler.SelectedItem as Kisi;
            //MessageBox.Show(seciliKisId.Id.ToString());
            MessageBox.Show(cmbKisiler.SelectedValue.ToString());
            MessageBox.Show("Şu an " + cmbKisiler.SelectedIndex + " index numaralı kişi seçildi.");
            cmbKisiler.SelectedIndex = -1;
        }
    }
    public static class KisiContext
    {
        static List<Kisi> kisiler = new List<Kisi>() 
        {
            new Kisi{Id=1,Adi="Ad 1",SoyAdi="Soyad 1"},
            new Kisi{Id=2,Adi="Ad 2",SoyAdi="Soyad 2"},
            new Kisi{Id=3,Adi="Ad 3",SoyAdi="Soyad 3"},
            new Kisi{Id=4,Adi="Ad 3",SoyAdi="Soyad 3"}
        };
        
        public static List<Kisi> Kisiler
        {
            get
            {
                return kisiler;
            }
        }
    }

    public  class Kisi
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string SoyAdi { get; set; }

        public string AdSoyad
        {
            get
            {
                return string.Format("{0} {1}", Adi, SoyAdi);
            }
        }

        //public override string ToString()
        //{
        //    return AdSoyad;
        //}

    }
}
