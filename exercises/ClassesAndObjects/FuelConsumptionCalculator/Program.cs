using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        private static void Main(string[] args)
        {
            int startKilometers;
            int liters;

            Car car = new Car(0);
            Car car1 = new Car(0);

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car.FillUp(startKilometers, liters);
                
                Console.Write("Enter first reading: ");
                startKilometers = Convert.ToInt32(Console.ReadLine());    
                Console.Write("Enter liters reading: ");
                liters = Convert.ToInt32(Console.ReadLine());
                car1.FillUp(startKilometers, liters);
            }

            Console.WriteLine("Kilometers per liter are " + car.CalculateConsumption() + " gasHog: " + car.GasHog());
            Console.WriteLine("Car Kilometers per liter are " + car.ConsumptionPer100Km()+ " economyCar: " + car.EconomyCar());
            Console.WriteLine("Kilometers per liter are " + car1.CalculateConsumption() + " gasHog: " + car1.GasHog());
            Console.WriteLine("Car1 Kilometers per liter are " + car1.ConsumptionPer100Km() + " economyCar: " + car1.EconomyCar());
            Console.ReadKey();
        }
    }
}
