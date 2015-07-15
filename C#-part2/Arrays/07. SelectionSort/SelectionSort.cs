//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.

using System;

class SelectionSort
{
    static void Main()
    {
        Console.Write("Please enter length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter {0} numbers separated by comma : ",n);
        string[] stringArray = Console.ReadLine().Split(',');
        int[] intArray = new int[stringArray.Length];
        int temp = 0;

        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = int.Parse(stringArray[i]);
        }

        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = i; j < intArray.Length; j++)
            {
                if (intArray[j] < intArray[i])
                {
                    temp = intArray[j];
                    intArray[j] = intArray[i];
                    intArray[i] = temp;
                }
            }
        }

        string result = string.Join(",", intArray);
        Console.WriteLine(result);


    }
}

