using System;


class SortThreeNumbers
{
    static void Main()
    {
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double n3 = double.Parse(Console.ReadLine());
        double maxFirstSecond = (Math.Max(n1, n2));
        double minFirstSecond = (Math.Min(n1, n2));
        if (maxFirstSecond > n3)
        {
            Console.WriteLine("{0} {1} {2}", maxFirstSecond, minFirstSecond, n3);
        }
        else
        {
            Console.WriteLine("{0} {1} {2}", n3, maxFirstSecond, minFirstSecond);
        }
    }
}

