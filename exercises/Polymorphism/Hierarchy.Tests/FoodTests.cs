using NUnit.Framework;

namespace Hierarchy.Tests
{
    public class Tests
    {
        public Meat _target;
        public Vegetable _target1;

        [SetUp]
        public void Setup()
        {
            _target = new Meat(2);
            _target1 = new Vegetable(1);
        }

        [Test]
        public void Quantity_Meat2_ExpectedResult2()
        {
            //Arrange
            var expected = 2;

            //Assert
            Assert.AreEqual(expected, _target._quantity);
        }

        [Test]
        public void Quantity_Vegetable1_ExpectedResult1()
        {
            //Arrange
            var expected = 1;

            //Assert
            Assert.AreEqual(expected, _target1._quantity);
        }
    }
}