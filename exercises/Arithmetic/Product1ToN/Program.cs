using System;

namespace Product1ToN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int product = 1;
            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }

            Console.WriteLine($"Product from 1 to {n} is {product}.");
            Console.Read();
        }
    }
}
