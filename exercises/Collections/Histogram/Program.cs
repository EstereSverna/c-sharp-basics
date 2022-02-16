using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Histogram
{
    class Program
    {
        private const string Path = "../../midtermscores.txt";

        private static void Main(string[] args)
        {
            List<int> scores = new List<int>();
            string[] readText = File.ReadAllText(Path).Split(' ');
            foreach (var s in readText)
            {
                scores.Add(int.Parse(s));
            }

            for(int i = 0; i<100; i+=10)
            {
                int scoreCount = 0;
                for (int j = i; j < i + 10; j++)     
                {
                    for (int m = 0; m < scores.Count; m++)
                    {
                        if (scores[m] == j)
                        {
                            scoreCount++;
                        }
                    }
                }     
                
                Console.WriteLine($"{i:00} - {i + 9:00}: {new string('*',  scoreCount)}");
            }

            Console.WriteLine($"    100: {new string('*', scores.Count(T => T == 100))}");
        }
    }
}
