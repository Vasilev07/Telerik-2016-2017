using System;

class BiggestNum
{
    static void Main()
    {
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double n3 = double.Parse(Console.ReadLine());
        double maxFirstSecond = (Math.Max(n1, n2));
        if (maxFirstSecond > n3)
        {
            Console.WriteLine(maxFirstSecond);
        }
        else
        {
            Console.WriteLine(n3);
        }
    }
}

