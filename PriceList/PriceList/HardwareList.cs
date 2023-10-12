using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceList
{
    public class HardwareList
    {
        public List<DataStorage> DevicesList { get; }

        public HardwareList() { DevicesList = new List<DataStorage>(); }

        public void Add(DataStorage storage) { DevicesList.Add(storage); }

        public void RemoveAt(int index) { if (index >= 0 && index < DevicesList.Count) DevicesList.RemoveAt(index); }

        public void Print() { foreach (var device in DevicesList) device.Print(); }

        public void Edit(int index)
        {
            if (index >= 0 && index < DevicesList.Count)
            {
                var device = DevicesList[index];
                char option;

                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter characteristic to edit:\n" + "1 - Name\n" + "2 - Manufacturer\n" + "3 - Model\n" + "4 - Quantity\n" + "5 - Price\n");
                    Console.Write(">>> ");

                    string input = Console.ReadLine();
                    option = input.Length > 0 ? input[0] : ' ';

                } while (!(char.IsDigit(option) && option >= '1' && option <= '5'));

                if (option == '1')
                {
                    Console.WriteLine("Enter a new Name:\n");
                    Console.Write(">>> ");
                    string newName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newName)) device.Name = newName;
                }
                else if (option == '2')
                {
                    Console.WriteLine("Enter a new Manufacturer:\n");
                    Console.Write(">>> ");
                    string newManufacturer = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newManufacturer)) device.Manufacturer = newManufacturer;
                }
                else if (option == '3')
                {
                    Console.WriteLine("Enter a new Model:\n");
                    Console.Write(">>> ");
                    string newModel = Console.ReadLine();
                    if (!string.IsNullOrEmpty(newModel)) device.Model = newModel;
                }
                else if (option == '4')
                {
                    Console.WriteLine("Enter a new Quantity:\n");
                    Console.Write(">>> ");
                    string newQuantity = Console.ReadLine();
                    if (int.TryParse(newQuantity, out int quantity)) device.Quantity = quantity;
                }
                else if (option == '5')
                {
                    Console.WriteLine("Enter a new Price:\n");
                    Console.Write(">>> ");
                    string newPrice = Console.ReadLine();
                    if (double.TryParse(newPrice, out double price)) device.Price = price;
                }

                Console.WriteLine("Successfully modified!");
                Thread.Sleep(1000);
            }
        }

        public List<DataStorage> FindAll(Predicate<DataStorage> match) { return DevicesList.FindAll(match); }
    }
}
