using System;


namespace PrimeCheck
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            bool prime = true;

            if (number < 2)
            {
                prime = false;
            }
            else
            {
                for (int i = 2; i <= (int)Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        prime = false;
                    }
                }

            }

            if (prime)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }
}

