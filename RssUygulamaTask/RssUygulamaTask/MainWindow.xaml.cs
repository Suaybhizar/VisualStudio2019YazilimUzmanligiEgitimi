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

namespace RssUygulamaTask
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
        Task<List<Makale>> MakaleleriGetir()
        {
            return Task<List<Makale>>.Factory.StartNew(() =>
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
                 Task.Delay(3000).Wait();

                 return makaleler;
             });

        }

        private async void btnMakaleleriGetir_Click(object sender, RoutedEventArgs e)
        {
            //Eğer async ve await olmasaydı aşağıdaki uzun kod satırını yazmak zorunda kalacaktık.
            //MakaleleriGetir()
            //    .ContinueWith(t =>
            //    {
            //        gridMakaleler.Dispatcher.BeginInvoke(new Action(() =>
            //        {
            //            gridMakaleler.ItemsSource = t.Result;
            //        }));

            //    });

            var makaleler = await MakaleleriGetir();
            gridMakaleler.ItemsSource = makaleler;



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
