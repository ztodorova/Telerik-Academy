/* Write a program that reads a string, reverses it and prints the result at the console.
Example:

input	output
sample	elpmas
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseString
{
    static void Main()
    {
        Console.Write("Please enter a string: ");
        StringBuilder input = new StringBuilder(Console.ReadLine());
        StringBuilder output = new StringBuilder();
        Console.Write("Reversed string: ");
        for (int i = input.Length - 1 ; i >= 0 ; i--)
        {
            output.Append(input[i]);
        }

        Console.WriteLine(output);
    }
}

