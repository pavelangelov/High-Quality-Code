using NUnit.Framework;
using Moq;

using Dealership.Models;
using Dealership.Contracts;
using Dealership.Factories;
using Dealership.Common.Enums;

namespace Dealership.Tests
{
    [TestFixture]
    public class CarCreatorShould
    {
        [Test]
        public void _CallVehicleFactory_CreateCarMethod_IfPassedParametersAreCorrect()
        {
            // Arange
            var make = "make";
            var model = "model";
            var price = 12;
            var seats = "4";
            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var mockedCar = new Mock<IVehicle>();
            var carCreator = new CarCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateCar(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>())).Verifiable();

            // Act
            var car = carCreator.Create(VehicleType.Car, make, model, price, seats);

            // Assert
            mockedVehicleFactory.Verify(x => x.CreateCar(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>()), Times.Exactly(1));
        }

        [Test]
        public void _ReturnNull_IfVehicleTypeIsIncorect()
        {
            // Arange
            var make = "make";
            var model = "model";
            var price = 12;
            var seats = "4";
            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var mockedCar = new Mock<IVehicle>();
            var carCreator = new CarCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateCar(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>())).Verifiable();

            // Act
            var car = carCreator.Create(VehicleType.Truck, make, model, price, seats);

            // Assert
            Assert.IsNull(car);
            mockedVehicleFactory.Verify(x => x.CreateCar(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>()), Times.Exactly(0));
        }
    }
}
