using System;
using System.Collections.Generic;
using PriceList;

functions functions = new functions(); 
HardwareList devicesList = new HardwareList();

while (true) {

    char choice = functions.GetMenuChoice();

    if (choice == '1')
    {
        char subChoice1 = functions.GetSubChoice("Choose device type:\n\n1 - Flash Memory.\n2 - HDD.\n3 - DVD.\n");

        if (subChoice1 >= '1' && subChoice1 <= '3')
        {
            DataStorage device;
            if (subChoice1 == '1') device = new FlashMemory();
            else if (subChoice1 == '2') device = new HDD();
            else if (subChoice1 == '3') device = new DVD();
            else device = null;

            if (device != null)
            {
                device.Input();
                devicesList.Add(device);
                Console.WriteLine("\nAdded!");
                Thread.Sleep(1000);
            }
        }
    }
    else if (choice == '2')
    {
        char subChoice2 = functions.GetSubChoice("Choose device to delete:\n\n0 - Return back.\n");

        if (subChoice2 != '0')
        {
            int indexToDelete = int.Parse(subChoice2.ToString()) - 1;
            if (indexToDelete >= 0 && indexToDelete < devicesList.DevicesList.Count)
            {
                devicesList.RemoveAt(indexToDelete);
                Console.WriteLine("\nRemoved!");
                Thread.Sleep(1000);
            }
        }
    }
    else if (choice == '3')
    {
        if (devicesList.DevicesList.Count >= 1)
        {
            Console.Clear();
            Console.WriteLine("Devices:\n");
            devicesList.Print();
            Console.WriteLine("\nEnter any integer number to go back.");
            Console.Write(">>> ");
            int ch3 = int.Parse(Console.ReadLine());
        }
        else
        {
            Console.WriteLine("There are no devices in the list");
            Thread.Sleep(1000);
        }
    }
    else if (choice == '4')
    {
        char subChoice4 = functions.GetSubChoice("Search by:\n1 - Name\n2 - Manufacturer\n3 - Model\n0 - Return back\n");

        if (subChoice4 != '0')
        {
            Console.WriteLine("\nEnter search query:\n");
            Console.Write(">>> ");
            string query = Console.ReadLine();
            List<DataStorage> found = new List<DataStorage>();

            if (subChoice4 == '1') found = devicesList.FindAll(x => x.Name.ToLower() == query.ToLower());
            else if (subChoice4 == '2') found = devicesList.FindAll(x => x.Manufacturer.ToLower() == query.ToLower());
            else if (subChoice4 == '3') found = devicesList.FindAll(x => x.Model.ToLower() == query.ToLower());
            else if (subChoice4 == '0') found = new List<DataStorage>();
            else found = new List<DataStorage>();

            if (found.Count > 0)
            {
                Console.WriteLine("\nFound:\n");
                foreach (var device in found) device.Print();

                Console.WriteLine("\nEnter any char to go back.");
                Console.Write(">>> ");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Device not found");
                Thread.Sleep(3000);
            }
        }
    }
    else if (choice == '5')
    {
        char subChoice5 = functions.GetSubChoice("Choose device to edit:\n0 - Return back.\n");

        if (subChoice5 != '0')
        {
            int indexToEdit = int.Parse(subChoice5.ToString()) - 1;
            if (indexToEdit >= 0 && indexToEdit < devicesList.DevicesList.Count) devicesList.Edit(indexToEdit);
        }
    }
}