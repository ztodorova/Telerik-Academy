using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesMain
{
    class MainMethod
    {
        static void Main()
        {
            //Problem 1-4 tests
            Point3D point = new Point3D(2, 3, 4);

            Console.WriteLine(point.ToString());

            Point3D staticPoint = Point3D.StartPoint;
            Console.WriteLine(staticPoint.ToString());

            Point3D a = new Point3D(0, 1, 2);
            Point3D b = new Point3D(2, 3, 4);

            Path g = new Path();
            g.AddPoint(a);
            g.AddPoint(b);


            PathStorage.SavePath(g,"bla");
           
            //Problem 5-8 tests

            GenericList<int> myList = new GenericList<int>(3);

            myList.AddElement(1);
            myList.AddElement(2);
            myList.AddElement(3);

            Console.WriteLine();
            Console.WriteLine("add elements:");

            for (int i = 0; i < myList.Elements.Length; i++)
            {
                Console.WriteLine(myList.Elements[i]);
            }
            Console.WriteLine();

            Console.WriteLine();

            myList.RemoveElement(2);

            for (int i = 0; i < myList.Elements.Length; i++)
            {
                Console.WriteLine(myList.Elements[i]);
            }

            Console.WriteLine();

            myList.InsertElement(555, 0);

            for (int i = 0; i < myList.Elements.Length; i++)
            {
                Console.WriteLine(myList.Elements[i]);
            }

            Console.WriteLine();


            for (int i = 0; i < myList.Elements.Length; i++)
            {
                Console.WriteLine(myList.Elements[i]);
            }


            Console.WriteLine();

            Console.WriteLine(myList.FindElement(555));

            Console.WriteLine(myList.ToString());

            Console.WriteLine();

            Console.WriteLine(myList.GetElement(1));
            
        }
    }
}
