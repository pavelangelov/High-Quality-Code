using Adapter_Pattern.Contracts;
using Adapter_Pattern.Models;

namespace Adapter_Pattern
{
    public class Startup
    {
        public static void Main()
        {
            var adapter = new Charger();
            var logger = new ConsoleLogger();

            var phones = new IRechargeble[]
            {
                new Gsm("Apple", "IPhone 6S"),
                new Gsm("Samsung", "Galaxy S6"),
                new Gsm("LG", "Nexus 5")
            };

            foreach (var phone in phones)
            {
                logger.WriteLine(adapter.Charge(phone));
            }
        }
    }
}
