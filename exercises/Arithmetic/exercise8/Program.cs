using System;

namespace exercise8
{
    internal class Program
    {
        static void Main()
        {
            var calculator = new SalaryCalculator();

            Console.WriteLine("Enter hours");
            var hoursWorked = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter base pay");
            var basePay = double.Parse(Console.ReadLine());

            var total = calculator.Calculate(basePay, hoursWorked);
            Console.WriteLine($"Total pay for employee is {total}.");
        }
    }
}
