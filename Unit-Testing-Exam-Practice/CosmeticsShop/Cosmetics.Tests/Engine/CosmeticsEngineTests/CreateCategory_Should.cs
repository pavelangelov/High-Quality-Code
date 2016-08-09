using System;
using System.IO;

using NUnit.Framework;
using Moq;

using Cosmetics.Contracts;

namespace Cosmetics.Tests.Engine.CosmeticsEngineTests
{
    [TestFixture]
    public class CreateCategory_Should
    {
        [Test]
        public void CallCreateCategoryFromFactory_IfInputIsPassedCorrectly()
        {
            // Arrange
            var input = "CreateCategory ForMale";
            Console.SetIn(new StringReader(input));

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedCategory = new Mock<ICategory>();

            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedCart.Object);

            // Act
            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>()));
            mockedEngine.Start();

            // Assert
            mockedFactory.Verify(x => x.CreateCategory(It.IsAny<string>()), Times.Once);
        }
    }
}
