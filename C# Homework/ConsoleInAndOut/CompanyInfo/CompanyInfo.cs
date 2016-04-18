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
        
        
        Console.WriteLine("{0}", companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel. {0}", phoneNumber);
        Console.WriteLine(faxNumber == "" ? "Fax: (no fax)" : "Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", webSite);
        Console.Write("Manager: {0} {1}", managerFirstName, managerLastName);
        Console.Write(" " + "(age: {0}", age);
        Console.WriteLine("," + " " + "tel. {0})", managerPhoneNumber);

    }
}
