using System;
using System.IO;

using NUnit.Framework;
using Moq;

using Cosmetics.Contracts;

namespace Cosmetics.Tests.Engine.CosmeticsEngineTests
{
    [TestFixture]
    public class ShowCategory_Should
    {
        [Test]
        public void CallPrint_FromCategory()
        {
            // Arrange
            var input = "ShowCategory ForMale";
            Console.SetIn(new StringReader(input));
            var mockedCategory = new Mock<ICategory>();
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedCart.Object);
            mockedEngine.Categories.Add("ForMale", mockedCategory.Object);
            mockedCategory.Setup(x => x.Print());
            // Act
            mockedEngine.Start();

            // Assert
            mockedCategory.Verify(x => x.Print(), Times.Once);
        }
    }
}
