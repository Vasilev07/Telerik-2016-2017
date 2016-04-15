using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModifyBit
{
    class Program
    {
        static void Main()
        {
            long N = long.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            int V = int.Parse(Console.ReadLine());

            if (V == 1)
            {
                long set = (long)1 << P;
                long found1 = N | set;
                Console.WriteLine(found1);
            }
            else
            {
                long set2 = (long)~(1 << P);
                long found2 = N & set2;
                Console.WriteLine(found2);
            }
        }
    }
}
