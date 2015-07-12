//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.
        

using System;
using System.Numerics;

class FibonacciNumbers
{
    static void Main()
    {
        Console.Write("Enter positive n: ");
        int n = int.Parse(Console.ReadLine());
        BigInteger[] fibonacci = new BigInteger[n];
        fibonacci[0] = 0;

        if (n >= 2)
        {
            fibonacci[1] = 1;
            if (n >= 3)
            {
                fibonacci[2] = 1;

                for (int i = 3; i < fibonacci.Length; i++)
                {
                    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }
        }
        Console.WriteLine(string.Join(" ", fibonacci));
        }
    }


