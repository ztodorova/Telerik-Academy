
namespace Shapes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Shape
    {
        private double width;
        private double height;

       public Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Invalid width!");
                }
                this.width = value;
            }
        }
        public double Height
        {
            get
            {
                return this.height;
            }
            set
            {
                if (value < 0)
                {
                    throw new FormatException("Invalid height");
                }
                this.height = value;
            }
        }

        public virtual string CalculateSurface()
        {
            return "Surface of the shape: "+(this.Width * this.Height).ToString();
        }

    }
}
