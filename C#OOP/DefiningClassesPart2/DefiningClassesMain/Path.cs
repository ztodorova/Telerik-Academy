using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesMain
{
    public class Path    //Problem 4. Path
    {
        private List<Point3D> points;

        public Path()
        {
            this.Points = new List<Point3D>();
        }

        public List<Point3D> Points
        {
            get { return this.points; }
            set { this.points = value; }
        }

        public void AddPoint(Point3D point)
        {
            this.Points.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.Points.Remove(point);
        }
        
    }
}
