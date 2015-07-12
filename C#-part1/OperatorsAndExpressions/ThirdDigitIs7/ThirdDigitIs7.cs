//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.WriteLine("Enter an integer:");
        int number = int.Parse(Console.ReadLine());

        int n = number / 100;
        bool isSeven = (n % 10) == 7;

        Console.WriteLine("Thirth digit from right to left is 7: {0}", isSeven);
    }
}

