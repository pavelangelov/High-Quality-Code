namespace Cars.Tests.JustMock
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using Cars.Contracts;
    using Cars.Tests.JustMock.Mocks;
    using Cars.Controllers;
    using Cars.Models;

    using Telerik.JustMock;

    [TestClass]
    public class CarsControllerTests
    {
        private readonly ICarsRepository carsData;
        private CarsController controller;

        public CarsControllerTests()
            : this(new JustMockCarsRepository())
        // : this(new MoqCarsRepository())
        {
        }

        private CarsControllerTests(ICarsRepositoryMock carsDataMock)
        {
            this.carsData = carsDataMock.CarsData;
        }

        [TestInitialize]
        public void CreateController()
        {
            this.controller = new CarsController(this.carsData);
        }

        [TestMethod]
        public void IndexShouldReturnAllCars()
        {
            var model = (ICollection<Car>)this.GetModel(() => this.controller.Index());

            Assert.AreEqual(4, model.Count);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarIsNull()
        {
            var model = (Car)this.GetModel(() => this.controller.Add(null));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarMakeIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void AddingCarShouldThrowArgumentNullExceptionIfCarModelIsNull()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));
        }

        [TestMethod]
        public void AddingCarShouldReturnADetail()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };

            var model = (Car)this.GetModel(() => this.controller.Add(car));

            Assert.AreEqual(1, model.Id);
            Assert.AreEqual("Audi", model.Make);
            Assert.AreEqual("A5", model.Model);
            Assert.AreEqual(2005, model.Year);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Details_ShouldThrow_IfCarIdIsIncorrect()
        {
            var car = new Car
            {
                Id = 15,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };
            int searchedId = 16;

            this.controller.Add(car);
            Mock.Arrange(() => this.carsData.GetById(Arg.AnyInt)).Returns(this.carsData.GetById(searchedId));

            var model = (Car)this.GetModel(() => this.controller.Details(16));
        }

        [TestMethod]
        public void Details_ShouldReturnTheCar_IfIdIsCorrect()
        {
            var car = new Car
            {
                Id = 1,
                Make = "BMW",
                Model = "330d",
                Year = 2014
            };
            int searchedId = 1;

            this.controller.Add(car);

            var model = (Car)this.GetModel(() => this.controller.Details(searchedId));

            Assert.AreEqual(car.Id, model.Id);
        }

        [TestMethod]
        public void Search_ShouldReturnNull_IfConditionIsIncorrect()
        {
            string condition = "asd";
            Mock.Arrange(() => this.carsData.Search(Arg.AnyString)).DoNothing();
            var searchResult = this.controller.Search(condition);

            Assert.IsNull(searchResult.Model);
        }

        [TestMethod]
        public void Search_ShouldReturnCollection_IfConditionIsCorrect()
        {
            Mock.Arrange(() => this.carsData.Search(Arg.Matches<string>(x => x == "make" || x == "model"))).Returns(new List<Car>());
            var searchResult = this.controller.Search("make");

            Assert.IsNotNull(searchResult.Model);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Sort_ShouldThrow_IfSortingParametherIsIncorrect()
        {
            string sortingParam = "tires";

            var soretedCars = this.GetModel(() => this.controller.Sort(sortingParam));
        }

        [TestMethod]
        public void Sort_ShouldReturnCollection_IfSortingParametherIsCorrect()
        {
            string sortingParam = "make";

            var soretedCars = this.GetModel(() => this.controller.Sort(sortingParam));

            Assert.IsTrue(sortingParam.Count() > 0);
        }
        private object GetModel(Func<IView> funcView)
        {
            var view = funcView();
            return view.Model;
        }
        
    }
}
