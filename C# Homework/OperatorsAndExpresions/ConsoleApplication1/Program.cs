using System;


namespace Rectangles
{
    class Program
    {
        static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double rectanglePerimeter = 2 * (width + height);
            double rectangleArea = width * height;
            Console.WriteLine("{0:F2} {1:F2}", rectangleArea, rectanglePerimeter);
        }
    }
}
