using System;
using System.Collections.Generic;

namespace exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> values = new HashSet<string>();

            values.Add("one");
            values.Add("two");
            values.Add("three");
            values.Add("four");
            values.Add("five");
            Console.WriteLine(string.Join(" ", values));

            values.Clear();
            Console.WriteLine(string.Join(" ", values));

            values.Add("one");
            values.Add("one");
            values.Add("one");
            values.Add("one");
            Console.WriteLine(string.Join(" ", values));
        }
    }
}
