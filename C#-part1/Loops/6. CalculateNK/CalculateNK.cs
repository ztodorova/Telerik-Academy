//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.

using System;
using System.Threading;
using System.Globalization;

class CalculateNK
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter n between 1 and 100: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k between 1 and 100 less than n: ");
        int k = int.Parse(Console.ReadLine());
        int nFact=1, kFact=1;
        decimal result;
        for (int i = 1; i <= n; i++)
        {
            nFact *= i;
            if (i<=k)
            {
                kFact *= i;
            }
        }
        result = (decimal)nFact / (decimal)kFact;
        Console.WriteLine("n! / k! = {0}", result);
    }
}

