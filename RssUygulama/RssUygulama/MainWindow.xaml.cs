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
using System.Xml.Linq;

namespace RssUygulama
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        List<Makale> MakaleleriGetir()
        {
            var makaleler = (from item in XDocument.Load("http://www.csharpnedir.com/rss/articles/?cat=cs").Element("rss").Element("channel")
                            .Elements("item")
                             select new Makale
                             {
                                 Baslik = item.Element("title").Value,
                                 Link = item.Element("link").Value,
                                 Tarih = DateTime.Parse(item.Element("pubDate").Value).ToString("dd.MM.yyyy.dddd"),
                                 Yazar = item.Element("author").Value
                             }).ToList();
            return makaleler;
        }

        private void btnMakaleleriGetir_Click(object sender, RoutedEventArgs e)
        {

            gridMakaleler.ItemsSource = MakaleleriGetir();



        }
    }

    public class Makale
    {
        public string Baslik { get; set; }
        public string Link { get; set; }
        public string Tarih { get; set; }
        public string Yazar { get; set; }

    }
}
