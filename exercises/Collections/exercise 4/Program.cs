using System;
using System.Collections.Generic;

namespace exercise_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.WriteLine("Enter a number to reveal whether it is happy or not");
            string number = Console.ReadLine();
            list.Add(int.Parse(number));
            int listNum = 0;

            do
            {
                foreach (char digit in list[^1].ToString())
                {
                    int n = int.Parse(digit.ToString());
                    listNum += n * n;
                }

                if (list.Contains(listNum)) 
                {
                    break; 
                }

                list.Add(listNum);
                listNum = 0;

            } while (list[^1] != 1);

            if (list[^1] == 1)
            { 
                Console.WriteLine($"{number} is happy"); 
            }
            else 
            { 
                Console.WriteLine($"{number} is not happy"); 
            }
        }
    }
}
