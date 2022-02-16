using DragRace;
using NUnit.Framework;

namespace DragraceTests
{
    internal class VolvoTests
    {
        public Volvo _target;

        [SetUp]
        public void Setup()
        {
            _target = new Volvo();
        }

        [Test]
        public void StartEngine_ExpectedResultrrrrr()
        {
            //Arrange
            var expected = "...rrrrrr.....";

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
        public void SpeedUp_ExpectedSpeed5()
        {
            //Arrange
            var expected = 5;

            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [Test]
        public void SlowDown_ExpectedSpeedMinus5()
        {
            //Arrange
            var expected = -5;

            //Act
            _target.SlowDown();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [Test]
        public void UseNitrousOxideEngine_ExpectedSpeed100()
        {
            //Arrange
            var expected = 100;

            //Act
            _target.UseNitrousOxideEngine();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}
