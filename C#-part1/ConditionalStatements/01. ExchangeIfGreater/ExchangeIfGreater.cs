//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;

class ExchangeIfGreater
{
    static void Main()
    {
        Console.WriteLine("Enter first value: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second value: ");
        double b = double.Parse(Console.ReadLine());

        if (a>b)
        {
            double c = a;
            a = b;
            b = c;
        }
        Console.WriteLine("{0} {1}", a,b);
        Main();
    }
}

