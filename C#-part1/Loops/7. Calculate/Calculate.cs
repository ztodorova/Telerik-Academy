//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.

using System;
using System.Threading;
using System.Globalization;

class Calculate
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter n between 1 and 100: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter k between 1 and 100 less than n: ");
        int k = int.Parse(Console.ReadLine());
        double nFact = 1, kFact = 1, nkFact = 1;
        double result = 0;
        double diff = (double)n - (double)k;
        for (int i = 1; i <= n; i++)
        {
            nFact *= (double)i;
            if (i <= k)
            {
                kFact *= (double)i;
            }
        }

        for (int i = 1; i <= diff; i++)
        {
            nkFact *= i;
        }

        result = nFact / (kFact * nkFact);
        Console.WriteLine("n! / (k! * (n-k)!) = {0}", result);
    }
}

