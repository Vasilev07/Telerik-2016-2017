using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age
{
    class Age
    {
        static void Main()
        {
            DateTime birthDay = new DateTime();
            birthDay = DateTime.Parse(Console.ReadLine());
            var myCurrentAge = (DateTime.Now - birthDay);
            int age = (int)(myCurrentAge.Days / 365.2 );
            Console.WriteLine(age);
            Console.WriteLine(age + 10);

            //DateTime bday = DateTime.Parse(Console.ReadLine());
            //DateTime now = DateTime.Today;
            //int age = now.Year - bday.Year;
            //if (now < bday.AddYears(age)) age--;
            //Console.WriteLine(age);
            //Console.WriteLine(age + 10);

        }

    }
}
