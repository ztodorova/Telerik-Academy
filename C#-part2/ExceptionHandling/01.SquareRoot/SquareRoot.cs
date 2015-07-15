﻿/*Write a program that reads an integer number and calculates and prints its square root.
If the number is invalid or negative, print Invalid number.
In all cases finally print Good bye.
Use try-catch-finally block. */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.SquareRoot
{
    class SquareRoot
    {
        static void Main()
        {
            Console.Write("Plese enter a number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                
                if (number < 0)
                {
                    throw new ArgumentException("Invalid number!");
                }
                Console.WriteLine("Square root: {0}", Math.Sqrt(number));
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid number!");
            }
            finally
            {
                
                Console.WriteLine("Good bye!");
            }
        }
    }
}
