using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceList
{
    public class FlashMemory : DataStorage
    {
        public double MemorySize { get; set; }
        public double UsbSpeed { get; set; }

        public override void Print()
        {
            Console.WriteLine($"Flash Memory:\n" +
                $"  Name: {Name}\n" +
                $"  Manufacturer: {Manufacturer}\n" +
                $"  Model: {Model}\n" +
                $"  Quantity: {Quantity}\n" +
                $"  Price: {Price}\n" +
                $"  Memory Size: {MemorySize}\n" +
                $"  USB Speed: {UsbSpeed}");
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter Memory Size: ");
            MemorySize = double.Parse(Console.ReadLine());
            Console.Write("Enter USB Speed: ");
            UsbSpeed = double.Parse(Console.ReadLine());
        }
    }
}
