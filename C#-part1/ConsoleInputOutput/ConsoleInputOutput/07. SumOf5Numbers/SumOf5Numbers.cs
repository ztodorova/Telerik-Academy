using System;

class SumOf5Numbers
{
    static void Main()
    {
        Console.Write("Enter five numbers separated by space: ");
        string numbers = Console.ReadLine();

        char delimiterChar = ' ';

        string[] SplitNumbers = numbers.Split(delimiterChar);

        foreach (string s in SplitNumbers)
        {
            System.Console.WriteLine(s);
        }

    }
}

