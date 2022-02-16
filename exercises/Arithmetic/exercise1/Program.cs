using System;

namespace exercise1
{
    public class TestNumbers
    {
        public bool Test(int a, int b)
        {
            return a == 15
                   || b == 15
                   || a + b == 15
                   || a - b == 15
                   || b - a == 15;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var t = new TestNumbers();
            Console.Write("Write your first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Write your second number");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write(t.Test(a, b));
        }
    }
}
