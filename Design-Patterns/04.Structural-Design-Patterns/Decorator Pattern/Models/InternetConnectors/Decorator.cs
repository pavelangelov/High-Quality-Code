using Decorator_Pattern.Contracts;

namespace Decorator_Pattern.Models.InternetConnectors
{
    /// <summary>
    /// The 'Decorator' abstract class
    /// </summary>
    public abstract class Decorator : INetConnector
    {
        protected INetConnector internetConnector;

        protected Decorator(INetConnector internetConnector)
        {
            this.internetConnector = internetConnector;
        }

        public abstract string ConnectDevice(INetClient device);

        public virtual string DisconnectDevice(INetClient device)
        {
            var connectionMsg = internetConnector.ConnectDevice(device);

            return connectionMsg;
        }
    }
}
