namespace deck_of_cards
{
  class Card
  {
    private string Suit;
    private string Face;
    private int Value;

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
