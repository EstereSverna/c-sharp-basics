using DragRace;
using NUnit.Framework;

namespace DragraceTests
{
    public class BmwTests
    {
        public Bmw _target;

        [SetUp]
        public void Setup()
        {
            _target = new Bmw();
        }

        [Test]
        public void StartEngine_ShouldReturnRrrrr()
        {
            //Arrange
            var expected = "Rrrrrrr.....";

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
        public void SpeedUp_ExpectedSpeed10()
        {
            //Arrange
            var expected = 10;

            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [Test]
        public void SlowDown_ExpectedSpeedMinus10()
        {
            //Arrange
            var expected = -10;

            //Act
            _target.SlowDown();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}
