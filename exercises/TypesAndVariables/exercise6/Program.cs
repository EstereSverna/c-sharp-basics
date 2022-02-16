using System;

namespace exercise6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter series of single digit numbers");
            string inputString = Console.ReadLine();

            int number = 0;
            int sum = 0;
            int m;

            try
            {
                number = Int32.Parse(inputString);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }

            while (number > 0)
            {
                m = number % 10;
                sum += m;
                number = (number - m) / 10;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
