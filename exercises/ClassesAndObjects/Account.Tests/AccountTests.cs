using NUnit.Framework;

namespace Account.Tests
{
    public class Tests
    {
        public AccountActions _target;

        [SetUp]
        public void Setup()
        {
            _target = new AccountActions("name", 10);
        }

        [Test]
        public void Balance_ExpectedResult10()
        {
            //Arrange
            var expected = 10; 

            //Assert
            Assert.AreEqual(expected, _target.Balance());
        }

        [Test]
        public void Withdrawal_Amount10_ExpectedResult0()
        {
            //Arrange
            var expected = 0;
            var withdraw = 10;

            //Assert
            Assert.AreEqual(expected, _target.Withdrawal(withdraw));
        }

        [Test]
        public void Deposit_Amount10_ExpectedResult20()
        {
            //Arrange
            var expected = 20;
            var deposit = 10;

            //Act
            _target.Deposit(deposit);

            //Assert
            Assert.AreEqual(expected, _target.Balance());
        }

        [Test]
        public void ToString_ShouldBeExpectedResult()
        {
            //Arrange
            var expected = "name: 10";

            //Assert
            Assert.AreEqual(expected, _target.ToString());
        }
    }
}