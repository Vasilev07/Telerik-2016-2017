using System;


namespace QuotesInStrings
{
    class QuotesInString
    {
        static void Main()
        {
            string firstString = "The";
            string secondString = @"""use""";
            string thirdString = "of quotations causes difficulties.";
            Console.WriteLine("{0} {1} {2}", firstString, secondString, thirdString);
        }
    }
}
