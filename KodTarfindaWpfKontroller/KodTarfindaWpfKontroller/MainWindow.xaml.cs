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

namespace KodTarfindaWpfKontroller
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //Grid grid = new Grid();
            //grid.Background = Brushes.Gray;

            //RowDefinition row1 = new RowDefinition();
            //row1.Height = new GridLength(1, GridUnitType.Star);

            //RowDefinition row2 = new RowDefinition();
            //row2.Height = new GridLength(30, GridUnitType.Pixel);

            //RowDefinition row3 = new RowDefinition();
            //row3.Height = new GridLength(2, GridUnitType.Star);

            //grid.RowDefinitions.Add(row1);
            //grid.RowDefinitions.Add(row2);
            //grid.RowDefinitions.Add(row3);

            //ColumnDefinition col1 = new ColumnDefinition();
            //col1.Width = new GridLength(150, GridUnitType.Pixel);

            //ColumnDefinition col2 = new ColumnDefinition();
            //col2.Width = new GridLength(1, GridUnitType.Star);

            //grid.ColumnDefinitions.Add(col1);
            //grid.ColumnDefinitions.Add(col2);

            //TextBlock label = new TextBlock();
            //label.Text = "Adınız";
            //Grid.SetColumn(label, 0);
            //Grid.SetRow(label, 0);

            //TextBox text = new TextBox();
            //text.Background = Brushes.Orange;
            //Grid.SetColumn(text, 1);
            //Grid.SetRow(text, 1);

            //grid.Children.Add(label);
            //grid.Children.Add(text);
            //this.Content = grid;

            //StackPanel panel = new StackPanel();
            //panel.Orientation = Orientation.Horizontal;

            //TextBlock label = new TextBlock();
            //label.Text = "Adınız";
            //TextBox Text = new TextBox();
            //Text.Width = 150;
            //Text.Height = 150;


            //panel.Children.Add(label);
            //panel.Children.Add(Text);

            //this.Content = panel;

            Canvas canvas = new Canvas();

            Ellipse ellipse = new Ellipse();
            ellipse.Fill = Brushes.Red;
            ellipse.Width = 50;
            ellipse.Height = 50;

            Canvas.SetLeft(ellipse, 150);
            Canvas.SetTop(ellipse, 50);

            

            canvas.Children.Add(ellipse);

            this.Content = canvas;
            
        }
    }
}
