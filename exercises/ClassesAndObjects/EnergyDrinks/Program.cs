using System;

namespace EnergyDrinks
{
    class Program
    {
        private const int NumberedSurveyed = 12467;
        private const double PurchasedEnergyDrinks = 0.14;
        private const double PreferCitrusDrinks = 0.64;

        private static void Main(string[] args)
        {
             var p = new Program();
             Console.WriteLine("Total number of people surveyed " + NumberedSurveyed);
             Console.WriteLine("Approximately " + p.CalculateEnergyDrinkers(NumberedSurveyed) + " bought at least one energy drink");
             Console.WriteLine(p.CalculatePreferCitrus(NumberedSurveyed) + " of those " + "prefer citrus flavored energy drinks.");
        }

        double CalculateEnergyDrinkers(int numberSurveyed)
        {
            return Math.Round(numberSurveyed * PurchasedEnergyDrinks);
        }

        double CalculatePreferCitrus(int numberSurveyed)
        {
            return Math.Round(CalculateEnergyDrinkers(numberSurveyed) * PreferCitrusDrinks);
        }
    }
}
