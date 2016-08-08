using System;

using NUnit.Framework;

using Cosmetics.Products;
using Cosmetics.Common;
using Cosmetics.Contracts;

namespace Cosmetics.Tests.Products.ProductTests
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        public void ThrowNullReferenceException_WhenTheNameIsNull()
        {
            // Arrange
            string productName = null;
            var brand = "Clear";
            var price = 2m;
            var genderType = GenderType.Unisex;
            var milliliters = 330u;
            var usage = UsageType.EveryDay;

            // Act, Assert
            Assert.Throws<NullReferenceException>(() => new Shampoo(productName, brand, price, genderType, milliliters, usage));
        }

        [Test]
        [TestCase("aa")]
        [TestCase("Sport-Sport")]
        public void ThrowIndexOutOfRangeException_WhenTheNameLengthIsInvalid(string invalidNameLength)
        {
            // Arrange
            var brand = "Clear";
            var price = 2m;
            var genderType = GenderType.Unisex;
            var milliliters = 330u;
            var usage = UsageType.EveryDay;

            // Act, Assert
            Assert.Throws<IndexOutOfRangeException>(() => new Shampoo(invalidNameLength, brand, price, genderType, milliliters, usage));
        }

        [Test]
        public void ThrowNullReferenceException_WhenTheBranchIsNull()
        {
            // Arrange
            var productName = "Sport";
            string brand = null;
            var price = 2m;
            var genderType = GenderType.Unisex;
            var milliliters = 330u;
            var usage = UsageType.EveryDay;

            // Act, Assert
            Assert.Throws<NullReferenceException>(() => new Shampoo(productName, brand, price, genderType, milliliters, usage));
        }

        [Test]
        [TestCase("a")]
        [TestCase("Clear-Sport")]
        public void ThrowIndexOutOfRangeException_WhenTheBranchLengthIsInvalid(string invalidBranchLength)
        {
            // Arrange
            var name = "Sport";
            var price = 2m;
            var genderType = GenderType.Unisex;
            var milliliters = 330u;
            var usage = UsageType.EveryDay;

            // Act, Assert
            Assert.Throws<IndexOutOfRangeException>(() => new Shampoo(name, invalidBranchLength, price, genderType, milliliters, usage));
        }

        [Test]
        public void CreateObjectWithAllProperties_IfPassedParametersAreCorrect()
        {
            // Arrange
            var name = "Sport";
            var brand = "Clear";
            var price = 2m;
            var genderType = GenderType.Unisex;
            var milliliters = 330u;
            var usage = UsageType.EveryDay;
            IProduct product = new Shampoo(name, brand, price, genderType, milliliters, usage);

            // Act, Assert
            Assert.AreEqual(name, product.Name);
            Assert.AreEqual(brand, product.Brand);
            Assert.AreEqual(price * milliliters, product.Price);
            Assert.AreEqual(genderType, product.Gender);

        }
    }
}
