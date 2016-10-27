using Decorator_Pattern.Contracts;

namespace Decorator_Pattern.Models.InternetConnectors
{
    public class MobileBroadband : Decorator
    {
        public MobileBroadband(INetConnector internetConnector) 
            : base(internetConnector)
        {
        }

        public override string ConnectDevice(INetClient device)
        {
            var connectionMsg = base.internetConnector.ConnectDevice(device);

            return connectionMsg + " Connection via 4G Network.";
        }

        public override string DisconnectDevice(INetClient device)
        {
            if (device.IsConnect)
            {
                this.CalculateConsumedDataPrice();
            }

            return base.DisconnectDevice(device);
        }

        public void CalculateConsumedDataPrice()
        {
            // Calculate how much the customer must pay for using mobile data
        }
    }
}
