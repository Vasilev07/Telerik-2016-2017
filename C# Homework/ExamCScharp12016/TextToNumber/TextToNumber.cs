using System;


class TextToNumber
{
    static void Main()
    {
        int M = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        int result = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '@')
            {
                break;
            }
            else if (input[i] - '0' >= 0 && input[i] - '0' <= 9)
            {
                result *= input[i] - '0';
            }
            else if ((input[i] >= 65 && input[i] <= 90) || (input[i] >= 97 && input[i] <= 122))
            {
                if (input[i] >= 97)
                {
                    result += input[i] - 97;
                }
                else
                {
                    result += input[i] - 65;
                }
            }
            else
            {
                result %= M;
            }
        }
        Console.WriteLine(result);
    }
}

