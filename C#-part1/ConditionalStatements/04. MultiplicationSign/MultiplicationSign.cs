//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;
using System.Threading;
using System.Globalization;

class MultiplicationSign
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.Write("Enter one real number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter second real number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter third real number: ");
        double c = double.Parse(Console.ReadLine());

        if ((a>0 && b>0 && c>0) || (a<0 && b<0 && c>0) || (a<0 && b>0 && c<0) || (a>0 && b<0 && c<0) || (a<0 && b<0 && c>0) 
            || (a<0 && b>0 && c<0) || (a>0 && b<0 && c<0))
        {
            Console.WriteLine("Product: +");
        }
        
        if ((a<0 && b<0 && c<0) || (a<0 && b>0 && c>0) || (a>0 && b<0 && c>0) || (a>0 && b>0 && c<0))
        {
            Console.WriteLine("Product: -");
        }

        if(a==0 || b==0 || c==0)
        {
            Console.WriteLine("Product: 0");
        }
    }
}

