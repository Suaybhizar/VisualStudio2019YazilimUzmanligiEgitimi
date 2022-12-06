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

namespace WpfTekilAnimasyonlar
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ellipse.Background = new SolidColorBrush(Colors.Red);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //DoubleAnımation          //double ve int türündeki özellikler için
            //ColorAnimation           //renk değiştirmek için
            //ThichnesAnimation        //margin ve padding değiştirmek için
            //from yazıldığı taktirde butona her tıklamada başlangıç değerine geri döner eğer
            //from koymazsak bir kere animaston hareket eder ve orada kalır tekrarlama olmaz.
            DoubleAnimation da1 = new DoubleAnimation();
            da1.From = 0;
            da1.To = 430;
            da1.Duration = TimeSpan.FromSeconds(1.5);
            da1.AutoReverse = true;
            ellipse.BeginAnimation(Canvas.LeftProperty, da1);

            DoubleAnimation da2 = new DoubleAnimation();
            da2.From = 0;
            da2.To = 300;
            da2.Duration = TimeSpan.FromSeconds(1.5);
            da2.AutoReverse = true;
            ellipse.BeginAnimation(Canvas.TopProperty, da2);

            ThicknessAnimation ta1 = new ThicknessAnimation();
            ta1.From = new Thickness(5); 
            ta1.To = new Thickness(15);
            ta1.Duration = TimeSpan.FromSeconds(1.5);
            ta1.AutoReverse = true;
            ellipse.BeginAnimation(Border.PaddingProperty, ta1);

            ColorAnimation ca1 = new ColorAnimation();
            ca1.From = Colors.Red;
            ca1.To = Colors.Lime;
            ca1.Duration = TimeSpan.FromSeconds(1.5);
            ca1.AutoReverse = true;
            ellipse.Background.BeginAnimation(SolidColorBrush.ColorProperty, ca1);


        }
    }
}
