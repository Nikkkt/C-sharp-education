using System;
using System.Linq;

namespace Poker
{
    public enum Hand
    {
        Nothing,
        HighCard,
        OnePair,
        TwoPairs,
        ThreeKind,
        Straight,
        Flush,
        FullHouse,
        FourKind
    }

    public struct HandValue
    {
        public int Total { get; set; }
        public int HighCard { get; set; }
        public int SecondHighCard { get; set; }
    }

    class HandEvaluator : Card
    {
        private int heartsSum;
        private int diamondSum;
        private int clubSum;
        private int spadesSum;
        private Card[] cards;
        private HandValue handValue;

        public HandEvaluator(Card[] sortedHand)
        {
            heartsSum = 0;
            diamondSum = 0;
            clubSum = 0;
            spadesSum = 0;
            cards = new Card[7];
            Cards = sortedHand;
            handValue = new HandValue();

            InitializeHandValue();
        }

        public HandValue HandValues
        {
            get { return handValue; }
            set { handValue = value; }
        }

        public Card[] Cards
        {
            get { return cards; }
            set
            {
                for (int i = 0; i < 7; i++)
                {
                    cards[i] = value[i];
                }
            }
        }

        public Hand EvaluateHand()
        {
            getNumberOfSuit();

            if (FourOfKind()) return Hand.FourKind;
            if (FullHouse()) return Hand.FullHouse;
            if (Flush()) return Hand.Flush;
            if (Straight()) return Hand.Straight;
            if (ThreeOfKind()) return Hand.ThreeKind;
            if (TwoPairs()) return Hand.TwoPairs;
            if (OnePair()) return Hand.OnePair;

            return Hand.HighCard;
        }

        private void InitializeHandValue()
        {
            if ((int)cards[0].myValue > (int)cards[1].myValue)
            {
                handValue.HighCard = (int)cards[0].myValue;
                handValue.SecondHighCard = (int)cards[1].myValue;
            }
            else
            {
                handValue.HighCard = (int)cards[1].myValue;
                handValue.SecondHighCard = (int)cards[0].myValue;
            }
        }

        private void getNumberOfSuit()
        {
            foreach (var element in Cards)
            {
                switch (element.mySuit)
                {
                    case Card.Suit.Hearts:
                        heartsSum++;
                        break;
                    case Card.Suit.Diamonds:
                        diamondSum++;
                        break;
                    case Card.Suit.Clubs:
                        clubSum++;
                        break;
                    case Card.Suit.Spades:
                        spadesSum++;
                        break;
                }
            }
        }

        private bool FourOfKind()
        {
            if ((cards[3].myValue == cards[4].myValue && cards[3].myValue == cards[5].myValue && cards[3].myValue == cards[6].myValue) ||
                (cards[1].myValue == cards[2].myValue && cards[1].myValue == cards[3].myValue && cards[1].myValue == cards[4].myValue))
            {
                handValue.Total = (int)cards[1].myValue * 4;
                return true;
            }
            else if (cards[2].myValue == cards[3].myValue && cards[2].myValue == cards[4].myValue && cards[2].myValue == cards[5].myValue)
            {
                handValue.Total = (int)cards[2].myValue * 4;
                return true;
            }
            else if (cards[0].myValue == cards[1].myValue && cards[0].myValue == cards[2].myValue && cards[0].myValue == cards[3].myValue)
            {
                handValue.Total = (int)cards[0].myValue * 4;
                return true;
            }

            return false;
        }

        private bool FullHouse()
        {
            if ((cards[0].myValue == cards[1].myValue && cards[2].myValue == cards[3].myValue && cards[2].myValue == cards[4].myValue) ||
                (cards[0].myValue == cards[1].myValue && cards[1].myValue == cards[2].myValue && cards[3].myValue == cards[4].myValue))
            {
                handValue.Total = (int)(cards[0].myValue) + (int)(cards[1].myValue) + (int)(cards[2].myValue) + (int)(cards[3].myValue) + (int)(cards[4].myValue);
                return true;
            }

            return false;
        }

        private bool Flush()
        {
            if (heartsSum == 5 || diamondSum == 5 || clubSum == 5 || spadesSum == 5)
            {
                handValue.Total = (int)cards[6].myValue;
                return true;
            }

            return false;
        }

        private bool Straight()
        {
            for (int i = 0; i < 3; i++)
            {
                if (cards[i].myValue + 1 == cards[i + 1].myValue &&
                    cards[i + 1].myValue + 1 == cards[i + 2].myValue &&
                    cards[i + 2].myValue + 1 == cards[i + 3].myValue &&
                    cards[i + 3].myValue + 1 == cards[i + 4].myValue)
                {
                    handValue.Total = (int)cards[i + 4].myValue;
                    return true;
                }
            }

            return false;
        }

        private bool ThreeOfKind()
        {
            for (int i = 0; i < 5; i++)
            {
                if (cards[i].myValue == cards[i + 1].myValue && cards[i + 1].myValue == cards[i + 2].myValue)
                {
                    handValue.Total = (int)cards[i].myValue * 3;
                    return true;
                }
            }

            return false;
        }

        private bool TwoPairs()
        {
            if (cards[0].myValue == cards[1].myValue && cards[2].myValue == cards[3].myValue)
            {
                handValue.Total = ((int)cards[0].myValue * 2) + ((int)cards[2].myValue * 2);
                return true;
            }

            if (cards[0].myValue == cards[1].myValue && cards[3].myValue == cards[4].myValue)
            {
                handValue.Total = ((int)cards[0].myValue * 2) + ((int)cards[3].myValue * 2);
                return true;
            }

            if (cards[1].myValue == cards[2].myValue && cards[3].myValue == cards[4].myValue)
            {
                handValue.Total = ((int)cards[1].myValue * 2) + ((int)cards[3].myValue * 2);
                return true;
            }

            return false;
        }

        private bool OnePair()
        {
            for (int i = 0; i < 6; i++)
            {
                if (cards[i].myValue == cards[i + 1].myValue)
                {
                    handValue.Total = (int)cards[i].myValue * 2;
                    return true;
                }
            }

            return false;
        }
    }
}
