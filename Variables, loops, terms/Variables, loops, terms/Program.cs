#region Classwork (14.06)
Console.Write("Enter circus radius >> ");
double radius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"S = {Math.PI * Math.Pow(radius, 2)}");
Console.WriteLine($"L = {2 * Math.PI * radius}\n");
#endregion

#region Homework (14.06)

#region Task 1
double firstNumber, secondNumber, thirdNumber;
Console.Write("Enter first number >> ");
firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number >> ");
secondNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number >> ");
thirdNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Average = {(firstNumber + secondNumber + thirdNumber) / 3}\n");
#endregion

#region Task 2
double number, degree;
Console.Write("Enter number >> ");
number = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number degree >> ");
degree = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Result = {Math.Pow(number, degree)}\n");
#endregion

#region Task 3
double hrivny, dollars, euro;
Console.Write("Enter amount in hrivnas >> ");
hrivny = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter dollar rate >> ");
dollars = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter euro rate >> ");
euro = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Amount in dollars = {hrivny / dollars} dollars\nAmount in dollars = {hrivny / euro} euro\n");
#endregion

#region Task 4
double kilometers;
Console.Write("Enter kilometers >> ");
kilometers = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Land miles = {kilometers / 1.609}\nNautical miles = {kilometers / 1.852}\n");
#endregion

#region Task 5
double num, percent;
Console.Write("Enter number >> ");
num = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter percent >> ");
percent = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{percent}% from {num} is {num * percent / 100}\n");
#endregion

#region Task 6
double celsius, fahrenheit;
Console.Write("Enter celsius degree >> ");
celsius = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{celsius} celsius in fahrenheit is {(celsius * 1.8) + 32}\n");

Console.Write("Enter fahrenheit degree >> ");
fahrenheit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{fahrenheit} fahrenheits in celsius is {(fahrenheit - 32) * 5 / 9}\n");
#endregion

#endregion

#region Classwork (19.06)

#region ClassTask 1
while (true)
{
    if (Console.KeyAvailable == true)
    {
        ConsoleKeyInfo k = Console.ReadKey(true);
        if (k.KeyChar == '1') Console.BackgroundColor = ConsoleColor.Red;
        else if (k.KeyChar == '2') Console.BackgroundColor = ConsoleColor.Yellow;
        else if (k.KeyChar == '3') Console.BackgroundColor = ConsoleColor.Green;
        else if (k.KeyChar == '9') break;
    }
    else Console.Write(" ");
    Thread.Sleep(15);
}
#endregion

#region ClassTask 2
int steps, counter = 0;
Console.Write("Enter number of steps >> ");
steps = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i < steps; i++)
{
    for (int j = 0; j < counter; j++) Console.Write(" ");
    Console.WriteLine("***");
    for (int j = 0; j < counter; j++) Console.Write(" ");
    Console.WriteLine("  *");
    for (int j = 0; j < counter; j++) Console.Write(" ");
    Console.WriteLine("  *");
    counter += 2;
}
#endregion

#endregion

