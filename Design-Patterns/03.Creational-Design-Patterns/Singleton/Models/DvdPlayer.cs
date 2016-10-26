using System.Collections.Generic;

using Singleton.Contracts;

namespace Singleton.Models
{
    public class DvdPlayer : Product, IProduct
    {
        public DvdPlayer(string brand, string model, IEnumerable<string> parameters) 
            : base(brand, model, parameters)
        {
        }
    }
}
