using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the 1st number: ");
            var input1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 2nd number: ");
            var input2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the 3rd number: ");
            var input3 = Convert.ToInt32(Console.ReadLine());

            if (input1 > input2)
            {
                if (input1 > input3)
                {
                    Console.WriteLine($"Largest number is {input1}");
                }
                else
                {
                    Console.WriteLine($"Largest number is {input3}");
                }
            }
            else
            {
                if (input2 > input3)
                {
                    Console.WriteLine($"Largest number is {input2}");
                }
                else
                {
                    Console.WriteLine($"Largest number is {input3}");
                }
            }

            Console.Read();
        }
    }
}
