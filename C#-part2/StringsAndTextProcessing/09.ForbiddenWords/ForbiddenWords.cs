﻿//We are given a string containing a list of forbidden words and a text containing some of these words.
//Write a program that replaces the forbidden words with asterisks.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _09.ForbiddenWords
{
    class ForbiddenWords
    {
        static void Main()
        {
            Console.WriteLine("Enter text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter forbidden words separated by comma: ");
            string forb = Console.ReadLine();
            forb = forb.Trim();
            string[] forbiddenWords = forb.Split(',');

            foreach (string word in forbiddenWords)
            {
                input = Regex.Replace(input, word, new String('*', word.Length));
            }

            Console.WriteLine("Output: " + input);

        }
        
        
        
    }
}

