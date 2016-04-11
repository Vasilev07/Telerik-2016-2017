using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObject
{
    class Program
    {
        static void Main()
        {
            string firstValue = "Hello ";
            string secondValue = "World";
            object conqOfValues;
            conqOfValues = firstValue + secondValue;
            string finalString = conqOfValues.ToString();
            Console.WriteLine(finalString);

        }
    }
}
