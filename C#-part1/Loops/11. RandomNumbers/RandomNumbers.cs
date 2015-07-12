//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;

class RandomNumbers
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter min: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter max (max>min): ");
        int max = int.Parse(Console.ReadLine());
        Random random = new Random();
        for (int i = 0; i <= n; i++)
        {
            int randomNumber = random.Next(min, max+1);
            Console.Write("{0} ", randomNumber);
        }
        Console.WriteLine();
    }
}

