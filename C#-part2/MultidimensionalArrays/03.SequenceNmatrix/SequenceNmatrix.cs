/*
We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
Write a program that finds the longest sequence of equal strings in the matrix.
 * 
 * matrix:            result:
ha fifi ho hi         ha, ha, ha
fo ha hi xx
xxx ho ha xx
 * 
matrix:              result:
s qq s              s, s, s
pp pp s
pp qq s
 * 
 */

using System;

class SequenceNmatrix
{
    static void Main()
    {
        Console.Write("Please enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter m: ");
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter a matrix of strings {0} x {1}: ", n, m);
        string[,] matrix = new string[n, m];
        for (int i = 0; i < n; i++)
        {
            string[] rowString = Console.ReadLine().Split(' ');
            for (int j = 0; j < rowString.Length; j++)
            {
                matrix[i, j] = rowString[j];
            }
        }

        int count = 0, bestCount = 0;
        string bestString = " ";


        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1)-1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    count++;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                   
                    bestString = matrix[row, col];
                }
            }
            count = 0;
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            for (int row = 0; row < matrix.GetLength(0)-1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    count++;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    
                    bestString = matrix[row, col];
                }
                
            }
            count = 0;
        }

        for (int row = 0; row < matrix.GetLength(0)-1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1 && row < matrix.GetLength(0) - 1; col++, row++)
            {
                if(matrix[row,col]==matrix[row+1,col+1])
                {
                    count++;
                }
                if (count > bestCount)
                {
                    bestCount = count;
                    
                    bestString = matrix[row, col];
                }
            }
            count = 0;
        }

        for (int i = 0; i <= bestCount; i++)
        {
            Console.Write("{0} ", bestString);
        }
        Console.WriteLine();
        
    }
}

