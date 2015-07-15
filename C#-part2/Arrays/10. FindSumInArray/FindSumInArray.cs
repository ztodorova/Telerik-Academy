//Write a program that finds in given array of integers a sequence of given sum S (if present).

using System;

class FindSumInArray
{
    static void Main()
    {
        Console.Write("Please enter s: ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("Please enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please write {0} numbers separated by comma : ", n);
        string[] stringArray = Console.ReadLine().Split(',');
        int[] intArray = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = int.Parse(stringArray[i]);
        }

        int sum = 0, resultStart = 0, resultEnd = 0;
        bool isPresent = false;

        for (int i = 0; i < intArray.Length; i++)
        {
            for (int j = i ; j < intArray.Length; j++)
            {
                sum += intArray[j];
                 if(sum==s)
                 {
                     isPresent = true;
                     resultStart = i;
                     resultEnd = j;
                     break;
                 }
            }

            sum = 0;
        }

        if (isPresent)
        {

            for (int i = resultStart; i <= resultEnd; i++)
            {
                if (i == resultEnd)
                {
                    Console.WriteLine("{0}", intArray[i]);
                }
                else
                {
                    Console.Write("{0}, ", intArray[i]);
                }
            }
        }
        else
        {
            Console.WriteLine("Sum is not present.");
        }
    }
}

