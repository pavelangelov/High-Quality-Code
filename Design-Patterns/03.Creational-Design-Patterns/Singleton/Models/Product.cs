using System.Collections.Generic;

using Singleton.Contracts;

namespace Singleton.Models
{
    public abstract class Product : IProduct
    {
        protected Product(string brand, string model, IEnumerable<string> features)
        {
            this.Brand = brand;
            this.Model = model;
            this.Features = features;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public IEnumerable<string> Features { get; set; }
    }
}
