using System;

namespace CalculateArea
{
    public class Geometry
    {
        public decimal AreaOfCircle(decimal radius)
        {
            return Math.Round((decimal)Math.PI * radius * radius, 1);
        }

        public decimal AreaOfRectangle(decimal length, decimal width)
        {
            return Math.Round(length * width, 1);
        }

        public decimal AreaOfTriangle(decimal ground, decimal height)
        {
            return Math.Round((height * ground) / 2, 1);
        }
    }
}
