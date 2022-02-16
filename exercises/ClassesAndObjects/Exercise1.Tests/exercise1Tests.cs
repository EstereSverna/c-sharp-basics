using exercise_1;
using NUnit.Framework;

namespace Exercise1.Tests
{
    public class Tests
    {
        public Product _target;

        [SetUp]
        public void Setup()
        {
            _target = new Product("name", 1, 2);
        }

        [Test]
        public void ChangePrice_Price5_ExpectedResult5()
        {
            //Arrange
            var expected = 5;

            //Act
            _target.ChangePrice(expected);

            //Assert
            Assert.AreEqual(expected, _target.Price);
        }

        [Test]
        public void ChangeQuantity_Quantity5_ExpectedResult5()
        {
            //Arrange
            var expected = 5;

            //Act
            _target.ChangeQuantity(expected);

            //Assert
            Assert.AreEqual(expected, _target.Amount);
        }

        [Test]
        public void PrintProduct_ShouldBeExpectedResult()
        {
            //Arrange
            var expected = "name, price 1, amount 2";

            //Assert
            Assert.AreEqual(expected, _target.PrintProduct());
        }
    }
}