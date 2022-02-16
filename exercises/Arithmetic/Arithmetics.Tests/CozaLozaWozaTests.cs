using CozaLozaWoza;
using NUnit.Framework;

namespace Arithmetic.Tests
{
    public class CozaLozaWozaTests
    {
        public WriteCoza _target;
        [SetUp]
        public void Setup()
        {
            _target = new WriteCoza();
        }

        [Test]
        public void Write_Number105_ExpectedResultCozaLozaWoza()
        {
            //Arrange
            var expected = "CozaLozaWoza ";
            var n = 105;

            //Act
            var result = _target.Write(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Write_Number35_ExpectedResultLozaWoza()
        {
            //Arrange
            var expected = "LozaWoza ";
            var n = 35;

            //Act
            var result = _target.Write(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Write_Number21_ExpectedResultCozaWoza()
        {
            //Arrange
            var expected = "CozaWoza ";
            var n = 21;

            //Act
            var result = _target.Write(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Write_Number15_ExpectedResultCozaLoza()
        {
            //Arrange
            var expected = "CozaLoza ";
            var n = 15;

            //Act
            var result = _target.Write(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Write_Number7_ExpectedResultWoza()
        {
            //Arrange
            var expected = "Woza ";
            var n = 7;

            //Act
            var result = _target.Write(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Write_Number5_ExpectedResultLoza()
        {
            //Arrange
            var expected = "Loza ";
            var n = 5;

            //Act
            var result = _target.Write(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Write_Number3_ExpectedResultCoza()
        {
            //Arrange
            var expected = "Coza ";
            var n = 3;

            //Act
            var result = _target.Write(n);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Write_Number4_ExpectedResult4()
        {
            //Arrange
            var expected = "4 ";
            var n = 4;

            //Act
            var result = _target.Write(n);

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
