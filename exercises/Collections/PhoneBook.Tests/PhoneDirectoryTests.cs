using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace PhoneBook.Tests
{
    [TestClass]
    public class PhoneDirectoryTests
    {
        private PhoneDirectory _target;

        [TestInitialize]
        public void Setup()
        {
            _target = new PhoneDirectory();
        }

        [TestMethod]
        public void PutNumber_Janis123_ShouldContainJanis()
        {
            //Arrange
            var number = "123";
            var name = "Janis";

           //Act
            _target.PutNumber(name, number);

            //Assert
            Assert.AreEqual(number, _target.GetNumber(name));
        }

        [TestMethod]
        public void GetNumber_Janis_ShouldBeNull()
        {
            //Arrange
            var name = "Janis";

            //Act
            var number = _target.GetNumber(name);

            //Assert
            Assert.AreEqual(null, number);
        }

        [TestMethod]
        public void Find_PutNumberAndFind_IndexShouldBeZero()
        {
            //Arrange
            var expected = 0;
            var number = "123";
            var name = "Janis";
            _target.PutNumber(name, number);

            //Act
            var result = _target.Find(name);

            //Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Find_FindJanis_ShouldBeMinus1()
        {
            //Act
            var result = _target.Find("Janis");

            //Assert
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        public void PutNumber_NoName_ShouldThrowException()
        {
            //Arrange
            var number = "123";

            //Assert
            Assert.ThrowsException<ArgumentException>(() => _target.PutNumber(null, number));
        }

        [TestMethod]
        public void PutNumber_NoNumber_ShouldThrowException()
        {
            //Arrange
            var name = "Janis";

            //Assert
            Assert.ThrowsException<ArgumentException>(() => _target.PutNumber(name, null));
        }
    }
}
