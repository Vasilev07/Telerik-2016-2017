using System;


namespace ConsoleApplication3
{
    class Program
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 2;
            double xPlusY = (x * x) + (y * y);
            bool isInTheCircle = xPlusY <= (r * r);
            if (isInTheCircle)
            {
                Console.WriteLine("yes {0:F2}", Math.Sqrt(xPlusY));
            }
            else
            {
                Console.WriteLine("no {0:F2}", Math.Sqrt(xPlusY));
            }
        }
    }
}




