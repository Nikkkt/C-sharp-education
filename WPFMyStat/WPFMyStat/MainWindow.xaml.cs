using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WPFMyStat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class Student
        {
            public int Number { get; set; }
            public bool IsPresent { get; set; }
            public bool IsLate { get; set; }
            public bool IsAbsent { get; set; }
            public string Name { get; set; }
            public string ExamGrade { get; set; }
            public string LessonGrade { get; set; }
        }

        public ObservableCollection<Student> Students { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Students = new ObservableCollection<Student>()
            {
                new Student { Number = 1, Name = "Druzenko Evhenii Viktorovych", IsPresent = true, ExamGrade = "11", LessonGrade = "1" },
                new Student { Number = 2, Name = "Kononenko Sofia Evhenivna", IsPresent = true, ExamGrade = "10", LessonGrade = "1" },
                new Student { Number = 3, Name = "Lahoda Daniil Ihorovych", IsPresent = true, ExamGrade = "9", LessonGrade = "1" },
                new Student { Number = 4, Name = "Terpilovskyi Nikita Olehovych", IsPresent = true, ExamGrade = "12", LessonGrade = "12" },
            };

            DataContext = this;
        }
    }
}
