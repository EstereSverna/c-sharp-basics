using System;

namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double height;
            double weight;
            double bmi;

            Console.WriteLine("enter height in m");
            Console.Write(">");
            
            bool validHeight = double.TryParse(Console.ReadLine(), out height);
            double heightInches = height * 39.3700787;

            Console.WriteLine("enter weight in kg");
            Console.Write(">");

            bool validweight = double.TryParse(Console.ReadLine(), out weight);
            double weightPounds = weight * 2.20462262;

            bmi = Math.Round(weightPounds * 703 / ((heightInches) * (heightInches)));

            if (bmi < 18.5)
            {
                Console.WriteLine($"Your BMI is {bmi}, you can be considered underweight");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine($"Your BMI is {bmi}, you have optimal weight");
            }
            else if (bmi >=25)
            {
                Console.WriteLine($"Your BMI is {bmi}, you can be considered overweight");
            }
            else 
            {
                Console.WriteLine("Something went wrong, you entered not valid values");
            }
            Console.Read();
        }
    }
}
