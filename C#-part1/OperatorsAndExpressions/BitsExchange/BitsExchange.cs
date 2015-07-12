//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.

using System;

class BitsExchange
{
    static void Main()
    {
        Console.Write("Enter number: ");
        uint n = uint.Parse(Console.ReadLine());

        uint mask1 = 7 << 3;
        uint bitsMask1 = n & mask1;
        uint bits1 = bitsMask1 >> 3;

        uint mask2 = 7 << 24;
        uint bitMask2 = n & mask2;
        uint bits2 = bitMask2 >> 24;

        uint mask4 = 7 << 3;
        uint maskInv = ~mask4;
        uint result1 = n & maskInv;                  // 000 on positions 3 4 5

        uint mask5 = 7 << 24;
        uint maskIn = ~mask5;
        uint result2 = result1 & maskIn;             // 000 on positions 3 4 5 and 24 25 26

        uint result4 = result2 | (bits2 << 3);
        uint result5 = result4 | (bits1 << 24);

        Console.WriteLine("The number with exchanged bits is: {0}", result5);

    }
}

