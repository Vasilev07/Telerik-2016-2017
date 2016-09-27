using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdBit
{
    class ThirdBit
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = 3;
            int mask = 1 << y;
            int nAndMask = x & mask;
            int bit = nAndMask >> y;
            if (bit == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine("1");
            }
        }
    }
}
