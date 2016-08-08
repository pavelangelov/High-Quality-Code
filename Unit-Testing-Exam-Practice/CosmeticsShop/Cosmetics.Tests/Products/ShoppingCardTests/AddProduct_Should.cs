using System;

using NUnit.Framework;
using Moq;

using Cosmetics.Products;
using Cosmetics.Contracts;

namespace Cosmetics.Tests.Products.ShoppingCardTests
{
    [TestFixture]
    public class AddProduct_Should
    {
        [Test]
        public void ThrowNullReferenceException_IfPassedParameterIsNull()
        {
            // Arrange
            var shopCard = new ShoppingCart();

            // Act, Assert
            Assert.Throws<NullReferenceException>(() => shopCard.AddProduct(null));
        }

        [Test]
        public void AddProduct_IfPassedParameterIsCorrect()
        {
            // Arrange
            var product = new Mock<IProduct>();
            var shopCart = new ShoppingCart();

            // Act
            shopCart.AddProduct(product.Object);

            // Assert
            Assert.IsTrue(shopCart.ContainsProduct(product.Object));
        }
    }
}
