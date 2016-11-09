using Dealership.Models;

namespace Dealership.Factories
{
    public interface IVehicleFactory
    {
        Car CreateCar(string make, string model, decimal price, int seats);


        Motorcycle CreateMotorcycle(string make, string model, decimal price, string category);


        Truck CreateTruck(string make, string model, decimal price, int weightCapacity);

    }
}
