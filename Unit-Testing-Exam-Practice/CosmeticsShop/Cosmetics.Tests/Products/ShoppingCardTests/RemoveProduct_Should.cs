using System;

using NUnit.Framework;
using Moq;

using Cosmetics.Products;
using Cosmetics.Contracts;

namespace Cosmetics.Tests.Products.ShoppingCardTests
{
    [TestFixture]
    public class RemoveProduct_Should
    {
        [Test]
        public void ThrowNullReferenceException_IfPassedParameterIsNull()
        {
            // Arrange
            var shopCart = new ShoppingCart();

            // Act, Assert
            Assert.Throws<NullReferenceException>(() => shopCart.RemoveProduct(null));
        }

        [Test]
        public void RemoveProduct_IfPassedParameterIsCorrect()
        {
            // Arrange
            var shopCart = new ShoppingCart();
            var mockedProduct = new Mock<IProduct>();

            // Act
            shopCart.AddProduct(mockedProduct.Object);
            shopCart.RemoveProduct(mockedProduct.Object);

            // Assert
            Assert.IsFalse(shopCart.ContainsProduct(mockedProduct.Object));
        }
    }
}
