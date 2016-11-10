using Dealership.Contracts;
using Dealership.Common.Enums;

namespace Dealership.Factories
{
    public class DealershipFactory : IDealershipFactory
    {
        private IUserFactory userFactory;
        private ICommentFactory commentFactory;

        public DealershipFactory(IVehicleFactory vehicleFactory, IUserFactory userFactory, ICommentFactory commentFactory)
        {
            this.userFactory = userFactory;
            this.commentFactory = commentFactory;
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
