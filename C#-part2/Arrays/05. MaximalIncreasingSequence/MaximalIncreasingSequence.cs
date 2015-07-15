//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                result
//3, 2, 3, 4, 2, 2, 4	2, 3, 4


using System;

class MaximalIncreasingSequence
{
    static void Main()
    {
        Console.Write("Please write numbers separated by comma : ");
        string[] stringArray = Console.ReadLine().Split(',');
        int[] intArray = new int[stringArray.Length];
        int counter = 0;
        int finalCounter = 0;
        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = int.Parse(stringArray[i]);
        }

        int result = 0;
        for (int i = 0; i < intArray.Length - 1; i++)
        {

            if (intArray[i] == intArray[i + 1] - 1)
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
            if (counter > finalCounter)
            {
                finalCounter = counter;
                result = intArray[i+1];
            }
        }
      
        int j = 1;
        int k = result - finalCounter;
        finalCounter++;

        while (j <= finalCounter)
        {
            if (j == finalCounter)
            {
                Console.Write("{0}", k);
            }
            else
            {
                Console.Write("{0}, ", k);
            }
            j++;
            k++;
        }
        Console.WriteLine();
         
    }
}

