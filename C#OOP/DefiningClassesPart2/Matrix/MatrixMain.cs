using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatrixProblem;

namespace Matrix
{
    class MatrixMain
    {
        static void Main(string[] args)
        {
            Matrix<int> matrix = new Matrix<int>(3, 2);

            matrix[0, 0] = 3;
            matrix[0, 1] = -1;
            matrix[1, 0] = -6;
            matrix[1, 1] = 2;
            matrix[2, 0] = -3;
            matrix[2, 1] = 1;

            Console.WriteLine(matrix.ToString());

            Matrix<int> matrix1 = new Matrix<int>(2, 2);

            matrix1[0, 0] = 2;
            matrix1[0, 1] = -1;
            matrix1[1, 0] = -1;
            matrix1[1, 1] = -4;

            Console.WriteLine(matrix1.ToString());

            Console.WriteLine();

            Matrix<int> sum = matrix * matrix1;

            Console.WriteLine(sum.ToString());
      
            if (matrix1)
            {
                Console.WriteLine("There are no zero elements!");
            }  
        }
    }
}
