// Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.LettersCount
{
    class LettersCount
    {
        static void Main()
        {
            Console.Write("Please enter a string: ");
            string text = Console.ReadLine();
            int[] symbols = new int[65536];
            for (int i = 0; i < text.Length; i++)
            {
                symbols[(int)text[i]]++;
            }

            for (int j = 0; j < symbols.Length; j++)
            {
                if(symbols[j]!=0)
                {
                    Console.WriteLine("{0} --> {1} time/s", (char)j, symbols[j]);
                }
            }
        }
    }
}
