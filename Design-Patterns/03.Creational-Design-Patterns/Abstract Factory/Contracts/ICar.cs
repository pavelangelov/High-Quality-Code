using System.Collections.Generic;

namespace Abstract_Factory.Contracts
{
    public interface ICar
    {
        string Brand { get; set; }

        string Model { get; set; }

        int Year { get; }

        IEnumerable<string> Extras { get; set; }
    }
}
