//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePerimeterArea
{
    static void Main()
    {
        Console.Write("Enter radius of a circle: ");
        double r = double.Parse(Console.ReadLine());
        double area;
        double perimeter;

        area = Math.PI * Math.Pow(r, 2);
        perimeter = 2 * Math.PI * r;

        Console.WriteLine("Perimeter: {0:F2}", perimeter);
        Console.WriteLine("Area is: {0:F2}", area);
 
    }
}

