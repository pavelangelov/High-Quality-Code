using Dealership.Contracts;
using Dealership.Engine;
using Dealership.Factories;
using Dealership.Models;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership
{
    public class DealershipModule : NinjectModule
    {
        private const string CarVehicleName = "Car";
        private const string TruckVehicleName = "Truck";
        private const string MotorcycleVehicleName = "Motorcycle";
        public override void Load()
        {
            Bind<DealershipEngine>().ToSelf().InSingletonScope();

            Bind<IVehicleFactory>().ToFactory().InSingletonScope();
            Bind<IUserFactory>().ToFactory().InSingletonScope();
            Bind<ICommentFactory>().ToFactory().InSingletonScope();

            Bind<IDealershipFactory>().To<DealershipFactory>().InSingletonScope();

            Bind<IReader>().To<ConsoleReader>();
            Bind<ILogger>().To<ConsoleLogger>();

            Bind<IComment>().To<Comment>();
            Bind<IUser>().To<User>();
            Bind<Car>().ToSelf();
            Bind<Motorcycle>().ToSelf();
            Bind<Truck>().ToSelf();
        }
    }
}
