using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Poker.Tests
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void ToStringTest()
        {
            var card = new Card(CardFace.Ace, CardSuit.Clubs);
            var result = "A♣";

            Assert.AreEqual(result, card.ToString());
        }
    }
}
