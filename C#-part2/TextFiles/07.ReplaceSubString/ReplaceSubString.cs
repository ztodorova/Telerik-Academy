using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _07.ReplaceSubString
{
    class ReplaceSubString
    {
        static void Main()
        {
            using (StreamReader sr = new StreamReader(@"../../input.txt"))
            {
                using (StreamWriter sw = new StreamWriter(@"../../output.txt"))
                {
     
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(line.Replace("start", "finish"));
                    }
                }
            }
        }
    }
}
