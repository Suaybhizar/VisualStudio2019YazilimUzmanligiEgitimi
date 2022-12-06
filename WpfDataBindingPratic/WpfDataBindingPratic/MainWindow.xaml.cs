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
using WpfDataBindingPratic.models;

namespace WpfDataBindingPratic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Student student;
        public MainWindow()
        {
            InitializeComponent();

            student = new Student
            {
                StudentId = 22334455,
                StudentName = "Şuayb",
                StudentLastName = "HIZAR",
                StudentDepartment = "Health Informatics Masters Of Degree"

            };
            this.DataContext = student;


        }

        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(student.StudentId.ToString());
            MessageBox.Show(student.StudentName.ToString());
            MessageBox.Show(student.StudentLastName.ToString());
            MessageBox.Show(student.StudentDepartment.ToString());
        }

       
    }
}
