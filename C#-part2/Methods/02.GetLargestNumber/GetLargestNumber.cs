//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;

class GetLargestNumber
{
    static void Main()
    {
        Console.Write("Please enter one integer: ");
        int oneInteger = int.Parse(Console.ReadLine());
        Console.Write("Please enter second integer: ");
        int secondInteger = int.Parse(Console.ReadLine());
        Console.Write("Please enter third integer: ");
        int thirdInteger = int.Parse(Console.ReadLine());

        int largestInteger;
        int largeInteger;

        largeInteger = GetMax(oneInteger, secondInteger);
        largestInteger = GetMax(largeInteger, thirdInteger);
        Console.WriteLine();
        Console.WriteLine("The largest integer is {0}.", largestInteger);
        Console.WriteLine();

    }

    static int GetMax(int a, int b)
    {
        if(a>b)
        {
            return a;
        }
        else
        {
            return b;
        }
    }
}

