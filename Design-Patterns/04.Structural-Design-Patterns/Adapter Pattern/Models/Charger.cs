using Adapter_Pattern.Contracts;

namespace Adapter_Pattern.Models
{
    public class Charger : ICharger
    {
        public string Charge(IRechargeble rechargebleItem)
        {
            var message = rechargebleItem.Charge();

            return message;
        }
    }
}
