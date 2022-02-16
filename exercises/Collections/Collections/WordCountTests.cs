using System.IO;
using NUnit.Framework;

namespace Collections
{
    public class WordCountTests
    {
        private WordCount.WordCount t;

        [SetUp]
        public void Setup()
        {
            var text = File.ReadAllText("../../../lear.txt");
               t = new WordCount.WordCount(text);
        }

        [Test]
        public void WordCount_leartxt_ShouldBe47()
        {
            //arrange
            var expected = 47;

            //act
            var result = t.CountWords();

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void CharCount_leartxt_ShouldBe248()
        {
            //arrange
            var expected = 248;

            //act
            var result = t.CountChars();

            //assert
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void LinesCount_leartxt_ShouldBe6()
        {
            //arrange
            var expected = 6;

            //act
            var result = t.CountLines();

            //assert
            Assert.AreEqual(expected, result);
        }
    }
}