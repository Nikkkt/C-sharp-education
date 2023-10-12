using System;
using System.Threading;

public class MyEventArgs
{
    public string Text { get; private set; }
    public string PersonName { get; private set; }

    public MyEventArgs(string personName, string text)
    {
        PersonName = personName;
        Text = text;
    }
}

class Program
{
    public class Person
    {
        public delegate void Del(object sender, MyEventArgs e);

        public event Del WorkEnded;

        public string FirstName;
        public string LastName;
        public string Birthday;

        public Person(string firstName, string lastName, string birthday)
        {
            FirstName = firstName;
            LastName = lastName;
            Birthday = birthday;
        }

        public void Work()
        {
            Console.WriteLine(FirstName + " " + LastName + " размахивает лазерным мечом...");
            Thread.Sleep(1000);
            if (WorkEnded != null)
                WorkEnded(this, new MyEventArgs(FirstName + " " + LastName, "Люк, я твой отец! )))"));
        }
    }

    static void Main(string[] args)
    {
        Person person = new Person("Дарт", "Вейдер", "4 мая 42 года до битвы у Явина");
        person.WorkEnded += Person_WorkEnded;
        person.Work();
    }

    static void Person_WorkEnded(object sender, MyEventArgs e)
    {
        var tmp = sender as Person;
        Console.WriteLine(tmp.FirstName + " " + tmp.LastName + " finished work: " + e.Text);
    }
}
