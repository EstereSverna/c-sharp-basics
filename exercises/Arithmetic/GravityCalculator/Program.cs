using System;

namespace GravityCalculator
{
    class Program
    {
        private static readonly Calculations _object = new Calculations();

        static void Main()
        {
            var fallingTime = 10.0;
            var initialVelocity = 0;
            var initialPosition = 0;

            var finalPosition = _object.Calculate(fallingTime, initialVelocity, initialPosition);
            Console.WriteLine("The object's position after " + fallingTime + " seconds is " + finalPosition + " m.");
            Console.ReadKey();
        }
    }

    public class Calculations
    {
        public double Calculate(double fallingTime, double initialVelocity, double initialPosition)
        {
            var gravity = -9.81;

            return Math.Round(0.5 * gravity * (fallingTime * fallingTime) + initialVelocity * fallingTime + initialPosition, 1);
        }
    }
}

