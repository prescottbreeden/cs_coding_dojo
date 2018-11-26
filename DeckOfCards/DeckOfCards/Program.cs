using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Player("Bob");
            var deck = new Deck();
            bob.DrawCard(deck.Deal());
            bob.DrawCard(deck.Deal());
            bob.DrawCard(deck.Deal());
            bob.DrawCard(deck.Deal());
            bob.ShowHand();
            bob.DiscardCard(0);
            bob.DiscardCard(0);
            bob.DiscardCard(0);
            bob.DiscardCard(0);
            bob.DiscardCard(0);
            bob.DiscardCard(0);
            bob.ShowHand();
        }
    }
}
