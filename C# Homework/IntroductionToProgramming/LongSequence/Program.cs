using System;

class PrintSequenceNumbers
{
    static void Main()
    {
        int number;
        for (int i = 2; i <= 1001; i++)
        {
            if (i % 2 == 0)
            {
                number = i;
            }
            else
            {
                number = i * (-1);
            }
            Console.WriteLine(number);
        }

    }
}