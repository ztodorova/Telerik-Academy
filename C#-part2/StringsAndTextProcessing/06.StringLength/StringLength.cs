//Write a program that reads from the console a string of maximum 20 characters. If the length of the string is less than 20, the rest of the characters should be filled with *.
//Print the result string into the console.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.StringLength
{
    class StringLength
    {
        static void Main()
        {
            Console.WriteLine("Please enter a string with length<=20: ");
            string input = Console.ReadLine();
            if (input.Length < 20)
            {
                string output = input.PadRight(20, '*');
                Console.WriteLine();
                Console.WriteLine(output);
            }
            else if (input.Length == 20)
            {
                string output = input;
                Console.WriteLine();
                Console.WriteLine(output);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Invalid number of characters!");
            }
        }
    }
}
