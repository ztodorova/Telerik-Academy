//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them)

using System;

class SortByStringLength
{
    static void Main()
    {
        Console.Write("Please enter an array of strings: ");
        string[] input = Console.ReadLine().Split(' ');
        sortArray(input);
        Console.Write("Sorted array: ");
        for (int i = 0; i < input.Length; i++)
        {
            Console.Write("{0} ", input[i]);
        }
        Console.WriteLine();
    }

    static void sortArray(string[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].Length < array[i].Length)
                {
                    string tmp = array[j];
                    array[j] = array[i];
                    array[i] = tmp;
                }
            }
        }
    }
}

