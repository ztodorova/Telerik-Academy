//Problem 1. StringBuilder.Substring

//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the class String.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilderSubstring
{
    class StringBuilderSubstringMain
    {
        static void Main()
        {
            string test = "abvgde";

            Console.WriteLine( test.Substring(3, 3));

            Console.WriteLine();

            StringBuilder builder = new StringBuilder();
            builder.Append("a");
            builder.Append("b");
            builder.Append("v");
            builder.Append("g");
            builder.Append("de");
          //  builder.Append("e");


            Console.WriteLine(builder.Substring(3, 3));
        }
    }
}
