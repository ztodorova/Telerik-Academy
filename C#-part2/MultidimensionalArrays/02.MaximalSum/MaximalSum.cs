//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class MaximalSum
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter m: ");
        int m = int.Parse(Console.ReadLine());

       Console.WriteLine("Please enter a matrix {0} x {1}: ", n, m);
       int[,] matrix = new int[n,m];
       for (int i = 0; i < n; i++)
       {
           string[] rowString = Console.ReadLine().Split(' ');
           for (int j = 0; j < rowString.Length; j++)
           {
               matrix[i, j] = int.Parse(rowString[j]);
           }
       }
     
        int with=3;
        int height=3;
        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < matrix.GetLength(0)-height+1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-with+1; col++)
            {
                int sum = 0;
                for (int platformRow = row; platformRow < row+height; platformRow++)
                {
                    for (int platformCol = col; platformCol < col+with; platformCol++)
                    {
                        sum += matrix[platformRow, platformCol];
                    }
                }

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }  
        }

        Console.WriteLine("Best platform is:");
        for (int platformRow = bestRow; platformRow < bestRow + height; platformRow++)
        {
            for (int platformCol = bestCol; platformCol < bestCol + with; platformCol++)
            {
                Console.Write("{0} ", matrix[platformRow,platformCol]);  
            }
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine("The maximal sum is {0}.", bestSum);

    }

}

