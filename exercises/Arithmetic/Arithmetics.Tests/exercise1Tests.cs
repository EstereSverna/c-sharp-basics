using exercise1;
using NUnit.Framework;

namespace Arithmetic.Tests
{
    public class Tests
    {
        private TestNumbers _target;

        [SetUp]
        public void Setup()
        {
            _target = new TestNumbers();
        }

        [Test]
        public void Test_AIs15_ShouldReturnTrue()
        {
            //arrange
            int a = 15;
            int b = 3;

            //assert
            Assert.IsTrue(_target.Test(a, b));
        }

        [Test]
        public void Test_BIs15_ShouldReturnTrue()
        {
            //arrange
            int a = 2;
            int b = 15;

            //assert
            Assert.IsTrue(_target.Test(a, b));
        }

        [Test]
        public void Test_APlusBIs15_ShouldReturnTrue()
        {
            //arrange
            int a = 1;
            int b = 14;

            //assert
            Assert.IsTrue(_target.Test(a, b));
        }

        [Test]
        public void Test_AMinusBIs15_ShouldReturnTrue()
        {
            //arrange
            int a = 32;
            int b = 17;

            //assert
            Assert.IsTrue(_target.Test(a, b));
        }

        [Test]
        public void Test_BMinusAIs15_ShouldReturnTrue()
        {
            //arrange
            int a = 17;
            int b = 32;

            //assert
            Assert.IsTrue(_target.Test(a, b));
        }

        [Test]
        public void Test_NeitherOfNumbersNorTheirSumOrDifferenceIs15_ShouldReturnFalse()
        {
            //arrange
            int a = 3;
            int b = 5;

            //assert
            Assert.IsFalse(_target.Test(a, b));
        }
    }
}