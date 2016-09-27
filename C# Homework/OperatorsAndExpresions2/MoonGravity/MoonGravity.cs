using System;


namespace MoonGravity
{
    class MoonGravity
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());
            double moonWeight = weight * (17.0 / 100);
            Console.WriteLine("{0:F3}", moonWeight);
        }
    }
}
