using System;
using System.IO;

using NUnit.Framework;
using Moq;

using Cosmetics.Contracts;

namespace Cosmetics.Tests.Engine.CosmeticsEngineTests
{
    [TestFixture]
    public class RemoveFromCategory_Should
    {
        [Test]
        public void CallRemoveCosmetics_FromCategory_IfProductExist()
        {
            // Arrange
            var input = "RemoveFromCategory ForMale Cool";
            Console.SetIn(new StringReader(input));

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedCategory = new Mock<ICategory>();
            var mockedProduct = new Mock<IProduct>();

            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedCart.Object);
            mockedEngine.Categories.Add("ForMale", mockedCategory.Object);
            mockedEngine.Products.Add("Cool", mockedProduct.Object);
            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(mockedCategory.Object);
            mockedCategory.Setup(x => x.RemoveCosmetics(It.IsAny<IProduct>()));

            // Act
            mockedEngine.Start();

            // Assert
            mockedCategory.Verify(x => x.RemoveCosmetics(It.IsAny<IProduct>()), Times.Once);
        }

        [Test]
        [TestCase("Male", "Cool")]
        [TestCase("ForMale", "cool")]
        public void NotCallRemoveCosmetics_FromCategory_IfProductOrCategoryDoesNotExist(string categoryName, string productName)
        {
            // Arrange
            var input = "RemoveFromCategory ForMale Cool";
            Console.SetIn(new StringReader(input));

            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedCategory = new Mock<ICategory>();
            var mockedProduct = new Mock<IProduct>();

            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedCart.Object);
            mockedEngine.Categories.Add(categoryName, mockedCategory.Object);
            mockedEngine.Products.Add(productName, mockedProduct.Object);
            mockedFactory.Setup(x => x.CreateCategory(It.IsAny<string>())).Returns(mockedCategory.Object);
            mockedCategory.Setup(x => x.RemoveCosmetics(It.IsAny<IProduct>()));

            // Act
            mockedEngine.Start();

            // Assert
            mockedCategory.Verify(x => x.RemoveCosmetics(It.IsAny<IProduct>()), Times.Never);
        }
    }
}
