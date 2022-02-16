using System;
using System.Collections.Generic;

namespace exercise_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            HashSet<string> uniqueValues = new HashSet<string>();
            string input;

            do
            {
                Console.Write("Enter name: ");
                input = Console.ReadLine();

                if (input.Length == 0)
                {
                    break;
                }

                input = input[..1].ToUpper() + input[1..].ToLower();
                uniqueValues.Add(input);
            } while (input.Length != 0);


            Console.Write("Unique name list contains: ");
            Console.WriteLine(string.Join(" ", uniqueValues));
        }
    }
}
