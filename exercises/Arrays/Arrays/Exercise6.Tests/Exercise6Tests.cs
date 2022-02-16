using NUnit.Framework;
using System.Linq;

namespace Exercise6.Tests
{
    public class Tests
    {
        private Exercise6 _target;

        [SetUp]
        public void Setup()
        {
            _target = new Exercise6();
        }

        [Test]
        public void CreateRndArray_ShouldContain10Elements()
        {
            // arrange
            var expected = 10;

            //act
            var arrayElementCount = _target.CreateRndArray().Count();

            // assert
            Assert.AreEqual(expected, arrayElementCount);
        }

        [Test]
        public void ArrayFromRndArray_RandomArray_ArrayShouldBeDifferentFromRandomArray()
        {
            // arrange
            var array1 = _target.CreateRndArray();

            //act
            var array2 = _target.ArrayFromRndArray(array1);

            // assert
            Assert.AreNotEqual(array1, array2);
        }

        [Test]
        public void CreateRndArray_ValuesShouldBeInIntervalFrom1To100()
        {
            //arrange
            var min = 1;
            var max = 100;
            var array = _target.CreateRndArray();

            //act
            var resultMax = array.Max();
            var resultMin = array.Min();

            //assert
            Assert.GreaterOrEqual(max, resultMax);
            Assert.LessOrEqual(min, resultMin);
        }

        [Test]
        public void ArrayFromRndArray_LastNumberShouldBeMinus7()
        {
            // arrange
            var expected = -7;

            // act
            _target.ArrayFromRndArray(_target.CreateRndArray());
            var real = _target.MyArray1[9];

            // assert
            Assert.AreEqual(expected, real);
        }
    }
}