using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            var suitIcons = new string[]
            {
                "♣",
                "♦",
                "♥",
                "♠"
            };
            var suit = suitIcons[((int)this.Suit) - 1];
            var face = CardFace((int)this.Face);

            return face + suit;
        }

        private string CardFace(int faceNumber)
        {
            var result = "";
            if (faceNumber <= 10)
            {
                result += faceNumber;
            } else
            {
                switch(faceNumber)
                {
                    case 11: result += "J"; break;
                    case 12: result += "Q"; break;
                    case 13: result += "K"; break;
                    case 14: result += "A"; break;
                }
            }

            return result;
        }
    }
}