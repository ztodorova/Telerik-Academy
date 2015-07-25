
namespace DefineClass
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Display
    {
        private float size;
        private int numberOfColours;

        public float Size
        {
            get { return this.size; }
            private set
            {
                if (value < 0)
                {
                    throw new FormatException("Display size must be positive integer!");
                }
                this.size = value;
            }
        }

        public int NumberOfColours
        {
            get { return this.numberOfColours; }
            private set
            {
                if (value < 0)
                {
                    throw new FormatException("Number of colours must be positive integer!");
                }
                this.numberOfColours = value;
            }
        }

        public Display()
        {

        }

        public Display(float displaySize,int displayNumberOfColours)
        {
            this.Size = displaySize;
            this.NumberOfColours = displayNumberOfColours;
        }
    }
}
