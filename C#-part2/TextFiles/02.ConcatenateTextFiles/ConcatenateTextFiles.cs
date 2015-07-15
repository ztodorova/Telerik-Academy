//Write a program that concatenates two text files into another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _02.ConcatenateTextFiles
{
    class ConcatenateTextFiles
    {
        static void Main()
        {
            StreamReader first = new StreamReader(@"../../firstFile.txt");
            StreamWriter third = new StreamWriter(@"../../thirdFile.txt",false);
            string line = first.ReadLine();
            while(line != null)
            {
                third.WriteLine(line);
                line = first.ReadLine();
            }
            first.Close();
            third.Close();

            StreamReader second = new StreamReader("../../secondFile.txt");
            StreamWriter thirdAgain = new StreamWriter("../../thirdFile.txt", true);
            line = second.ReadLine();
            while (line != null)
            {
                thirdAgain.WriteLine(line);
                line = second.ReadLine();
            }

            second.Close();
            thirdAgain.Close();
        }
    }
}
