//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

    class ExtractBitFromInteger
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

            Console.WriteLine("The value is: {0}", bit);

        }
    }

