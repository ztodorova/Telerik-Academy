using System;

class NumbersInInterval
{
    static void Main()
    {
        Console.WriteLine("Enter one positive integer: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter another positive integer: ");
        int b = int.Parse(Console.ReadLine());
        int counter = 0;
        for (int i = a; i <= b; i++)
        {
            if(i%5==0)
            {
                counter++;
            }
        }
        Console.WriteLine("Result: {0}", counter);
    }
}

