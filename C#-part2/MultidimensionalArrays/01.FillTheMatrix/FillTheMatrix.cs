//Write a program that fills and prints a matrix of size (n, n) as shown below

//1	5	9	13
//2	6	10	14
//3	7	11	15
//4	8	12	16

using System;

    class FillTheMatrix
    {
        static void Main()
        {
            Console.Write("Please enter n: ");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];
            int a = 1;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = a;
                    a++;
                }

            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,-2} ",matrix[col,row]);
                }
                Console.WriteLine();
            }


        }
    }

