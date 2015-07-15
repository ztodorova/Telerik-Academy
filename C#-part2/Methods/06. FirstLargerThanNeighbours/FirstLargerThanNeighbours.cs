//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.

using System;

class FirstLargerThanNeighbours
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

        Console.WriteLine("The first element larger than its neighbours is on position {0}.", IsLarger(integers));

    }

    static int IsLarger(int[] numbers)
    {
        for (int pos = 0; pos < numbers.Length; pos++)
        {
            if (pos == 0)
            {
                if (numbers[pos] > numbers[pos + 1])
                {
                    return pos;
                }
            }
            else if (pos == numbers.Length - 1)
            {
                if (numbers[pos] > numbers[pos - 1])
                {
                    return pos;
                }
            }
            else
            {
                if (numbers[pos] > numbers[pos - 1] && numbers[pos] > numbers[pos + 1])
                {
                    return pos;
                }
            }
        }
        return -1;
    }
}


