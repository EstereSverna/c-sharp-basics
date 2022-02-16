using DragRace;
using NUnit.Framework;

namespace DragraceTests
{
    internal class TeslaTests
    {
        public Tesla _target;

        [SetUp]
        public void Setup()
        {
            _target = new Tesla();
        }

        [Test]
        public void StartEngine_ExpectedResultSilence()
        {
            //Arrange
            var expected = "-- silence ---";

            //Assert
            Assert.AreEqual(expected, _target.StartEngine());
        }

        [Test]
        public void ShowCurrentSpeed_ExpectedSpeed0()
        {
            //Arrange
            var expected = 0;

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [Test]
        public void SpeedUp_ExpectedSpeed15()
        {
            //Arrange
            var expected = 15;

            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [Test]
        public void SlowDown_ExpectedSpeedMinus15()
        {
            //Arrange
            var expected = -15;

            //Act
            _target.SlowDown();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}
