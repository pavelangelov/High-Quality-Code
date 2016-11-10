using Dealership.Contracts;
using Dealership.Engine;
using Dealership.Factories;
using Dealership.Models;
using Ninject;
using Ninject.Extensions.Factory;
using Ninject.Modules;

namespace Dealership
{
    public class DealershipModule : NinjectModule
    {
        private const string CarCreatorName = "CarCreator";
        private const string TruckCreatorName = "TruckCreator";
        private const string MotorcycleCreatorName = "MotorcycleCreator";
        public override void Load()
        {
            Bind<DealershipEngine>().ToSelf().InSingletonScope();

            Bind<IVehicleFactory>().ToFactory().InSingletonScope();
            Bind<IUserFactory>().ToFactory().InSingletonScope();
            Bind<ICommentFactory>().ToFactory().InSingletonScope();
            Bind<ICommandFactory>().ToFactory().InSingletonScope();

            Bind<IDealershipFactory>().ToFactory().InSingletonScope();

            Bind<IReader>().To<ConsoleReader>();
            Bind<ILogger>().To<ConsoleLogger>();

            Bind<IVehicleCreator>().To<CarCreator>().Named(CarCreatorName);
            Bind<IVehicleCreator>().To<TruckCreator>().Named(TruckCreatorName);
            Bind<IVehicleCreator>().To<MotorcycleCreator>().Named(MotorcycleCreatorName);

            Bind<IVehicleCreator>().ToMethod(ctx =>
            {
                IVehicleCreator carCreator = ctx.Kernel.Get<IVehicleCreator>(CarCreatorName);
                IVehicleCreator truckCreator = ctx.Kernel.Get<IVehicleCreator>(TruckCreatorName);
                IVehicleCreator motorcycleCreator = ctx.Kernel.Get<IVehicleCreator>(MotorcycleCreatorName);

                carCreator.SetSuccsessor(truckCreator);
                truckCreator.SetSuccsessor(motorcycleCreator);

                return carCreator;
            }).WhenInjectedInto<IEngine>();

            Bind<IComment>().To<Comment>();
            Bind<IUser>().To<User>();
            Bind<Car>().ToSelf();
            Bind<Motorcycle>().ToSelf();
            Bind<Truck>().ToSelf();
            Bind<Command>().ToSelf();
        }
    }
}
