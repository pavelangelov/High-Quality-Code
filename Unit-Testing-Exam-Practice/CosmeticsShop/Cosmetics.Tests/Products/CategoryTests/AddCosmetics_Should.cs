using System;

using NUnit.Framework;
using Moq;

using Cosmetics.Products;
using Cosmetics.Contracts;

namespace Cosmetics.Tests.Products.CategoryTests
{
    [TestFixture]
    public class AddCosmetics_Should
    {
        [Test]
        public void ThrowNullReferenceException_WhenPassedParameterIsNull()
        {
            // Arrange
            var categoryName = "Shampoo";
            var category = new Category(categoryName);

            // Act, Assert
            Assert.Throws<NullReferenceException>(() => category.AddCosmetics(null));
        }

        [Test]
        public void AddProduct_WhenPassedParameterIsCorrect()
        {
            // Becouse products is private field, if we add product to collection, the Print() should return
            // "{categoryName} category - {products.Count} {product/products} in total"

            // Arrange
            var categoryName = "Shampoo";
            var expectedResult = "Shampoo category - 1 product in total";
            var category = new Category(categoryName);
            var mockedProduct = new Mock<IProduct>();

            // Act
            category.AddCosmetics(mockedProduct.Object);

            // Assert
            Assert.AreEqual(expectedResult, category.Print());
        }
    }
}
