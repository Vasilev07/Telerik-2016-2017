using System;


namespace BitExchange
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int mask = 1 << 3;
            int thirdBit = (number & mask) >> 3;
            mask = 1 << 24;
            int twentyFourthBit = (number & mask) >> 24;

            if (thirdBit == 0)
            {
                mask = ~(1 << 24);
                number = number & mask;
            }
            else if (thirdBit == 1)
            {
                mask = (1 << 24);
                number = number | mask;
            }
            if (twentyFourthBit == 0)
            {
                mask = ~(1 << 3);
                number = number & mask;
            }
            else if (twentyFourthBit == 1)
            {
                mask = (1 << 3);
                number = number | mask;
            }

            int secondNumber = int.Parse(Console.ReadLine());
            int mask2 = 1 << 4;
            int fourthdBit = (secondNumber & mask2) >> 4;
            mask2 = 1 << 25;
            int twentyFifthBit = (secondNumber & mask2) >> 25;

            if (fourthdBit == 0)
            {
                mask2 = ~(1 << 25);
                secondNumber = secondNumber & mask2;
            }
            else if (fourthdBit == 1)
            {
                mask2 = (1 << 25);
                secondNumber = secondNumber | mask2;
            }
            if (twentyFifthBit == 0)
            {
                mask2 = ~(1 << 4);
                secondNumber = secondNumber & mask2;
            }
            else if (twentyFifthBit == 1)
            {
                mask2 = (1 << 4);
                secondNumber = secondNumber | mask2;
            }

            int thirdNumber = int.Parse(Console.ReadLine());
            int mask3 = 1 << 5;
            int fifthBit = (secondNumber & mask3) >> 5;
            mask3 = 1 << 26;
            int twentySixthBit = (thirdNumber & mask3) >> 26;

            if (fifthBit == 0)
            {
                mask3 = ~(1 << 26);
                thirdNumber = thirdNumber & mask3;
            }
            else if (fifthBit == 1)
            {
                mask3 = (1 << 26);
                thirdNumber = thirdNumber | mask3;
            }
            if (twentySixthBit == 0)
            {
                mask3 = ~(1 << 5);
                thirdNumber = thirdNumber & mask3;
            }
            else if (twentySixthBit == 1)
            {
                mask3 = (1 << 5);
                thirdNumber = thirdNumber | mask3;
            }

        }
    }
}
