using System;
using NUnit.Framework;
using Cosmetics.Products;
using Cosmetics.Common;
using System.Collections.Generic;

namespace Cosmetics.Tests.Products
{
    [TestFixture]
    public class Constructor_Should
    {
        [Test]
        [TestCase("Ant")]
        [TestCase("Anticavity-0.24%")]
        public void ThrowIndexOutOfRangeException_IfAnyIngredientLengthIsInvalid(string invalidIngredient)
        {
            // Arrange
            var name = "White+";
            var brand = "Colgate";
            var price = 2m;
            var gender = GenderType.Unisex;
            var ingredients = new List<string>() { "Anticavity", invalidIngredient };


            // Act, Assert
            Assert.Throws<IndexOutOfRangeException>(() => new Toothpaste(name, brand, price, gender, ingredients));
        }

        [Test]
        public void SetIngredients_IfPassedParameterIsCorrect()
        {
            // Arrange
            var name = "White+";
            var brand = "Colgate";
            var price = 2m;
            var gender = GenderType.Unisex;
            var ingredients = new List<string>() { "Triclosan" };
            var toothpaste = new Toothpaste(name, brand, price, gender, ingredients);

            // Act, Assert
            Assert.AreEqual(ingredients[0], toothpaste.Ingredients);
        }
    }
}
