﻿using System;
using System.Collections.Generic;

namespace ListExercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colors = new List<string>();
            colors.Add("Red");
            colors.Add("Green");
            colors.Add("Orange");
            colors.Add("White");
            colors.Add("Black");

            Console.WriteLine(string.Join(",", colors));

            colors.Insert(0, "Violet");
            colors.Insert(2, "Blue");

            Console.WriteLine(string.Join(",", colors));
        }
    }
}