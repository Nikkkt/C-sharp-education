using arrays__strings__regex__classes;

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
#endregion