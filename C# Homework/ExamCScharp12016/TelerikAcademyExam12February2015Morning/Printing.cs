using System;


class Printing
{
    static void Main()
    {
        ushort students = ushort.Parse(Console.ReadLine());
        ushort sheets = ushort.Parse(Console.ReadLine());
        double price = double.Parse(Console.ReadLine());
        double neededSheets = students * sheets;
        double realms = neededSheets / 500;
        double sum = realms * price;
        Console.WriteLine("{0:F2}", sum);
    }
}

