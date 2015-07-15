//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;


class TriangleSurface
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
        Console.WriteLine("Please make a choice:");
        Console.WriteLine("Find surface of a triangle by given Side and an altitude to it ---> 1 ");
        Console.WriteLine("Find surface of a triangle by given Three sides ---> 2 ");
        Console.WriteLine("Find surface of a triangle by given Two sides and an angle between them ---> 3 ");
        switch(Console.ReadLine())
        {
            case "1": SurfaceBySideAndAltitude();
                break;
            case "2": SurfaceByThreeSides();
                break;
            case "3": SurfaceByTwoSidesAndAngle();
                break;
            default: Console.WriteLine("Invalid choice!");
                break;
        }
    }

       static void SurfaceBySideAndAltitude()
        {
            Console.Write("Please enter side of the triangle: ");
            double side = double.Parse(Console.ReadLine());
            Console.Write("Please enter altitude to the side: ");
            double altitude = double.Parse(Console.ReadLine());
            double area = (side * altitude) / 2;
            Console.WriteLine("Surface of the triangle: {0}", area);
        }

    static void SurfaceByThreeSides()
       {
           Console.Write("Please enter the first side of the triangle: ");
           double a = double.Parse(Console.ReadLine());
           Console.Write("Please enter the second side of the triangle: ");
           double b = double.Parse(Console.ReadLine());
           Console.Write("Please enter the third side of the triangle: ");
           double c = double.Parse(Console.ReadLine());
           double p = (a + b + c)/2;
           double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
           Console.WriteLine("Surface of the triangle: {0:F2}", area);
       }

    static void SurfaceByTwoSidesAndAngle()
    {
        Console.Write("Please enter the first side of the triangle: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Please enter the second side of the triangle: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the angle between the sides in gradus: ");
        double angleGradus = double.Parse(Console.ReadLine());
        double angle = angleGradus * Math.PI / 180.0;
        double area = ((a * b *( Math.Sin(angle))) / 2);
        Console.WriteLine("Surface of the triangle: {0:F2}", area);

    }

    
}

