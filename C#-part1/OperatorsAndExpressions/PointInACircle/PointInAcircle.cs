//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class PointInACircle
{
    static void Main()
    {
        Console.WriteLine("Enter x:");
        double x = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter y:");
        double y = double.Parse(Console.ReadLine());

        double r = 2.0;
        double xyPoint = 0.0;

        bool inCircle = Math.Pow((x - xyPoint), 2) + Math.Pow((y - xyPoint), 2) <= r * r;
        Console.WriteLine("The point is in the circle: {0}", inCircle);
    
    }
}

