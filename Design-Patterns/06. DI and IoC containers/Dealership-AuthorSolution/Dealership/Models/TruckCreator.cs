using Dealership.Contracts;
using Dealership.Common.Enums;
using Dealership.Factories;

namespace Dealership.Models
{
    public class TruckCreator : VehicleCreator, IVehicleCreator
    {
        public TruckCreator(IVehicleFactory vehicleFactory) 
            : base(vehicleFactory)
        {
        }

        protected override bool CanCreate(VehicleType type)
        {
            return VehicleType.Truck == type;
        }

        public override IVehicle Create(VehicleType type, string make, string model, decimal price, string additionalParam)
        {
            if (this.CanCreate(type))
            {
                var truck = this.VehicleFactory.CreateTruck(make, model, price, int.Parse(additionalParam));

                return truck;
            }

            if (this.Successor != null)
            {
                return this.Successor.Create( type,  make,  model,  price,  additionalParam);
            }

            return null;
        }
    }
}
