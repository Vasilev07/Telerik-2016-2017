using System;


class QuadraticEquation
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double sqrtPart = (b * b - (4 * a * c));
        double x1 = (-b - (Math.Sqrt(sqrtPart))) / (2 * a);
        double x2 = (-b + (Math.Sqrt(sqrtPart))) / (2 * a);

        if (sqrtPart > 0)
        {
            Console.WriteLine("{0:F2}", Math.Min(x1, x2));
            Console.WriteLine("{0:F2}", Math.Max(x1, x2));
        }
        else
        if (sqrtPart == 0)
        {
            Console.WriteLine("{0:F2}", x1);
        }
        else
        {
            Console.WriteLine("no real roots");
        }
    }
}


