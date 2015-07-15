/*Write a program that converts a string to a sequence of C# Unicode character literals.
Use format strings.
Example:

input	output
Hi!	\u0048\u0069\u0021
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.UnicodeCharacters
{
    class UnicodeCharacters
    {
        static void Main()
        {
            Console.WriteLine("Please enter string: ");
            string input = Console.ReadLine();
            foreach (char symbol in input)
            {
                int a = (int)symbol;
                
                Console.Write("{0:X}", a);
            }
            Console.WriteLine();
        }
    }
}
