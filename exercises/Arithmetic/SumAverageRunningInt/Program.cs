using System;

namespace SumAverageRunningInt
{
    class Program
    {
        static void Main(string[] args)
        {
            var sum = 0;
            decimal average;
            const int lowerBound = 1;
            const int upperBound = 100;

            for (var number = lowerBound; number <= upperBound; ++number)
            {
                sum += number;
            }

            average = (decimal)sum / ((decimal)upperBound - (decimal)lowerBound + 1);

            Console.WriteLine($"The sum of {lowerBound} to {upperBound} is {sum}");
            Console.WriteLine($"The average is {string.Format("{0:0.00}", average)}");
            Console.ReadLine();
        }
    }
}
