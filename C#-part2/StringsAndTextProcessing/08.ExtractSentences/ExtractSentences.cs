/*
 Write a progtam that extracts from a given text all sentences containing dgiven word.
 * Example:
 * The word is: in
 * The text is: We are living in a yellow submarine. We do not have anything else. Inside the submarine is very tight. So we are drinking all day. We will move out of it in 5 days.
 * The expected result is: We are living in a yellow submarine. We will move out of it in 5 days.
 * */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.ExtractSentences
{
    class ExtractSentences
    {
        static void Main()
        {
            Console.WriteLine("Please enter text: ");
            string[] text = Console.ReadLine().Split('.');
            Console.Write("Please enter a word to search: ");
            string inputWord = Console.ReadLine();
            string word = " " + inputWord + " ";
            Console.WriteLine();
            Console.WriteLine("Result:");
            for (int i = 0; i < text.Length; i++)
            {
                if(text[i].IndexOf(word,0)>=0)
                {
                    Console.Write(text[i]+".");
                }
                
            }

            Console.WriteLine();
        }
    }
}
