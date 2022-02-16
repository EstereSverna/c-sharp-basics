using System;

namespace exercise_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FuelGauge fuel = new FuelGauge();
            Odometer odometer = new Odometer(0, fuel);

            for (int x = 0; x < 70; x++)
            {
                fuel.Fuel();
            }

            while (fuel.GetAmountOfFuel() > 0)
            {
                odometer.Drive();

                Console.WriteLine("Mileage: " + odometer.GetMilage());
                Console.WriteLine("Fuel level: " + fuel.GetAmountOfFuel() + " liters");
            }
        }
    }
}
