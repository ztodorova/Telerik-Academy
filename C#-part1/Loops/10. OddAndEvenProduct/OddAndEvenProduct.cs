//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.

using System;

class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Please enter n numbers separeted by space: ");
        string stringNumbers = "1 " + Console.ReadLine();
        string[] numbers = stringNumbers.Split(' ');
        int productOdd = 1, productEven = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (i % 2 == 0)
            {
                productOdd *= int.Parse(numbers[i]);
            }
            else
            {
                productEven *= int.Parse(numbers[i]);
            }
        }

        if (productOdd == productEven)
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}

