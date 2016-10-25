using Factory_Method.Contracts;
using Factory_Method.Utils;

namespace Factory_Method.Models
{
    public class IPhone : IGsm
    {
        public IPhone()
        {
            this.Manufacturer = Constants.IPhoneManufacturer;
            this.Model = Constants.IPhoneModel;
            this.DisplaySize = Constants.IPhoneDisplaySize;
            this.Colors = Constants.DisplayColors;
        }

        public int Colors { get; private set; }

        public double DisplaySize { get; private set; }

        public string Manufacturer { get; private set; }

        public string Model { get; private set; }

        public override string ToString()
        {
            return $"{this.Manufacturer} {this.Model}\r\nDisplay size: {this.DisplaySize}\r\nDisplay colors: {this.Colors}";
        }
    }
}
