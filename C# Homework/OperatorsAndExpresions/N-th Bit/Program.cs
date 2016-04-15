using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_th_Bit
{
    class Program
    {
        static void Main()
        {

            long N = long.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());

            long bit1 = N >> P;
            long bit2 = bit1 & 1;

            Console.WriteLine(bit2);
        }
    }
}
