//Write a program that reads a string from the console and lists all different words in the string along with information how many times each word is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.WordsCount
{
    class WordsCount
    {
        static void Main()
        {
            Console.WriteLine("Please enter text: ");
            string input = Console.ReadLine();

            string[] words = input.Split(new char[] { ' ', '.', ',', '!', '?' });

            for (int i = 0; i < words.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < i; j++)
                {
                    if (words[i] == words[j])
                    {
                        found = true;
                        break;
                    }
                }

                if (found == false)
                {
                    
                    int count = 1;
                    for (int j = i + 1; j < words.Length; j++)
                    {
                        if (words[i] == words[j])
                        {
                            count++;
                        }
                    }
                    Console.WriteLine("Word '{0}' is used {1} time(s).", words[i], count);
                }
            }

        }
    }
}
