//Modify the solution of the previous problem to replace only whole words (not strings).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace _08.ReplaceWholeWord
{
    class ReplaceWholeWord
    {
        static void Main()
        {
            Regex wordRgx = new Regex("\bstart\b", RegexOptions.IgnoreCase);

            using (StreamReader sr = new StreamReader("../../input.txt"))
            {
                using (StreamWriter sw = new StreamWriter("../../output.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(wordRgx.Replace(line, "finish"));
                    }
                }
            }
        }
    }
}
