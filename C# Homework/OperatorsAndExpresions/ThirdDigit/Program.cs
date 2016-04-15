using System;


namespace ThirdDigit
{
    class Program
    {
        static void Main()
        {
            string N = Console.ReadLine();
            int stringLenght = N.Length;
            int position = stringLenght - 3;
            if (stringLenght < 3)
            {
                Console.WriteLine("false 0");
            }
            else
                
            if (N[position] == '7')
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false " + N[position]);
            }

        }
    }
}
