using System;
using System.Linq;

namespace Poker
{
    class DeckOfCards : Card
    {
        const int NumberOfCards = 52;
        private Card[] Deck;

        public DeckOfCards() { Deck = new Card[NumberOfCards]; }
        public Card[] GetDeck { get { return Deck; } }

        public void SetupDeck()
        {
            int i = 0;
            foreach (Suit s in Enum.GetValues(typeof(Suit)))
            {
                foreach (Value v in Enum.GetValues(typeof(Value)))
                {
                    Deck[i] = new Card { mySuit = s, myValue = v };
                    i++;
                }
            }
            ShuffleCards();
        }

        public void ShuffleCards()
        {
            Random rand = new Random();
            Card temp;
            for (int shuffle = 0; shuffle < 1000; shuffle++)
            {
                for (int i = 0; i < NumberOfCards; i++)
                {
                    int SecondCardIndex = rand.Next(13);
                    temp = Deck[i];
                    Deck[i] = Deck[SecondCardIndex];
                    Deck[SecondCardIndex] = temp;
                }
            }
        }
    }
}