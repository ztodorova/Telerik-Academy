using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesMain
{
    //Problem 1. Structure
    public struct Point3D
    {
        private static readonly Point3D startPoint; //Problem 2. Static read-only field
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public static Point3D StartPoint { get { return startPoint; } } //Problem 2. Static read-only field

        public Point3D(double xCoord, double yCoord, double zCoord)
            : this()
        {
            this.X = xCoord;
            this.Y = yCoord;
            this.Z = zCoord;
        }

        static Point3D()                       //Problem 2. Static read-only field
        {
        startPoint = new Point3D(0,0,0);
    }

        public override string ToString()
        {
            string result = "{" + this.X.ToString() + "," + this.Y.ToString() + "," + this.Z.ToString() + "}";
            return result;
        }
    }
}
