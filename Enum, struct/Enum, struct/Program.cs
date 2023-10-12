using Microsoft.VisualBasic;

class Program
{
    enum Anniversary
    {
        Paper = 1,
        Cotton = 2,
        Leather = 3,
        Flowers = 4,
        Wooden = 5,
        Candy = 6,
        Copper = 7,
        Bronze = 8,
        Pottery = 9,
        Tin = 10,
        Steel = 11,
        Silk = 12,
        Lace = 13,
        Ivory = 14,
        Crystal = 15,
        China = 20,
        Silver = 25,
        Pearl = 30,
        Coral = 35,
        Ruby = 40,
        Sapphire = 45,
        Golden = 50,
        Emerald = 55,
        Diamond = 60,
        BlueSapphire = 65,
        Platinum = 70,
        Oak = 80
    }
    static void Main()
    {
        Console.WriteLine(Enum.GetNames(typeof(Anniversary))[new Random().Next(Enum.GetNames(typeof(Anniversary)).Length)]);
    }
}