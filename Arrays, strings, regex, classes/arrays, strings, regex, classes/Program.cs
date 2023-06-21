int rows, columns;
Console.Write("Enter number of rows >> ");
rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number of columns >> ");
columns = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[rows, columns];

for (int i = 0; i < rows * columns; i++) {
    int j = i / columns;
    int k = j % 2 == 0 ? i % columns : columns - 1 - i % columns;
    arr[j, k] = i + 1;
}
for (int i = 0; i < rows; i++) {
    for (int j = 0; j < columns; j++) Console.Write(arr[i, j] + "\t");
    Console.WriteLine();
}