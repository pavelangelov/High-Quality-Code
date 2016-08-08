using System;

using NUnit.Framework;
using Moq;

using Cosmetics.Contracts;
using Cosmetics.Products;

namespace Cosmetics.Tests.Products.CategoryTests
{
    [TestFixture]
    public class RemoveCosmetics_Should
    {
        [Test]
        public void ThrowNullReferenceException_WhenPassedParameterIsNull()
        {
            // Arrange
            var categoryName = "Shampoo";
            var category = new Category(categoryName);

            // Act, Assert
            Assert.Throws<NullReferenceException>(() => category.RemoveCosmetics(null));
        }

        [Test]
        public void ThrowInvalidOperationException_IfTheCollectionDoesNotContainTheProduct()
        {
            // Arrange
            var categoryName = "Shampoo";
            var category = new Category(categoryName);
            var mockedProduct = new Mock<IProduct>();

            // Act, Assert
            Assert.Throws<InvalidOperationException>(() => category.RemoveCosmetics(mockedProduct.Object));
        }

        [Test]
        public void RemoveProduct_WhenPassedParameterIsCorrect()
        {
            // Becouse products is private field, if we remove product from collection, the Print() should return
            // "{categoryName} category - {products.Count} {product/products} in total"

            // Arrange
            var categoryName = "Shampoo";
            var expectedResult = "Shampoo category - 0 products in total";
            var category = new Category(categoryName);
            var mockedProduct = new Mock<IProduct>();

            // Act
            category.AddCosmetics(mockedProduct.Object);
            category.RemoveCosmetics(mockedProduct.Object);

            // Assert
            Assert.AreEqual(expectedResult, category.Print());
        }
    }
}
