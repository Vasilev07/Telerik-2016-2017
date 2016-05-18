using System;



class ExchangeNumbers
{
    static void Main()
    {
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double greaterNumber;
        double lowerNumber;


        if (firstNumber > secondNumber)
        {
            greaterNumber = firstNumber;
            lowerNumber = secondNumber;
            secondNumber = greaterNumber;
            firstNumber = lowerNumber;
            Console.WriteLine("{0} {1}", lowerNumber, greaterNumber);
        }
        else if (firstNumber == secondNumber)
        {
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("{0} {1}", firstNumber, secondNumber);
        }
    }
}


