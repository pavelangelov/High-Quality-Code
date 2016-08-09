using System;
using System.IO;

using NUnit.Framework;
using Moq;

using Cosmetics.Contracts;

namespace Cosmetics.Tests.Engine.CosmeticsEngineTests
{
    [TestFixture]
    public class AddToCategory_Should
    {
        [Test]
        public void CallAddCosmetics_FromCategory_IfInputIsPassedCorrectly()
        {
            // Arrange
            var input = "AddToCategory ForMale Cool";
            Console.SetIn(new StringReader(input));

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedCategory = new Mock<ICategory>();
            var mockedProduct = new Mock<IProduct>();

            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedCart.Object);
            mockedEngine.Categories.Add("ForMale", mockedCategory.Object);
            mockedEngine.Products.Add("Cool", mockedProduct.Object);
            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(mockedCategory.Object);
            mockedCategory.Setup(x => x.AddCosmetics(It.IsAny<IProduct>()));

            // Act
            mockedEngine.Start();

            // Assert
            mockedCategory.Verify(x => x.AddCosmetics(It.IsAny<IProduct>()), Times.Once);
        }
    }
}
