using System;

using NUnit.Framework;

using Cosmetics.Engine;
using Cosmetics.Products;

namespace Cosmetics.Tests.Engine.CosmeticsFactoryTests
{
    [TestFixture]
    public class ShoppingCart_Should
    {
        [Test]
        public void ReturnNewShoppingCart()
        {
            // Arrange
            var factory = new CosmeticsFactory();

            // Act
            var shoppingCart = factory.ShoppingCart();

            // Assert
            Assert.IsInstanceOf(typeof(ShoppingCart), shoppingCart);
        }
    }
}
