using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using ArmyOfCreatures.Extended;
using ArmyOfCreatures.Logic;
using ArmyOfCreatures.Logic.Battles;
using System.Reflection;

namespace ArmyOfCreatures.Tests.Extended.BattleManagerWithThreeArmiesTests
{
    [TestClass]
    public class Constructor_Should
    {
        [TestMethod]
        public void CallBaseConstructor_AndInitObjectWithAllProperties()
        {
            // Arrange
            var mockedBaseBattleMng = new Mock<IBattleManager>();
            var mockedFactory = new Mock<ICreaturesFactory>();
            var mockedLogger = new Mock<ILogger>();
            var extendetBattleMng = new BattleManagerWithThreeArmies(mockedFactory.Object, mockedLogger.Object);
            
            PrivateObject obj = new PrivateObject(extendetBattleMng);
            
            // Assert
            Assert.IsNotNull(obj.GetFieldOrProperty("thirdArmyCreatures"));

            
        }
        // TODO: Check if called base constructor!!!
    }
}
