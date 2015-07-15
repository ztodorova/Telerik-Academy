//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;

class IndexOfLetters
{
    static void Main()
    {
        int n = 26;
        char[] alphabet = new char[n];

        for (int i = 0, j=65; i < alphabet.Length; i++,j++)
        {
            alphabet[i] = (char)j;
        }

        Console.Write("Please enter a word in capital letters: ");
        string word = Console.ReadLine();
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if(word[i] == alphabet[j])
                {
                    Console.WriteLine("{0} --> index {1}", word[i], j);
                }
            }
        }
        
    }
}

