//In combinatorics, the Catalan numbers are calculated by the catalan-formula: C = (2*n)! / (n+1)! * n!
//Write a program to calculate the nth Catalan number by given n (0 ≤ n ≤ 100).

using System;
using System.Threading;
using System.Globalization;

class CatalanNumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.Write("Enter n between 0 and 100: ");
        int n = int.Parse(Console.ReadLine());
        double catalan;
        double nFact=1, n2Fact=1, n1Fact=1;
        double n2 = 2 * (double)n;
        double n1 = (double)n + 1;
        for (int i = 1; i <= n; i++)
        {  
            nFact *= i;   
        }

        for (int i = 1; i <= n2; i++)
        {
           n2Fact *= i; 
        }

        for (int i = 1; i <= n1; i++)
        {
            n1Fact *= i;
        }
        
        catalan = n2Fact / (n1Fact * nFact);
        Console.WriteLine("C = {0}", catalan);
    }
}

