//Write a program that finds the biggest of three numbers.

using System;
using System.Threading;
using System.Globalization;

    class TheBiggestOf3Numbers
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

            if (b > a)
            {
                a = b;
            }

            if (c > a)
            {
                a = c;
            }

            Console.WriteLine("The biggest number is: {0}", a);

            Main();
        }
    }

