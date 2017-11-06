using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

           
            var n = int.Parse(Console.ReadLine());
            var array = new int[n];
            var merged = "";
            var mergedArr = new string[n - 1];
            var squashing = new string[n - 1];
            for (var i = 0; i < n; i++)
            {
                var numbers = int.Parse(Console.ReadLine());
                array[i] = numbers; 
            }

            for (int i = 0; i < array.Length-1; i++)
            {
                var firstNumber = array[i] % 10;
                var secondNumber = array[i + 1] / 10;
                merged += firstNumber;
                merged += secondNumber;
                mergedArr[i] = merged;
                merged = "";
            }

            for (int i = 0; i < array.Length - 1; i++)
            {
                var firstNumber = array[i] / 10;
                
                var secondNumber = array[i] % 10 + array[i + 1] / 10;
                var thirdNumber = array[i + 1] % 10;
                merged += firstNumber;
                merged += secondNumber % 10;
                merged += thirdNumber;
                squashing[i] = merged;
                merged = "";
            }

            Console.WriteLine(string.Join(" ", mergedArr));
            Console.WriteLine(string.Join(" ", squashing));
           
        }
    }
}
