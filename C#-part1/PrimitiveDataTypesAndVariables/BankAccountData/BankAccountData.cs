//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

using System;

class BankAccountData
{
    static void Main()
    {
        string firstName = "Todor";
        string secondName = "Petrov";
        string lastName = "Todorov";
        decimal balance = 1056.75M;
        string iban = "BG78UBBS12345678912345";
        string firstCcNumber = "1234567891234567";
        string secondCcNumber = "7894561237894561";
        string thirdCcNumber = "7418529637418529";

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("SecondName: {0}", secondName);
        Console.WriteLine("Last name: {0}", lastName);
        Console.WriteLine("Balance: {0}", balance);
        Console.WriteLine("First credit card number: {0}", firstCcNumber);
        Console.WriteLine("Second credit card number: {0}", secondCcNumber);
        Console.WriteLine("Third credit card number: {0}", thirdCcNumber);     

    }
}

