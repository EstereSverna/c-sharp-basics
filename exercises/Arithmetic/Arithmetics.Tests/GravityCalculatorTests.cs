using GravityCalculator;
using NUnit.Framework;

namespace Arithmetic.Tests
{
    public class GravityCalculatorTests
    {
        private Calculations _target;

        [SetUp]
        public void Setup()
        {
            _target = new Calculations();
        }

        [Test]
        public void Calculate_FallingTime10_ExpectedResultNegative490Point5()
        {
            //arrange
            var fallingTime = 10;
            var expected = -490.5;

            //act
            var result = _target.Calculate(fallingTime, 0, 0);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
