namespace DeckOfCards
{
  class Card
  {
    public string Suit { get; set; }
    public string Face { get; set; }
    public int Value { get; set; }

    public Card(string suit, string face, int value)
    {
      Suit = suit;
      Face = face;
      Value = value;
    }

    public override string ToString() 
    {
      return $"{Face} of {Suit}";
    }
  }
}
