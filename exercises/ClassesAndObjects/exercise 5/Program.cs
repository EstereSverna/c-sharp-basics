using System;

namespace exercise_5
{
    internal class DateTest
    {
        static void Main()
        {
            Date dt = new Date(2021, 12, 10);            
            Console.WriteLine(dt.DisplayDate());
            dt.Year = 2000;
            Console.WriteLine(dt.DisplayDate());

            Date dt1 = new Date(2022, 1, 31);
            Console.WriteLine(dt1.DisplayDate());
            Console.WriteLine(dt1.Year);
            Console.WriteLine(dt1.Month);
            Console.WriteLine(dt1.Day);
        }
    }
}
