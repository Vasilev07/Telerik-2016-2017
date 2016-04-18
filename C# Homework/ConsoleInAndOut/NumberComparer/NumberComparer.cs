using System;


class NumberComparer
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine(Math.Max(x, y));
    }
}
