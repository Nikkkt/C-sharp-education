#region Classwork
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