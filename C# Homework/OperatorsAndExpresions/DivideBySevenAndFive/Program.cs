using System;

    class Program
    {
        static void Main()
        {
            double Number = double.Parse(Console.ReadLine());
            if ((Number % 7 == 0) && (Number % 5 == 0))
            {
                Console.WriteLine("true " + Number);
            }
            else
            {
                Console.WriteLine("false " + Number);
            }
        }
    }

