//Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

using System;

class ExtractBit3
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int mask = 8;

        int check = number & mask;
        int bit = check >> 3;

        if (bit == 1) Console.WriteLine("The bit at position 3 is 1");
        else
            Console.WriteLine("The bit at position 3 is 0");

    }
}

