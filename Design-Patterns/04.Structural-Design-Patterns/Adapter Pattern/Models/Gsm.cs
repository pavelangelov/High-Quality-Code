using Adapter_Pattern.Contracts;

namespace Adapter_Pattern.Models
{
    public class Gsm : Phone, IRechargeble
    {
        public const int MaxBatteryCharge = 100;
        public Gsm(string manufacturer, string model) 
            : base(manufacturer, model)
        {
            this.BattryCharge = 50;
        }

        public int BattryCharge { get; set; }

        public string Charge()
        {
            if (this.BattryCharge < 90)
            {
                this.BattryCharge += 10;
            }
            else if (this.BattryCharge < MaxBatteryCharge)
            {
                this.BattryCharge = 100;
            }
            else
            {
                return "The battery is already fully charged!";
            }

            return $"The battery is charged on {this.BattryCharge}%.";
        }
    }
}
