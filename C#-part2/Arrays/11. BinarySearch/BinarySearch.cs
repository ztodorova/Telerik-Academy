//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.

using System;

class BinarySearch
{
    static void Main()
    {
        
        Console.Write("Please write sorted numbers separated by comma : ");
        string[] stringArray = Console.ReadLine().Split(',');
        int[] intArray = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = int.Parse(stringArray[i]);
        }

        Array.Sort(intArray);

        Console.Write("Please enter number to search: ");
        int k = int.Parse(Console.ReadLine());

        int min=0, max=intArray.Length-1, mid=0, result=0;


        while(min<=max)
        {
            mid = (min+max)/2;
                
            if (intArray[mid] == k)
            {
                result = mid;
                break;
            }
            else if(k < intArray[mid])
            {
                max = mid - 1;
            }
            else
            {
                min = mid + 1;
            }
        }

        Console.WriteLine("{0} is on index {1} of the array.",k,result);

    }
}

