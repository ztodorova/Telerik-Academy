//Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the 
//rectangle R(top=1, left=-1, width=6, height=2).

using System;

    class InsideCircleOutsideRectangle
    {
        static void Main()
        {
            //(x - center_x)^2 + (y - center_y)^2 < radius^2
            double XY = 1.0;
            double radius = 1.5;

            Console.Write("Enter coordinate X: ");
            double horizontal = double.Parse(Console.ReadLine());
            Console.Write("Enter coordinate Y: ");
            double vertical = double.Parse(Console.ReadLine());

            bool isInsideCircle = (Math.Pow((horizontal - XY), 2) + Math.Pow((vertical - XY), 2)) <= radius * radius;

            double topV = 1.0;
            double leftH = -1.0;
            double bottomV = -1.0;
            double rightH = 5.0;

            bool isOutsideRectangle;

            if (!((horizontal >= leftH && horizontal <= rightH) && (vertical <= topV && vertical >= bottomV)))
            {
                isOutsideRectangle = true;
            }
            else
            {
                isOutsideRectangle = false;
            }

            if (isInsideCircle && isOutsideRectangle)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }

    }

