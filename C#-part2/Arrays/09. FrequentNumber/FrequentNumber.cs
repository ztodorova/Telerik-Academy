//Write a program that finds the most frequent number in an array.
//Example:

//input	                                    result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3	    4 (5 times)

using System;

class FrequentNumber
{
    static void Main()
    {
        Console.Write("Please enter the length of the array: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please write {0} numbers separated by comma : ", n);
        string[] stringArray = Console.ReadLine().Split(',');
        int[] intArray = new int[stringArray.Length];

        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = int.Parse(stringArray[i]);
        }

        Array.Sort(intArray);

        int counter=0;
        int finalCounter = 0;
        int result=0;

        for (int i = 0; i < stringArray.Length-1; i++)
        {
            if (intArray[i]==intArray[i+1])
            {
                counter++;
            }
            else
            {
                counter=0;
            }
            if (counter>finalCounter)
            {
                finalCounter = counter;
                result = intArray[i];
            }

        }

        finalCounter++;

        Console.WriteLine("{0} ({1} times)", result, finalCounter);


    }
}

