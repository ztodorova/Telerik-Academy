//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.WriteLine("Enter a four digit number:");
        int number = int.Parse(Console.ReadLine());
        int firstDigit, secondDigit, thirdDigit, fourthDigit;

        firstDigit = number / 1000;
        secondDigit = (number / 100) % 10;
        thirdDigit = (number / 10) % 10;
        fourthDigit = number % 10;

        Console.WriteLine("The sum of the digits is: "+(firstDigit+secondDigit+thirdDigit+fourthDigit));
        Console.WriteLine("Number in reversed order is: {0}{1}{2}{3}",fourthDigit,thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("Numer with last digit on first position is: {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine("Numer with exchanged second and thirth digits is: {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}

