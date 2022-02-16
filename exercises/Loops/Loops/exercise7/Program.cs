using System;

namespace exercise7
{
    internal class Piglet
    {
        private static int sum;
        private static char playing;
        static void Main(string[] args)
        {
            sum = 0;
            playing = 'y';

            Console.WriteLine("Welcome to Piglet!");

            Random random = new Random();
            int input = random.Next(1, 7);
            CaseCheck(input);

            while (playing == 'y')
            {
                Console.WriteLine("Roll again?");
                string answer = Console.ReadLine();

                if (answer == "n")
                {
                    break;
                }

                input = random.Next(1, 7);
                CaseCheck(input);
            }

            Console.WriteLine("You got " + sum + " points.");
            Console.Read();
        }

        private static void CaseCheck(int input)
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine("You rolled a 1!");
                    sum = 0;
                    playing = 'n';
                    break;
                case 2:
                    Console.WriteLine("You rolled a 2!");
                    sum += 2;            
                    break;
                case 3:
                    Console.WriteLine("You rolled a 3!");
                    sum += 3;
                    break;
                case 4:
                    Console.WriteLine("You rolled a 4!");
                    sum += 4;
                    break;
                case 5:
                    Console.WriteLine("You rolled a 5!");
                    sum += 5;
                    break;
                case 6:
                    Console.WriteLine("You rolled a 6!");
                    sum += 6;
                    break;
            }
        }
    }
}

