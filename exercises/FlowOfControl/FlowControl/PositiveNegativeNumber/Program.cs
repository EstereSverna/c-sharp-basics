using System;

namespace PositiveNegativeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number.");
            var input = Console.ReadLine();

            double number;

            if (!double.TryParse(input, out number))
            {
                Console.WriteLine("{0} is not a number", input);
            }
            else
            {

                if (number > 0)
                {
                    Console.WriteLine("Number is positive");
                }
                else if (number < 0)
                {
                    Console.WriteLine("Number is negative");
                }
                else
                {
                    Console.WriteLine("Number is zero");
                }
            }
            Console.ReadLine();
        }
    }
}
