//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

class DecimalToBinaryNumber
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        long number = long.Parse(Console.ReadLine());
        long result = number;
        string binary = "";

        if (number == 0)
        {
            Console.WriteLine("0");
        }
        else
        {
            while (result > 0)
            {
                binary += (result % 2).ToString();
                result /= 2;
            }

            char[] output = binary.ToCharArray();

            for (int i = output.Length - 1; i >= 0; i--)
            {
                Console.Write(output[i]);
            }
            Console.WriteLine();
        }
    }
}

