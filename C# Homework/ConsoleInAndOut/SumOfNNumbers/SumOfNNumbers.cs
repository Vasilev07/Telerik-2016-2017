using System;

class SumOfNNumbers
{
    static void Main()
    {
        double n = double.Parse(Console.ReadLine());
        double sum = 0.00;
        double number = double.MinValue;
        for (int i = 0; i < n; i++)
        {
            number = double.Parse(Console.ReadLine());
            sum += number;
        }

        Console.WriteLine(sum);

    }
}

