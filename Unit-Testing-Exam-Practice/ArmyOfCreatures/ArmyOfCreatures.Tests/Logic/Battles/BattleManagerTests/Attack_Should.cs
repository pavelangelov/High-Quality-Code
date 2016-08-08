using System;
using NUnit.Framework;
using Moq;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Creatures;
using System.Collections.Generic;

namespace ArmyOfCreatures.Tests.Logic.Battles.BattleManagerTests
{
    [TestFixture]
    public class Attack_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenAttackerIdentifierIsNull()
        {
            // Arange
            var mockedCreatureFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var battleManager = new BattleManager(mockedCreatureFactory.Object, mockedLogger.Object);
            var defender = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => battleManager.Attack(null, defender));
        }

        [Test]
        public void ThrowArgumentNullException_WhenDefenderIdentifierIsNull()
        {
            // Arange
            var mockedCreatureFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var battleManager = new ExtendedBattleManager(mockedCreatureFactory.Object, mockedLogger.Object);
            var attacker = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => battleManager.Attack(attacker, null));
        }
        [Test]
        public void ThrowArgumentException_WhenAttackingUnitIsNull()
        {
            // Arange
            var mockedCreatureFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var battleManager = new BattleManager(mockedCreatureFactory.Object, mockedLogger.Object);
            var attacker = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");

            // Act & Assert
            Assert.Throws<ArgumentException>(() => battleManager.Attack(attacker, null));
        }

        [Test]
        public void CallWriteLineFromLoggerExactlyFourTimes_IfSuccsessfull()
        {
            // Arange
            var mockedCreatureFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var battleManager = new ExtendedBattleManager(mockedCreatureFactory.Object, mockedLogger.Object);
            var attacker = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var defender = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var creature = new Angel();
            
            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>()));

            // Act
            battleManager.Attack(attacker, defender);

            // Assert
            mockedLogger.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Exactly(4));
        }

        [Test]
        public void ReturnRightResult_WhenAttackingWithTwoBehemonth()
        {
            double expectedPoints = 56;
            // Arrange
            var mockedCreatureFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var battleManager = new BattleManager(mockedCreatureFactory.Object, mockedLogger.Object);

            var attacker = CreatureIdentifier.CreatureIdentifierFromString("Behemoth(1)");
            var defender = CreatureIdentifier.CreatureIdentifierFromString("Behemoth(2)");
            var creature = new Behemoth();

            List<string> logerMsgs = new List<string>();
            
            mockedCreatureFactory.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            // add every logger message, so in the end we could find defender`s total defense points
            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>())).Callback<string>(m => logerMsgs.Add(m));

            // Act
            battleManager.AddCreatures(attacker, 2);
            battleManager.AddCreatures(defender, 1);
            battleManager.Attack(attacker, defender);

            // We have exactly 6 logger calls, and the last one contains defender`s total defense points
            var defenderDefensePoints = ExtrackTotalDefencePoints(logerMsgs[5]);

            // Assert
            Assert.AreEqual(expectedPoints, defenderDefensePoints);
        }

        private double ExtrackTotalDefencePoints(string loggerMsg)
        {
            var startIndex = loggerMsg.IndexOf("THP:") + 4;
            var lastIndex = loggerMsg.IndexOf(";", startIndex);

            var result = double.Parse(loggerMsg.Substring(startIndex, lastIndex - startIndex));
            return result;
        }
    }
}
