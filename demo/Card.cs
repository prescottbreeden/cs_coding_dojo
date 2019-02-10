namespace demo
{
  class Card
  {
    public string Face { get; set; }
    public string Suit { get; set; }
    public int Value { get; set; }

    public Card(string face, string suit, int val)
    {
      Face = face;
      Suit = suit;
      Value = val;
    }

    public override string ToString()
    {
      return $"{Face} of {Suit}";
    }

  }
}
