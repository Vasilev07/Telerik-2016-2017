using System;




class Program
{
    static void Main()
    {
        uint N = ushort.Parse(Console.ReadLine());
        uint M = ushort.Parse(Console.ReadLine());
        uint x = 0;
        for (uint i = N + 1; i < M; i++)
        {
            if (i % 5 == 0)
            {
                x++;
            }
        }
        Console.WriteLine(x);
    }
}
