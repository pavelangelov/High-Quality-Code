namespace Decorator_Pattern.Contracts
{
    public interface INetConnector
    {
        string ConnectDevice(INetClient device);

        string DisconnectDevice(INetClient device);
    }
}
