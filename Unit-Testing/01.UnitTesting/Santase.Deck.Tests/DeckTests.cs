using NUnit.Framework;
using Santase;

namespace Santase.Tests
{
    [TestFixture]
    public class DeckTests
    {
       [Test]
        public void TestMethod1()
        {
            Deck deck = new Deck();

            Assert.AreEqual(24, deck.CardsLeft);
        }
    }
}
