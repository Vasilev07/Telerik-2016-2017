using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class BankAcc
    {
        static void Main(string[] args)
        {
            string firstName = "George";
            string middleName = "Borislavov";
            string lastName = "Vasilev";
            long balance = 8306112507;
            string bankName = "FIB";
            string iban = "BGASDASDASG!@!!";
            int numberOfCard = 556456;
            Console.WriteLine(" First Name: {0} \n Middle Name: {1}\n Last Name: {2} \n Balance: {3} \n Bank Name: {4} \n IBAN: {5} \n Card Number : {6} ", firstName,middleName, lastName, balance, bankName, iban, numberOfCard);
        }
    }
}
