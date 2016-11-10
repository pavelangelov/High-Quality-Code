using Dealership.Contracts;
using Dealership.Common.Enums;
using Dealership.Factories;

namespace Dealership.Models
{
    public abstract class VehicleCreator : IVehicleCreator
    {
        protected VehicleCreator(IVehicleFactory vehicleFactory)
        {
            this.VehicleFactory = vehicleFactory;
        }

        public IVehicleFactory VehicleFactory { get; set; }

        public IVehicleCreator Successor { get; set; }

        protected abstract bool CanCreate(VehicleType type);

        public abstract IVehicle Create(VehicleType type, string make, string model, decimal price, string additionalParam);

        public void SetSuccsessor(IVehicleCreator successor)
        {
            this.Successor = successor;
        }
    }
}
