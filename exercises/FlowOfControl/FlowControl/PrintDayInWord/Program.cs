using System;

namespace PrintDayInWord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] dayValues = { 0, 1, 2, 3, 4, 5, 6 };
            int dayNumber = 0;

            if(Array.IndexOf( dayValues, dayNumber )!= -1)
            {
                if(dayNumber  == 0)
                {
                    Console.WriteLine("Sunday");
                }
                else if (dayNumber == 1)
                {
                    Console.WriteLine("Monday");
                }
                else if (dayNumber == 2)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (dayNumber == 3)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (dayNumber == 4)
                {
                    Console.WriteLine("Thursday");
                }
                else if (dayNumber == 5)
                {
                    Console.WriteLine("Friday");
                }
                else if (dayNumber == 6)
                {
                    Console.WriteLine("Saturday");
                }
            }
            else
            {
                Console.WriteLine("Not a valid day");
            }
        }
    }
}
