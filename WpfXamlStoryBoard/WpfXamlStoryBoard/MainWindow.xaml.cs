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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfXamlStoryBoard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Hareket.Completed += Hareket_Completed;
        }

        private void Hareket_Completed(object sender, EventArgs e)
        {
            btnBaslat.IsEnabled = true;
        }

        public Storyboard Hareket
        {
            get
            {
                return Resources["sbHareket"] as Storyboard;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Hareket.Begin(border, true);
           
            (sender as Button).IsEnabled = false;
        }

        private void btnDuraklat_Click(object sender, RoutedEventArgs e)
        {
            Hareket.Pause(border);
        }

        private void btnDevam_Click(object sender, RoutedEventArgs e)
        {
            Hareket.Resume(border);
        }
    }
}
