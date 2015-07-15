//Write a program that compares two char arrays lexicographically (letter by letter).

using System;

class CompareCharArrays
{
    static void Main()
    {
        Console.WriteLine("Please enter two words on new lines:");

        string word1 = Console.ReadLine();
        string word2 = Console.ReadLine();

        int compare;
        if (word1.Length < word2.Length)
        {
            compare = word1.Length;

        }
        else
        {
            compare = word2.Length;

        }

        for (int i = 0; i < compare; i++)
        {
            if (word1[i] < word2[i])
            {
                Console.WriteLine("{0} < {1}", word1, word2);
                return;
            }
            if (word1[i] > word2[i])
            {
                Console.WriteLine("{0} > {1}", word1, word2);
                return;
            }

        }

        if (word1.Length == word2.Length)
        {
            Console.WriteLine("{0} = {1}", word1, word2);
        }
        else
        {
            if (word1.Length < word2.Length)
            {
                Console.WriteLine("{0} < {1}", word1, word2);

            }
            else
            {
                Console.WriteLine("{0} > {1}", word1, word2);

            }
        }

    }
}

