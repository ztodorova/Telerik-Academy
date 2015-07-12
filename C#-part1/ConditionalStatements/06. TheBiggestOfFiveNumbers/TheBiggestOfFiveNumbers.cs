//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Globalization;
using System.Threading;

    class TheBiggestOfFiveNumbers 
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
            Console.WriteLine("Enter third number: ");
            double d = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            double e = double.Parse(Console.ReadLine());

            if (b > a)
            {
                a = b;
            }

            if (c > a)
            {
                a = c;
            }

            if (d > a)
            {
                a = d;
            }

            if (e > a)
            {
                a = e;
            }


            Console.WriteLine("The biggest number is: {0}", a);

            Main();
        }
    }

