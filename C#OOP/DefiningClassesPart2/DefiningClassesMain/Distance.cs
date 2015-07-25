using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesMain
{
    public static class Distance //Problem 3. Static class
    {
        public static double CalculateDistance(Point3D first, Point3D second)
        {
            double result = Math.Sqrt(Math.Pow((first.X - second.X), 2) + Math.Pow((first.Y - second.Y), 2) + Math.Pow((first.Z - second.Z), 2));
            return result;
        }
    }
}
