using System;

namespace Poker
{
    public class Card
    {
        public enum Value { Two = 2, Three, Four, Five, Six, Seven, Eight, Nine, Ten, Jack, Queen, King, Ace }

        public enum Suit { Hearts, Spades, Diamonds, Clubs }

        public Value myValue { get; set; }
        public Suit mySuit { get; set; }
    }
}
