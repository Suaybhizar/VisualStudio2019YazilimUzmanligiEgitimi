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

namespace WpfOlaylar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //txtMesaj.GotFocus += MetinKutusuAktif;
            //txtMesaj.LostFocus += TxtMesaj_LostFocus;
        }

        //private void TxtMesaj_LostFocus(object sender, RoutedEventArgs e)
        //{
        //    txtMesaj.Background = Brushes.White;
        //}

        //private void MetinKutusuAktif(object sender, RoutedEventArgs e)
        //{
        //    TextBox txt = sender as TextBox;
        //    txt.Background = Brushes.Orange;
        //}

        //public void ButonaTiklandi(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Butona Tıklandı");
        //}

        public void MesajVer(object sender,RoutedEventArgs e)
        {
            Button btn = sender as Button;
            MessageBox.Show(btn.Content + " tıklandı");

            btn.Click -= MesajVer;
        }
    }
}
