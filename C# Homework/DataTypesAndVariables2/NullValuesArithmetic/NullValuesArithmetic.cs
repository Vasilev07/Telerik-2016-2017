using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullValuesArithmetic
{
    class NullValuesArithmetic
    {
        static void Main(string[] args)
        {
            int? firstValue = null;
            double? secondValue = null;
            int? thirdValue = firstValue + 5;
            double? fourthValue = secondValue + 5;
            Console.WriteLine("First Value: {0}; \n Second Value: {1}; \n Third Value: {2}; \n Fourth Value: {3};", firstValue, secondValue, thirdValue, fourthValue);
        }
    }
}
