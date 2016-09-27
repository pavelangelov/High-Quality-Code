using System;
using NUnit.Framework;

namespace Matrix.Tests.UtilsTests
{
    [TestFixture]
    public class DeltaUtils
    {
        [Test]
        [TestCase(null)]
        [TestCase("")]
        [TestCase("left")]
        [TestCase("Downleft")]
        [TestCase("upleft")]
        [TestCase("DL")]
        [TestCase("Down Left")]
        [TestCase("some string")]
        public void GetDeltasByDirectionShould_ThrowArgumentException_IfPassedParameterIsIncorect(string invalidDirection)
        {
            Assert.Throws<ArgumentException>(() => MatrixHomework.Utils.DeltaUtils.GetDeltasByDirection(invalidDirection));
        }

        [Test]
        [TestCase("DownRight", 1, 1)]
        [TestCase("Down", 1, 0)]
        [TestCase("DownLeft", 1, -1)]
        [TestCase("Left", 0, -1)]
        [TestCase("UpLeft", -1, -1)]
        [TestCase("Up", -1, 0)]
        [TestCase("UpRight", -1, 1)]
        [TestCase("Right", 0, 1)]
        public void GetDeltasByDirectionShould_ReturnCorectIDelta_IfPassedParameterIsValid(string validDirection, int deltaX, int deltaY)
        {
            var delta = MatrixHomework.Utils.DeltaUtils.GetDeltasByDirection(validDirection);

            Assert.IsTrue(delta.GetType().Name == "Delta");
            Assert.AreEqual(deltaX, delta.X);
            Assert.AreEqual(deltaY, delta.Y);
        }
    }
}
