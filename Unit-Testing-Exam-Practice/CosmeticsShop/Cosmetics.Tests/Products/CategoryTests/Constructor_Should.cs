using System;

using NUnit.Framework;

using Cosmetics.Products;

namespace Cosmetics.Tests.Products.CategoryTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void ThrowNullReferenceException_WhenNameIsNull()
        {
            // Arrange, Act, Assert
            Assert.Throws<NullReferenceException>(() => new Category(null));
        }

        [Test]
        [TestCase("a")]
        [TestCase("aaaaaaaaaaaaaaaa")]
        public void ThrowIndexOutOfRangeException_WhenNameLengthIsInvalid(string nameWithInvalidLength)
        {
            // Arrange, Act, Assert
            Assert.Throws<IndexOutOfRangeException>(() => new Category(nameWithInvalidLength));
        }

        [Test]
        [TestCase("aa")]
        [TestCase("aaaaaaaaaaaaaaa")]
        public void SetName_IfPassedParameterIsCorrect(string nameWithValidLength)
        {
            // Arrange
            var category = new Category(nameWithValidLength);
            
            // Act, Assert
            Assert.AreEqual(nameWithValidLength, category.Name);
        }
    }
}
