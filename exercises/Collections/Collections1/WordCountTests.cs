using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;
using System.IO;

namespace WordCount.Tests
{
    [TestClass]
    public class WordCountTests
    {
        static readonly string text = File.ReadAllText("../../lear.txt");
        private readonly WordCountCalculator t = new WordCountCalculator(text);


        [TestMethod]
            public void WordCount_leartxt_ExpectedResult47()
            {
                //arrange
                var expected = 47;

                //act
                var result = t.CountWords();

                //assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void CharCount_leartxt_ExpectedResult248()
            {
                //arrange
                var expected = 248;

                //act
                var result = t.CountChars();

                //assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void LinesCount_leartxt_ExpectedResult6()
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

