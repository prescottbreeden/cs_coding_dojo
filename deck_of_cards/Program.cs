using System;

namespace deck_of_cards
{
  class Program
  {
    static void Main(string[] args)
    {
      Deck gameDeck = new Deck();
      gameDeck.ShuffleDeck();
      gameDeck.PrintDeck();
    }
  }
}
