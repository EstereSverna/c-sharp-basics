using NUnit.Framework;
using exercise8;

namespace Arithmetic.Tests
{
    public class Exercise8Tests
    {
        private SalaryCalculator _target;

        [SetUp]
        public void Setup()
        {
            _target = new SalaryCalculator();
        }

        [Test]
        public void Calculate_Hours40BasePay8_ShouldBeExpectedResult()
        {
            //arrange
            var hours = 40;
            var basePay = 8;
            var expected = hours * basePay;

            //act
            var result = _target.Calculate(basePay,hours);

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void Calculate_Hours70BasePay8_ShouldThrowException()
        {
            //arrange
            var hours = 70;
            var basePay = 8;

            //assert
            Assert.Throws<InvalidBasePayOrHours>(() => _target.Calculate(basePay, hours));
        }

        [Test]
        public void Calculate_Hours40BasePay5_ShouldThrowException()
        {
            //arrange
            var hours = 40;
            var basePay = 5;

            //assert
            Assert.Throws<InvalidBasePayOrHours>(() => _target.Calculate(basePay, hours));
        }

        [Test]
        public void Calculate_Hours60BasePay8_ShouldCalculateExtraForOvertimeAsExpectedResult()
        {
            //arrange
            var hours = 60;
            var basePay = 8;
            var expected = 40 * basePay + (hours - 40) * basePay * 1.5;

            //act
            var result = _target.Calculate(basePay, hours);

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}
