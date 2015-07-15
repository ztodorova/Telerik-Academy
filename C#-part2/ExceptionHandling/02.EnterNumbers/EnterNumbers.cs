/*Write a method ReadNumber(int start, int end) that enters an integer number in a given range [start…end].
If an invalid number or non-number text is entered, the method should throw an exception.
Using this method write a program that enters 10 numbers: a1, a2, … a10, such that 1 < a1 < … < a10 < 100
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.EnterNumbers
{
    class EnterNumbers
    {
        static void Main()
        {
            int[] numbers = new int[10];
            int min = 1;
            int max = 100;
            try
            {
                numbers[0] = ReadNumber(min, max);
                for (int i = 1; i < 10; i++)
                {
                    min = numbers[i - 1];
                    numbers[i] = ReadNumber(min, max);
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Invalid number!");
            }
        }

        static int ReadNumber(int start, int end)
        {
            Console.WriteLine("Please enter a number between {0} and {1}: ",start,end);
             int number = int.Parse(Console.ReadLine());
                if(number<start || number>end)
                {
                    throw new Exception("Number is not in the range!");
                }
                
            return number;
        }
    }
}
