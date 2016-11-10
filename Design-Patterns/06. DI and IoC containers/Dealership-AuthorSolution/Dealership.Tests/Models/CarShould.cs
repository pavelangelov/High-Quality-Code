using System;

using NUnit.Framework;

using Dealership.Models;

namespace Dealership.Tests.Models
{
    
    [TestFixture]
    public class CarShould
    {
        [Test]
        public void _CreateNewCar_WithValidProperties_WhenParametersAreValid()
        {
            var make = "Honda";
            var model = "Civic";
            var price = 2000m;
            var seats = 4;

            // Arrange, Act
            var car = new Car(make, model, price, seats);

            // Assert
            Assert.AreEqual(typeof(Car), car.GetType());
            Assert.AreEqual(make, car.Make);
            Assert.AreEqual(model, car.Model);
            Assert.AreEqual(price, car.Price);
            Assert.AreEqual(seats, car.Seats);
        }

        [Test]
        [TestCase("a", "Civic", 2000, 4)]
        [TestCase("aaaaaaaaaaaaaaaa", "Civic", 2000, 4)]
        [TestCase("Honda", "", 2000, 4)]
        [TestCase("Honda", "aaaaaaaaaaaaaaaa", 2000, 4)]
        [TestCase("Honda", "Civic", -1, 4)]
        [TestCase("Honda", "Civic", 1000001, 4)]
        [TestCase("Honda", "Civic", 2000, 0)]
        [TestCase("Honda", "Civic", 2000, 11)]
        public void _ThrowArgumenException_IfPassedParametersAreInvalid(string make, string model, decimal price, int seats)
        {
            // Arrange, Act, Assert
           Assert.Throws<ArgumentException>(() => new Car(make, model, price, seats));
        }
    }
}
