using System;

namespace demo
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Deck gameDeck = new Deck();
      gameDeck.ShuffleDeck();
      gameDeck.PrintDeck();
      Player yehor = new Player("Yehor");
      System.Console.WriteLine(yehor);
      yehor.DrawCard(gameDeck);
      System.Console.WriteLine(yehor.Hand[0]);
    }
  }
}
