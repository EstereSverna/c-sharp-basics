using System;

namespace exercise_10
{
    internal class NumberSquare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Min?");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Max?");
            int max = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[max - min + 1];

            for (int i = 0; i <= max - min; i++)
            {
                array[i] = min + i;
            }

            for (int i = 0; i <= max - min; i++)
            {
                Console.WriteLine(string.Join(" ", array));
                Rotate(ref array, -(1));               
            }
        }

        private static void Rotate<T>(ref T[] array, int shiftCount)
        {
            T[] backupArray = new T[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
               backupArray[(i + array.Length + shiftCount % array.Length) % array.Length] = array[i];
            }

            array = backupArray;
        }
    }
}
