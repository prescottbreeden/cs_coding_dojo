using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOfCards
{
    class Player
    {
        private string Name;
        private List<Card> Hand = new List<Card>();
        private const int Size = 5;

        public Player(string name)
        {
            Name = name;
        }

        public void DrawCard(Card card)
        {
            if (Hand.Count < Size)
                Hand.Add(card);
        }
        public void ShowHand()
        {
            foreach (Card card in Hand)
            {
                Console.WriteLine(card); 
            }
        }

        public Card DiscardCard(int index)
        {
            if (index >= Hand.Count)
                return null;
            Card discard = Hand[index];
            Hand.RemoveAt(index);
            return discard;
        }
    }
}
