//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;

class QuickSort
{
    static void Main()
    {
        int[] unsorted = { 1, 3, 5, 9, 2, 7, 10, 14, 11 };
        Console.Write("Unsorted array: ");
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i] + " ");
        }

        Console.WriteLine();

        Quicksort(unsorted, 0, unsorted.Length - 1);

        Console.Write("Sorted array:   ");
        for (int i = 0; i < unsorted.Length; i++)
        {
            Console.Write(unsorted[i]+" ");
        }

        Console.WriteLine();
 
    }

    public static void Quicksort(int[] elements, int left, int right)
    {
        int i = left, j = right;
        IComparable pivot = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(pivot) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(pivot) > 0)
            {
                j--;
            }

            if (i <= j)
            {
          
                IComparable tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = (int)tmp;

                i++;
                j--;
            }
        }

      
        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }
    }
}

