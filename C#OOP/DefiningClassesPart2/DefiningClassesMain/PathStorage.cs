using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DefiningClassesMain
{
    public static class PathStorage   //Problem 4. Path
    {
       public static void SavePath(Path onePath,string fileName)
       {
           
           using (StreamWriter streamWriter =
    new StreamWriter("..//..//"+fileName+".txt"))
           {
               for (int i = 0; i < onePath.Points.Count; i++)
               {
                   streamWriter.WriteLine(onePath.Points[i].ToString()); 
               }
               
           }
   }

    public static Path LoadPath(string fileName)
      {
        Path result = new Path();
        using(StreamReader reader = new StreamReader("..//..//"+fileName+".txt"))
        {
            string line = reader.ReadLine();
            while (line != null)
            {
                
                string[] lineArray = line.Split(',');
               Point3D currentPoint = new Point3D(double.Parse(lineArray[0].Trim('{')), double.Parse(lineArray[1]), double.Parse(lineArray[2].Trim('}')));
               result.AddPoint(currentPoint);
               line = reader.ReadLine();
            }
        }

        return result;
       }
    }
}
