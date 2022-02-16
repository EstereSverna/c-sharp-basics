using System;

namespace VariablesAndNames
{
    class Program
    {
        private static void Main(string[] args)
        {
            int Cars;
            int Drivers;
            int Passengers;
            int CarsNotDriven;
            int CarsDriven;
            double SeatsInACar;
            int CarpoolCapacity;
            double AveragePassengersPerCar;

            Cars = 100;
            SeatsInACar = 4.0;
            Drivers = 28;
            Passengers = 90;
            CarsNotDriven = Cars - Drivers;
            CarsDriven = Drivers;
            CarpoolCapacity = Cars * Convert.ToInt32(SeatsInACar);
            AveragePassengersPerCar = (double)Passengers / (double)CarsDriven;

            Console.WriteLine("There are " + Cars + " cars available.");
            Console.WriteLine("There are only " + Drivers + " drivers available.");
            Console.WriteLine("There will be " + CarsNotDriven + " empty cars today.");
            Console.WriteLine("We can transport " + CarpoolCapacity + " people today.");
            Console.WriteLine("We have " + Passengers + " to carpool today.");
            Console.WriteLine("We need to put about " + String.Format("{0:0.00}", AveragePassengersPerCar) + " in each car.");
            Console.ReadKey();
        }
    }
}