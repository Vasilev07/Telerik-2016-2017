using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountData
{
    class Program
    {
        static void Main()
        {
            string firstName = "Georgi";
            string middleName = "Borislavov";
            string lastName = "Vasilev";
            decimal money = 256489.05M;
            string bankName = "Societe General";
            string iban = "BG1241241243";
            ulong firstCard = 372151897379856;
            ulong secondCard = 372151897379898;
            ulong thirdCard = 3721518973798141;
            Console.WriteLine("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}\n{7}\n{8}\n", firstName, middleName, lastName, money, bankName, iban, firstCard, secondCard, thirdCard);

        }
    }
}
