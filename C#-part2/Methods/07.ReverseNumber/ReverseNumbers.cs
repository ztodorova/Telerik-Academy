//Write a method that reverses the digits of given decimal number.
//Example:

//input	output
//256	 652

using System;
using System.Collections.Generic;

class ReverseNumbers
{
    static void Main()
    {
       Console.Write("Please enter decimal number: ");
        decimal n = decimal.Parse(Console.ReadLine());
        ReverseDigits(n);
    }

    static void ReverseDigits(decimal number)
    {
        string stringNumber = number.ToString();
        Console.Write("Reversed number: ");
        for (int i = stringNumber.Length-1; i >= 0; i--)
        {
            Console.Write(stringNumber[i]);
        }

       Console.WriteLine(); 
    }
}

