using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_world {
    internal class main {
        static void Main(string[] args) {
            Console.Write("Enter message >> ");
            string message = Console.ReadLine();
            Console.WriteLine($"Message: \"{message}\"");
        }
    }
}