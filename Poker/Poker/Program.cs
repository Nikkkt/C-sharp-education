using System;

namespace Poker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.SetWindowSize(130, 100);
            Console.BufferWidth = 65;
            Console.BufferHeight = 50;
            Console.Title = "Poker Simulator";
            DealCards dc = new DealCards();
            bool quit = false;

            while (!quit)
            {
                dc.Deal();
                int x = 0, y = 0;
                Console.SetCursorPosition(x, y);

                char selection = ' ';
                while (selection != 'Y' && selection != 'N')
                {
                    Console.SetCursorPosition(0, 48);
                    Console.WriteLine("Play again? (Y)es or (N)o");
                    selection = char.ToUpper(Console.ReadKey().KeyChar);

                    if (selection == 'Y')
                        quit = false;
                    else if (selection == 'N')
                        quit = true;
                    else
                        Console.WriteLine("Invalid input, try again.");
                }
            }
        }
    }
}
