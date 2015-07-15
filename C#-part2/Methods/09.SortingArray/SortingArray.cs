//Write a method that return the maximal element in a portion of array of integers starting at given index.
//Using it write another method that sorts an array in ascending / descending order.

using System;

class SortingArray
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

        Console.Write("Please enter index: ");
        int position = int.Parse(Console.ReadLine());

        int max = MaximalElement(integers, position);
        if (position < 0 || position > integers.Length)
        {
            Console.WriteLine("Invalid index!");
        }
        else
        {
            Console.WriteLine("The maximal element after index {0} is {1}.", position, max);    
        }

        SortAscending(integers);
        Console.Write("Sorted array in ascending order: ");
        for (int i = 0; i < integers.Length; i++)
        {
            Console.Write("{0} ", integers[i]);
        }
        Console.WriteLine();
        
        SortDescending(integers);
        Console.Write("Sorted array in descending order: ");
        for (int i = 0; i < integers.Length; i++)
        {
            Console.Write("{0} ", integers[i]);
        }
        Console.WriteLine();

    }

        static int MaximalElement(int[] array, int index)
    {

        int max = array[index];
        for (int i = index; i < array.Length; i++)
        {
           if (array[i] > max)
           {
               max = array[i];
           }
        }
            return max;
    }

    static void SortDescending(int[] arrayToSort)
        {
            int maxValue = 0,curr;
            for (int i = 0; i < arrayToSort.Length; i++)
            {
               maxValue = MaximalElement(arrayToSort, i);
               int tmp = arrayToSort[i];
               curr = Array.IndexOf(arrayToSort, maxValue);
               arrayToSort[i] = arrayToSort[curr];
               arrayToSort[curr] = tmp;
            }
        }

    static void SortAscending(int[] arrayToSort)
    {
        SortDescending(arrayToSort);
        Array.Reverse(arrayToSort);
    }
}
