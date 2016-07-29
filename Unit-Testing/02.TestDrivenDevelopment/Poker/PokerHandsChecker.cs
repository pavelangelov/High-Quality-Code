using System;
using System.Linq;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            var cards = hand.Cards;
            for (int i = 0; i < cards.Count; i++)
            {
                var currentCard = cards[i];
                for (int j = i + 1; j < cards.Count; j++)
                {
                    if (currentCard.Face == cards[j].Face && currentCard.Suit == cards[j].Suit)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFourOfAKind(IHand hand)
        {
            var counter = 0;
            var cards = hand.Cards.GroupBy(x => x.Face);

            foreach (var group in cards)
            {
                if (group.Count() == 4)
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            var cards = hand.Cards;
            var firstCardSuit = cards[0].Suit;
            var hasFlush = cards.All(x => x.Suit == firstCardSuit);

            return hasFlush;

        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            throw new NotImplementedException();
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}