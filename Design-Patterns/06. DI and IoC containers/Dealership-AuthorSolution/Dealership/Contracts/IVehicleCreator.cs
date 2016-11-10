using Dealership.Common.Enums;

namespace Dealership.Contracts
{
    public interface IVehicleCreator
    {
        void SetSuccsessor(IVehicleCreator successor);

        IVehicle Create(VehicleType type, string make, string model, decimal price, string additionalParam);
    }
}
