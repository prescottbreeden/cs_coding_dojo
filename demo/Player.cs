using System.Collections.Generic;

namespace demo
{
  class Player
  {
    public string Name { get; set; }
    public List<Card> Hand = new List<Card>();
    public bool IsCheater { get; set; }

    public Player(string name)
    {
       Name = name; 
       if (name == "Yehor")
       {
         IsCheater = true;
       }
       else 
       {
         IsCheater = false;
       }
    }

    public void DrawCard(Deck deck)
    {
      Hand.Add(deck.DealCard());
    } 

    public override string ToString()
    {
      if(IsCheater)
        return $"Player {Name} is a not a Cheater... maybe...";
      else
        return $"Player {Name} is not a Cheater";
    }
  }
}
