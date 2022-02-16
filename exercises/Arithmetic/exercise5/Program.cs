using System;

namespace exercise5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int guess;
            Random r = new Random();
            int rInt = r.Next(1, 101);

            Console.WriteLine("I'm thinking of a number between 1-100.  Try to guess it.");
            Console.Write(">");
            bool isValid = int.TryParse(Console.ReadLine(), out guess);

            if (isValid == true)
            {
                if (rInt == guess)
                {
                    Console.Write("You guessed it!  What are the odds?!?");
                }
                else if (rInt > guess)
                {
                    Console.Write($"Sorry, you are too low.  I was thinking of {rInt}.");
                }
                else
                {
                    Console.Write($"Sorry, you are too high.  I was thinking of {rInt}.");
                }
            }
            else
            {
                Console.Write("It is not a number");
            }

        }
    }
}
