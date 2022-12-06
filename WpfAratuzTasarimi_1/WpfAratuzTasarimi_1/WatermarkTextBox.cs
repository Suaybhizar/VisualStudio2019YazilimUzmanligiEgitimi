using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace WpfAratuzTasarimi_1
{
    public class WatermarkTextBox : TextBox
    {


        public ImageSource Source
        {
            get { return (ImageSource)GetValue(SourceProperty); }
            set { SetValue(SourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Source.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register("Source", typeof(ImageSource), typeof(WatermarkTextBox), new PropertyMetadata(null));







        public string FilligranText
        {
            get { return (string)GetValue(FilligranTextProperty); }
            set { SetValue(FilligranTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for FilligranText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty FilligranTextProperty =
            DependencyProperty.Register("FilligranText", typeof(string), typeof(string), new PropertyMetadata("Buraya Bir Değer Girilecek"));


    }

}
