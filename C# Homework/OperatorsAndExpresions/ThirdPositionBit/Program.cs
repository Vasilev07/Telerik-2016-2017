using System;


namespace ThirdPositionBit
{
    class Program
    {
        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            int numPosition = 3;
            int mask = 1 << numPosition;
            int result = num & mask;
            int bit = result >> numPosition;
            Console.WriteLine(bit);
        }
    }
}
