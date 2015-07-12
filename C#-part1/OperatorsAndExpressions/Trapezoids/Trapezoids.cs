//Write an expression that calculates trapezoid's area by given sides a and b and height h

using System;

class Trapezoids
{
    static void Main()
    {
        Console.WriteLine("Enter trapezoid's side a:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter trapezoid's side b:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter trapezoid's height:");
        double h = double.Parse(Console.ReadLine());

        double  area = ((a+b)/2)*h;


        Console.WriteLine("Area of the trapezoid is: {0}", area);
        Main();
    }
}

