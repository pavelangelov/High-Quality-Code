using NUnit.Framework;
using Moq;

using Dealership.Common.Enums;
using Dealership.Factories;
using Dealership.Models;

namespace Dealership.Tests.Models
{

    [TestFixture]
    public class TruckCreatorShould
    {
        [Test]
        public void _CallVehicleFactory_CreateTruckMethod_IfPassedParametersAreCorrect()
        {
            // Arange
            var make = "Volvo";
            var model = "FH4";
            var price = 11800;
            var weightCapacity = "80";

            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var truckCreator = new TruckCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateTruck(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>())).Verifiable();

            // Act
            var truck = truckCreator.Create(VehicleType.Truck, make, model, price, weightCapacity);

            // Assert
            mockedVehicleFactory.Verify(x => x.CreateTruck(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>()), Times.Exactly(1));
        }

        [Test]
        public void _ReturnNull_IfVehicleTypeIsIncorect_AndDoesNotHaveSuccessor()
        {
            // Arange
            var make = "Volvo";
            var model = "FH4";
            var price = 11800;
            var weightCapacity = "80";

            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var truckCreator = new TruckCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateTruck(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>())).Verifiable();

            // Act
            var truck = truckCreator.Create(VehicleType.Car, make, model, price, weightCapacity);

            // Assert
            Assert.IsNull(truck);
            mockedVehicleFactory.Verify(x => x.CreateTruck(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<int>()), Times.Exactly(0));
        }


        [Test]
        public void _CallVehicleFactory_CreateTruckMethod_AndReturnTruckWithCorrectParameters()
        {
            // Arange
            var make = "Volvo";
            var model = "FH4";
            var price = 11800;
            var weightCapacity = 80;

            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var truckCreator = new TruckCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateTruck(make, model, price, weightCapacity)).Returns(new Truck(make, model, price, weightCapacity));

            // Act
            var truck = truckCreator.Create(VehicleType.Truck, make, model, price, weightCapacity.ToString());

            // Assert
            Assert.AreEqual(typeof(Truck), truck.GetType());
            Assert.AreEqual(truck.Make, make);
            Assert.AreEqual(truck.Model, model);
            Assert.AreEqual(truck.Price, price);
            Assert.AreEqual(truck.Wheels, 8);
        }
    }
}
