using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace arrays__strings__regex__classes
{
    internal class Group
    {
        private List<Student> Students;
        private string GroupName;
        private string Specialization;
        private int GroupNumber;

        private static string stringFakeData = @"
            {
              ""Names"": [ ""Dmytro"", ""Nikita"", ""Vladyslav"", ""Vyacheslav"", ""Bohdan"", ""Andriy"", ""Oleksandr"", ""Mark"", ""Svyatoslav"" ],
              ""Surnames"": [ ""Hranzov"", ""Terpilovskyi"", ""Kobzar"", ""Arzibashev"", ""Tolmachov"", ""Hromanchuk"", ""Untilov"" ],
              ""Patronymics"": [ ""Oleksiovich"", ""Olehovich"", ""Vitalovich"", ""Serhiovich"", ""Evhenovich"", ""Valerovich"", ""Konstyantynovich"" ],
              ""Countries_and_Cities"": [
                [ ""Ukraine"", ""Odesa"" ],
                [ ""Romania"", ""Constanta"" ],
                [ ""Moldova"", ""Chisinau"" ],
                [ ""Poland"", ""Wroclaw"" ],
                [ ""France"", ""Marcel"" ],
                [ ""Germany"", ""Berlin"" ],
                [ ""Czech Republic"", ""Praha"" ]
              ],
              ""PostalCodes"": [ 65065, 38072, 45367, 21034, 15090, 54089, 76890 ],
              ""Streets"": [ ""Peremoha avenue"", ""1st May Street"", ""Haharina avenue"", ""Main Street"", ""Fontan Street"" ],
              ""Houses"": [ ""23/5"", ""34/1"", ""9/2"", ""17/3"", ""14/1"" ],
              ""Specialization"": [ ""Frontend"", ""Backend"", ""Data Science"", ""Machine learning"" ]
            }
        ";

        public Group() {
            Random randomNumber = new Random();
            dynamic fakeData = JsonConvert.DeserializeObject(stringFakeData);
            GroupNumber = 30 + randomNumber.Next(1, 5);
            GroupName = "P-" + GroupNumber;
            Specialization = fakeData.Specialization[randomNumber.Next(0, fakeData.Specialization.Count)];

            JArray countriesAndCitiesArray = (JArray)fakeData.Countries_and_Cities;
            JArray surnamesArray = (JArray)fakeData.Surnames;
            JArray namesArray = (JArray)fakeData.Names;
            JArray patronymicsArray = (JArray)fakeData.Patronymics;
            JArray postalCodesArray = (JArray)fakeData.PostalCodes;
            JArray streetsArray = (JArray)fakeData.Streets;
            JArray housesArray = (JArray)fakeData.Houses;

            Students = new List<Student>(10);

            for (int i = 0; i < 10; i++)
            {
                List<string> countriesAndCities = countriesAndCitiesArray[randomNumber.Next(0, countriesAndCitiesArray.Count)].ToObject<List<string>>();
                string surname = surnamesArray[randomNumber.Next(0, surnamesArray.Count)].ToString();
                string name = namesArray[randomNumber.Next(0, namesArray.Count)].ToString();
                string patronymic = patronymicsArray[randomNumber.Next(0, patronymicsArray.Count)].ToString();

                DateTime birthdate = new DateTime(randomNumber.Next(2000, 2007), randomNumber.Next(1, 13), randomNumber.Next(1, 29));
                Address address = new Address(
                    countriesAndCities[0],
                    countriesAndCities[1],
                    countriesAndCities[1] + " Region",
                    postalCodesArray[randomNumber.Next(0, postalCodesArray.Count)].ToObject<int>(),
                    streetsArray[randomNumber.Next(0, streetsArray.Count)].ToString(),
                    housesArray[randomNumber.Next(0, housesArray.Count)].ToString()
                );
                string phoneNumber = "+38066" + randomNumber.Next(1000000, 9999999);

                int[] homeworkGrades = { randomNumber.Next(8, 13), randomNumber.Next(8, 13), randomNumber.Next(8, 13), randomNumber.Next(8, 13), randomNumber.Next(8, 13) };
                int[] finalworkGrades = { randomNumber.Next(8, 13), randomNumber.Next(8, 13), randomNumber.Next(8, 13), randomNumber.Next(8, 13), randomNumber.Next(8, 13) };
                int[] examsGrades = { randomNumber.Next(8, 13), randomNumber.Next(8, 13), randomNumber.Next(8, 13), randomNumber.Next(8, 13), randomNumber.Next(8, 13) };

                Student newFakeStudent = new Student(
                    surname,
                    name,
                    patronymic,
                    birthdate,
                    address,
                    phoneNumber,
                    homeworkGrades,
                    finalworkGrades,
                    examsGrades
                );

                Students.Add(newFakeStudent);
            }
        }

        public Group(List<Student> students, string groupName, string specialization, int groupNumber)
        {
            Students = new List<Student>(students);
            GroupName = groupName;
            Specialization = specialization;
            GroupNumber = groupNumber;
        }

        public List<Student> students
        {
            get { return Students; }
            set
            {
                if (value == null || value.Count == 0) throw new InvalidGroupStudents("Null or empty list");
                if (value.Distinct().Count() != value.Count) throw new GroupDuplicateStudents("Duplicate in list");
                Students = value;
            }
        }

        public string groupName
        {
            get { return GroupName; }
            set
            {
                if (value == null || value.Length == 0) throw new InvalidGroupName("Null or empty name");
                GroupName = value;
            }
        }

        public string specialization
        {
            get { return Specialization; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new InvalidGroupSpecialization("Null or whitespace value");
                if (!value.All(el => char.IsLetter(el) || char.IsWhiteSpace(el))) throw new InvalidGroupSpecialization("Invalid data");
                Specialization = value;
            }
        }

        public int groupNumber
        {
            get { return GroupNumber; }
            set
            {
                if (value < 0 || value > 100) throw new InvalidGroupCourseNumber("Invalid data");
                GroupNumber = value;
            }
        }

        public Student this[int i]
        {
            get
            {
                if (i >= 0 && i < Students.Count) return Students[i];
                else if (i < 0 && i >= -Students.Count) return Students[Students.Count + i];
                else throw new InvalidGroupStudents("Index out of range");
            }
            set
            {
                if (i >= 0 && i < Students.Count) Students[i] = value;
                else if (i < 0 && i >= -Students.Count) Students[Students.Count + i] = value;
                else throw new InvalidGroupStudents("Index out of range");
            }
        }

        public Student this[string name, string surname]
        {
            get
            {
                if (students.Any(student => student.name == name)) foreach (Student student in Students) if (student.name == name && student.surname == surname) return student;
                throw new InvalidGroupStudents($"Student {name} {surname} not found");
            }
            set
            {
                List<Student> studentsCopy = new List<Student>(Students); bool studentFound = false;
                for (int i = 0; i < studentsCopy.Count; i++) if (studentsCopy[i].name == name && studentsCopy[i].surname == surname) { students[i] = value; studentFound = true; break; }
                if (!studentFound) throw new InvalidGroupStudents($"Student {name} {surname} not found");
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine($"GroupName: {GroupName}\nSpecialization: {Specialization}\nGroupNumber: {GroupNumber}\nStudents: ");
            for (int i = 0; i < Students.Count; i++)
            {
                Console.WriteLine($"{i+1}.");
                Students[i].ShowInfo();
                Console.WriteLine("\n");
            }
        }
    }
}
