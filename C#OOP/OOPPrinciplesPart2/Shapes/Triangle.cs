using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        public Triangle(double width, double height) : base(width, height)
        {

        }

        public override string CalculateSurface()
        {
            return "Surface of triangle is: "+((this.Width * this.Height) / 2).ToString();
        }
    }
}
