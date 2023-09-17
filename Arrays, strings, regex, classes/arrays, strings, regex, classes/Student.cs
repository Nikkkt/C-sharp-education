using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace arrays__strings__regex__classes
{
    internal class Student : IComparable<Student>
    {
        private string Surname;
        private string Name;
        private string Patronymic;
        private DateTime DateOfBirth;
        private Address Address;
        private string PhoneNumber;
        private int[] HomeworkGrades;
        private int[] FinalworkGrades;
        private int[] ExamsGrades;

        public Student() {
            Surname = "NONE";
            Name = "NONE";
            Patronymic = "NONE";
            DateOfBirth = new DateTime();
            Address = new Address();
            PhoneNumber = "NONE";
            HomeworkGrades = new int[] { };
            FinalworkGrades = new int[] { };
            ExamsGrades = new int[] { };
        }

        public Student(
            string surname, string name, string patronymic, 
            DateTime dateOfBirth, Address address,  string phoneNumber, 
            int[] homeworkGrades, int[] finalworkGrades, int[] examsGrades) 
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            Address = address;
            PhoneNumber = phoneNumber;
            HomeworkGrades = homeworkGrades;
            FinalworkGrades = finalworkGrades;
            ExamsGrades = examsGrades;
        }

        public Student(
            string surname, string name, string patronymic, DateTime dateOfBirth, 
            string country, string city, string region, int postalCode, string street, string house, string phoneNumber, 
            int[] homeworkGrades, int[] finalworkGrades, int[] examsGrades)
        {
            Surname = surname;
            Name = name;
            Patronymic = patronymic;
            DateOfBirth = dateOfBirth;
            Address = new Address(country, city, region, postalCode, street, house);
            PhoneNumber = phoneNumber;
            HomeworkGrades = homeworkGrades;
            FinalworkGrades = finalworkGrades;
            ExamsGrades = examsGrades;
        }

        public int CompareTo(Student other)
        {
            if (this == other) return 0;
            if (this > other) return 1;
            else return -1;
        }

        public class SortByHomework : IComparer<Student>
        {
            public int Compare(Student first, Student second)
            {
                if (first.homeworkGrades.Average() == second.homeworkGrades.Average()) return 0;
                if (first.homeworkGrades.Average() > second.homeworkGrades.Average()) return 1;
                else return -1;
            }
        }

        public class SortByFinalWork : IComparer<Student>
        {
            public int Compare(Student first, Student second)
            {
                if (first.finalworkGrades.Average() == second.finalworkGrades.Average()) return 0;
                if (first.finalworkGrades.Average() > second.finalworkGrades.Average()) return 1;
                else return -1;
            }
        }

        public class SortByExamsWork : IComparer<Student>
        {
            public int Compare(Student first, Student second)
            {
                if (first.examsGrades.Average() == second.examsGrades.Average()) return 0;
                if (first.examsGrades.Average() > second.examsGrades.Average()) return 1;
                else return -1;
            }
        }

        public string surname
        {
            get { return Surname; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new InvalidSurname("Null or whitespace value");
                if (!value.All(el => char.IsLetter(el))) throw new InvalidSurname("Invalid data");
                Surname = value;
            }
        }

        public string name
        {
            get { return Name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new InvalidName("Null or whitespace value");
                if (!value.All(el => char.IsLetter(el))) throw new InvalidName("Invalid data");
                Name = value;
            }
        }

        public string patronymic
        {
            get { return Patronymic; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new InvalidPatronymic("Null or whitespace value");
                if (!value.All(el => char.IsLetter(el))) throw new InvalidPatronymic("Invalid data");
                Patronymic = value;
            }
        }

        public DateTime dateOfBirth
        {
            get { return DateOfBirth; }
            set
            {
                if (value >= DateTime.Now || value <= DateTime.Now.AddYears(-80)) throw new InvalidBirthDate("Invalid birth date");
                DateOfBirth = value;
            }
        }

        public Address address
        {
            get { return Address; }
            set
            {
                if (value == null) throw new InvalidAddress("Null value");
                Address = value;
            }
        }

        public string phoneNumber
        {
            get { return PhoneNumber; }
            set
            {
                if (value.Length <= 8 || value.Length >= 12) throw new InvalidPhoneNumber("Invalid phone number");
                PhoneNumber = value;
            }
        }

        public int[] homeworkGrades
        {
            get { return HomeworkGrades; }
            set
            {
                if (value == null) throw new InvalidGrade("Null value");
                if (!value.All(el => el >= 1 && el <= 12)) throw new InvalidGrade("Invalid value of the grade");
                HomeworkGrades = value;
            }
        }

        public int[] finalworkGrades
        {
            get { return FinalworkGrades; }
            set
            {
                if (value == null) throw new InvalidGrade("Null value");
                if (!value.All(el => el >= 1 && el <= 12)) throw new InvalidGrade("Invalid value of the grade");
                FinalworkGrades = value;
            }
        }

        public int[] examsGrades
        {
            get { return ExamsGrades; }
            set
            {
                if (value == null) throw new InvalidGrade("Null value");
                if (!value.All(el => el >= 1 && el <= 12)) throw new InvalidGrade("Invalid value of the grade");
                ExamsGrades = value;
            }
        }

        public void AddHomeworkGrade(int grade)
        {
            int[] tmp = HomeworkGrades;
            HomeworkGrades = new int[tmp.Length + 1];
            for (int i = 0; i < tmp.Length; i++) HomeworkGrades[i] = tmp[i];
            HomeworkGrades[HomeworkGrades.Length - 1] = grade;
        }
        public void AddFinalworkGrade(int grade) {
            int[] tmp = FinalworkGrades;
            FinalworkGrades = new int[tmp.Length + 1];
            for (int i = 0; i < tmp.Length; i++) FinalworkGrades[i] = tmp[i];
            FinalworkGrades[FinalworkGrades.Length - 1] = grade;
        }
        public void AddExamGrade(int grade) {
            int[] tmp = ExamsGrades;
            ExamsGrades = new int[tmp.Length + 1];
            for (int i = 0; i < tmp.Length; i++) ExamsGrades[i] = tmp[i];
            ExamsGrades[ExamsGrades.Length - 1] = grade;
        }
        public int GetAverageHomeworkGrade()
        {
            int result = 0;
            if (HomeworkGrades.Length != 0)
            {
                foreach (int grade in HomeworkGrades) result += grade;
                result /= HomeworkGrades.Length;
            }
            return result;
        }

        public override bool Equals(object obj)
        {
            Student obj2 = obj as Student;
            if (obj == null) return false;
            return (obj2.surname == this.surname && obj2.name == this.name &&
                obj2.patronymic == this.patronymic && obj2.dateOfBirth == this.dateOfBirth &&
                obj2.address == this.address && obj2.phoneNumber == this.phoneNumber);
        }

        public static bool operator ==(Student student1, Student student2)
        {
            if (ReferenceEquals(student1, student2)) return true;
            if ((object)student1 != null) return student1.Equals(student2);
            if ((object)student2 != null) return student2.Equals(student1);
            return (student1.surname == student2.surname && student1.name == student2.name &&
                student1.patronymic == student2.patronymic && student1.dateOfBirth == student2.dateOfBirth &&
                student1.address == student2.address && student1.phoneNumber == student2.phoneNumber);
        }
        public static bool operator !=(Student student1, Student student2) { return !(student1 == student2); }
        public static bool operator <(Student student1, Student student2) { return student1.GetAverageHomeworkGrade() <  student2.GetAverageHomeworkGrade(); }
        public static bool operator >(Student student1, Student student2) { return student1.GetAverageHomeworkGrade() > student2.GetAverageHomeworkGrade(); }
        public static bool operator <=(Student student1, Student student2) { return student1.GetAverageHomeworkGrade() <= student2.GetAverageHomeworkGrade(); }
        public static bool operator >=(Student student1, Student student2) { return student1.GetAverageHomeworkGrade() >= student2.GetAverageHomeworkGrade(); }
        public static bool operator true(Student student) { return (student.GetAverageHomeworkGrade() >= 7); }
        public static bool operator false(Student student) { return (student.GetAverageHomeworkGrade() < 7); }

        public void ShowInfo() { 
            Console.WriteLine($"Full name: {Surname} {Name} {Patronymic}\nDate of birth: {DateOfBirth.ToShortDateString()}\nAddress: {Address.toString()}\nPhone number: {PhoneNumber}");
            Console.Write("Homework grades: ");
            foreach (var i in HomeworkGrades) Console.Write(i + " ");
            Console.Write("\nFinalwork grades: ");
            foreach (var i in FinalworkGrades) Console.Write(i + " ");
            Console.Write("\nExams grades: ");
            foreach (var i in ExamsGrades) Console.Write(i + " ");
        }

        public override string ToString()
        {
            string homeworkGrades = ""; foreach (int grade in HomeworkGrades) homeworkGrades += grade + " ";
            string finalworkGrades = ""; foreach (int grade in FinalworkGrades) finalworkGrades += grade + " ";
            string examsGrades = ""; foreach (int grade in ExamsGrades) examsGrades += grade + " ";
            string result = $"Full name: {Surname} {Name} {Patronymic}\nDate of birth: {DateOfBirth.ToShortDateString()}\nAddress: {Address.toString()}\nPhone number: {PhoneNumber}\nHomework grades: {homeworkGrades}\nFinalwork grades: {finalworkGrades}\nExam grades: {examsGrades}";
            return result;
        }
    }
}