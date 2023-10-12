using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PriceList
{
    public class functions
    {
        public char GetMenuChoice()
        {
            char ch;
            do
            {
                Console.Clear();
                Console.WriteLine("==========\nMain Menu:\n==========\n1 - Add Device\n2 - Remove Device\n3 - List Devices\n4 - Search Device\n5 - Edit Device");
                Console.Write(">>> ");
                string input = Console.ReadLine();
                ch = input.Length > 0 ? input[0] : ' ';
            } while (!(char.IsDigit(ch) && ch >= '1' && ch <= '5'));
            return ch;
        }

        public char GetSubChoice(string prompt)
        {
            char ch;
            do
            {
                Console.Clear();
                Console.WriteLine(prompt);
                Console.Write(">>> ");
                string input = Console.ReadLine();
                ch = input.Length > 0 ? input[0] : ' ';
            } while (!(char.IsDigit(ch)));
            return ch;
        }
    }
}
