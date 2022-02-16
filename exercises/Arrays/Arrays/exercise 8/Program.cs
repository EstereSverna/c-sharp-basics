using System;
using System.Text;

namespace exercise_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "geometry", "algebra", "Sophia", "Socrates" };

            var rnd = new Random();
            var word = words[rnd.Next(0, words.Length)];
            var guessable = new string('_', word.Length);
            var misses = string.Empty;
            var missesCount = 0;

            while (guessable.IndexOf('_') != -1 && missesCount != 3)
            {
                Console.WriteLine($"word: {guessable}");
                Console.WriteLine($"misses: {misses}");
                var input = Console.ReadKey();
                var guess = input.KeyChar;
                Console.WriteLine();
                Console.WriteLine($"Guess: {guess}");

                if (word.ToLower().IndexOf(guess) > -1)
                {
                    for (var i = 0; i < word.Length; i++)
                    {
                        if (word.ToLower()[i] == guess)
                        {
                            var sb = new StringBuilder(guessable);
                            sb[i] = word[i];
                            guessable = sb.ToString();
                        }
                    }
                }
                else
                {
                    misses += guess;
                    missesCount++;
                }
            }

            if (guessable.IndexOf('_') == -1)
            {
                Console.WriteLine($"Congratulations! You guessed the word: {guessable}");
            }
            else if (missesCount == 3)
            {
                Console.WriteLine($"You missed! The word was: {word}");
            }

            Console.Read();
        }
    }
}
