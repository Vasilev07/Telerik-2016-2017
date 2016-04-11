using System;


namespace Age
{
    class Program
    {
        static void Main()
        {
            string strDate = DateTime.Now.ToString("MM/dd/yyyy");
            DateTime BirthDate = DateTime.Parse(Console.ReadLine());
            DateTime Now = DateTime.Now;
            int Age = (int)((Now - BirthDate).TotalDays / 365.2);
            Console.WriteLine(Age);
            Console.WriteLine(Age + 10);
        }
    }
}
