using System;
using System.Linq;

namespace Exercise2
{
    class Program
    {
        private static void Main(string[] args)
        {
            var sum = 0;

            Console.WriteLine("Please enter a min number");
            int minNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a max number");
            int maxNumber = int.Parse(Console.ReadLine());

            if (minNumber > maxNumber)
            {
                Console.WriteLine("Your minimum number exceeds maximum number");
                Console.ReadKey();
            }
            else
            {
                int[] sumArray = Enumerable.Range(minNumber, maxNumber - minNumber + 1).ToArray();

                for (int i = 0; i < sumArray.Length; i++)
                {
                    sum += sumArray[i];
                }

                Console.WriteLine("The sum is " + sum);
                Console.ReadKey();
            }
        }
    }
}
