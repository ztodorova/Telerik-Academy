/*A dictionary is stored as a sequence of text lines containing words and their explanations.
Write a program that enters a word and translates it by using the dictionary.
Sample dictionary:

input	output
.NET	platform for applications from Microsoft
CLR	managed execution environment for .NET
namespace	hierarchical organization of classes
    */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.WordDictionary
{
    class WordDictionary
    {
        static void Main()
        {
            Console.Write("Pleasee enter a word: ");
            string word = Console.ReadLine();
            Console.Write("{0}: ",word);
            switch (word)
            {
                case ".NET": Console.WriteLine("platform for applications from Microsoft");
                    break;
                case "CLR": Console.WriteLine("managed execution environment for .NET");
                    break;
                case "namespace": Console.WriteLine("hierarchical organization of classes");
                    break;
                default: Console.WriteLine("Word not found!");
                    break;
            }
        }
    }
}
