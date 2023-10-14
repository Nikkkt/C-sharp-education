using System.Text;
using Enum__struct;
Console.OutputEncoding = Encoding.UTF8;

List<Item> items = new List<Item>();
items.Add(new Item("Банан", 15.4, 3));
items.Add(new Item("Мівіна", 12.5, 2));
items.Add(new Item("Рево", 51, 1));

Check check = new Check("Україна", "АТБ", "Одеса", "Маршала Говорова 5а", items, 6, "Володимир Олександрович", "UNIVERSAL BANK");
check.PrintCheck();