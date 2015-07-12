// Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years

using System;

class AgeInTenYears
{
    static void Main()
    {
        Console.WriteLine("Enter your date of birth in the format yyyy/mm/dd");
        DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());
        DateTime dateToday = DateTime.Now;
        int age = dateToday.Year - dateOfBirth.Year;

        if (dateToday.Month < dateOfBirth.Month || (dateToday.Month == dateOfBirth.Month && dateToday.Day < dateOfBirth.Day))
        {
            age--;
        }

        Console.WriteLine("You are " + age + " years old.");
        Console.WriteLine("In 10 years you will be " + (age + 10) + " years old.");
    }
}

