using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class NullValue
    {
        static void Main()
        {
            int? pesho = null;
            double? gosho = null;
            Console.WriteLine("Null integer value:" + pesho);
            Console.WriteLine("Null double value:" + gosho);

            gosho += 5;
            pesho -= 10;
            Console.WriteLine("Integer value:" + pesho);
            Console.WriteLine("Double value:" + gosho);


        }
    }
}
