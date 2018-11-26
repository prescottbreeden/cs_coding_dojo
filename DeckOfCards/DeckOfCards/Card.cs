namespace DeckOfCards
{
    class Card
    {
        private string Suit;
        private string Face;
        private int Value;

        public Card(string suit, string face, int val)
        {
            Suit = suit;
            Face = face;
            Value = val;
        }

        public override string ToString()
        {
            return $"Suit: {Suit}, Face: {Face}, Value: {Value}";
        }
    }
}
