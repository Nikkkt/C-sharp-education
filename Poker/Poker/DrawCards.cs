using System;

namespace Poker
{
    class DrawCards
    {
        public static void DrawCardOutline(int xCoor, int yCoor)
        {
            Console.BackgroundColor = ConsoleColor.White;

            int x = xCoor * 12;
            int y = yCoor;

            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write(" __________\n");

            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(x, y + 1 + i);

                if (i != 9)
                {
                    Console.WriteLine("|          |");
                }
                else
                {
                    Console.WriteLine("|__________|");
                }
            }
        }

        public static void DrawCardSuitValue(Card card, int xCoor, int yCoor)
        {
            char cardSuit = ' ';
            int x = xCoor * 12;
            int y = yCoor;

            switch (card.mySuit)
            {
                case Card.Suit.Hearts:
                    cardSuit = '\u2665';
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.Suit.Diamonds:
                    cardSuit = '\u2666';
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case Card.Suit.Clubs:
                    cardSuit = '\u2663';
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
                case Card.Suit.Spades:
                    cardSuit = '\u2660';
                    Console.ForegroundColor = ConsoleColor.Black;
                    break;
            }

            Console.SetCursorPosition(x + 2, y + 2);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 9, y + 2);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 2, y + 9);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 9, y + 9);
            Console.Write(cardSuit);
            Console.SetCursorPosition(x + 4, y + 5);
            Console.Write(card.myValue);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}