//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.Numerics;

    class BinaryToDecimalNumber
    {
        static void Main()
        {
            Console.Write("Please enter a binary integer: ");
            string binary = Console.ReadLine();
            long result=0;
            for (int i = 0, j=binary.Length-1; i <= binary.Length && j>=0 ; i++, j--)
            {
              int bin = binary[i] - '0';
              result += ((long)bin*(long)Math.Pow(2,j));
            }

            Console.WriteLine(result);
        }
    }

