using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace WpfDataGridPratics.NewFolder1
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentFullName { get; set; }
        public string StudentDepartment { get; set; }
        public double MidtermExams { get; set; }
        public double FinalExams { get; set; }
        public SolidColorBrush PassedorFaild { get; set; }
    }
}
