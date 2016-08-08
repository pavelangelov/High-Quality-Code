using System;

using NUnit.Framework;
using Moq;

using Cosmetics.Products;
using Cosmetics.Contracts;

namespace Cosmetics.Tests.Products.ShoppingCardTests
{
    [TestFixture]
    public class TotalPrice_Should
    {
        [Test]
        public void ReturnRightResult()
        {
            // Arrange
            var shopCart = new ShoppingCart();
            var mockedProduct = new Mock<IProduct>();
            var expectedTotal = 15m;
            mockedProduct.SetupGet(x => x.Price).Returns(5m);

            // Act
            shopCart.AddProduct(mockedProduct.Object);
            shopCart.AddProduct(mockedProduct.Object);
            shopCart.AddProduct(mockedProduct.Object);

            // Assert
            Assert.AreEqual(expectedTotal, shopCart.TotalPrice());
        }
    }
}
