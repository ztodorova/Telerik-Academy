using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height)
        {
            
        }

        public override string CalculateSurface()
        {
            return "Surface of rectangle is: "+(this.Width * this.Height).ToString();
        }
    }
}
