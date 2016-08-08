using System;
using NUnit.Framework;
using Moq;
using ArmyOfCreatures.Logic.Battles;
using ArmyOfCreatures.Console.Commands;
using ArmyOfCreatures.Logic.Creatures;
using ArmyOfCreatures.Logic;

namespace ArmyOfCreatures.Tests.ConsoleTests.Commands.AddCommand
{
    [TestFixture]
    public class ProcessCommand_Should
    {
        [Test]
        public void ShouldThrowArgumentNullException_WhenParamsStringIsNull()
        {
            // Arrange
            var mockedBattleMng = new Mock<IBattleManager>();
            var addCmd = new Console.Commands.AddCommand();

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => addCmd.ProcessCommand(mockedBattleMng.Object, null));
        }

        [Test]
        public void ShouldCallIBattleManagerAddCreatures_WhenCommandIsParsedSuccsessfully()
        {
            // Arrange
            var mockedBattleMng = new Mock<IBattleManager>();
            var addCmd = new Console.Commands.AddCommand();
            var id = CreatureIdentifier.CreatureIdentifierFromString("Angel(1)");
            var command = new string[] { "10", "Angel(1)" };

            // Act
            addCmd.ProcessCommand(mockedBattleMng.Object, command);

            // Assert
            mockedBattleMng.Verify(x => x.AddCreatures(It.IsAny<CreatureIdentifier>(), It.IsAny<int>()), Times.Once);
        }
    }
}
