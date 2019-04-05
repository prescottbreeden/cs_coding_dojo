using System;

namespace DeckOfCards
{
  class Program
  {
    static void Main(string[] args)
    {
      Player sam = new Player("Sam");
      Player haytham = new Player("Haytham");
      Deck deck = new Deck();
      System.Console.WriteLine(deck);
      deck.Shuffle();
      sam.DrawCard(deck);
      haytham.DrawCard(deck);
      System.Console.WriteLine(sam.Hand[0]);
      System.Console.WriteLine(haytham.Hand[0]);
      System.Console.WriteLine(deck);
    }
  }
}
