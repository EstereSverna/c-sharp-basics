using DragRace;
using NUnit.Framework;

namespace Dragrece.Tests
{
    public class Tests
    {
        public Audi _target;

        [SetUp]
        public void Setup()
        {
            _target = new Audi();
        }

        [Test]
        public void StartEngine_ShouldReturnRrrrr()
        {
            //Arrange
            var expected = "Rrrrrrr.....";

            //Assert
            Assert.AreEqual(expected, _target.StartEngine());
        }
    }
}