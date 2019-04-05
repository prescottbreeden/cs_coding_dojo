using System;
using System.Collections.Generic;

namespace DeckOfCards
{
  class Deck
  {
    public List<Card> cards = new List<Card>();
    private int size = 52;
    string[] suits = { "hearts", "clubs", "diamonds", "spades" };
    string[] faces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };
    int[] values = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };

    public Deck()
    {
      CreateNormalDeck();
    }

    public Card Deal()
    {
      Card deal = cards[0];
      cards.RemoveAt(0);
      return deal;
    }

    public void Rebuild()
    {
      cards.Clear();
      CreateNormalDeck();
    }

    public void Shuffle()
    {
      if (cards.Count < size)
        Rebuild();

      for(int i = 0; i < size; i++)
      {
        Random rand = new Random();        
        int random = rand.Next(size);
        Card temp = cards[i];
        cards[i] = cards[random];
        cards[random] = temp;
      }

    }

    public void CreateNormalDeck()
    {
      int i;
      for(i = 0; i < size; i++)
      {
        Card card = new Card(suits[i%4], faces[i%13], values[i%13]);
        cards.Add(card);
      }
    }

    public void PrintDeck()
    {
      foreach(Card card in cards)
      {
        System.Console.WriteLine(card);
      }
    }

    public override string ToString()
    {
      return $"MaxSize: {size}, CurrentSize: {cards.Count}";
    }
  }
}
