using System;
using System.Collections.Generic;

namespace demo
{
  class Deck
  {
    public string[] Faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
    public string[] Suits = { "clubs", "spades", "diamonds", "hearts" };
    public int[] Values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
    public int Size = 52;
    public List<Card> Cards;

    public Deck()
    {
      Cards = BuildDeck();        
    }

    private List<Card> BuildDeck()
    {
      List<Card> newDeck = new List<Card>();
      for(int i = 0; i < Size; i++)
      {
        Card newCard = new Card(
          Faces[i%13],
          Suits[i%4],
          Values[i%13]
        );
        newDeck.Add(newCard);
      }
      return newDeck;
    }

    public void ResetDeck()
    {
      Cards = BuildDeck();
    }

    public void PrintDeck()
    {
      foreach(Card card in Cards)
      {
        System.Console.WriteLine(card);
      }
    }

    public void ShuffleDeck()
    {
      Random rand = new Random();
      for(int i = 0; i < Size; i++)
      {
        Card temp = Cards[i];    
        int random = rand.Next(Size);
        Cards[i] = Cards[random];
        Cards[random] = temp;
      }
    }

    public Card DealCard()
    {
      Card deal = Cards[0];
      Cards.RemoveAt(0);
      return deal;
    }
  }
}
