using System;

namespace exercise7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int uppercaseLetters = 0;

            Console.WriteLine("Please enter a string");
            string inputString = Console.ReadLine();

            foreach(char c in inputString)
            {
                if(Char.IsUpper(c))
                    uppercaseLetters++;
            }

            Console.WriteLine($"There are {uppercaseLetters} uppercase letters in string: {inputString}");
            Console.ReadLine();
        }
    }
}
