using System;
using NUnit.Framework;
using Moq;
using ArmyOfCreatures.Logic.Specialties;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Tests.Logic.Specialties.DoubleDefenseWheDefendingTests
{
    [TestFixture]
    public class ApplyWhenDefending_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenTheDefenderWithSpecialtyIsNull()
        {
            // Arrange
            var rounds = 1;
            var doubleDef = new DoubleDefenseWhenDefending(rounds);
            var attackCreature = new Mock<ICreaturesInBattle>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => doubleDef.ApplyWhenDefending(null, attackCreature.Object));
        }

        [Test]
        public void ThrowArgumentNullException_WhenTheAttackerIsNull()
        {
            // Arrange
            var rounds = 1;
            var doubleDef = new DoubleDefenseWhenDefending(rounds);
            var defender = new Mock<ICreaturesInBattle>();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => doubleDef.ApplyWhenDefending(defender.Object, null));
        }

        [Test]
        public void ReturnAndNotChangeTheCurrentDefenseProperty_WhenTheEffectIsExpired()
        {
            // Arrange
            var rounds = 1;
            var creature = new Angel();
            var doubleDef = new DoubleDefenseWhenDefending(rounds);
            var defender = new CreaturesInBattle(creature, 1);
            var attacker = new Mock<ICreaturesInBattle>();

            // Act
            doubleDef.ApplyWhenDefending(defender, attacker.Object);
            var currentDefense = defender.CurrentDefense;
            doubleDef.ApplyWhenDefending(defender, attacker.Object);

            // Assert
            Assert.AreEqual(currentDefense, defender.CurrentDefense);
        }

        [Test]
        public void MultiplyByTwoTheCurrentDefenseProperty_WhenTheEffectHasNotExpired()
        {
            // Arrange
            var rounds = 1;
            var creature = new Angel();
            var doubleDef = new DoubleDefenseWhenDefending(rounds);
            var defender = new CreaturesInBattle(creature, 1);
            var attacker = new Mock<ICreaturesInBattle>();
            var expectedDefense = defender.CurrentDefense * 2;

            // Act
            doubleDef.ApplyWhenDefending(defender, attacker.Object);

            // Assert
            Assert.AreEqual(expectedDefense, defender.CurrentDefense);
        }
    }
}
