//Write a program that reads a text file and inserts line numbers in front of each of its lines.
//The result should be written to another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03.LineNumbers
{
    class LineNumbers
    {
        static void Main()
        {
            StreamReader first = new StreamReader(@"../../firstFile.txt");
            StreamWriter result = new StreamWriter(@"../../result.txt", true);
            string line = first.ReadLine();
            int counter = 1;
            while(line != null)
            {
                result.Write("{0} ", counter);
                result.WriteLine(line);
                line = first.ReadLine();
                counter++;
            }

            first.Close();
            result.Close();
        }
    }
}
