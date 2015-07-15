/*You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to upper-case.
The tags cannot be nested.
Example: We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.

The expected result: We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
 * */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            Console.WriteLine("Please enter text: ");
            string input = Console.ReadLine();
            int startIndex = input.IndexOf("<upcase>");
            int start = startIndex;
            string output = input;
            while (startIndex >= 0)
            {
                output = ToUpper(output, startIndex);
                startIndex = output.IndexOf("<upcase>");
            }
            Console.WriteLine(output);
        }

        static string ToUpper(string input, int startIndex)
        {
            startIndex = input.IndexOf("<upcase>");
            int endIndex = input.IndexOf("</upcase>");
            string newString = "";

            startIndex = input.IndexOf("<upcase>", startIndex) + 8;
            endIndex = input.IndexOf("</upcase>", endIndex);
            int end = endIndex - startIndex;
            string subString = input.Substring(startIndex, end);
            newString = input.Substring(0, startIndex - 8) + subString.ToUpper() + input.Substring(endIndex + 9);
            startIndex++;
            endIndex++;

            return newString;
        }
    }
}
