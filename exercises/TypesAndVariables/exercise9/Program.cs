using System;

namespace exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double distance = 2500; //meters
            double hours = 5;
            double minutes = 56;
            double seconds = 23;

            double SpeedInMetersInSecond = distance / ((hours * 60 * 60) + (minutes * 60) + seconds);
            double SpeedInKmInHour = (distance / 1000) / (hours + (minutes / 60) + (seconds / 60 / 60));
            double SpeedInMilesInHour = (distance / 1609) / (hours + (minutes / 60) + (seconds / 60 / 60));

            Console.WriteLine($"Your speed in meters/second is {String.Format("{0:0.00000000}", SpeedInMetersInSecond)}.");
            Console.WriteLine($"Your speed in km/hour is {String.Format("{0:0.00000000}", SpeedInKmInHour)}.");
            Console.WriteLine($"Your speed in miles/hour is {String.Format("{0:0.00000000}", SpeedInMilesInHour)}.");
            Console.Read();
        }
    }
}
