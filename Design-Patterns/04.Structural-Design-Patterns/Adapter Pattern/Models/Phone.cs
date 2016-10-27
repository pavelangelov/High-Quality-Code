using Adapter_Pattern.Contracts;

namespace Adapter_Pattern.Models
{
    public abstract class Phone : IPhone
    {
        protected Phone(string manufacturer, string model)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
        }

        public string Manufacturer { get; set; }

        public string Model { get; set; }
    }
}