#region Homework (19.06)
int Number, n = 0, c = 1, pos = 0;
Console.Write("Enter number >> ");
Number = Convert.ToInt32(Console.ReadLine());
int tmp = Number;
while (tmp > 0) {
    n++;
    tmp /= 10;
}
while (n - c >= 0) {
    if ((int)(number / Math.Pow(10, n - c)) % 10 == 0) {
        Console.SetCursorPosition(pos, 2);
        Console.WriteLine(" 000 ");
        Console.SetCursorPosition(pos, 3);
        Console.WriteLine("0   0");
        Console.SetCursorPosition(pos, 4);
        Console.WriteLine("0   0");
        Console.SetCursorPosition(pos, 5);
        Console.WriteLine("0   0");
        Console.SetCursorPosition(pos, 6);
        Console.WriteLine("0   0");
        Console.SetCursorPosition(pos, 7);
        Console.WriteLine("0   0");
        Console.SetCursorPosition(pos, 8);
        Console.WriteLine("0   0");
        Console.SetCursorPosition(pos, 9);
        Console.WriteLine(" 000 ");
    }
    if ((int)(number / Math.Pow(10, n - c)) % 10 == 1) {
        Console.SetCursorPosition(pos, 2);
        Console.WriteLine("  1  ");
        Console.SetCursorPosition(pos, 3);
        Console.WriteLine(" 11  ");
        Console.SetCursorPosition(pos, 4);
        Console.WriteLine("1 1  ");
        Console.SetCursorPosition(pos, 5);
        Console.WriteLine("  1  ");
        Console.SetCursorPosition(pos, 6);
        Console.WriteLine("  1  ");
        Console.SetCursorPosition(pos, 7);
        Console.WriteLine("  1  ");
        Console.SetCursorPosition(pos, 8);
        Console.WriteLine("  1  ");
        Console.SetCursorPosition(pos, 9);
        Console.WriteLine("11111");
    }
    if ((int)(number / Math.Pow(10, n - c)) % 10 == 2) {
        Console.SetCursorPosition(pos, 2);
        Console.WriteLine(" 222 ");
        Console.SetCursorPosition(pos, 3);
        Console.WriteLine("2   2");
        Console.SetCursorPosition(pos, 4);
        Console.WriteLine("    2");
        Console.SetCursorPosition(pos, 5);
        Console.WriteLine("   2 ");
        Console.SetCursorPosition(pos, 6);
        Console.WriteLine("  2  ");
        Console.SetCursorPosition(pos, 7);
        Console.WriteLine("2    ");
        Console.SetCursorPosition(pos, 8);
        Console.WriteLine("2    ");
        Console.SetCursorPosition(pos, 9);
        Console.WriteLine("22222");
    }
    if ((int)(number / Math.Pow(10, n - c)) % 10 == 3) {
        Console.SetCursorPosition(pos, 2);
        Console.WriteLine(" 333 ");
        Console.SetCursorPosition(pos, 3);
        Console.WriteLine("3   3");
        Console.SetCursorPosition(pos, 4);
        Console.WriteLine("    3");
        Console.SetCursorPosition(pos, 5);
        Console.WriteLine("  33 ");
        Console.SetCursorPosition(pos, 6);
        Console.WriteLine("    3");
        Console.SetCursorPosition(pos, 7);
        Console.WriteLine("    3");
        Console.SetCursorPosition(pos, 8);
        Console.WriteLine("3   3");
        Console.SetCursorPosition(pos, 9);
        Console.WriteLine(" 333 ");
    }
    if ((int)(number / Math.Pow(10, n - c)) % 10 == 4) {
        Console.SetCursorPosition(pos, 2);
        Console.WriteLine("   4 ");
        Console.SetCursorPosition(pos, 3);
        Console.WriteLine("  44 ");
        Console.SetCursorPosition(pos, 4);
        Console.WriteLine(" 4 4 ");
        Console.SetCursorPosition(pos, 5);
        Console.WriteLine("4  4 ");
        Console.SetCursorPosition(pos, 6);
        Console.WriteLine("44444");
        Console.SetCursorPosition(pos, 7);
        Console.WriteLine("   4 ");
        Console.SetCursorPosition(pos, 8);
        Console.WriteLine("   4 ");
        Console.SetCursorPosition(pos, 9);
        Console.WriteLine("   4 ");
    }
    if ((int)(number / Math.Pow(10, n - c)) % 10 == 5) {
        Console.SetCursorPosition(pos, 2);
        Console.WriteLine("55555");
        Console.SetCursorPosition(pos, 3);
        Console.WriteLine("5    ");
        Console.SetCursorPosition(pos, 4);
        Console.WriteLine("5    ");
        Console.SetCursorPosition(pos, 5);
        Console.WriteLine("5555 ");
        Console.SetCursorPosition(pos, 6);
        Console.WriteLine("    5");
        Console.SetCursorPosition(pos, 7);
        Console.WriteLine("    5");
        Console.SetCursorPosition(pos, 8);
        Console.WriteLine("5   5");
        Console.SetCursorPosition(pos, 9);
        Console.WriteLine(" 555 ");
    }
    if ((int)(number / Math.Pow(10, n - c)) % 10 == 6) {
        Console.SetCursorPosition(pos, 2);
        Console.WriteLine(" 666 ");
        Console.SetCursorPosition(pos, 3);
        Console.WriteLine("6   6");
        Console.SetCursorPosition(pos, 4);
        Console.WriteLine("6    ");
        Console.SetCursorPosition(pos, 5);
        Console.WriteLine("6 66 ");
        Console.SetCursorPosition(pos, 6);
        Console.WriteLine("66  6");
        Console.SetCursorPosition(pos, 7);
        Console.WriteLine("6   6");
        Console.SetCursorPosition(pos, 8);
        Console.WriteLine("6   6");
        Console.SetCursorPosition(pos, 9);
        Console.WriteLine(" 666 ");
    }
    if ((int)(number / Math.Pow(10, n - c)) % 10 == 7) {
        Console.SetCursorPosition(pos, 2);
        Console.WriteLine("77777");
        Console.SetCursorPosition(pos, 3);
        Console.WriteLine("7   7");
        Console.SetCursorPosition(pos, 4);
        Console.WriteLine("   7 ");
        Console.SetCursorPosition(pos, 5);
        Console.WriteLine("   7 ");
        Console.SetCursorPosition(pos, 6);
        Console.WriteLine("  7  ");
        Console.SetCursorPosition(pos, 7);
        Console.WriteLine("  7  ");
        Console.SetCursorPosition(pos, 8);
        Console.WriteLine(" 7   ");
        Console.SetCursorPosition(pos, 9);
        Console.WriteLine(" 7   ");
    }
    if ((int)(number / Math.Pow(10, n - c)) % 10 == 8) {
        Console.SetCursorPosition(pos, 2);
        Console.WriteLine(" 888 ");
        Console.SetCursorPosition(pos, 3);
        Console.WriteLine("8   8");
        Console.SetCursorPosition(pos, 4);
        Console.WriteLine("8   8");
        Console.SetCursorPosition(pos, 5);
        Console.WriteLine(" 888 ");
        Console.SetCursorPosition(pos, 6);
        Console.WriteLine("8   8");
        Console.SetCursorPosition(pos, 7);
        Console.WriteLine("8   8");
        Console.SetCursorPosition(pos, 8);
        Console.WriteLine("8   8");
        Console.SetCursorPosition(pos, 9);
        Console.WriteLine(" 888 ");
    }
    if ((int)(number / Math.Pow(10, n - c)) % 10 == 9) {
        Console.SetCursorPosition(pos, 2);
        Console.WriteLine(" 999 ");
        Console.SetCursorPosition(pos, 3);
        Console.WriteLine("9   9");
        Console.SetCursorPosition(pos, 4);
        Console.WriteLine("9   9");
        Console.SetCursorPosition(pos, 5);
        Console.WriteLine("9   9");
        Console.SetCursorPosition(pos, 6);
        Console.WriteLine(" 9999");
        Console.SetCursorPosition(pos, 7);
        Console.WriteLine("    9");
        Console.SetCursorPosition(pos, 8);
        Console.WriteLine("9   9");
        Console.SetCursorPosition(pos, 9);
        Console.WriteLine(" 999 ");
    }
    c++;
    pos += 6;
}
#endregion