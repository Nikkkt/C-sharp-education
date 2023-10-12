using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceList
{
    public class HDD : DataStorage
    {
        public double DiskSize { get; set; }
        public double UsbSpeed { get; set; }

        public override void Print()
        {
            Console.WriteLine($"HDD:\n" +
                $"  Name: {Name}\n" +
                $"  Manufacturer: {Manufacturer}\n" +
                $"  Model: {Model}\n" +
                $"  Quantity: {Quantity}\n" +
                $"  Price: {Price}\n" +
                $"  Disk Size: {DiskSize}\n" +
                $"  USB Speed: {UsbSpeed}");
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Enter Disk Size: ");
            DiskSize = double.Parse(Console.ReadLine());
            Console.Write("Enter USB Speed: ");
            UsbSpeed = double.Parse(Console.ReadLine());
        }
    }
}
