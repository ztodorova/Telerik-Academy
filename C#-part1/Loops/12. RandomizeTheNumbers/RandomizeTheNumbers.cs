//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

using System;

class RandomizeTheNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];
        Random randomNumber = new Random();
        for (int i = 0; i < n; i++)
        {
            numbers[i] = i+1;
        }

        for (int i = 1; i < numbers.Length; i++)
        {
            int tmp = numbers[i];
            int r = randomNumber.Next(i, numbers.Length);
            numbers[i] = numbers[r];
            numbers[r] = tmp;
        }

        for (int i = 0; i <= n; i++)
        {
            Console.Write("{0} ", numbers[i]);
        }

    }
}

