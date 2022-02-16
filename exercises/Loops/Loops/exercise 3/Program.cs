using System;

namespace exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[20];

            for (int i = 0; i < 20; i++)
            {
                int x = random.Next(100);
                array[i] = x;
            }

            Console.WriteLine(String.Join(" ", array));
            Console.WriteLine("Which number position do you want to know?");
            int number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] == number)
                {
                    Console.WriteLine("The position of " + number + " in array is " + i);
                }
            }
        }
    }
}
