using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FlightPlanner.Tests
{
    [TestClass]
    public class PlanFlightsTests
    {
        private PlanFlights _target;
        string[] a = { "San Jose -> New York", "San Jose -> Anchorage", "New York -> San Jose" };

        [TestInitialize]
        public void Setup()
        {
            _target = new PlanFlights();
            _target.Initialize(a);
        }

        [TestMethod]
        public void Initialize_ArrayWith2StartCities_DictionaryCountShouldBe2()
        {
            //Arrange
            var expected = 2;

            //Assert
            Assert.AreEqual(expected, _target.planner.Count);
        }

        [TestMethod]
        public void FirstCity_SanJose_ExpectedResultSanJose()
        {
            //Arrange
            var expected = "San Jose";

            //Act
            var result = _target.FirstCity(expected);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FirstCity_InvalidCity_ShouldReturnInvalidMessage()
        {
            //Arrange
            var expected = "You chose invalid city. Choose the starting city from list";

            //Act
            var result = _target.FirstCity("invalid city");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NextCity_SanJoseThenNewYork_ExpectedResultNewYork()
        {
            //Arrange
            var first = "San Jose";
            var expected = "New York";
            _target.FirstCity(first);

            //Act
            var result = _target.NextCity(expected);

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void NextCity_InvalidCity_ShouldReturnInvalidMessage()
        {
            //Arrange
            var expected = "You chose invalid city. Choose from list";

            //Act
            var result = _target.NextCity("invalid city");

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void FinalRoute_SanJoseNewYorkSanJose_ShouldReturnExpectedRoute()
        {
            //Arrange
            var expected = "San Jose -> New York -> San Jose";
            var first = "San Jose";
            var next = "New York";
            _target.FirstCity(first);
            _target.NextCity(next);
            _target.NextCity(first);

            //Act
            var result = _target.FinalRoute();

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}
