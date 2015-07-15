//Write a program that reads a text file and prints on the console its odd lines.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _01.OddLines
{
    class OddLines
    {
        static void Main()
        {
            
            string file = "../../test.txt";
            using(StreamReader reader = new StreamReader(file))
            {
                int counter = 0;
                string line = reader.ReadLine();
                while(line!=null)
                {
                    counter++;
                    line = reader.ReadLine(); 

                    if(counter%2 != 0)
                    {  
                        Console.WriteLine("Line {0}: {1}", counter,line);    
                    }
                    
                }
            }
        }
    }
}
