//Write a program that extracts from a given text all palindromes, e.g. ABBA, lamal, exe

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            Console.Write("Please enter text: ");
            string[] words = Console.ReadLine().Split(' ', ',', '.', '!', '?');
            Console.Write("Palindromes: ");
            for (int i = 0; i < words.Length; i++)
            {
                int counter = 0;
                for (int j = 0, p = words[i].Length-1; j < words[i].Length; j++, p--)
                {
                    string current=words[i];
                    
                    if (current[j] == current[p])
                    {
                        counter++;
                    }

                }
                if (counter == words[i].Length)
                {
                    Console.Write("{0} ", words[i]);
                }
            }
            Console.WriteLine();

        }
    }
}
