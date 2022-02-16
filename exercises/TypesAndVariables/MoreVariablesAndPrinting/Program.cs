using System;

namespace MoreVariablesAndPrinting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string eyes;
            string teeth;
            string hair;
            int age;
            double height;
            double weight;

            name = "Zed A. Shaw";
            age = 35;
            height = 74 * 2.54;
            weight = 180 * 0.453592;
            eyes = "Blue";
            teeth = "White";
            hair = "Brown";

            Console.WriteLine("Let's talk about " + name + ".");
            Console.WriteLine("He's " + String.Format("{0:0.00}", height) + " inches tall.");
            Console.WriteLine("He's " + String.Format("{0:0.00}", weight) + " pounds heavy.");
            Console.WriteLine("Actually, that's not too heavy.");
            Console.WriteLine("He's got " + eyes + " eyes and " + hair + " hair.");
            Console.WriteLine("His teeth are usually " + teeth + " depending on the coffee.");
            Console.WriteLine("If I add " + age + ", " + String.Format("{0:0.00}", height) + ", and " +
                                                         String.Format("{0:0.00}", weight) + " I get " +
                                                         String.Format("{0:0.00}", (age + height + weight)) + ".");
            Console.ReadKey();
        }
    }
}