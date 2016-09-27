using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourDigit
{
    class FourDigit
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var a = input[0];
            var b = input[1];
            var c = input[2];
            var d = input[3];
            int sumOfDigits = 0;
            for (int i = 0; i < input.Length; i++)
            {
                sumOfDigits += input[i]-'0';
            }
            Console.WriteLine(sumOfDigits);
            Console.WriteLine("{0}{1}{2}{3}", d, c , b , a);
            Console.WriteLine("{0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("{0}{1}{2}{3}", a, c, b, d);
        }


    }
}
