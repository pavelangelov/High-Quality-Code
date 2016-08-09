using System;
using System.Collections.Generic;
using System.IO;

using NUnit.Framework;
using Moq;

using Cosmetics.Contracts;
using Cosmetics.Common;

namespace Cosmetics.Tests.Engine.CosmeticsEngineTests
{
    [TestFixture]
    public class CreateToothpaste_Should
    {
        [Test]
        public void CallCreateToothpaste_FromFactory()
        {
            // Arrange
            var input = "CreateToothpaste White+ Colgate 15.50 men fluor,bqla,golqma";
            Console.SetIn(new StringReader(input));
            var mockedFactory = new Mock<ICosmeticsFactory>();
            var mockedCart = new Mock<IShoppingCart>();
            var mockedEngine = new MockedCosmeticsEngine(mockedFactory.Object, mockedCart.Object);
            mockedFactory.Setup(x => x.CreateToothpaste(It.IsAny<string>(),
                                                       It.IsAny<string>(),
                                                       It.IsAny<decimal>(),
                                                       It.IsAny<GenderType>(),
                                                       It.IsAny<IList<string>>()));
            // Act
            mockedEngine.Start();

            // Assert
            mockedFactory.Verify(x => x.CreateToothpaste(It.IsAny<string>(),
                                                       It.IsAny<string>(),
                                                       It.IsAny<decimal>(),
                                                       It.IsAny<GenderType>(),
                                                       It.IsAny<IList<string>>()), Times.Once);
        }
    }
}
