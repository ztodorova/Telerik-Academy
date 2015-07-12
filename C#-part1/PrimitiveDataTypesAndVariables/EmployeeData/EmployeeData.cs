﻿/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:

First name
Last name
Age (0...100)
Gender (m or f)
Personal ID number (e.g. 8306112507)
Unique employee number (27560000…27569999)

Declare the variables needed to keep the information for a single employee using appropriate primitive data types. 
Use descriptive names. Print the data at the console. */

using System;

class EmployeeData
{
    static void Main()
    {
        string firstName = "Steven";
        string lastName = "Allan";
        byte age = 47;
        char gender = 'm';
        long idNumber = 8306112507;
        long employeeNumber = 27560000;

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last Name: {0}", lastName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID number: {0}", idNumber);
        Console.WriteLine("Unique employee number: {0}", employeeNumber);
    }
}

