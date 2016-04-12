using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingFloats
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double firstValue = double.Parse(Console.ReadLine());
            double secondValue = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool equal = Math.Abs(firstValue - secondValue) < eps;
            if (equal)
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
