using System;
using System.IO;

namespace FlightPlanner
{
    class Program
    {
        public static PlanFlights _planner = new PlanFlights();
        private const string Path = "../../flights.txt";

        public static void Main()
        {
            string[] readText = File.ReadAllLines(Path);
            _planner.Initialize(readText);

            Welcome();
            FirstCity();
            NextCity();
            FinalRoute();
        }

        private static void Welcome()
        {
            Console.WriteLine("What would you like to do:");
            Console.WriteLine("To display list of the cities press 1");
            Console.WriteLine("To exit program press #");
            Console.Write(">");
            var input = Console.ReadLine();

            if (input == "1")
            {
                foreach (string key in _planner.planner.Keys)
                {
                    Console.WriteLine(key);
                }
            }

            if (input == "#")
            {
                return;
            }
        }

        private static void FirstCity()
        {
            Console.WriteLine("Choose the starting city:");
            Console.WriteLine();
            _planner.GetFirstCity();
        }

        private static void NextCity()
        {
            Console.WriteLine("Choose next city:");
            Console.WriteLine(string.Join("\n", _planner.planner[_planner.enteredCities[_planner.enteredCities.Count - 1]]));
            _planner.GetNextCity();
        }

        private static void FinalRoute()
        {
            Console.WriteLine("Your chosen route is:");
            Console.WriteLine(_planner.FinalRoute());
        }
    }
}
