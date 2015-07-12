//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;
using System.Globalization;
using System.Threading;

class CalculateSum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());
        decimal s = 1;
        decimal fact = 1;
        for (int i = 1; i <= n; i++)
        {
            fact *=(decimal)i;
            s +=(fact /(decimal)Math.Pow(x, i));
        }
       Console.WriteLine("The Sum is: {0:F5}", s);
    }
    
}

