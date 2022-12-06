using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace RssUygulamaThread
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
        void MakaleleriGetir()
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

            Thread.Sleep(5000);

            gridMakaleler.Dispatcher.BeginInvoke(new Action(() =>
            {
                gridMakaleler.ItemsSource = makaleler;
            }));


        }

        private void btnMakaleleriGetir_Click(object sender, RoutedEventArgs e)
        {
            Thread makaleThread = new Thread(MakaleleriGetir);
            makaleThread.Start();
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

