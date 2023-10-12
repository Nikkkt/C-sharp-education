using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceList
{
    public class DVD : DataStorage
    {
        public double ReadSpeed { get; set; }
        public double WriteSpeed { get; set; }

        public override void Print()
        {
            Console.WriteLine($"DVD:\n" +
                $"  Name: {Name}\n" +
                $"  Manufacturer: {Manufacturer}\n" +
                $"  Model: {Model}\n" +
                $"  Quantity: {Quantity}\n" +
                $"  Price: {Price}\n" +
                $"  Read Speed: {ReadSpeed}\n" +
                $"  Write Speed: {WriteSpeed}");
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter Read Speed: ");
            ReadSpeed = double.Parse(Console.ReadLine());
            Console.Write("Enter Write Speed: ");
            WriteSpeed = double.Parse(Console.ReadLine());
        }
    }
}
