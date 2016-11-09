using Dealership.Engine;
using Ninject;
using System;
using System.IO;

namespace Dealership
{
    public class Startup
    {
        public static void Main()
        {
            var kernel = new StandardKernel(new DealershipModule());
            var engine = kernel.Get<DealershipEngine>();

            engine.Start();
        }
    }
}
