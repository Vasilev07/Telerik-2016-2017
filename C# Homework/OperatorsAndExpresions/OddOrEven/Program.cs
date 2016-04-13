using System;
namespace OddOrEven
{
    class Program
    {
        static void Main()
        {
            int amount = int.Parse(Console.ReadLine());
          
                if (amount % 2 == 0)
                {
                    Console.WriteLine("even " + amount);
                }
                else
                {
                    Console.WriteLine("odd " + amount);
                }

            }
        }
    }

