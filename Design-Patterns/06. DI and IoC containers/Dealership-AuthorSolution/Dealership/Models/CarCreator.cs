using Dealership.Contracts;
using Dealership.Common.Enums;
using Dealership.Factories;

namespace Dealership.Models
{
    public class CarCreator : VehicleCreator, IVehicleCreator
    {

        public CarCreator(IVehicleFactory vehicleFactory) 
            : base(vehicleFactory)
        {
        }
        

        protected override bool CanCreate(VehicleType type)
        {
            return VehicleType.Car == type;
        }

        public override IVehicle Create(VehicleType type, string make, string model, decimal price, string additionalParam)
        {
            if (this.CanCreate(type))
            {
                var car = this.VehicleFactory.CreateCar( make,  model,  price,  int.Parse(additionalParam));
                return car;
            }

            if (this.Successor != null)
            {
                return this.Successor.Create( type,  make,  model,  price,  additionalParam);
            }

            return null;
        }
    }
}
