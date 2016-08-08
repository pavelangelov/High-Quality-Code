using System;
using System.Collections.Generic;

using NUnit.Framework;

using Cosmetics.Common;
using Cosmetics.Engine;
using Cosmetics.Products;

namespace Cosmetics.Tests.Engine.CosmeticsFactoryTests
{
    [TestFixture]
    public class CreateToothpaste_Should
    {
        [Test]
        public void ReturnNewToothpaste_AndAllPropertiesMustHaveCorrectValue()
        {
            // Arrange
            var name = "White+";
            var brand = "Colgate";
            var price = 2m;
            var gender = GenderType.Unisex;
            var ingredients = new List<string>() { "Anticavity", "Triclosan" };
            var factory = new CosmeticsFactory();
            var expectedIngredients = string.Join(", ", ingredients);

            // Act 
            var toothpaste = factory.CreateToothpaste(name, brand, price, gender, ingredients);

            //Assert
            Assert.IsInstanceOf(typeof(Toothpaste), toothpaste);
            Assert.AreEqual(name, toothpaste.Name);
            Assert.AreEqual(brand, toothpaste.Brand);
            Assert.AreEqual(price, toothpaste.Price);
            Assert.AreEqual(gender, toothpaste.Gender);
            Assert.AreEqual(expectedIngredients, toothpaste.Ingredients);
        }
    }
}
