using Dealership.Engine;

namespace Dealership.Factories
{
    public interface ICommandFactory
    {
        Command CreateCommand(string parameters);
    }
}
