using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays__strings__regex__classes
{
    internal class Student
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

        public string GetSurname() { return Surname; }
        public string GetName() { return Name; }
        public string GetPatronymic() {  return Patronymic; }
        public DateTime GetDateOfBirth() {  return DateOfBirth; }
        public Address GetAddress() { return Address; }
        public string GetPhoneNumber() { return PhoneNumber; }
        public int[] GetHomeworkGrades() {  return HomeworkGrades; }
        public int[] GetFinalworkGrades() { return FinalworkGrades; }
        public int[] GetExamsGrades() { return ExamsGrades; }

        public void SetSurname(string surname) { Surname = surname; }
        public void SetName(string name) {  Name = name; }
        public void SetPatronymic(string patronymic) { Patronymic = patronymic; }
        public void SetDateOfBirth(DateTime dateOfBirth) { DateOfBirth = dateOfBirth; }
        public void SetAddress(Address address) { Address = address; }
        public void SetPhoneNumber(string phoneNumber) { PhoneNumber = phoneNumber; }
        public void SetHomeworkGrades(int[] homeworkGrades) { HomeworkGrades = homeworkGrades; }
        public void SetFinalworkGrades(int[] finalworkGrades) { FinalworkGrades = finalworkGrades; }
        public void SetExamsGrades(int[] examsGrades) { ExamsGrades = examsGrades; }

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

        public void ShowInfo() { 
            Console.WriteLine($"Full name: {Surname} {Name} {Patronymic}\nDate of birth: {DateOfBirth.ToShortDateString()}\nAddress: {Address.toString()}\nPhone number: {PhoneNumber}");
            Console.Write("Homework grades: ");
            foreach (var i in HomeworkGrades) Console.Write(i + " ");
            Console.Write("\nFinalwork grades: ");
            foreach (var i in FinalworkGrades) Console.Write(i + " ");
            Console.Write("\nExams grades: ");
            foreach (var i in ExamsGrades) Console.Write(i + " ");
        }
    }
}