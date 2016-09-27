using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAndObject
{
    class StrAndObj
    {
        static void Main(string[] args)
        {
            string firstVar = "Hello";
            string secondVar = "World";
            object concatenation = firstVar + ' ' + secondVar;
            string holder = (string)concatenation;
            Console.WriteLine(holder);
        }
    }
}
