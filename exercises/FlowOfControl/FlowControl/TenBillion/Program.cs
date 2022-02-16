using System;

namespace TenBillion
{
    class Program
    {
        //TODO Write a C# program that reads an positive integer and count the number of digits the number (less than ten billion) has.
        static void Main(string[] args)
        {
            Console.WriteLine("Input an integer number less than ten billion: ");

            var input = Console.ReadLine();

            long n;

            if (long.TryParse(input, out n))
            {
                if (n < 0)
                {
                    n *= -1;
                }


                if (n > 10000000000)
                {
                    Console.WriteLine("Number is greater or equals 10,000,000,000!");
                }
                else
                {
                    int digits = 1;

                    if (n < 10)
                    {
                        digits = 1;
                    }
                    else if (n < 100)
                    {
                        digits = 2;
                    }
                    else if (n < 1000)
                    {
                        digits = 3;
                    }
                    else if (n < 10000)
                    {
                        digits = 4;
                    }
                    else if (n < 100000)
                    {
                        digits = 5;
                    }
                    else if (n < 1000000)
                    {
                        digits = 6;
                    }
                    else if (n < 10000000)
                    {
                        digits = 7;
                    }
                    else if (n < 100000000)
                    {
                        digits = 8;
                    }
                    else if (n < 1000000000)
                    {
                        digits = 9;
                    }
                    else if (n < 10000000000)
                    {
                        digits = 10;
                    }

                    Console.WriteLine("Number of digits in the number: " + digits);
                }
            }
            else
            {
                Console.WriteLine("The number is not a long");
            }
            Console.Read();
        }
    }
}
