using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.ReverseNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            var list = new List<char>();

            while (true)
            {
                var input = Console.ReadLine().Split();
                var command = input[0];
                var chararray = new List<char>();
                if (input.Length > 1)
                {
                    chararray.AddRange(input[1].ToCharArray());
                }
                if (command == "set")
                {
                    list.Clear();
                    list.AddRange(chararray);
                }
                else if (command == "front-add")
                {
                    list.InsertRange(0, chararray);
                }
                else if (command == "front-remove")
                {
                    if (list.Count > 0)
                    {
                        list.RemoveAt(0);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "back-add")
                {
                    list.AddRange(chararray);
                }
                else if (command == "back-remove")
                {
                    if (list.Count > 0)
                    {
                        list.RemoveAt(list.Count - 1);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (command == "reverse")
                {
                    list.Reverse();
                }
                else if (command == "print")
                {
                    if (list.Count == 0)
                    {
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine(String.Join("", list));
                    }
                }
                if (command == "end")
                {
                    break;
                }
            }
        }
    }
}