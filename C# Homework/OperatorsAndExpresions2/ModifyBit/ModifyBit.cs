using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class ModifyBit
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {
                int mask = 1 << p;
                int result = n | mask;
                Console.WriteLine(result);
            }
            else if (x == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine(result);
            }
            
        }

    }
}