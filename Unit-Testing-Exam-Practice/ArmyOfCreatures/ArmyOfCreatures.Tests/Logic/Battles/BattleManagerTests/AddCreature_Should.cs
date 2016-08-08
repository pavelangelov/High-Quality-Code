using System;
using NUnit.Framework;
using Moq;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Logic.Creatures;

namespace ArmyOfCreatures.Tests.Logic.Battles.BattleManagerTests
{
    [TestFixture]
    public class AddCreature_Should
    {
        [Test]
        public void ThrowArgumentNullException_WhenIdentifierIsNull()
        {
            // Arrange
            var mockedDb = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var battleMng = new BattleManager(mockedDb.Object, mockedLogger.Object);

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => battleMng.AddCreatures(null, 1));
        }

        [Test]
        public void CallCreateCreatureFromFactory()
        {
            // Arrange
            var mockedDb = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var creature = new Angel();
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var battleMng = new BattleManager(mockedDb.Object, mockedLogger.Object);

            mockedDb.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            // Act
            battleMng.AddCreatures(identifier, 1);

            // Assert
            mockedDb.Verify(x => x.CreateCreature(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void CallWriteLineFromLogger()
        {
            // Arrange
            var mockedDb = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var creature = new Angel();
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var battleMng = new ExtendedBattleManager(mockedDb.Object, mockedLogger.Object);

            mockedDb.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);
            mockedLogger.Setup(x => x.WriteLine(It.IsAny<string>())).Verifiable();

            // Act
            battleMng.AddCreatures(identifier, 1);

            // Assert
            mockedLogger.Verify(x => x.WriteLine(It.IsAny<string>()), Times.Once);
        }

        [Test]
        public void ThrowArgumentException_WhenAddingInArmyThree()
        {
            // Arrange
            var mockedDb = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var battleMng = new BattleManager(mockedDb.Object, mockedLogger.Object);
            var identifier = CreatureIdentifier.CreatureIdentifierFromString("Angel(3)");
            var creature = new Angel();

            mockedDb.Setup(x => x.CreateCreature(It.IsAny<string>())).Returns(creature);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => battleMng.AddCreatures(identifier, 1));
        }
    }
}
