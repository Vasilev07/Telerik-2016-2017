using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class EmployeeData
    {
        static void Main(string[] args)
        {
            string firstName = "George";
            string lastName = "Vasilev";
            byte age = 19;
            char gender = 'm';
            long idNumber = 8306112507;
            uint uniqueNumber = 27569999;
            Console.WriteLine(" First Name: {0} \n Last Name: {1} \n Age: {2} \n Gender: {3} \n Id Number: {4} \n Unique Number {5}", firstName, lastName, age, gender, idNumber, uniqueNumber);
        }
    }
}
