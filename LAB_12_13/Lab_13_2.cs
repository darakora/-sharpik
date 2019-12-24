using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_12_13
{
    enum CardSuit
    {
        Clubs,
        Spackes,
        Hearts,
        Diamonds
    }

    enum CardValues
    {
        Valet = 10,
        King,
        Dama,
        Tuz
    }

    class IncorrectCardNumberExeption : Exception
    {
        public IncorrectCardNumberExeption() : base() { }
    }

    class Card
    {
        public CardSuit Suit { get; private set; }

        private int number;
        public int Number
        {
            get => number;
            set
            {
                if (value < 2 && value > 13)
                {
                    throw new IncorrectCardNumberExeption();
                }
                number = value;
            }
        }

        public Card(CardSuit suit, int number)
        {
            this.Suit = suit;
            this.Number = number;
        }

        public override string ToString()
        {
            return (number < 10 ? number.ToString() : Enum.GetName(typeof(CardValues), number)) + " " + Suit;
        }
    }

    class CardDeck
    {
        private List<Card> cards;

        public CardDeck()
        {
            this.cards = new List<Card>();
            GenerateCards();
            foreach (var item in cards)
            {
                Console.WriteLine(item);
            }
        }

        private void GenerateBySuite(CardSuit suit)
        {
            for (int i = 2; i <= 13; ++i)
            {
                cards.Add(new Card(suit, i));
            }
        }

        private void GenerateCards()
        {
            for(int i = 0; i < 4;  ++i)
            {
                GenerateBySuite((CardSuit)i);
            }
        }

        public void MixCards()
        {
            cards = cards.OrderBy(a => Guid.NewGuid()).ToList();
        }

        public Card GetOne()
        {
            Random rand = new Random();
            return cards[rand.Next(0, cards.Count)];
        }

        public List<Card> GetSix()
        {
            Random rand = new Random();
            List<Card> res = new List<Card>();
            for(int i = 1; i <= 6; ++i)
            {
                res.Add(cards[rand.Next(0, cards.Count)]);
            }
            return res;
        }
    }

}
