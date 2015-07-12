//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

class Rectangles
{
    static void Main()
    {
        Console.WriteLine("Enter width of the rectangle:");
        double width = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter height of the rectangle:");
        double height = double.Parse(Console.ReadLine());

        double perimeter = (2 * width) + (2 * height);
        double area = width * height;

        Console.WriteLine("The rectangle has perimeter {0} and area {1}.", perimeter, area);
    }
}

