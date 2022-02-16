using System;
using System.Linq;

namespace CalculateArea
{
    public class Menu
    {
        private readonly Geometry _geometry = new Geometry();
        public int GetMenu()
        {
            Console.WriteLine("Geometry Calculator\n");
            Console.WriteLine("1. Calculate the Area of a Circle");
            Console.WriteLine("2. Calculate the Area of a Rectangle");
            Console.WriteLine("3. Calculate the Area of a Triangle");
            Console.WriteLine("4. Quit\n");
            Console.WriteLine("Enter your choice (1-4) : ");
            var keyboard = Console.ReadLine();

            if (!int.TryParse(keyboard, out var userChoice))
            {
                Console.WriteLine("You have entered non-numeric characters");
            }

            int[] validChoices = { 1, 2, 3, 4 };

            return validChoices.Contains(userChoice) ? userChoice : 0;
        }

        public void CalculateCircleArea()
        {
            Console.WriteLine("What is the circle's radius? ");
            if (!decimal.TryParse(Console.ReadLine(), out var radius))
            {
                Console.WriteLine("You have entered non-numeric characters");
            }
            Console.WriteLine($"The circle's area is {_geometry.AreaOfCircle(radius)}");
        }

        public void CalculateRectangleArea()
        {
            Console.WriteLine("Enter length? ");
            if (!decimal.TryParse(Console.ReadLine(), out var length))
            {
                Console.WriteLine("You have entered non-numeric characters");
            }

            Console.WriteLine("Enter width? ");
            if (!decimal.TryParse(Console.ReadLine(), out var width))
            {
                Console.WriteLine("You have entered non-numeric characters");
            }

            Console.WriteLine($"The rectangle's area is {_geometry.AreaOfRectangle(length, width)}");
        }

        public void CalculateTriangleArea()
        {
            Console.WriteLine("Enter length of the triangle's base? ");
            if (!decimal.TryParse(Console.ReadLine(), out var ground))
            {
                Console.WriteLine("You have entered non-numeric characters");
            }

            Console.WriteLine("Enter triangle's height? ");
            if (!decimal.TryParse(Console.ReadLine(), out var height))
            {
                Console.WriteLine("You have entered non-numeric characters");
            }

            Console.WriteLine($"The triangle's area is {_geometry.AreaOfTriangle(ground, height)}");
        }
    }
}
