using NUnit.Framework;
using System;

namespace Hierarchy.Tests
{
    public class MouseTests
    {
        public Mouse _target;
        public Food _food;

        [SetUp]
        public void Setup()
        {
            _target = new Mouse("Mouse", "Gray", 1.1, "Home");
        }

        [Test]
        public void MakeSound_ExpectedResultsqueeak()
        {
            //Arrange
            var expected = "squeeak";

            //Assert
            Assert.AreEqual(expected, _target.MakeSound());
        }

        [Test]
        public void ToString_ShouldBeExpected()
        {
            //Arrange
            var expected = "Mouse[Gray, 1.1, Home, 0] ";

            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }

        [Test]
        public void EatMeat_ShouldThrowException()
        {
            //Arrange
            _food = new Meat(1);

            //Assert
            Assert.Throws<ArgumentException>(() => _target.Eat(_food));
        }

        [Test]
        public void EatVegetable_ToStringShouldBeEqualToExpectedResult()
        {
            //Arrange
            _food = new Vegetable(1);
            var expected = "Mouse[Gray, 1.1, Home, 1] ";

            //Act
            _target.Eat(_food);

            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }
    }
}
