//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

class CheckBitAtPosition
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter bit position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int andMask = number & mask;
        int bit = andMask >> position;
        bool check;

        if (bit == 1)
            check = true;
        else
            check = false;

        Console.WriteLine("The bit has value 1: {0}", check);

    }
}

