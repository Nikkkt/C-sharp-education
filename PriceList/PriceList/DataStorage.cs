using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceList
{
    public abstract class DataStorage
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public abstract void Print();
        public virtual void Input()
        {
            Console.Write("Enter Name: ");
            Name = Console.ReadLine();
            Console.Write("Enter Manufacturer: ");
            Manufacturer = Console.ReadLine();
            Console.Write("Enter Model: ");
            Model = Console.ReadLine();
            Console.Write("Enter Quantity: ");
            Quantity = int.Parse(Console.ReadLine());
            Console.Write("Enter Price: ");
            Price = double.Parse(Console.ReadLine());
        }
    }
}
