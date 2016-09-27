using System;


namespace ThirdDigit
{
    class ThirdDigit
    {
        static void Main()
        {
            string digit = Console.ReadLine();
            
            if (digit.Length >= 3)
            {
                char thirdDigit = digit[digit.Length - 3];
                if (thirdDigit == '7')
                {
                    Console.WriteLine("true");

                }
                else
                {
                    Console.WriteLine("false" + " " + thirdDigit);
                }
            }
            else
            {
                Console.WriteLine("false" + " " + 0);
            }
           
        }
    }
}
