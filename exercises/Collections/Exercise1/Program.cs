using System;
using System.Collections.Generic;

namespace Exercise1
{
    class Program
    {
        private static void Main(string[] args)
        {
            string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };

            List<string> cars = new List<string>(array);
            Console.WriteLine(string.Join(", ", cars));

            HashSet<string> cars1 = new HashSet<string>(array);
            Console.WriteLine(string.Join(", ", cars1));

            Dictionary<string, string> cars2 =
              new Dictionary<string, string>(){
                  {"Audi", "Germany"},
                  {"BMW", "Germany"},
                  {"Honda", "Japan"},
                  {"Mercedes", "Germany"},
                  {"VolksWagen", "Germany"},
                  {"Tesla", "USA"} };
            Console.WriteLine(string.Join(", ", cars2));
        }
    }
}
