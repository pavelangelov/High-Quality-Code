using Dealership.Contracts;
using Dealership.Common.Enums;

namespace Dealership.Factories
{
    public class DealershipFactory : IDealershipFactory
    {
        private IVehicleFactory vehicleFactory;
        private IUserFactory userFactory;
        private ICommentFactory commentFactory;

        public DealershipFactory(IVehicleFactory vehicleFactory, IUserFactory userFactory, ICommentFactory commentFactory)
        {
            this.vehicleFactory = vehicleFactory;
            this.userFactory = userFactory;
            this.commentFactory = commentFactory;
        }

        public IVehicle CreateCar(string make, string model, decimal price, int seats)
        {
            var car = this.vehicleFactory.CreateCar(make, model,  price, seats);

            return car;
        }

        public IVehicle CreateMotorcycle(string make, string model, decimal price, string category)
        {
            var motorcycle = this.vehicleFactory.CreateMotorcycle(make, model, price, category);

            return motorcycle;
        }

        public IVehicle CreateTruck(string make, string model, decimal price, int weightCapacity)
        {
            var truck = this.vehicleFactory.CreateTruck(make, model, price, weightCapacity);

            return truck;
        }

        public IUser CreateUser(string username, string firstName, string lastName, string password, Role role)
        {
            var user = this.userFactory.CreateUser(username, firstName, lastName, password, role);

            return user;
        }

        public IComment CreateComment(string content)
        {
            var comment = this.commentFactory.CreateComment(content);

            return comment;
        }
    }
}
