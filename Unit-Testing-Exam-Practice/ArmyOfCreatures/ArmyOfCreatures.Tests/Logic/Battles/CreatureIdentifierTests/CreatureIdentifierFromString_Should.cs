using System;
using NUnit.Framework;
using ArmyOfCreatures.Logic.Battles;

namespace ArmyOfCreatures.Tests.Logic.Battles.CreatureIdentifierTests
{
    [TestFixture]
    public class CreatureIdentifierFromString_Should
    {
        [Test]
        public void ThrowArgumentNullException_IfValueToParseIsNull()
        {
            // Arrange & Act & Assert
            Assert.Throws<ArgumentNullException>(() => CreatureIdentifier.CreatureIdentifierFromString(null));
        }

        [Test]
        public void ThrowFormatException_IfArmyNumberIsInvalid()
        {
            // Arrange 
            var invalidArmyNumber = "(test)";

            // Act & Assert
            Assert.Throws<FormatException>(() => CreatureIdentifier.CreatureIdentifierFromString("Angel" + invalidArmyNumber));
        }

        [Test]
        public void ThrowIndexOutOfRangeException_IfInputStringIsInvalid()
        {
            // Arrange 
            var invalidString = "Angel1";

            // Act & Assert
            Assert.Throws<IndexOutOfRangeException>(() => CreatureIdentifier.CreatureIdentifierFromString(invalidString));
        }
    }
}
