//Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one.
//input	                        output
//aaaaabbbbbcdddeeeedssaa	    abcdedsa

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.SeriesOfLetters
{
    class SeriesOfLetters
    {
        static void Main()
        {
            Console.Write("Please enter string: ");
            string input = Console.ReadLine();
            StringBuilder output = new StringBuilder();
            output.Append(input[0]);
            for (int i = 1; i < input.Length; i++)
			{
                if (input[i - 1] != input[i])
                {
                    output.Append(input[i]);
                }
			}

            Console.WriteLine("Result: {0}", output);
        }
    }
}
