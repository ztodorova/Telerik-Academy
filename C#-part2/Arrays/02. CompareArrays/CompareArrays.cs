//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.

using System;

class CompareArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter the number of elements in the arrays:");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Please enter {0} integer values on new lines: ", n);
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        int[] array2 = new int[n];
        Console.WriteLine("Please enter {0} integer values on new lines:", n);
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < array2.Length; i++)
        {
           if (array[i] == array2[i])
           {
               Console.WriteLine("Elements on positions {0} are equal.", i);
           }
           else if (array[i]>array2[i])
           {
               Console.WriteLine("Element on position {0} from the first array is greater.", i);
           }
           else if (array[i]<array2[i])
           {
               Console.WriteLine("Element on position {0} from the second array is greater", i);
           }
        }

    }
}

