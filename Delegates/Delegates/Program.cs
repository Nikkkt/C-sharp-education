using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public delegate bool Comparer(object obj1, object obj2);

    static class Sorter
    {
        static public void BubbleSort(object[] array, Comparer del)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (del(array[j], array[i]))
                    {
                        object temporary = array[i];
                        array[i] = array[j];
                        array[j] = temporary;
                    }
                }
            }
        }
    }

    public class Person
    {
        public string FirstName;
        public string LastName;
        public DateTime Birthday;

        public Person(string FirstName, string LastName, DateTime Birthday)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
        }

        public override string ToString()
        {
            return string.Format(
                "FirstName: {0, -10} LastName: {1, -12} Birthday: {2:dd.MM.yyyy}.",
                FirstName, LastName, Birthday);
        }
    }

    static public bool PersonBirthdayComparer(object o1, object o2)
    {
        Person left = o1 as Person;
        Person right = o2 as Person;

        if (left == null || right == null)
            throw new Exception("some invalid object types: "
                + o1.GetType() + "    " + o2.GetType());

        return ((Person)o1).Birthday.CompareTo(((Person)o2).Birthday) < 0;
    }

    //object[] persons = {
    //     new Person("Вячеслав", "Арцыбашев", new DateTime(1996, 1, 1)),
    //     new Person("Максим", "Бойко", new DateTime(1992, 11, 6)),
    //     new Person("Алексей", "Вербицкий", new DateTime(1991, 5, 11)),
    //     new Person("Святослав", "Георгиев", new DateTime(1990, 10, 8)),
    //     new Person("Андрей", "Громанчук", new DateTime(1989, 6, 14)),
    //     new Person("Владислав", "Кобзар", new DateTime(1984, 10, 8))

    //};

    //Console.WriteLine("Группа:\n");
    //foreach (object person in persons) Console.WriteLine(person);

    //Console.WriteLine("\nПосле сортировки:\n");
    //Sorter.BubbleSort(persons, PersonBirthdayComparer);
    //foreach (object person in persons) Console.WriteLine(person);

    //Console.WriteLine("\n");

    delegate bool LambdaRange(int number);
    delegate bool LambdaIndex(int index);

    static int PracticeRange(int[] arr, LambdaRange filter)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++) if (filter(arr[i])) sum += arr[i];
        return sum;
    }

    static int PracticeIndex(int[] arr, LambdaIndex filter)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++) if (filter(i)) sum += arr[i];
        return sum;
    }

    static void Main()
    {
        int[] array = new int[10];
        for (int i = 0; i < array.Length; i++) array[i] = new Random().Next(1, 400);
        foreach (int number in array) Console.Write($"{number} ");

        LambdaRange filter1 = x => x >= 100 && x <= 999;
        LambdaIndex filter2 = x => x % 2 == 0;
        LambdaIndex filter3 = x => x % 3 == 0;

        Console.WriteLine("\n\nx >= 100 && x <= 999 : " + PracticeRange(array, filter1));
        Console.WriteLine("x % 2 == 0 : " + PracticeIndex(array, filter2));
        Console.WriteLine("x % 3 == 0 : " + PracticeIndex(array, filter3));
    }
}