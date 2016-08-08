using System;

using NUnit.Framework;

using Cosmetics.Common;
using Cosmetics.Contracts;
using Cosmetics.Engine;

namespace Cosmetics.Tests.Engine.CosmeticsFactoryTests
{
    [TestFixture]
    public class CreateShampoo_Should
    {
        [Test]
        public void ReturnNewShampoo_AndAllPropertiesMustHaveCorrectValue()
        {
            // Arrange
            var name = "Sport";
            var brand = "Clear";
            var price = 5m;
            var gender = GenderType.Men;
            var milliliters = 500u;
            var usage = UsageType.EveryDay;
            var factory = new CosmeticsFactory();
            var expectedPrice = price * milliliters;

            // Act
            var shampoo = factory.CreateShampoo(name, brand, price, gender, milliliters, usage);

            // Assert
            Assert.IsInstanceOf(typeof(IShampoo), shampoo);
            Assert.AreEqual(name, shampoo.Name);
            Assert.AreEqual(brand, shampoo.Brand);
            Assert.AreEqual(expectedPrice, shampoo.Price);
            Assert.AreEqual(gender, shampoo.Gender);
            Assert.AreEqual(milliliters, shampoo.Milliliters);
            Assert.AreEqual(usage, shampoo.Usage);
        }
    }
}
