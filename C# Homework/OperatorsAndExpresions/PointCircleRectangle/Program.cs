using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointCircleRectangle
{
    class Program
    {
        static void Main()
        {
            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            decimal centerA = 1M;
            decimal centerB = 1M;
            decimal r = 1.5M;

            decimal leftA = -1M;
            decimal rightA = 5M;
            decimal topB = 1M;
            decimal bottomB = -1M;

            bool inTheRectangle = (a >= leftA && a <= rightA) && (b <= topB && b >= bottomB);
            bool inTheCircle = (a - centerA) * (a - centerA) + (b - centerB) * (b - centerB) <= (r * r);

            if (inTheCircle)
            {
                Console.Write("inside circle ");
            }
            else
            {
                Console.Write("outside circle ");
            }

            if (inTheRectangle)
            {
                Console.WriteLine("inside rectangle");
            }
            else
            {
                Console.WriteLine("outside rectangle");
            }
        }
    }
}
