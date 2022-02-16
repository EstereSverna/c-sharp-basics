﻿using System;

namespace exercise_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(5, 2);
            Point p2 = new Point(-3, 6);
            SwapPoints( p1, p2);
            Console.WriteLine("(" + p1.x + ", " + p1.y + ")");
            Console.WriteLine("(" + p2.x + ", " + p2.y + ")");
        }

        public static void SwapPoints(Point p1, Point p2)
        {
            int a = p1.x;
            int b = p1.y;

            p1.x = p2.x;
            p1.y = p2.y;

            p2.x = a;
            p2.y = b;
        }
    }
}
