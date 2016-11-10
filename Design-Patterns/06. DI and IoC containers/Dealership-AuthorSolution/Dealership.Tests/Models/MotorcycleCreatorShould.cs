using NUnit.Framework;
using Moq;

using Dealership.Common.Enums;
using Dealership.Factories;
using Dealership.Models;

namespace Dealership.Tests.Models
{
    [TestFixture]
    public class MotorcycleCreatorShould
    {
        [Test]
        public void _CallVehicleFactory_CreateMotorcycleMethod_IfPassedParametersAreCorrect()
        {
            // Arange
            var make = "Kawasaki";
            var model = "Z1000";
            var price = 12000;
            var category = "Naked";

            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var motorcycleCreator = new MotorcycleCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateMotorcycle(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<string>())).Verifiable();

            // Act
            var motorcycle = motorcycleCreator.Create(VehicleType.Motorcycle, make, model, price, category);

            // Assert
            mockedVehicleFactory.Verify(x => x.CreateMotorcycle(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<string>()), Times.Exactly(1));
        }

        [Test]
        public void _ReturnNull_IfVehicleTypeIsIncorect_AndDoesNotHaveSuccessor()
        {
            // Arange
            var make = "Kawasaki";
            var model = "Z1000";
            var price = 12000;
            var category = "Naked";

            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var motorcycleCreator = new MotorcycleCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateMotorcycle(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<string>())).Verifiable();

            // Act
            var motorcycle = motorcycleCreator.Create(VehicleType.Truck, make, model, price, category);

            // Assert
            Assert.IsNull(motorcycle);
            mockedVehicleFactory.Verify(x => x.CreateMotorcycle(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<decimal>(), It.IsAny<string>()), Times.Exactly(0));
        }


        [Test]
        public void _CallVehicleFactory_CreateMotorcycleMethod_AndReturnMotorcycleWithCorrectParameters()
        {
            // Arange
            var make = "Kawasaki";
            var model = "Z1000";
            var price = 12000;
            var category = "Naked";

            var mockedVehicleFactory = new Mock<IVehicleFactory>();
            var motorcycleCreator = new MotorcycleCreator(mockedVehicleFactory.Object);

            mockedVehicleFactory.Setup(x => x.CreateMotorcycle(make, model, price, category)).Returns(new Motorcycle(make, model, price, category));

            // Act
            var motorcycle = motorcycleCreator.Create(VehicleType.Motorcycle, make, model, price, category);

            // Assert
            Assert.AreEqual(typeof(Motorcycle), motorcycle.GetType());
            Assert.AreEqual(motorcycle.Make, make);
            Assert.AreEqual(motorcycle.Model, model);
            Assert.AreEqual(motorcycle.Price, price);
            Assert.AreEqual(motorcycle.Wheels, 2);
        }
    }
}
