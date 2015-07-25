

namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Square : Shape
    {
        public Square(double width) : base(width, width)
        {

        }

        public override string CalculateSurface()
        {
            return "Surface of the square is: "+(this.Width * this.Height).ToString();
        }
    }
}
