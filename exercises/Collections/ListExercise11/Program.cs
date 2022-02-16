using System;
using System.Collections.Generic;
using System.Linq;

namespace ListExercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list1 = new List<string>() 
            { 
                "apple",
                "pear",
                "mango",
                "orange",
                "banana",
                "pumpkin",
                "avocado",
                "spinach",
                "asparagus",
                "kiwi"
            };

            Console.WriteLine(String.Join(", ", list1));

            list1.Insert(4, "chocolate");
            Console.WriteLine(String.Join(", ", list1));

            list1[list1.Count() - 1] = "carrots";
            Console.WriteLine(String.Join(", ", list1));

            list1.Sort();
            Console.WriteLine(String.Join(", ", list1));

            string answer = list1.Contains("Foobar") ? "true" : "false";
            Console.WriteLine(String.Join(", ", answer));

            foreach (string item in list1)
            {
                Console.WriteLine(item);
            }
        }
    }
}
