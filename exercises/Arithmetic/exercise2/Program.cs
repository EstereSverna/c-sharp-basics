using System;

namespace exercise2
{
    public class Check
    {
        public string CheckOddEven(int a)
        {
            return a % 2 == 0 ? "Even number" : "Odd number";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var c = new Check();

            Console.Write("To check whether integer is odd or even write: yes");
            var checkCondition = Console.ReadLine();

            while (checkCondition == "yes")
            {
                Console.Write("Write your number");
                int b = Convert.ToInt32(Console.ReadLine());
                c.CheckOddEven(b);
                Console.ReadLine();

                Console.Write("To check whether integer is odd or even write: yes");
                checkCondition = Console.ReadLine();
            }
            Console.WriteLine("bye!");
            Console.ReadLine();
        }
    }
}
