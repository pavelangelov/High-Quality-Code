using NUnit.Framework;
using Santase;

namespace Santase.Tests
{
    [TestFixture]
    public class DeckTests
    {
       [Test]
        public void CardsLeft_ShouldReturnAllCards_WhenDeckIsInit()
        {
            Deck deck = new Deck();

            Assert.AreEqual(24, deck.CardsLeft);
        }

        [Test]
        public void GetNextCard_ShouldRemoveLastCardOfTheDeck()
        {
            var deck = new Deck();
            var numberOfCards = deck.CardsLeft;

            var nextCard = deck.GetNextCard();

            Assert.IsTrue(numberOfCards != deck.CardsLeft);
        }

        [Test]
        public void GetNextCard_ShouldThrow_IfThereIsNoMoreCards()
        {
            var deck = new Deck();
            var numberOfCards = deck.CardsLeft;

            for (int i = 0; i < numberOfCards; i++)
            {
                deck.GetNextCard();
            }

            Assert.Throws<InternalGameException>(() => deck.GetNextCard());
        }

        [Test]
        public void ChangeTrumpCard_ShouldWorkCorrectly()
        {
            var deck = new Deck();
            var card = deck.GetNextCard();

            deck.ChangeTrumpCard(card);

            Assert.AreEqual(card, deck.TrumpCard);
        }
    }
}
