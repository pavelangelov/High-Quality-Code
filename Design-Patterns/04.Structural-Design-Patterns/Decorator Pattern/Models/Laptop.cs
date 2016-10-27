using Decorator_Pattern.Contracts;

namespace Decorator_Pattern.Models
{
    public class Laptop : INetClient
    {
        public Laptop(string name)
        {
            this.Name = name;
            this.IsConnect = false;
        }

        public string Name { get; set; }

        public bool IsConnect { get; set; }

        public string SurfInNet()
        {
            if (this.IsConnect)
            {
                return "I`m in the Web :)";
            }
            else
            {
                return "I`m not connected to Internet :(";
            }
        }
    }
}
