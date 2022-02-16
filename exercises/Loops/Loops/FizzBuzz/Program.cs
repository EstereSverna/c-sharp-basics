using System;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Max value? ");
            var valid = int.TryParse(Console.ReadLine(), out n);

            if (valid == true && n > 0)
            {
                for (int i = 0; i <= n; i++)
                {
                    if (i % 15 == 0)
                    {
                        Console.Write("FizzBuzz ");
                    }
                    else if (i % 5 == 0)
                    {
                        Console.Write("Buzz ");
                    }
                    else if (i % 3 == 0)
                    {
                        Console.Write("Fizz ");
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }

                    if (i % 20 == 0)
                    {
                        Console.WriteLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("You entered not valid input");
            }

            Console.Read(); 
        }
    }
}
