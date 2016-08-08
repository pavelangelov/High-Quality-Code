using System;

using NUnit.Framework;

using Cosmetics.Engine;
using Cosmetics.Products;

namespace Cosmetics.Tests.Engine.CosmeticsFactoryTests
{
    [TestFixture]
    public class CreateCategory_Should
    {
        [Test]
        public void ReturnNewCategory()
        {
            // Arange
            var categoryName = "Hair care";
            var factory = new CosmeticsFactory();

            // Act
            var category = factory.CreateCategory(categoryName);

            // Assert
            Assert.IsInstanceOf(typeof(Category), category);
            Assert.AreEqual(categoryName, category.Name);
        }
    }
}
