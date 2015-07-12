//Write an expression that checks if given integer is odd or even.

using System;

class OddOrEven
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        string text = Console.ReadLine();
        int n = int.Parse(text);
        bool isOdd;

        if(n%2==0)
        { 
            isOdd= false;
            Console.WriteLine("isOdd={0}",isOdd); 
        }
        else
        {
            isOdd=true;
            Console.WriteLine("isOdd={0}",isOdd);

        }

    }
}
