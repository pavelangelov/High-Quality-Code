using NUnit.Framework;
using Moq;

using MatrixHomework;
using MatrixHomework.Contracts;

namespace Matrix.Tests.StartupTests
{
    [TestFixture]
    public class GetMatrixSizeFromUserShould_
    {

        [Test]
        [TestCase("1", 1)]
        [TestCase("2", 2)]
        [TestCase("3", 3)]
        [TestCase("4", 4)]
        [TestCase("20", 20)]
        public void GetMatrixSizeFromUserShould_ReturnCorrectNumber_IfInputIsValid(string input, int expectedResult)
        {
            var mockedLogger = new Mock<ILogger>();
            var mockedReader = new Mock<IReader>();

            mockedLogger.Setup(x => x.WriteLine(It.IsIn<string>())).Verifiable();
            mockedReader.Setup(x => x.ReadLine()).Returns(input);

            var result = Startup.GetMatrixSizeFromUser(mockedLogger.Object, mockedReader.Object);

            Assert.AreEqual(expectedResult, result);
        }

        [Test]
        [TestCase("one", "1", 1)]
        [TestCase("2a", "2", 2)]
        [TestCase("number", "3", 3)]
        [TestCase("aaa", "4", 4)]
        [TestCase("word", "2", 2)]
        public void GetMatrixSizeFromUserShould_NotToThrow_IfInputIsInvalid(string invalidInput, string validInput, int expectedResult)
        {
            var mockedLogger = new Mock<ILogger>();
            var mockedReader = new Mock<IReader>();

            mockedLogger.Setup(x => x.Write(It.IsIn<string>())).Verifiable();
            mockedReader.SetupSequence(x => x.ReadLine()).Returns(invalidInput)
                                                            .Returns(validInput);

            int result = Startup.GetMatrixSizeFromUser(mockedLogger.Object, mockedReader.Object);

            Assert.AreEqual(expectedResult, result);
            mockedLogger.Verify(x => x.Write(It.IsAny<string>()), Times.Exactly(2));
            mockedReader.Verify(x => x.ReadLine(), Times.Exactly(2));
        }
    }
}
