//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LeapYear
{
    static void Main()
    {
        Console.Write("Please enter a year: ");
        int year = int.Parse(Console.ReadLine());
        bool leap = DateTime.IsLeapYear(year);
        if(leap)
        {
            Console.WriteLine("{0} is a leap year.", year);
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}

