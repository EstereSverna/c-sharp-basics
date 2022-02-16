using DragRace;
using NUnit.Framework;

namespace DragraceTests
{
    public class LadaTests
    {
        public Lada _target;

        [SetUp]
        public void Setup()
        {
            _target = new Lada();
        }

        [Test]
        public void StartEngine_ExpectedMessagerumrumrum()
        {
            //Arrange
            var expected = ".--- rum rum rum ----";

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
        public void SpeedUp_ExpectedSpeed50()
        {
            //Arrange
            var expected = 50;

            //Act
            _target.SpeedUp();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }

        [Test]
        public void SlowDown_ExpectedSpeedMinus50()
        {
            //Arrange
            var expected = -50;

            //Act
            _target.SlowDown();

            //Assert
            Assert.AreEqual(expected, _target.ShowCurrentSpeed());
        }
    }
}
