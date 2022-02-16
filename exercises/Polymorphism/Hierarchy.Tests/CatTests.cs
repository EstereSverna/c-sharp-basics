using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class CatTests
    {
        public Cat _target;
        public Food _food;

        [SetUp]
        public void Setup()
        {
            _target = new Cat("Cat", "Gray", 1.1, "Home", "Persian");
        }

        [Test]
        public void MakeSound_ExpectedResultmeowwww()
        {
            //Arrange
            var expected = "meowwww";

            //Assert
            Assert.AreEqual(expected, _target.MakeSound());
        }

        [Test]
        public void ToString_ToStringShouldBeExpected()
        {
            //Arrange
            var expected = "Cat[Gray, Persian, 1.1, Home, 0] ";

            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }

        [Test]
        public void EatMeat_ToStringShouldBeExpected()
        {
            //Arrange
            _food = new Meat(1);
            var expected = "Cat[Gray, Persian, 1.1, Home, 1] ";

            //Act
            _target.Eat(_food);

            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }

        [Test]
        public void EatVegetable_ToStringShouldBeExpected()
        {
            //Arrange
            _food = new Vegetable(1);
            var expected = "Cat[Gray, Persian, 1.1, Home, 1] ";

            //Act
            _target.Eat(_food);

            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }
    }
}
