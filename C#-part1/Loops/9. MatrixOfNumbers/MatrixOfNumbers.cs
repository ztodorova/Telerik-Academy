﻿//Write a program that reads from the console a positive integer number n (1 ≤ n ≤ 20) and prints a matrix like in the examples below. Use two nested loops.

using System;

class MatrixOfNumbers
{
    static void Main()
    {
        Console.Write("Enter n between 0 and 20: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            for (int j = i; j < n+i; j++)
            {
                Console.Write("{0, -2} ", j);
            }
            Console.WriteLine(); 
        }
    }
}

