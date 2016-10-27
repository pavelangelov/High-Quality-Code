using Decorator_Pattern.Contracts;

namespace Decorator_Pattern.Models.InternetConnectors
{
    public class WiFiRouter : Decorator
    {
        public WiFiRouter(INetConnector internetConnector) 
            : base(internetConnector)
        {
        }

        public override string ConnectDevice(INetClient device)
        {
            var connectionMsg = base.internetConnector.ConnectDevice(device);

            return connectionMsg + " Connection via Wi-Fi.";
        }
    }
}
