using CalculateArea;
using NUnit.Framework;

namespace Arithmetic.Tests
{
    public class CalculateAreaTests
    {
        private Geometry _target;

        [SetUp]
        public void Setup()
        {
            _target = new Geometry();
        }

        [Test]
        public void AreaOfCircle_ValidRadius5_ExpectedResult78Point5()
        {
            //arrange
            var expected = 78.5;
            var result = _target.AreaOfCircle(5);

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AreaOfRectangle_ValidLength5ValidWidth3_ExpectedResult15()
        {
            //arrange
            var expected = 15.0;
            var result = _target.AreaOfRectangle(5, 3);

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void AreaOfTriangle_ValidGround7ValidHeight5_ExpectedResult17Point5()
        {
            //arrange
            var expected = 17.5;
            var result = _target.AreaOfTriangle(7, 5);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
