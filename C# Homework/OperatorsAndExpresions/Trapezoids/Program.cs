﻿using System;


namespace Trapezoids
{
    class Program
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double trapArea = ((a + b) / 2) * h;
            Console.WriteLine("{0:F7}", trapArea);
        }
    }
}
