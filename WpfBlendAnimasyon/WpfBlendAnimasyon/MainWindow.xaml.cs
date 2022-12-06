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

namespace WpfBlendAnimasyon
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

        private void btnBaslat_Click(object sender, RoutedEventArgs e)
        {
            Storyboard sb = Resources["ellipsesHareket"] as Storyboard;
            var animation = sb.Children[2] as ColorAnimationUsingKeyFrames;
            animation.KeyFrames[1].Value = Colors.Orange;
            animation.KeyFrames[2].Value = Colors.Orange;
            animation.KeyFrames[3].Value = Colors.Orange;

            var doubleAnimation = sb.Children[0] as DoubleAnimationUsingKeyFrames;
            doubleAnimation.KeyFrames[1].Value = 250;
            sb.Begin(ellipse, true);
        }
    }
}
