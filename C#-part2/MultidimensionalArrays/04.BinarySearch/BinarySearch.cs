//Write a program, that reads from the console an array of N integers and an integer K, sorts the array and using the method 
//Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;

class BinarySearch
{
    static void Main()
    {
        Console.Write("Please enter n integers: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            arr[i] = int.Parse(input[i]);
        }

        Console.Write("Please enter k: ");
        int k = int.Parse(Console.ReadLine());
        Array.Sort(arr);

        int result = Array.BinarySearch(arr, k);
        if (result > 0)
        {
            Console.WriteLine("Largest number <= k is: {0}.", arr[result]);
        }
        else if (result < 0)
        {
            while (k >= 0)
            {
                k--;
                result = Array.BinarySearch(arr, k);
                if (result > 0)
                {
                    Console.WriteLine("Largest number <= k is: {0}.", arr[result]);
                    break;
                }
            }
            if (result < 0)
                Console.WriteLine("No such number!");
        }
    }
}
