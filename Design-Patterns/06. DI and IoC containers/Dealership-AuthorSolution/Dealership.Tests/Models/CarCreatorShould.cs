using NUnit.Framework;
using Moq;

using Dealership.Contracts;
using Dealership.Common.Enums;
using Dealership.Factories;
using Dealership.Models;

namespace Dealership.Tests.Models
{
    [TestFixture]
    public class CarCreatorShould
    {
        [Test]
        public void _CallVehicleFactory_CreateCarMethod_IfPassedParametersAreCorrect()
        {
            // Arange
            var make = "Seat";
            var model = "Cordoba";
            var price = 1200m;
            var seats = "4";

            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var carCreator = new CarCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateCar(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>())).Verifiable();

            // Act
            var car = carCreator.Create(VehicleType.Car, make, model, price, seats);

            // Assert
            mockedVehicleFactory.Verify(x => x.CreateCar(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>()), Times.Exactly(1));
        }

        [Test]
        public void _ReturnNull_IfVehicleTypeIsIncorect_AndDoesNotHaveSuccessor()
        {
            // Arange
            var make = "Seat";
            var model = "Cordoba";
            var price = 1200m;
            var seats = "4";

            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var carCreator = new CarCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateCar(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>())).Verifiable();

            // Act
            var car = carCreator.Create(VehicleType.Truck, make, model, price, seats);

            // Assert
            Assert.IsNull(car);
            mockedVehicleFactory.Verify(x => x.CreateCar(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>()), Times.Exactly(0));
        }


        [Test]
        public void _CallVehicleFactory_CreateCarMethod_AndReturnCarWithCorrectParameters()
        {
            // Arange
            var make = "Seat";
            var model = "Cordoba";
            var price = 1200m;
            var seats = 4;

            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var carCreator = new CarCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateCar(make, model, price, seats)).Returns(new Car(make, model, price, seats));

            // Act
            var car = carCreator.Create(VehicleType.Car, make, model, price, seats.ToString());

            // Assert
            Assert.AreEqual(typeof(Car), car.GetType());
            Assert.AreEqual(car.Make, make);
            Assert.AreEqual(car.Model, model);
            Assert.AreEqual(car.Price, price);
            Assert.AreEqual(car.Wheels, 4);
        }
    }
}
