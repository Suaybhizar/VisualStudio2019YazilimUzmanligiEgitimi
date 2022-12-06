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
using UzaktanEgitim.WpfApp2.Business;
using UzaktanEgitim.WpfApp2.Models;

namespace UzaktanEgitim.WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            UrunleriGetir();
            KategorileriGetir();
        }
        void UrunleriGetir()
        {
            try
            {
                gridUrunler.ItemsSource = UrunBusiness.UrunleriGetir();
                gridUrunler.SelectedIndex = 0;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Ürünler alınırken bir hata oluştu. Hata mesajı : " + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        void KategorileriGetir()
        {
            try
            {
                cmbKategoriler.DisplayMemberPath = "KategoriAdi"; //Gösterilecek property
                cmbKategoriler.SelectedValuePath = "KategoriId"; //Arka planda seçilen elemana ait değer kullanıcı bu değeri görmeyecek.
                cmbKategoriler.ItemsSource = KategoriBusiness.KategorileriGetir();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Kategoriler alınırken bir hata oluştu. Hata mesajı : " + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnYeniKayit_Click(object sender, RoutedEventArgs e)
        {
            yeniKayit = true;
            txtBirimFiyat.Clear();
            txtStokAdedi.Clear();
            txtUrunAdi.Clear();
            cmbKategoriler.SelectedIndex = 0;
        }
        bool yeniKayit = false;
        private void btnKaydet_Click(object sender, RoutedEventArgs e)
        {
            Urun seciliUrun = gridUrunler.SelectedItem as Urun;
            if (!yeniKayit)
            {
                try
                {
                    //Güncelleme Yapılıyor
                    int seciliSatirNo=gridUrunler.SelectedIndex;
                    UrunBusiness.UrunGuncelle(seciliUrun.UrunId, txtUrunAdi.Text, cmbKategoriler.SelectedValue,
                       txtBirimFiyat.Text, txtStokAdedi.Text);
                    UrunleriGetir();
                    gridUrunler.SelectedIndex = seciliSatirNo;
                    MessageBox.Show("Ürün Başarıyla Güncellendi.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ürün güncellenirken bir hata oluştu. Hata mesajı : " + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                //Yeni kayıt ekleniyor
                try
                {
                    UrunBusiness.UrunEkle(txtUrunAdi.Text, cmbKategoriler.SelectedValue, txtBirimFiyat.Text, txtStokAdedi.Text);
                    UrunleriGetir();
                    MessageBox.Show("Ürün Başarıyla Eklendi");
                    yeniKayit = false;
                    gridUrunler.SelectedIndex = gridUrunler.Items.Count - 1;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("Ürün eklenirken bir hata oluştu. Hata mesajı : " + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }


        }

        private void btnSil_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Urun seciliUrun = gridUrunler.SelectedItem as Urun;
                UrunBusiness.UrunSil(seciliUrun.UrunId);
                UrunleriGetir();
                MessageBox.Show("Ürün Başarıyla Silindi.");

            }
            catch (Exception ex)
            {

                MessageBox.Show("Ürün silinirken bir hata oluştu. Hata mesajı : " + ex.Message, "Hata", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}

