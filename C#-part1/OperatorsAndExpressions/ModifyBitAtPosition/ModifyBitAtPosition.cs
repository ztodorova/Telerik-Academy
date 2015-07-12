//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

class ModifyBitAtPosition
{
    static void Main()
    {

        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter bit position: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter a bit value 0 or 1: ");
        int v = int.Parse(Console.ReadLine());
        
        if (v==0)
        {
            int mask = ~(1 << p);
            int result = n & mask;
            Console.WriteLine("The number after modification is: {0}", result);
        }
        else
        {
            int mask = 1 << p;
            int result = n | mask;
            Console.WriteLine("Tne number after modification is: {0}", result);
        }

    }
}

