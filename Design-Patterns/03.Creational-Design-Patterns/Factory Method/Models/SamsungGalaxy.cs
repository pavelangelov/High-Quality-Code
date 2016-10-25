using Factory_Method.Contracts;
using Factory_Method.Utils;

namespace Factory_Method.Models
{
    public class SamsungGalaxy : IGsm
    {
        public SamsungGalaxy()
        {
            this.Manufacturer = Constants.GalaxyManufacturer;
            this.Model = Constants.GalaxyModel;
            this.DisplaySize = Constants.GalaxyDisplaySize;
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
