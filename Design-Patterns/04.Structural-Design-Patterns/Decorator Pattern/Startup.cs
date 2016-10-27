using System;

using Decorator_Pattern.Contracts;
using Decorator_Pattern.Models;
using Decorator_Pattern.Models.InternetConnectors;

namespace Decorator_Pattern
{
    public class Startup
    {
        public static void Main()
        {
            var logger = new ConsoleLogger();

            INetClient laptop = new Laptop("My-Laptop");

            // Create concrete internet provider
            INetConnector internetProvider = new InternetProvider();

            ConnectDevice(internetProvider, laptop, logger);
            DisconnectDevice(internetProvider, laptop, logger);

            // Create first Decorator
            INetConnector router = new WiFiRouter(internetProvider);

            ConnectDevice(router, laptop, logger);
            DisconnectDevice(router, laptop, logger);

            // Create second Decorator
            INetConnector mobileNet = new MobileBroadband(internetProvider);

            ConnectDevice(mobileNet, laptop, logger);
            DisconnectDevice(mobileNet, laptop, logger);
        }

        private static void ConnectDevice(INetConnector internetProvider, INetClient device, ILogger logger)
        {
            logger.WriteLine("------ Start Connection --------");
            logger.WriteLine(internetProvider.ConnectDevice(device));
            logger.WriteLine(device.SurfInNet());
        }


        private static void DisconnectDevice(INetConnector internetProvider, INetClient device, ILogger logger)
        {
            logger.WriteLine(internetProvider.DisconnectDevice(device));
            logger.WriteLine(device.SurfInNet());
            logger.WriteLine("------ End Connection --------");
            logger.WriteLine(Environment.NewLine);
        }
    }
}
