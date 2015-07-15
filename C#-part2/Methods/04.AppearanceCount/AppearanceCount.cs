// Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.

using System;

class AppearanceCount
{
    static void Main()
    {
        Console.Write("Please enter numbers separated by space: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] integers = new int[input.Length];
        for (int i = 0; i < input.Length; i++)
        {
            integers[i] = int.Parse(input[i]);
        }
        Console.Write("Please enter a number to search: ");
        int number = int.Parse(Console.ReadLine());
        int appearance = CountAppearance(number, integers);
        Console.WriteLine("{0} appears {1} times in the array.", number, appearance);
    }

    static int CountAppearance(int n, int[] numbers)
    {
        int counter=0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if(numbers[i] == n)
            {
                counter++;
            }
        }
        return counter;
    }
}

