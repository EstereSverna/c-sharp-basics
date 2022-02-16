using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace FlightPlanner
{
    public class PlanFlights
    {
        public List<string> enteredCities = new List<string>();
        public Dictionary<string, List<string>> planner;
        public string startingCity;
        public string nextCity;

        public void Initialize(string[] flights)
        {
            planner = new Dictionary<string, List<string>>();

            foreach (var s in flights)
            {
                string[] str = Regex.Split(s, @" -> ");

                if (planner.ContainsKey(str[0]))
                {
                    planner[str[0]].Add(str[1]);
                }
                else
                {
                    planner.Add(str[0], new List<string> { str[1] });
                }
            }
        }

        public void GetFirstCity()
        {
            while (!enteredCities.Any())
            {
                FirstCity(Console.ReadLine());
            }
        }

        public string FirstCity(string start)
        {
            if (planner.Keys.Contains(start))
            {
                startingCity = start;
                enteredCities.Add(startingCity);
                return startingCity;
            }
            else
            {
                return "You chose invalid city. Choose the starting city from list";
            }
        }

        public void GetNextCity()
        {
            do
            {
                NextCity(Console.ReadLine());
            }
            while (nextCity != startingCity);
        }

        public string NextCity(string next)
        { 
            if (planner.Keys.Contains(next))
            {
                nextCity = next;
                enteredCities.Add(nextCity);
                return nextCity;
            }
            else
            {
                return "You chose invalid city. Choose from list";
            }
        }

        public string FinalRoute()
        {
            return String.Join(" -> ", enteredCities);
        }
    }
}
