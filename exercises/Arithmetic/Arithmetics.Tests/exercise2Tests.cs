using exercise2;
using NUnit.Framework;

namespace Arithmetic.Tests
{
    public class exercise2Tests
    {
        private Check _target;

        [SetUp]
        public void Setup()
        {
            _target = new Check();
        }

        [Test]
        public void CheckOddEven_Numbers2And100_ShouldBeEven()
        {
            //arrange
            var n = 2;
            var p = 100;
            var expected = "Even number";

            //act
            var result = _target.CheckOddEven(n);
            var result1 = _target.CheckOddEven(p);

            //assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected, result1);
        }

        [Test]
        public void CheckOddEven_Numbers3And151_ShouldBeOdd()
        {
            //arrange
            var n = 3;
            var p = 151;
            var expected = "Odd number";

            //act
            var result = _target.CheckOddEven(n);
            var result1 = _target.CheckOddEven(p);

            //assert
            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected, result1);
        }

        [Test]
        public void CheckOddEven_Number0_ShouldBeEven()
        {
            //arrange
            var n = 0;
            var expected = "Even number";

            //act
            var result = _target.CheckOddEven(n);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
