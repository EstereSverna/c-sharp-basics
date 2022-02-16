using NUnit.Framework;
using System;

namespace Hierarchy.Tests
{
    internal class TigerTests
    {
        public Tiger _target;
        public Food _food;

        [SetUp]
        public void Setup()
        {
            _target = new Tiger("Tiger", "Gray", 1.1, "Home");
        }

        [Test]
        public void MakeSound_ExpectedResultROAR()
        {
            //Arrange
            var expected = "ROAR!!!";

            //Assert
            Assert.AreEqual(expected, _target.MakeSound());
        }

        [Test]
        public void ToString_ShouldBeEqualWithExpected()
        {
            //Arrange
            var expected = "Tiger[Gray, 1.1, Home, 0] ";

            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }

        [Test]
        public void EatMeat_ShouldBeEqualWithExpected()
        {
            //Arrange
            _food = new Meat(1);
            var expected = "Tiger[Gray, 1.1, Home, 1] ";

            //Act
            _target.Eat(_food);

            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }

        [Test]
        public void EatVegetable_ShouldThrowException()
        {
            //Arrange
            _food = new Vegetable(1);

            //Assert
            Assert.Throws<ArgumentException>(() => _target.Eat(_food));
        }
    }
}
