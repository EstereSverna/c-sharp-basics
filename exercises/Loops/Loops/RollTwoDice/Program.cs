using System;

namespace RollTwoDice
{
    internal class RollTwoDice
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            Console.Write("Desired sum: ");
            int desiredSum = Convert.ToInt32(Console.ReadLine());
            int sum;

            do
            {
                int dice1 = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);
                sum = dice1 + dice2;

                Console.WriteLine($"{dice1} and {dice2} = {sum}");

            } while (desiredSum != sum);
        }
    }
}
