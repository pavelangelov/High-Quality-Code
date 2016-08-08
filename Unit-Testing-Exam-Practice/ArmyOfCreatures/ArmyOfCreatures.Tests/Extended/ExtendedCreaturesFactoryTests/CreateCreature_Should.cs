using System;
using NUnit.Framework;
using ArmyOfCreatures.Extended;

namespace ArmyOfCreatures.Tests.Extended.ExtendedCreaturesFactoryTests
{
    [TestFixture]
    public class CreateCreature_Should
    {
        [Test]
        public void ThrowArgumentExceptionWithMessageThatContainsTheString_InvalidCreatureType()
        {
            // Arrange
            var msg = "Invalid creature type";
            var extendedCreatureFc = new ExtendedCreaturesFactory();

            // Act
            string throwedMsg = String.Empty;
            try
            {
                extendedCreatureFc.CreateCreature("invalid string");
            }
            catch (ArgumentException ex)
            {
                throwedMsg = ex.Message;
            }

            // Assert
            Assert.IsTrue(throwedMsg.Contains(msg));
        }

        [Test]
        [TestCase("AncientBehemoth")]
        [TestCase("CyclopsKing")]
        [TestCase("Goblin")]
        [TestCase("Griffin")]
        [TestCase("WolfRaider")]
        [TestCase("Angel")]
        public void ReturnTheCorrespondingCreatureType_BasedOnTheStringThatIsPassed(string creatureTypeStr)
        {
            // Arrange
            var extendedCreatureFc = new ExtendedCreaturesFactory();

            // Act
            var creature = extendedCreatureFc.CreateCreature(creatureTypeStr);

            // Assert
            Assert.AreEqual(creatureTypeStr, creature.GetType().Name);
        }
    }
}
