using Dealership.Contracts;
using Dealership.Common.Enums;
using Dealership.Factories;

namespace Dealership.Models
{
    public class MotorcycleCreator : VehicleCreator, IVehicleCreator
    {
        public MotorcycleCreator(IVehicleFactory vehicleFactory) 
            : base(vehicleFactory)
        {
        }

        protected override bool CanCreate(VehicleType type)
        {
            return VehicleType.Motorcycle == type;
        }

        public override IVehicle Create(VehicleType type, string make, string model, decimal price, string additionalParam)
        {
            if (this.CanCreate(type))
            {
                var motorcycle = this.VehicleFactory.CreateMotorcycle(make, model, price, additionalParam);
                return motorcycle;
            }

            if (this.Successor != null)
            {
                return this.Successor.Create(type, make, model, price, additionalParam);
            }

            return null;
        }
    }
}
