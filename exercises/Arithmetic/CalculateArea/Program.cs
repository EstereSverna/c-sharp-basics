using System;

namespace CalculateArea
{
    public class Program
    {
        static void Main()
        {
            var menu = new Menu(); 

            switch (menu.GetMenu())
            {
                case 1:
                    menu.CalculateCircleArea();
                    break;
                case 2:
                    menu.CalculateRectangleArea();
                    break;
                case 3:
                    menu.CalculateTriangleArea();
                    break;
                case 4:
                    Console.WriteLine("You chose to quit");
                    break;
            }
        }
    }
}
