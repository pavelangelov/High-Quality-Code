using System;
using NUnit.Framework;
using ArmyOfCreatures.Logic.Battles;

namespace ArmyOfCreatures.Tests.Logic.Battles.CreatureIdentifierTests
{
    [TestFixture]
    public class ToString_Should
    {
        [Test]
        public void OutputExpectedResult()
        {
            // Arrange
            var expectedResult = "Angel(2)";
            var identifier = CreatureIdentifier.CreatureIdentifierFromString(expectedResult);

            // Assert
            Assert.AreEqual(expectedResult, identifier.ToString());
        }
    }
}
