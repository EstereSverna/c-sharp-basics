using exercise_5;
using NUnit.Framework;

namespace DateTest
{
    public class Tests
    {
        public Date _target;

        [SetUp]
        public void Setup()
        {
            _target = new Date(1999, 11, 12);
        }

        [Test]
        public void GetDay_ExpectedResult12()
        {
            //Arrange
            var expected = 12; 

            //Assert
            Assert.AreEqual(expected, _target.Day);
        }

        [Test]
        public void SetDay_Day13_ExpectedResult13()
        {
            //Arrange
            var expected = 13;

            //Act
            _target.Day = expected;

            //Assert
            Assert.AreEqual(expected, _target.Day);
        }

        [Test]
        public void GetMonth_ExpectedResult11()
        {
            //Arrange
            var expected = 11;

            //Assert
            Assert.AreEqual(expected, _target.Month);
        }

        [Test]
        public void SetMonth_Month1_ExpectedResult1()
        {
            //Arrange
            var expected = 1;

            //Act
            _target.Month = expected;

            //Assert
            Assert.AreEqual(expected, _target.Month);
        }

        [Test]
        public void GetYear_ExpectedResult1999()
        {
            //Arrange
            var expected = 1999;

            //Assert
            Assert.AreEqual(expected, _target.Year);
        }

        [Test]
        public void SetYear_Year2022_ExpectedResult2022()
        {
            //Arrange
            var expected = 2022;

            //Act
            _target.Year = expected;

            //Assert
            Assert.AreEqual(expected, _target.Year);
        }

        [Test]
        public void DisplayDate_ShouldBeExpectedResult()
        {
            //Arrange
            var expected = "11/12/1999";

            //Assert
            Assert.AreEqual(expected, _target.DisplayDate());
        }
    }
}