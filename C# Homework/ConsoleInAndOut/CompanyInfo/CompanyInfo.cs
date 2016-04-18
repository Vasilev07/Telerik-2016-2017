using System;



class CompanyInfo
{
    static void Main()
    {
        string companyName = Console.ReadLine();
        string companyAddress = Console.ReadLine();
        string phoneNumber = Console.ReadLine();
        string faxNumber = Console.ReadLine();
        string webSite = Console.ReadLine();
        string managerFirstName = Console.ReadLine();
        string managerLastName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        string managerPhoneNumber = Console.ReadLine();
        
        if (string.IsNullOrEmpty(faxNumber) == true)
        {
            Console.WriteLine("(no fax)");
        }
        else
        {
            Console.WriteLine(faxNumber);
        }

        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Adress: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.WriteLine("{0} {1} ", managerFirstName, managerLastName, age);


    }
}
