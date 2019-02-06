using System;
using System.Collections.Generic;

namespace deck_of_cards
{
  class Deck
  {
    private List<Card> Cards;
    private string[] Suits = { "clubs", "spades", "diamonds", "hearts" };
    private string[] Faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
    private int[] Values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

    public Deck()
    {
      Cards = BuildDeck();
    }

    private List<Card> BuildDeck()
    {
      List<Card> newCards = new List<Card>();
      for (int i = 0; i < 52; i++)
      {
        newCards.Add(new Card(
            Suits[i % 4],
            Faces[i % 13],
            Values[i % 13]
        ));
      }
      return newCards;
    }

    public void ShuffleDeck()
    {
      Random rand = new Random();
      for(int i = 0; i < Cards.Count; i++)
      {
        int random = rand.Next(Cards.Count);
        Card temp = Cards[i];
        Cards[i] = Cards[random];
        Cards[random] = temp;
      }
    }

    public void PrintDeck()
    {
      foreach (Card card in Cards)
      {
        System.Console.WriteLine(card);
      }
    }
  }
}
