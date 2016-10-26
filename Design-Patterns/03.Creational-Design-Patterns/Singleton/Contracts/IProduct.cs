using System.Collections.Generic;

namespace Singleton.Contracts
{
    public interface IProduct
    {
        string Brand { get; set; }

        string Model { get; set; }

        IEnumerable<string> Features { get; set; }
    }
}
