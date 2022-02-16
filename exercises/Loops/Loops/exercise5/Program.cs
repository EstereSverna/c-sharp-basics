using System;

namespace exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first word:");
            string input1 = Console.ReadLine();
            Console.WriteLine("Enter second word");
            string input2 = Console.ReadLine();

            Console.Write(input1);
            Console.Write(new String('.', 30 - input1.Length - input2.Length));
            Console.Write(input2);

            Console.WriteLine();
        }
    }
}
