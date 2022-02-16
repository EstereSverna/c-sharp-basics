using System;

namespace exercise8
{
    internal class Program
    {
        static void ConvertMinutesToYearsAndDays(int minutes)
        {
            int years = minutes / (60 * 24 * 365);
            minutes %= (60 * 24 * 365);
            int days = minutes / (60 * 24);

            Console.WriteLine($"It's equal to {years} years and {days} days.");
        }

        public static void Main()
        {
            int minutes = 527040;
            ConvertMinutesToYearsAndDays(minutes);
            Console.Read();
        }
    }
}
