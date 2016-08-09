using System;
using System.IO;

using NUnit.Framework;
using Moq;

using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Tests.Engine.CosmeticsEngineTests
{
    [TestFixture]
    public class CreateShampoo_Should
    {
        [Test]
        public void CallCreateShampoo_FromFactory()
        {
            // Arrange
            var input = "CreateShampoo Cool Nivea 0.50 men 500 everyday";
            Console.SetIn(new StringReader(input));
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedCart.Object);
            mockedFactory.Setup(x => x.CreateShampoo(It.IsAny<string>(),
                                                       It.IsAny<string>(),
                                                       It.IsAny<decimal>(),
                                                       It.IsAny<GenderType>(),
                                                       It.IsAny<uint>(),
                                                       It.IsAny<UsageType>()));
            // Act
            mockedEngine.Start();

            // Assert
            mockedFactory.Verify(x => x.CreateShampoo(It.IsAny<string>(),
                                                       It.IsAny<string>(),
                                                       It.IsAny<decimal>(),
                                                       It.IsAny<GenderType>(),
                                                       It.IsAny<uint>(),
                                                       It.IsAny<UsageType>()), Times.Once);
        }
    }
}
