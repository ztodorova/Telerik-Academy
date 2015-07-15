//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input	                                    result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	       2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;

class MaximalSum
{
    static void Main()
    {

        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please write {0} numbers separated by comma : ", n);
        string[] stringArray = Console.ReadLine().Split(',');
        int[] intArray = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = int.Parse(stringArray[i]);
        }

        int start = 0, currentSum = 0, bestSum = int.MinValue;
        int bestStart = 0, bestEnd = 0;

        for (int i = 0; i < intArray.Length; i++)
        {
            if (currentSum <= 0)
            {
                start = i;
                currentSum = 0;
            }

            currentSum += intArray[i];

            if(currentSum>bestSum)
            {
                bestSum = currentSum;
                bestStart = start;
                bestEnd = i;
            }
        }

        Console.Write("Sequence of maximal sum: ");
        for (int i = bestStart; i <= bestEnd; i++)
        {
            if(i==bestEnd)
            {
                Console.WriteLine("{0}", intArray[i]);
            }
            else
            {
                Console.Write("{0}, ", intArray[i]);
            }
        }
    }
}

