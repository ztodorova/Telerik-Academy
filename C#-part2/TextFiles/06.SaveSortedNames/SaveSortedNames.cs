//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _06.SaveSortedNames
{
    class SaveSortedNames
    {
        static void Main()
        {
            List<string> namesList = new List<string>();

            ReadFile(namesList);
            namesList.Sort();
            WriteToFile(namesList);
        }

        private static void WriteToFile(List<string> namesList)
        {
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt", false, Encoding.UTF8))
            {
                foreach (string name in namesList)
                {
                    writer.WriteLine(name);
                }
            }
        }

        private static void ReadFile(List<string> namesList)
        {
            using (StreamReader reader = new StreamReader(@"..\..\input.txt", Encoding.UTF8))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    namesList.Add(line);
                    line = reader.ReadLine();
                }
            }
        }
    }
}
