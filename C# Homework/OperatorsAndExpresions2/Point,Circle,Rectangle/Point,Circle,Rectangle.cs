using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_Circle_Rectangle
{
    class PointCircleRectangle
    {
        static void Main()
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double r = 1.5;
            double pitagor = (x * x) + (y * y);
            bool isInTheCircle = (x - 1) * (x - 1) + (y - 1) * (y - 1) <= (r * r);//in circle
            bool isInRectangle = (x <= -1 || x <= 5 && y <=1 || y <= -1);//in rectangle
            if (isInTheCircle && isInRectangle)
            {
                Console.WriteLine("inside circle inside rectangle");
            }
            else if(!isInTheCircle && isInRectangle)
            {
                Console.WriteLine("outside circle inside rectangle");
            }
            else if (isInTheCircle && !isInRectangle)
            {
                Console.WriteLine("inside circle outside rectangle");
            }
            else
            {
                Console.WriteLine("outside circle outside rectangle");
            }
        }

    }
    }

