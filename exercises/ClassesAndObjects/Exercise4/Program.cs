using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var spiderMan = new Movie("Spider-Man: Into the Spider-Verse", "Columbia Pictures");
            var casinoRoyale = new Movie("Casino Royale", "Eon Productions", "PG13");
            var glass = new Movie("Glass", "Buena Vista International", "PG13");
            var movies = new List<Movie>
            {
                spiderMan,
                casinoRoyale,
                glass
            };

            var filtered = GetPg(movies.ToArray());
            foreach (var movie in filtered)
            {
                Console.WriteLine($"{movie.Display()}");
            }
        }

        public static Movie[] GetPg(Movie[] movies)
        {
            var filtered = new List<Movie>();
            foreach (var movie in movies)
            {
                if (movie.GetRating() == "PG")

                {
                    filtered.Add(movie);
                }
            }
            return filtered.ToArray();
        }
    }
}
