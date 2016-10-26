using System.Collections.Generic;

using Singleton.Contracts;

namespace Singleton.Models
{
    public class Laptop : Product, IProduct
    {
        public Laptop(string brand, string model, IEnumerable<string> parameters)
            : base(brand, model, parameters)
        {
        }
    }
}
