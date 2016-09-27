using System;

class PrintSequenceNumbers
{
    static void Main()
    {
        int numberPrint;
        for (int i = 2; i <= 11; i++)
        {
            if (i % 2 == 0)
            {
                numberPrint = i;
            }
            else
            {
                numberPrint = i * (-1);
            }
            Console.WriteLine(numberPrint);
        }
    }
}