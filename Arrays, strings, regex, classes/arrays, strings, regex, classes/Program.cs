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

/* Group variable = new Group();
variable.ShowInfo();

Address studentAddress = new Address("Ukraine", "Odesa", "Odesa Region", 65000, "Haharina Avenue", "23/5");
Student student = new Student("Terpilovskyi", "Nikita", "Olehovich", new DateTime(2006, 1, 29), studentAddress, "+380663351004", new int[] { 11, 11, 12, 11 }, new int[] { 11, 12 }, new int[] { 10, 11, 12 });

Console.WriteLine("\n");
student.ShowInfo();
Console.WriteLine("\n\n");

// ADDRESS EXCEPTIONS
try
{
    student.address.country = "";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.address.city = "";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.address.region = "";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.address.postalCode = 29012006;
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.address.street = "";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.address.house = "";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}

//STUDENT EXCEPTIONS
try
{
    student.surname = "";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.name = "";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.patronymic = "";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.dateOfBirth = new DateTime(2024, 1, 29);
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.phoneNumber = "+380663";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.homeworkGrades = new int[] { -1, 13 };
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.finalworkGrades = new int[] { -1, -2 };
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    student.examsGrades = new int[] { 11, 12, 13 };
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}

//GROUP EXCEPTIONS
List<Student> errorStudentsArray = new List<Student> { student, student };
try
{
    variable.students = errorStudentsArray;
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    variable.students = new List<Student> { };
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    variable.specialization = "";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    variable.groupName = "";
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}
try
{
    variable.groupNumber = 1331;
}
catch (Exception ex)
{
    Console.WriteLine($"ERROR: {ex}\n");
}

#region Classwork (22.06)
int rows, columns;
Console.Write("Enter number of rows >> ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns >> ");
columns = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[rows, columns];

for (int i = 0; i < rows * columns; i++)
{
    int j = i / columns;
    int k = j % 2 == 0 ? i % columns : columns - 1 - i % columns;
    arr[j, k] = i + 1;
}
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++) Console.Write(arr[i, j] + "\t");
    Console.WriteLine();
}
#endregion

#region Homework (26.06)
Address myAddress = new Address("Ukraine", "Odesa", "Odesa region", 65000, "Gagarina avenue", "23/5");
int[] hwGrades = new int[] { 12, 11, 11, 12, 11 };
int[] fwGrades = new int[] { 12, 11, 11 };
int[] eGrades = new int[] { 12, 12 };
Student me = new Student("Terpilovskyi", "Nikita", "Olehovich", new DateTime(2006, 1, 29), myAddress, "+3806651004", hwGrades, fwGrades, eGrades);
me.ShowInfo();
Console.WriteLine("\n");
me.AddHomeworkGrade(12);
me.AddFinalworkGrade(12);
me.AddExamGrade(12);
me.ShowInfo();
Console.WriteLine("\n");
#endregion

#region Classwork (28.06)
void Add(ref int[] arr)
{
    int[] tmp = new int[arr.Length + 1];
    for (int i = 0; i < arr.Length; i++) tmp[i] = arr[i];
    tmp[tmp.Length - 1] = 5;
    arr = new int[tmp.Length];
    for (int i = 0; i < tmp.Length; i++) arr[i] = tmp[i];
}

int[] nums = { 1, 2, 3, 4, 5 };
for (int i = 0; i < nums.Length; i++) Console.Write(nums[i] + " ");
Console.WriteLine();
Add(ref nums);
for (int i = 0; i < nums.Length; i++) Console.Write(nums[i] + " ");
#endregion */