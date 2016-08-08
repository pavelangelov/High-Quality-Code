using System;
using NUnit.Framework;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Tests.Logic.Battles.CreaturesInBattleTests
{
    [TestFixture]
    public class DealDamage_Should
    {
        [Test]
        public void ThrowArgumentNullException_IfDefenderIsNull()
        {
            // Arrange
            var creature = new Angel();
            var creatureInBattle = new CreaturesInBattle(creature, 1);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => creatureInBattle.DealDamage(null));
        }

        [Test]
        public void ReturnExpectedResult()
        {
            // When Angel attack Angel, the defender takes damage: 50

            // Arrange
            var creature = new Angel();
            var attackedCreature = new CreaturesInBattle(creature, 1);
            var defendedCreature = new CreaturesInBattle(creature, 1);
            var expectedHeath = defendedCreature.TotalHitPoints - attackedCreature.PermanentAttack;

            // Act
            attackedCreature.DealDamage(defendedCreature);

            // Assert
            Assert.AreNotEqual(expectedHeath, defendedCreature.TotalHitPoints);
        }
    }
}
