//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SumIntegers
{
    static void Main()
    {
        Console.Write("Please enter numbers separated by space: ");
        int sum = Sum(Console.ReadLine());
        Console.WriteLine("Sum: {0}", sum);
    }

    static int Sum(string stringNumbers)
    {
        string[] arrayNumbers = stringNumbers.Split();
        int[] numbers = new int[arrayNumbers.Length];
        for (int i = 0; i < arrayNumbers.Length; i++)
        {
            numbers[i] = int.Parse(arrayNumbers[i]);
        }

        int sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }

        return sum;  
    }
}

