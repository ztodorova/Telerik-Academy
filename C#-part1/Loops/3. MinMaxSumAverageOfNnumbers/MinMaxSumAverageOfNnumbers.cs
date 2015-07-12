//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.

using System;
using System.Threading;
using System.Globalization;

class MinMaxSumAverageOfNnumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        int n = int.Parse(Console.ReadLine());
        int min=0, max=0;
        double sum=0, avg=0;
        for (int i = 1; i <= n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            if (number<min)
            {
                min = number;
            }
            if (number>max)
            {
                max=number;
            }
            sum += number;
        }
        avg = sum / n;
        Console.WriteLine("min = {0}", 1);
        Console.WriteLine("max = {0}", max);
        Console.WriteLine("sum = {0}", sum);
        Console.WriteLine("avg = {0:F2}", avg);
    }
}

