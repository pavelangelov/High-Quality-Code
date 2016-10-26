using System.Collections.Generic;

using Singleton.Contracts;

namespace Singleton.Models
{
    public class Fridge : Product, IProduct
    {
        public Fridge(string brand, string model, IEnumerable<string> parameters) 
            : base(brand, model, parameters)
        {
        }
    }
}
