using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfDataGridPratics.NewFolder1;
using System.Windows.Media;

namespace WpfDataGridPratics.EntityContext
{
    public class StudentContext
    {
        List<Student> Student;

        public StudentContext()
        {
            Student = new List<Student>
            {
                new Student{StudentId=1, StudentFullName="Ali Eren ERDAYI", StudentDepartment="Graphic Design",
                    MidtermExams=55,FinalExams=90 ,PassedorFaild=new SolidColorBrush(Colors.Lime)},
                new Student{StudentId=2, StudentFullName="Furkan SAĞTAŞ", StudentDepartment="Nurse",
                    MidtermExams=75,FinalExams=65.50 ,PassedorFaild=new SolidColorBrush(Colors.Lime)},
                new Student{StudentId=3, StudentFullName="Tuğkan PALA", StudentDepartment="Health Menagement",
                    MidtermExams=55,FinalExams=55 ,PassedorFaild=new SolidColorBrush(Colors.Yellow)},
                new Student{StudentId=4, StudentFullName="Özge ÖZMEN", StudentDepartment="Physiotherapy",
                    MidtermExams=45,FinalExams=85 ,PassedorFaild=new SolidColorBrush(Colors.Yellow)},
                new Student{StudentId=5, StudentFullName="Damla AYCI", StudentDepartment="Health Menagement",
                    MidtermExams=65.75,FinalExams=95.50 ,PassedorFaild=new SolidColorBrush(Colors.Lime)},
                new Student{StudentId=6, StudentFullName="Şuayb HIZAR", StudentDepartment="Health Menagement",
                    MidtermExams=35.50,FinalExams=45.50 ,PassedorFaild=new SolidColorBrush(Colors.Maroon)},
                new Student{StudentId=7, StudentFullName="Buğra ŞAHİN", StudentDepartment="Construction engineery",
                    MidtermExams=65,FinalExams=75 ,PassedorFaild=new SolidColorBrush(Colors.Yellow)},
                new Student{StudentId=8, StudentFullName="İlayda ROKZAN", StudentDepartment="Health Menagement and Nurse",
                    MidtermExams=45,FinalExams=35 ,PassedorFaild=new SolidColorBrush(Colors.Maroon)},
                new Student{StudentId=9, StudentFullName="Sevde HIZAR", StudentDepartment="Software Developer",
                    MidtermExams=65,FinalExams=75 ,PassedorFaild=new SolidColorBrush(Colors.Yellow)},
                new Student{StudentId=10, StudentFullName="Melike AKÇALI", StudentDepartment="Health MEnagement",
                    MidtermExams=85,FinalExams=85 ,PassedorFaild=new SolidColorBrush(Colors.Lime)}

            };
        }

        public List<Student> Students
        {
            get { return Student; }
        }
    }
}
