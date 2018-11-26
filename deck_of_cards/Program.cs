using System;
using System.Collections.Generic;

namespace deck_of_cards
{

  class Deck
  {
    List<Card> Cards = new List<Card>();
    private const int Size = 52;

    public Deck()
    {
      int count = 0;
      int value = 1;
      while (count < Size)
      {
       count++;
       value++; 
       value % 13;
      }
       for (int i = 1; i <= Size; i++)
       {
          Cards.Add(i % 13)  
       }
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }
}
