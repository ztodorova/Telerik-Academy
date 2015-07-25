using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixProblem
{
    public class Matrix<T>     //Problem 8. Matrix
        where T : IComparable
    {


        public Matrix(int rows, int columns)
        {
            this.Rows = rows;
            this.Cols = columns;
            this.MyMatrix = new T[rows, columns];
        }

        public int Rows { get; set; }
        public int Cols { get; set; }
        public T[,] MyMatrix;


        public T this[int row, int col]     //Problem 9. Matrix indexer
        {
            get
            {
                if (row < 0 || row >= this.Rows || col < 0 || col >= this.Cols)
                {
                    throw new IndexOutOfRangeException();
                }
                return this.MyMatrix[row, col];
            }
            set
            {
                if (row < 0 || row >= this.Rows || col < 0 || col >= this.Cols)
                {
                    throw new IndexOutOfRangeException();
                }
                this.MyMatrix[row, col] = value;
            }
        }

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)     //Problem 10. Matrix operations
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new FormatException("Matrices are with different dimensions!");
            }
            Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);
            for (int rows = 0; rows < result.Rows; rows++)
            {
                for (int cols = 0; cols < result.Cols; cols++)
                {
                    result[rows, cols] = (dynamic)m1[rows, cols] + m2[rows, cols];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)    //Problem 10. Matrix operations
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new FormatException("Matrices are with different dimensions!");
            }
            Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);
            for (int rows = 0; rows < result.Rows; rows++)
            {
                for (int cols = 0; cols < result.Cols; cols++)
                {
                    result[rows, cols] = (dynamic)m1[rows, cols] - m2[rows, cols];
                }
            }
            return result;
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)     // Problem 10. Matrix operations
        {
            if (m1.Cols != m2.Rows)
            {
                throw new FormatException("Matrices cannot be multiplied!");
            }
            Matrix<T> result = new Matrix<T>(m1.Rows, m2.Cols);

            for (int rows = 0; rows < result.Rows; rows++)
            {
                for (int cols = 0; cols < result.Cols; cols++)
                {
                    for (int k = 0; k < m1.Cols; ++k)
                        result[rows, cols] += (dynamic)m1[rows, k] * m2[k, cols];

                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)        //Problem 10. Matrix operations
        {

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    if (matrix[i, j] == (dynamic)0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int rows = 0; rows < this.Rows; rows++)
            {
                for (int cols = 0; cols < this.Cols; cols++)
                {

                    builder.Append(this.MyMatrix[rows, cols] + "\t");

                }
                builder.AppendLine();
            }

            return builder.ToString();
        }

    }
}
