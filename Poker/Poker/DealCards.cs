using System;
using System.Linq;

namespace Poker
{
    class DealCards : DeckOfCards
    {
        private Card[] PlayerHand;
        private Card[] ComputerHand;
        private Card[] SortedPlayerHand;
        private Card[] SortedComputerHand;
        private Card[] FlopHand;
        public Card[] FirstPlayerHand;
        public Card[] FirstComputerHand;

        public DealCards()
        {
            FlopHand = new Card[5];
            PlayerHand = new Card[7];
            FirstPlayerHand = new Card[2];
            SortedPlayerHand = new Card[7];
            ComputerHand = new Card[7];
            FirstComputerHand = new Card[2];
            SortedComputerHand = new Card[7];
        }
        public void Deal()
        {
            SetupDeck();
            GetHand();
            SortCards();
            DisplayCards();
            EvaluateHands();
        }
        public void GetHand()
        {
            for (int i = 0; i < 2; i++)
                PlayerHand[i] = GetDeck[i];

            for (int i = 2; i < 4; i++)
                ComputerHand[i - 2] = GetDeck[i];

            for (int i = 4; i < 9; i++)
                FlopHand[i - 4] = GetDeck[i];

            FirstPlayerHand = PlayerHand;
            FirstComputerHand = ComputerHand;
            FlopHand.CopyTo(PlayerHand, 2);
            FlopHand.CopyTo(ComputerHand, 2);
        }
        public void SortCards()
        {
            var QueryPlayer = from hand in PlayerHand
                              orderby hand.myValue
                              select hand;

            var QueryComputer = from hand in ComputerHand
                                orderby hand.myValue
                                select hand;

            var index = 0;

            foreach (var element in QueryPlayer.ToList())
            {
                SortedPlayerHand[index] = element;
                index++;
            }
            index = 0;
            foreach (var element in QueryComputer.ToList())
            {
                SortedComputerHand[index] = element;
                index++;
            }
        }
        public void DisplayCards()
        {
            Console.Clear();
            int x = 0;
            int y = 1;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Players hand");
            for (int i = 0; i < 2; i++)
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(PlayerHand[i], x, y);
                x++;
            }

            y = 15;
            x = 0;

            Console.SetCursorPosition(x, 14);
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("Flop");
            for (int i = 0; i < 5; i++)
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(FlopHand[i], x, y);
                x++;
            }

            y = 29;
            x = 0;

            Console.SetCursorPosition(x, 28);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Computers hand");
            for (int i = 0; i < 2; i++)
            {
                DrawCards.DrawCardOutline(x, y);
                DrawCards.DrawCardSuitValue(ComputerHand[i], x, y);
                x++;
            }
        }
        public void EvaluateHands()
        {
            HandEvaluator firstPlayerHandEvaluator = new HandEvaluator(FirstPlayerHand);
            HandEvaluator firstComputerHandEvaluator = new HandEvaluator(FirstComputerHand);
            Hand playerHighCard = firstPlayerHandEvaluator.EvaluateHand();
            Hand computerHighCard = firstComputerHandEvaluator.EvaluateHand();

            HandEvaluator playerHandEvaluator = new HandEvaluator(SortedPlayerHand);
            HandEvaluator computerHandEvaluator = new HandEvaluator(SortedComputerHand);

            Hand playerHand = playerHandEvaluator.EvaluateHand();
            Hand computerHand = computerHandEvaluator.EvaluateHand();

            Console.WriteLine("\n\n\n\n\n\n\n\nPlayer's Hand: " + playerHand);
            Console.WriteLine("\nComputer's Hand: " + computerHand);

            if (playerHand > computerHand)
            {
                Console.WriteLine("Player WINS!");
            }
            else if (playerHand < computerHand)
            {
                Console.WriteLine("Computer WINS!");
            }
            else
            {
                if (playerHandEvaluator.HandValues.Total > computerHandEvaluator.HandValues.Total)
                    Console.WriteLine("Player WINS!");
                else if (playerHandEvaluator.HandValues.Total < computerHandEvaluator.HandValues.Total)
                    Console.WriteLine("Computer WINS!");
                else if (firstPlayerHandEvaluator.HandValues.HighCard > firstComputerHandEvaluator.HandValues.HighCard)
                    Console.WriteLine("Player WINS!");
                else if (firstPlayerHandEvaluator.HandValues.HighCard < firstComputerHandEvaluator.HandValues.HighCard)
                    Console.WriteLine("Computer WINS!");
                else if (firstPlayerHandEvaluator.HandValues.SecondHighCard > firstComputerHandEvaluator.HandValues.SecondHighCard)
                    Console.WriteLine("Player WINS!");
                else if (firstPlayerHandEvaluator.HandValues.SecondHighCard < firstComputerHandEvaluator.HandValues.SecondHighCard)
                    Console.WriteLine("Computer WINS!");
                else
                    Console.WriteLine("DRAW, everyone's a winner!");
            }
        }
    }
}
