using Dealership.Contracts;
using Dealership.Common.Enums;

namespace Dealership.Factories
{
    public interface IUserFactory
    {
        IUser CreateUser(string username, string firstName, string lastName, string password, Role role);
    }
}
