using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class MaxOfFive
{
    static void Main()
    {
        double[] numbers = new double[5];
        for (int i = 0; i < 5; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
        }

        Console.WriteLine(numbers.Max());
    }
}

