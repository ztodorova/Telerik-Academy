//Write a method that checks if the element at given position in given array of integers is larger than its two neighbours (when such exist).

using System;

class LargerThanNeighbours
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
        Console.Write("Please enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} is larger than its neighbours: {1}.", integers[position], IsLarger(integers, position));

    }

    static bool IsLarger(int[] numbers, int pos)
    {
        if (pos == 0)
        {
            if (numbers[pos] > numbers[pos + 1])
            {
                return true;
            }
            else
                return false;
        }
        else if (pos == numbers.Length - 1)
        {
            if (numbers[pos] > numbers[pos - 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            if (numbers[pos] > numbers[pos - 1] && numbers[pos] > numbers[pos + 1])
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

