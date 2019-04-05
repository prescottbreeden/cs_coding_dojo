using System.Collections.Generic;

namespace DeckOfCards
{
// Give the Player a draw method of which draws a card from a deck, adds it to the player's hand and returns the Card.
// Give the Player a discard method which discards the Card at the specified index from the player's hand and returns this Card or null if the index does not exist.
  class Player
  {
    public string Name { get; set; }
    public List<Card> Hand { get; set; } = new List<Card>(3);

    public Player(string name)
    {
      Name = name;
    }

    public void DrawCard(Deck deck)
    {
      Hand.Add(deck.Deal());
    }
    
  }
}
