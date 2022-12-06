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

namespace AsyncAwaitKeyword
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

        Task<int> RasgeleSayiÜret(int bitis)
        {
            var task = Task<int>.Factory.StartNew(() =>
            {
                Task.Delay(3000).Wait();
                return new Random().Next(0, 50);
            }).ContinueWith(t =>
            {
                Task.Delay(2000).Wait();
                return new Random().Next(t.Result, bitis);
            });
            return task;
        }

        private async void btnSayiTut_Click(object sender, RoutedEventArgs e)
        {
            var sonuc = await RasgeleSayiÜret(500);
            txtRasgeleSayi.Text = sonuc.ToString();
            txtRasgeleSayi.Background = Brushes.Orange;
        }
    }
}
