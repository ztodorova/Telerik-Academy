// Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;

class DivideBy7and5
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string text = Console.ReadLine();
        int n = int.Parse(text);
        bool divide = (n % 7 == 0) && (n % 5 == 0);
        Console.WriteLine("Number can be divided by 7 and 5: {0}", divide );
        
    }
}

