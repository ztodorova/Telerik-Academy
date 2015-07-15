/*
 * Write a program that reverses the words in given sentence.
Example:

input	                                    output
C# is not C++, not PHP and not Delphi!	    Delphi not and PHP, not C++ not is C#!

 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.ReverseSentence
{
    class ReverseSentence
    {
        static void Main()
        {
            Console.WriteLine("Please enter text: ");
            string input = Console.ReadLine();

            List<StringBuilder> words = new List<StringBuilder>();
            string word = "";

            foreach (char ch in input)
            {
                if (ch == ' ')
                {
                    if (word != "")
                    {
                        words.Add(new StringBuilder(word));
                        word = "";
                    }
                }
                else if (ch == ',')
                {
                    if (word != "")
                    {
                        words.Add(new StringBuilder(word));
                        words.Add(new StringBuilder(ch.ToString()));
                        word = "";
                    }
                }
                else if ((ch != '!') && (ch != '?'))
                {
                    word += ch;
                }
            }

            words.Add(new StringBuilder(word));
            for (int i = words.Count - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }

            Console.Write(input[input.Length - 1]);
            Console.WriteLine();
        }
        
    }
}
