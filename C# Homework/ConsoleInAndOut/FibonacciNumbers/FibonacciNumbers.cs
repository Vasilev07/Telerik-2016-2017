using System;

class FibonacciNumbers
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        ulong x = 0;
        ulong y = 1;
        if (n <= 1)
            Console.WriteLine("0");
        else if (n == 2)
        {
            Console.WriteLine("{0}, {1}", x, y);
        }
        else
        {
            Console.Write("{0}, {1}, ", x, y);
            for (byte i = 2; i < n; i++)
            {
                y = x + y;
                x = y - x;
                if (i != n - 1)
                    Console.Write("{0}, ", y);
                else
                    Console.WriteLine(y);
            }
        }
    }
}

