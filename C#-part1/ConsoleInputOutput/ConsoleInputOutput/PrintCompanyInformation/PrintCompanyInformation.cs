//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.

using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Enter company name:");
        string companyName = Console.ReadLine();
        Console.Write("Enter company address:");
        string companyAddress = Console.ReadLine();
        Console.Write("Enter phone number:");
        string phoneNumber = Console.ReadLine();
        Console.Write("Enter fax number:");
        string faxNumber = Console.ReadLine();
        Console.Write("Enter web site:");
        string website = Console.ReadLine();
        Console.Write("Enter manager first name:");
        string managerFirstName = Console.ReadLine();
        Console.Write("Enter manager last name:");
        string managerLastName = Console.ReadLine();
        Console.Write("Enter manager age:");
        int managerAge = int.Parse(Console.ReadLine());
        Console.Write("Enter manager phone number:");
        string managerPhoneNumber = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: {0}", companyAddress);
        Console.WriteLine("Tel.: {0}", phoneNumber);
        Console.WriteLine("Fax: {0}", faxNumber);
        Console.WriteLine("Web site: {0}", website);
        Console.WriteLine("Manager: {0} {1} (age {2}, tel. {3})", managerFirstName, managerLastName, managerAge, managerPhoneNumber);

    }
}

