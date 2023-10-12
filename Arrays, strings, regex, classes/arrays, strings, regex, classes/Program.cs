using arrays__strings__regex__classes;

Address studentAddress1 = new Address("Ukraine", "Odesa", "Odesa Region", 65000, "Haharina Avenue", "23/5");
Address studentAddress2 = new Address("Ukraine", "Odesa", "Odesa Region", 65000, "Haharina Avenue", "23/5");

Student student1 = new Student("Terpilovskyi", "Nikita", "Olehovich",
    new DateTime(2006, 1, 29), studentAddress1, "+380663351004",
    new int[] { 11, 11, 12, 11 }, new int[] { 11, 12 }, new int[] { 10, 11, 12 });

Student student2 = new Student("Terpilovskyi", "Nikita", "Olehovich",
    new DateTime(2006, 1, 29), studentAddress2, "+380663351004",
    new int[] { 11, 11, 12, 11 }, new int[] { 11, 12 }, new int[] { 10, 11, 12 });

Student student3 = new Student("Ivanov", "Ivan", "Ivanovich",
    new DateTime(2006, 1, 29), studentAddress1, "+380674481669",
    new int[] { 8, 7, 6, 4 }, new int[] { 11, 12 }, new int[] { 10, 11, 12 });

Student student4 = new Student("Pupkin", "Vasiliy", "Vasiliovich",
    new DateTime(2005, 10, 15), studentAddress1, "+380671287836",
    new int[] { 8, 7, 9, 9 }, new int[] { 5, 12 }, new int[] { 10, 8, 12 });

Console.WriteLine(studentAddress1 == studentAddress2); // True
Console.WriteLine(student1 == student2); // True
Console.WriteLine(student1 == student3); // False
Console.WriteLine(student1 != student3); // True
Console.WriteLine(student1 < student3); // False
Console.WriteLine(student1 > student3); // True
Console.WriteLine(student1 <= student3); // False
Console.WriteLine(student1 >= student3); // True

if (student1) Console.WriteLine("Student1");
if (student3) Console.WriteLine("Something went wrong...");
else Console.WriteLine("Student3");

Group TestGroup = new Group(new List<Student> { student1, student3 }, "P15", "Programming", 15);
Console.WriteLine($"{TestGroup[0]}\n");
Console.WriteLine($"{TestGroup[-1]}\n");
Console.WriteLine($"{TestGroup["Nikita", "Terpilovskyi"]}\n");

TestGroup[0] = student4;
Console.WriteLine($"{TestGroup[0]}\n");
TestGroup[0] = student1;

TestGroup[-1] = student4;
Console.WriteLine($"{TestGroup[-1]}\n");
TestGroup[-1] = student3;

TestGroup["Nikita", "Terpilovskyi"] = student4;
Console.WriteLine($"{TestGroup["Vasiliy", "Pupkin"]}\n");
TestGroup["Vasiliy", "Pupkin"] = student1;

foreach (Student student in TestGroup) { Console.WriteLine(student + "\n"); }