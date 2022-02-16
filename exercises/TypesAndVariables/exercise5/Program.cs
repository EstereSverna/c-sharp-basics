using System;
using ConsoleTables;

namespace exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var table = new ConsoleTable("1", "English", "Ms. Garcia");
            table.AddRow(2, "Math", "Mr. Davis")
                 .AddRow(3, "Art", "Mr. James");

            table.Write();
            Console.Read();
        }
    }
}
