/*
1	8	9	16
2	7	10	15
3	6	11	14
4	5	12	13
 */

using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter n:");
        int n = int.Parse(Console.ReadLine());

        int[,] arr = new int[n, n];
        int odd = n * 2;
        int even = 1;

        for (int col = 0; col < arr.GetLength(0); col++)
        {
            if (col % 2 != 0)
            {
                for (int row = 0; row < arr.GetLength(1); row++)
                {
                    arr[row, col] = odd;
                    odd--;
                }
                odd = even + n * 2 - 1;
            }
            if (col % 2 == 0)
            {
                for (int row = 0; row < arr.GetLength(1); row++)
                {
                    arr[row, col] = even;
                    even++;
                }
                even += n;
            }
        }
        for (int row = 0; row < arr.GetLength(0); row++)
        {
            for (int col = 0; col < arr.GetLength(1); col++)
            {
                Console.Write("{0,2} ", arr[row, col]);
            }
            Console.WriteLine();
        }
    }
}
