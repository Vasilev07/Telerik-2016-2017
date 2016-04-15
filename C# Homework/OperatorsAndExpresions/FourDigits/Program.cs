using System;


namespace FourDigits
{
    class Program
    {
        static void Main()
        {
            
            string input = Console.ReadLine(); 
            int sumOfDigits = 0;
            for (int i = 0; i < input.Length; i++) 
            { 
                sumOfDigits += input[i] - '0';
            }
            string reversedNum = "";
            for (int i = input.Length - 1; i >= 0; i--) 
            {
                reversedNum += input[i];
            }
            string cutted = (input[input.Length - 1] + input).Substring(0, 4);
            char[] name = { 'a','b','c','d'};
            name[0] = 'a';
            name[1] = 'ç';
            name[2] = 'b';
            name[3] = 'd';
            Console.WriteLine(name);
            Console.ReadLine();
        }
    }
}
