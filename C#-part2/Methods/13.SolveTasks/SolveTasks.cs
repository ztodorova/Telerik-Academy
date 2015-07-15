/*Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
Create appropriate methods.
Provide a simple text-based menu for the user to choose which task to solve.
Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SolveTasks
{
    class SolveTasks
    {
        static void Main()
        {
            Console.WriteLine("Please choose the task which has to be solved:");
            Console.WriteLine("1. Reverses the digits of a number");
            Console.WriteLine("2. Calculates the average of a sequence of integers");
            Console.WriteLine("3. Solves a linear equation a * x + b = 0");
            string input = Console.ReadLine();
            Console.Clear();
            switch (input)
            {
                case "1": ReverseDigits(); break;
                case "2": Average(); break;
                case "3": LinearEquation(); break;
                default: Console.WriteLine("Invalid input data!\nTry again:\n"); Main(); break;
            }
        }
        static void ReverseDigits()
        {
            Console.Write("Please enter number: ");
            decimal n = decimal.Parse(Console.ReadLine());
            while (n < 0)
            {
                Console.Write("Please enter positive number: ");
                n = decimal.Parse(Console.ReadLine());
            }
            string stringNumber = n.ToString();
            Console.Write("Reversed number: ");
            for (int i = stringNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(stringNumber[i]);
            }
            Console.WriteLine();
        }
        static void Average()
        {
            Console.Write("Enter sequence of integers on the same line separated by space: ");
            string[] inputString = Console.ReadLine().Split(' ');

            while (inputString.Length <= 1)
            {
                Console.Write("Sequence should not be empty. Try again: ");
                inputString = Console.ReadLine().Split(' ');
            }


            int[] inputInt = new int[inputString.Length];
            int sum = 0;
            int result = 0;
            for (int i = 0; i < inputInt.Length; i++)
            {
                inputInt[i] = int.Parse(inputString[i]);
                sum += inputInt[i];
            }
            result = sum / inputInt.Length;
            Console.WriteLine("Avarage of sequence is: " + result);
        }
        static void LinearEquation()
        {
            Console.Write("Enter value for a :");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter value for b :");
            int b = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("Every number is a solution.");
                }
                else
                {
                    Console.WriteLine("Equation does not have any solution");
                }
            }
            double x = -b / a;
            Console.WriteLine("The result of {0} * x + {1} = 0 is x = {2}", a, b, x);

        }
    }
}
