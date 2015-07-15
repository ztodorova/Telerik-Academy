//Write a program that finds the maximal sequence of equal elements in an array.
//Example:

//input	                             result
//2, 1, 1, 2, 3, 3, 2, 2, 2, 1	    2, 2, 2


using System;

class MaximalSequance
{
    static void Main()
    {
        Console.Write("Please enter numbers separated by comma : ");
        string[] stringArray = Console.ReadLine().Split(',');
        int[] intArray = new int[stringArray.Length];
        int counter = 0;
        int finalCounter = 0;
        for (int i = 0; i < stringArray.Length; i++)
        {
            intArray[i] = int.Parse(stringArray[i]);
        }

        int result=0;
        for (int i = 0; i < intArray.Length-1; i++)
        {
            
            if (intArray[i] == intArray[i+1])
            {
                counter++;
            }
            else
            {
                counter = 0;
            }
            if(counter > finalCounter)
            {
                finalCounter = counter;
                result = intArray[i];
            }
        }
        finalCounter++;

        int j = 1;
        while(j<=finalCounter)
        {
            if (j == finalCounter)
            {
                Console.Write("{0}", result);
            }
            else
            {
                Console.Write("{0}, ", result);
            }
            j++;
        }
        Console.WriteLine();
         
    }
}

