using System;
using System.Linq;

namespace WordCount
{
    public class WordCountCalculator
    {
        private readonly string _txt;
        private char[] delimiters = new char[] { ' ', '\r', '\n', '\t', '\'', ',' };
        
        public WordCountCalculator( string text)
        {

            _txt = text;
        }
        public int CountLines()
        {
            return _txt.Split('\n').Count();
        }

        public int CountWords()
        {
            return _txt.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public int CountChars()
        {
            return _txt.Replace("\n", String.Empty).Length;
        }

        public string printLines()
        {
            return $"Lines = {CountLines()}";
        }
        public string printWords()
        {
            return $"Words = {CountWords()}";
        }

        public string printChars()
        {
            return $"Chars = {CountChars()}";
        }
    }
}
