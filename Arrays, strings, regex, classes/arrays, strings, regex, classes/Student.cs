﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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