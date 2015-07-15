//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
using System.Collections;

class MaximalKsum
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter k: ");
        int k = int.Parse(Console.ReadLine());
        Console.Write("Please write {0} numbers separated by comma : ", n);
        string[] stringArray = Console.ReadLine().Split(',');
        int[] intArray = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = int.Parse(stringArray[i]);
        }

        Array.Sort(intArray);

        int result = 0;
        int j = 1;
        int sum = 0;
        int finalSum = 0;

        for (int i = 0; i < intArray.Length - k + 1; i++)
        {
            int m = i;

            while (j <= k)
            {
                sum += intArray[m];
                j++;
                m++;
            }
            j = 1;

            if (sum > finalSum)
            {
                finalSum = sum;
                result = i;
            }


        }

        for (int i = 1; i <= k; i++)
        {
            if (i == k)
            {
                Console.WriteLine("{0}", intArray[result]);
            }
            else
            {
                Console.Write("{0},", intArray[result]);
                result++;
            }
        }
            

    }
}

