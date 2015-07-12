//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;
using System.Threading;
using System.Globalization;

class Sort3Numbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Enter first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter third number: ");
        double c = double.Parse(Console.ReadLine());

        if (a >= b && a > c)
        {
            if (b >= c)
            {
                Console.WriteLine("{0} {1} {2}", a, b, c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", a, c, b);
            }
        }

        if (b > a && b >= c)
        {
            if (a >= c)
            {
                Console.WriteLine("{0} {1} {2}", b, a, c);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", b, c, a);
            }
        }
        if (c >= a && c > b)
        {
            if (a >= b)
            {
                Console.WriteLine("{0} {1} {2}", c, a, b);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", c, b, a);
            }
        }
        if (a == b && a == c)
        {
            Console.WriteLine("{0} {1} {2}", c, b, a);
        }
 
        Main();
    }
}

