using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
        private List<Card> Cards = new List<Card>();
        private const int Size = 52;
        private string[] Faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "jack", "queen", "king", "ace" };
        private string[] Suits = { "hearts", "clubs", "spades", "diamonds" };
        private int[] Values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

        public Deck()
        {
            for (int i = 0; i < Size; i++)
            {
                Cards.Add(new Card(Suits[i / 13], Faces[i % 13], Values[i % 13]));
            }
            this.ShuffleDeck();
        }

        public void Print()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine(card);
            }
        }

        public void ShuffleDeck()
        {
            for (int i = 0; i < Size; i++)
            {
                Random rand = new Random();
                int idx = rand.Next(Size);
                Card temp = Cards[i];
                Cards[i] = Cards[idx];
                Cards[idx] = temp;
            }
        }

        public Card Deal()
        {
            Card deal = Cards[0];
            Cards.RemoveAt(0);
            return deal;
        }

        public void Reset()
        {
            Cards.Clear();
            Deck reshuffle = new Deck();
            Cards = reshuffle.Cards;
        }

    }
}
