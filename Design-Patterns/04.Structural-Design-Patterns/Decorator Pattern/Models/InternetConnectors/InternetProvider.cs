using Decorator_Pattern.Contracts;

namespace Decorator_Pattern.Models.InternetConnectors
{
    public class InternetProvider : INetConnector
    {
        public string ConnectDevice(INetClient device)
        {
            device.IsConnect = true;

            return $"{device.Name} is connected to Internet now.";
        }

        public string DisconnectDevice(INetClient device)
        {
            device.IsConnect = false;

            return $"{device.Name} is disconnected.";
        }
    }
}
