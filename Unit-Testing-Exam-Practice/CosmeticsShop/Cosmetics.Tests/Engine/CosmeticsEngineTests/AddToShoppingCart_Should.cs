using System;
using System.IO;

using NUnit.Framework;
using Moq;

using Cosmetics.Contracts;

namespace Cosmetics.Tests.Engine.CosmeticsEngineTests
{
    [TestFixture]
    public class AddToShoppingCart_Should
    {
        [Test]
        public void CallAddProduct_FromShoppingCart()
        {
            // Arrange
            var input = "AddToShoppingCart White+";
            Console.SetIn(new StringReader(input));
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedCart.Object);
            var mockedProduct = new Mock<IProduct>();
            mockedEngine.Products.Add("White+", mockedProduct.Object);
            mockedCart.Setup(x => x.AddProduct(It.IsAny<IProduct>()));

            // Act
            mockedEngine.Start();

            // Assert
            mockedCart.Verify(x => x.AddProduct(It.IsAny<IProduct>()), Times.Once);
        }
    }
}
